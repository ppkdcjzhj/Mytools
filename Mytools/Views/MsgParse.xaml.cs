using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MyTools.Views
{
    /// <summary>
    /// Interaction logic for MsgParse.xaml
    /// </summary>
    public partial class MsgParse : UserControl
    {
        public MsgParse()
        {
            this.InitializeComponent();
        }

        //仅支持前多少个字节，超长可选择另存为txt文本
        private void File_Open(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog =
                new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "打开文件";
            dialog.Filter = "所有文件|*.*|文本文件|*.txt";
            if (dialog.ShowDialog() == true)
            {
                dataSrc.Text = dialog.FileName;
            }
        }
    }
}
