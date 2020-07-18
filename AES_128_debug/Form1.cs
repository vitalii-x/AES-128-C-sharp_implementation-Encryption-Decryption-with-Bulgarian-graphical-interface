using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AES_forms
{

    public partial class Form1 : Form
    {
        static byte[] encrypt(string message, string key)
        {
            byte[] msg = Encoding.UTF8.GetBytes(message);//Привет, как дель, меня зовут Жак!

            AES aes = new AES(Encoding.UTF8.GetBytes(key));

            //create a padded message, emptyness is filled by zeroes
            int originalLen = msg.Length;
            int lenOfPaddedMessage = originalLen;

            if (lenOfPaddedMessage % 16 != 0)
                lenOfPaddedMessage = (lenOfPaddedMessage / 16 + 1) * 16;

            byte[] paddedMessage = new byte[lenOfPaddedMessage];
            for (int i = 0; i < lenOfPaddedMessage; i++)
            {
                if (i >= originalLen) paddedMessage[i] = 0;
                else paddedMessage[i] = msg[i];
            }

            //encrypt padded message:
            byte[] product = new byte[lenOfPaddedMessage];

            for (int i = 0; i < lenOfPaddedMessage / 16; i++)
            {
                byte[] tmp = new byte[16];
                Array.Copy(paddedMessage, (i * 16), tmp, 0, 16);
                tmp = aes.AESencrypt(tmp);
                for (int a = 0; a < tmp.Length; a++)
                    Array.Copy(tmp, 0, product, i * 16, 16);
            }

            return product;
        }
        static byte[] encryptFile(byte[] fb, string key)
        {
            AES aes = new AES(Encoding.UTF8.GetBytes(key));
            //create a padded message, emptyness is filled by zeroes
            int originalLen = fb.Length;
            int lenOfPaddedMessage = originalLen;

            if (lenOfPaddedMessage % 16 != 0)
                lenOfPaddedMessage = (lenOfPaddedMessage / 16 + 1) * 16;

            byte[] paddedMessage = new byte[lenOfPaddedMessage];
            for (int i = 0; i < lenOfPaddedMessage; i++)
            {
                if (i >= originalLen) paddedMessage[i] = 0;
                else paddedMessage[i] = fb[i];
            }

            //encrypt padded message:
            byte[] product = new byte[lenOfPaddedMessage];
            for (int i = 0; i < lenOfPaddedMessage / 16; i++)
            {
                byte[] tmp = new byte[16];
                Array.Copy(paddedMessage, (i * 16), tmp, 0, 16);
                tmp = aes.AESencrypt(tmp);
                for (int a = 0; a < tmp.Length; a++)
                    Array.Copy(tmp, 0, product, i * 16, 16);
            }

            return product;
        }
        static string decrypt(byte[] cipher, string key)
        {
            string text = "";

            byte[] tmp = new byte[16];
            for (int i = 0; i < cipher.Length / 16; i++)
            {
                Array.Copy(cipher, i * 16, tmp, 0, 16);
                AES aes = new AES(Encoding.UTF8.GetBytes(key));
                byte[] ba = aes.AESdecrypt(tmp);
                text += Encoding.UTF8.GetString(ba);
            }
            //string text = Encoding.UTF8.GetString(ba);
            return text;

        }

        static byte[] decryptFile(byte[] cipher, string key)
        {
            Console.WriteLine(cipher.Length);
            byte[] bar = new byte[cipher.Length];

            byte[] tmp = new byte[16];
            AES aes = new AES(Encoding.UTF8.GetBytes(key));
            for (int i = 0; i < cipher.Length / 16; i++)
            {
                Array.Copy(cipher, i * 16, tmp, 0, 16);
                tmp = aes.AESdecrypt(tmp);
                Array.Copy(tmp, 0, bar, i * 16, 16);
            }
            return bar;
        }

        public Form1()
        {
            InitializeComponent();

            fileButtonsSwitcher(false);
            plainButtonsSwitcher(false);
            encryptb.Visible = false;
        }

        public string key;
        public static byte[] cipher;

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (keyBox.Text.Length >= 16 && textBox1.Text.Length >= 1)
            {
                key = keyBox.Text;
                cipher = encrypt(textBox1.Text, key);
                StringBuilder hex = new StringBuilder(cipher.Length * 2);
                foreach (byte b in cipher)
                    hex.AppendFormat("{0:x2}:", b);
                string final = hex.ToString().Substring(0, hex.Length - 1);
                textBox2.Text = final;
            }
            else MessageBox.Show("Въведете за ключа 16 или повече байта или изберете файл", "Съобщение");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void operationStatus_Click(object sender, EventArgs e)
        {

        }


        string path = "";//
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
                pathLabel.Text = od.FileName;
            path = pathLabel.Text;
        }

        private void decryptb_Click(object sender, EventArgs e)
        {
            key = keyBox.Text;
            textBox3.Text = decrypt(cipher, key);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fileButtonsSwitcher(bool i)
        {
                buttonE.Visible = i;
                fileLabel.Visible = i;
                pathLabel.Visible = i;
                operationStatus.Visible = i;
                decryptTo.Visible = i;
                labelKf.Visible = i;
                keyBoxf.Visible = i;
                encryptbf.Visible = i;
                fileKeyCount.Visible = i;
        }
        public void plainButtonsSwitcher(bool i)
        {
            textBox1.Visible = i;
            textBox2.Visible = i;
            textBox3.Visible = i;
            inputLabel.Visible = i;
            cipherLabel.Visible = i;
            decryptedLabel.Visible = i;
            decryptb.Visible = i;
            keyBox.Visible = i;
            label1.Visible = i;
            encryptb.Visible = i;
            textKeyCount.Visible = i;
        }
        private void modeFb_Click(object sender, EventArgs e)
        {
            modeFb.BackColor = Color.Green;
            modePb.BackColor = Color.FromArgb(255, 64, 16, 32);
            fileButtonsSwitcher(true);
            plainButtonsSwitcher(false);

        }

        private void modePb_Click(object sender, EventArgs e)
        {
            modePb.BackColor = Color.Green;
            modeFb.BackColor = Color.FromArgb(255, 64, 16, 32);
            fileButtonsSwitcher(false);
            plainButtonsSwitcher(true);

        }

        private void inputLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        string encryptedInto = "";
        private void encryptbf_Click(object sender, EventArgs e)
        {
            if (Encoding.UTF8.GetBytes(keyBoxf.Text).Length >= 16 && path.Length != 0)
            {
                byte[] rb = File.ReadAllBytes(path);
                byte[] product;
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    key = keyBoxf.Text;
                    product = encryptFile(rb, key);
                    File.WriteAllBytes(sfd.FileName, product);
                    encryptedInto = sfd.FileName;
                    operationStatus.Text = "Шифра записан във " + encryptedInto;
                }
            }
            else MessageBox.Show("Въведете за ключа 16 или повече байта или изберете файл", "Съобщение");
        }

        string decryptedInto = "";
        private void decryptTo_Click(object sender, EventArgs e)
        {
            if (Encoding.UTF8.GetBytes(keyBoxf.Text).Length >= 16 && path.Length != 0)
            {
                byte[] rb = File.ReadAllBytes(path);
                byte[] product;
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    key = keyBoxf.Text;
                    product = decryptFile(rb, key);
                    File.WriteAllBytes(sfd.FileName, product);
                    decryptedInto = sfd.FileName;
                    operationStatus.Text = "Разшифрованите битове са записани във " + decryptedInto;
                }
            }
            else MessageBox.Show("Въведете за ключа 16 или повече байта или изберете файл", "Съобщение");
        }

        private void keyBoxf_TextChanged(object sender, EventArgs e)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(keyBoxf.Text);
            int counter = tmp.Length;
            fileKeyCount.Text = counter.ToString();
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(keyBox.Text);
            int counter = tmp.Length;
            textKeyCount.Text = counter.ToString();
        }
    }
}
