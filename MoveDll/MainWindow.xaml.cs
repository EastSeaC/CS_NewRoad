using System.IO;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace MoveDll
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();
            if (P_File_Folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SourceDirectory.Text = P_File_Folder.SelectedPath + "\\";
            }

        }

        private void DestFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();
            if (P_File_Folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DestDirectory.Text = P_File_Folder.SelectedPath;
            }
        }

        private void CopyFile(string srcFile, string destDir)
        {
            DirectoryInfo destDirectory = new DirectoryInfo(destDir);
            string fileName = Path.GetFileName(srcFile);
            if (!File.Exists(srcFile))
            {
                MessageBox.Show("文件不存在");
            }
            else
            {
                if (!destDirectory.Exists)
                {
                    destDirectory.Create();
                }
                File.Copy(srcFile, destDirectory.FullName + "\\" + fileName, false);

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(SourceDirectory.Text);
            string srcFileName = SourceDirectory.Text + "Debug\\" + info.Name;
            string a = srcFileName + ".dll", b = srcFileName + ".lib";

            CopyFile(a, DestDirectory.Text + "\\Debug");
            CopyFile(b, DestDirectory.Text + "\\Debug");
            if (header.IsChecked == true)
            {
                string path = SourceDirectory.Text;
                DirectoryInfo root = new DirectoryInfo(path);
                FileInfo[] files = root.GetFiles();

                foreach (FileInfo files1 in files)
                {
                    if (files1.Extension.Equals(".h"))
                    {
                        CopyFile(files1.FullName, DestDirectory.Text);
                    }
                    else MessageBox.Show("不匹配");
                }

            }
            MessageBox.Show("移动成功");
        }


    }
}
