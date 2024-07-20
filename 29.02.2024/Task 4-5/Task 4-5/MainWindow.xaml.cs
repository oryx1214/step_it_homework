using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task_4_5.Services;

namespace Task_4_5
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

        private void FindBtn_Click(object sender, RoutedEventArgs e) // if you create a dublicat file after name OS cenerate "[Имя файла ] - копия.txt".
        {

            FindSameFilesService.Find(SourceTxtBox.Text); //This method is findig "копия" to understand what file is dublicat.Copied files move to net8.0 - windows


        }
    }
}