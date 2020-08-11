using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Open_module
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Process process = new Process();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void location_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            process.StartInfo.FileName = "D:\\Notepad++\\notepad++.exe";
            process.StartInfo.Arguments = prefix.Text + filename.Text + ".py";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = location.Text;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = false;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
        }
    }
}
