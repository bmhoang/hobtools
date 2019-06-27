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
                var rsa = new StandardRSA(privateKey.Text, publicKey.Text);
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
    }
}
