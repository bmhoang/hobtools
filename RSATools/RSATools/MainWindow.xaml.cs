using hob.crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using hob;

namespace RSATools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Decrypt(object sender, RoutedEventArgs e)
        {
            try
            {
                var rsa = new StandardRSA(privateKey.Text);
                plainText.Text = rsa.Decrypt(cipherText.Text);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Encrypt(object sender, RoutedEventArgs e)
        {
            try { 
                var rsa = new StandardRSA(privateKey.Text, publicKey.Text);
                cipherText.Text = rsa.Encrypt(plainText.Text);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        static int[] keysize = new int[] { 512, 1024, 2048, 4096 };
        private void GenNewKeys(object sender, RoutedEventArgs e)
        {
            string pubKey;
            string priKey;
            SimpleRSA.GenerateBase64RSAKeys(keysize[cbxKeys.SelectedIndex], out priKey, out pubKey);
            var cryptoServiceProvider = new System.Security.Cryptography.RSACryptoServiceProvider(keysize[cbxKeys.SelectedIndex]);
            publicKey.Text = cryptoServiceProvider.ExportPublicKey();
            privateKey.Text = cryptoServiceProvider.ExportPrivateKey();
        }

    }
}
