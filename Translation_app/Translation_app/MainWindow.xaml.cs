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
using Ctrl_Dll;

namespace Translation_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        clsTranslationCtrl clsTC;
        public MainWindow()
        {
            InitializeComponent();
            clsTC = new clsTranslationCtrl();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            string msg = clsTC.SetJAtoEN("test", "en", "ja") ? "success" : "Err";

            MessageBox.Show($"Btn0 click {msg}");
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Btn1 click");

        }
    }
}
