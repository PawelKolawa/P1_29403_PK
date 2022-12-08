using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GenKlucz_Click(object sender, EventArgs e)
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny

            string publicKeyString = GetKeyString(publicKey);
            string privateKeyString = GetKeyString(privateKey);
            textBox1.Text = privateKeyString;
            textBox2.Text = publicKeyString;

        }
        public static string GetKeyString(RSAParameters publicKey)
        {

            var stringWriter = new System.IO.StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, publicKey);
            return stringWriter.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MinimumSize = new Size(340, 150);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MinimumSize = new Size(340, 150);
        }

        private void SzyfrujButton_Click(object sender, EventArgs e)
        {
            string publicKeyString = textBox2.Text;

            string textToEncrypt = textBox3.Text;

            string encryptedText = Encrypt(textToEncrypt, publicKeyString); //Szyfrowanie za pomocą klucza publicznego
            textBox4.Text=encryptedText;

            
            
        }

        private void DeszyfrujButton_Click(object sender, EventArgs e)
        {
            string encryptedText = textBox4.Text;
            string privateKeyString = textBox1.Text;

            string decryptedText = Decrypt(encryptedText, privateKeyString); //Odszyfrowywanie za pomocą klucza prywatnego
            textBox3.Text=decryptedText;
        }

        public static string Encrypt(string textToEncrypt, string publicKeyString)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decrypt(string textToDecrypt, string privateKeyString)
        {
            var bytesToDescrypt = Encoding.UTF8.GetBytes(textToDecrypt);
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(privateKeyString);
                    var resultBytes = Convert.FromBase64String(textToDecrypt);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    string decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void zapiszklucz_Click(object sender, EventArgs e)
        {
            string privateKeyString = textBox1.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Plik XML|*.xml";
            saveFileDialog1.FileName = "kluczPrywatny";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                //System.IO.FileStream saveFile = (System.IO.FileStream)saveFileDialog1.OpenFile();
                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(privateKeyString);
                    fs.Write(info, 0, info.Length);
                }
            }
        }
        

        private void ZapiszKluczPubliczny_Click(object sender, EventArgs e)
        {
            string publicKeyString = textBox2.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Plik XML|*.xml";
            saveFileDialog1.FileName = "kluczPubliczny";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                //System.IO.FileStream saveFile = (System.IO.FileStream)saveFileDialog1.OpenFile();
                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                {                
                    byte[] info = new UTF8Encoding(true).GetBytes(publicKeyString);
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void WczytajKlucz_Click(object sender, EventArgs e)
        {
            string sciezkaPrywatna;
            using (OpenFileDialog prywatny = new OpenFileDialog())
            {
                prywatny.Filter = "Wszystkie pliki|*";
                prywatny.Title = "Wybierz plik";
                if (prywatny.ShowDialog() != DialogResult.OK) return;
                string sciezka = prywatny.FileName;
                sciezkaPrywatna = sciezka;
                
            }
            string kluczPrywatny = sciezkaPrywatna;
            textBox1.Text = System.IO.File.ReadAllText(kluczPrywatny);

        }

        private void WczytajKluczPubliczny_Click(object sender, EventArgs e)
        {
            string sciezkaPubliczna;
            using (OpenFileDialog publiczny = new OpenFileDialog())
            {
                publiczny.Filter = "Wszystkie pliki|*";
                publiczny.Title = "Wybierz plik";
                if (publiczny.ShowDialog() != DialogResult.OK) return;
                string sciezka = publiczny.FileName;
                sciezkaPubliczna = sciezka;

            }
            string kluczPubliczny = sciezkaPubliczna;
            textBox2.Text = System.IO.File.ReadAllText(kluczPubliczny);
        }

        private void SzyfrowanyZapisz_Click(object sender, EventArgs e)
        {
            string tekst = textBox4.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Plik txt|*.txt";
            saveFileDialog1.FileName = "Zaszyfrowany";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(tekst);
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            string sciezkatekstu;
            using (OpenFileDialog publiczny = new OpenFileDialog())
            {
                publiczny.Filter = "Wszystkie pliki|*";
                publiczny.Title = "Wybierz plik";
                if (publiczny.ShowDialog() != DialogResult.OK) return;
                string sciezka = publiczny.FileName;
                sciezkatekstu = sciezka;

            }
            string kluczPubliczny = sciezkatekstu;
            textBox4.Text = System.IO.File.ReadAllText(kluczPubliczny);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
