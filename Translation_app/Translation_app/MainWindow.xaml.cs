using System;
using System.Diagnostics;
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

        clsTranslationCtrl clsTransC;
        clsDialogCtrl clsDC;
        clsSysCtrl clsSC;
        public MainWindow()
        {
            InitializeComponent();
            clsTransC = new clsTranslationCtrl();
            clsDC = new clsDialogCtrl();
            clsSC = new clsSysCtrl();

            this.Topmost = true;
        }

        //***************************************************************************************************
        //Ctrl部
        //***************************************************************************************************


        //***************************************************************************************************
        private void Btn_ENtoJA_Click(object sender, RoutedEventArgs e)
        {
            SetTr(TXB.Text, "ja", "en");

        }

        //***************************************************************************************************
        private void Btn_JAtoEN_Click(object sender, RoutedEventArgs e)
        {
            SetTr(TXB.Text, "en", "ja");
        }

        //***************************************************************************************************
        private void TXB_en_TextChanged(object sender, TextChangedEventArgs e)
        {
            BtnEN(BTN_ENtoJA, TXB);
            BtnEN(BTN_JAtoEN, TXB);
            BtnEN(BTN_Clear, TXB);
        }

        //***************************************************************************************************
        private void BTN_Clipboad_click(object sender, RoutedEventArgs e)
        {
            if(clsDC.ShowMsg_YN("クリップボードの内容をテキストボックスに読込みますか？"))
            {
                string strClip = clsSC.GetClipboard_Text();
                TXB.Text = "";
                TXB.Text = strClip;
            }

        }

        //***************************************************************************************************
        private void ClickBTN_Debug(object sender, RoutedEventArgs e)
        {
            //var result_htmk = clsTransC.GetHtml("test", "en", "ja");
            //MessageBox.Show(result_htmk);
            //clsBrowserCtrl clsBC = new clsBrowserCtrl();
            //MessageBox.Show(clsBC.GetHtml("https://www.google.co.jp/"));



            /*IDataObject data = Clipboard.GetDataObject();
            if (data != null)
            {
                var result0 = data.GetFormats();
                //関連付けられているすべての形式を列挙する
                foreach (string fmt in result0)
                {
                    Debug.WriteLine(fmt);
                }
                Debug.WriteLine(result0.GetType());
            }

            cls_ClipBoardCtrl clsCBC = new cls_ClipBoardCtrl();

            var result_ = clsCBC.GetClipBoardInf();
            //foreach (string str_ in result_)
            //    Debug.WriteLine(str_);
            Debug.WriteLine(result_.GetType());*/



            cls_Python_Ctrl clsPy = new cls_Python_Ctrl();
            string result_ = clsPy.mPyRead(@"E:\_git\VS\Translation_app\Translation_app\Translation_app\GetText_ClipImg_.py");
            MessageBox.Show(result_);
        }

        //***************************************************************************************************
        private void Click_BTN_Clear(object sender, RoutedEventArgs e)
        {
            TXB.Text = "";
            TXB_Result.Text = "";
        }


        //***************************************************************************************************
        //関数部
        //***************************************************************************************************
        private void BtnEN(Button btn, TextBox txb)
        {
            btn.IsEnabled = (txb.Text != "") ? true : false;
        }

        //***************************************************************************************************
        private void SetTr(string str_vaoue, string change_language, string target_language)
        {
            string EnValue = TXB.Text;
            //string msg = (clsTransC.SetTranslation(str_vaoue, change_language, target_language)) ? "success" : "Err";
            string strHtml = clsTransC.GetHtml(str_vaoue, change_language, target_language);
            string msg = (strHtml != "") ? "success" : "Error";
            Debug.WriteLine(msg);
            TXB_Result.Text = strHtml;
        }


    }
}
