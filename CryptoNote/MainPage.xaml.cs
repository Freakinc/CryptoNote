using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CryptoNote
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Rebex.Licensing.Key = "==AUM4mkBEtGZDGI2Rj0blUl3vrEj+W16WsVfvbgIxk2eg==";
            this.InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                
                textBlock.Text = "Encoding";
                RSA rsa = new RSA();
                textBox.Text = rsa.encode(textBox.Text);
                textBox1.Text = "" + rsa.GetNKey();
                textBox2.Text = "" + rsa.GetDKey();
            }
            else
            {
                textBlock.Text = "Текст для шифрования не может быть пустым!";
            }


        }
    }
}
