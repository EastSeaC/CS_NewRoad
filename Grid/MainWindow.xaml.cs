using System.Windows;
using System.Windows.Controls;

using System.Collections.ObjectModel;
using System.IO;
using System.Text;
namespace DataGridTest
{
    public enum sexual_enum
    {
        BOY,
        GIRL
    }
    public class people
    {
        public string id { get; set; }
        public string name{ get; set; }
        public string no { get; set; }
    }
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<people> peopleList = new ObservableCollection<people>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {

            


            peopleList.Add(new people()
            {
                id="ae",
                name = "小红",
                no = "18",
            });

            (FindName("DATA_GRID") as DataGrid).ItemsSource = peopleList;
        }

    
    }
}

