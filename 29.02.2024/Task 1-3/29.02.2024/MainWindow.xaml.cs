using _29._02._2024.Services;
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

namespace _29._02._2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool SaveInFile = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private  async void SentenceCountBtn_Checked(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";
            if (TextCheckService.IsNull(EnteredTxtBox.Text)) return;
            if (!SaveInFile) InfoTxtBlock.Text =  $"Sentences Count : {Convert.ToString(await CountsService.SentenceCount(EnteredTxtBox.Text))}";
            else
            {
                using FileStream fs = new("Hw.txt", FileMode.Truncate);
                using StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Sentences Count : {Convert.ToString(await CountsService.SentenceCount(EnteredTxtBox.Text))}");
            }
        }

        private async void SymbolCountBtn_Checked(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";
            if (TextCheckService.IsNull(EnteredTxtBox.Text)) return;
            if (!SaveInFile) InfoTxtBlock.Text =  $"Symbol Count : {Convert.ToString(await CountsService.SymbolCount(EnteredTxtBox.Text))}";
            else
            {
                using FileStream fs = new("Hw.txt", FileMode.Truncate);
                using StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Symbol Count : {Convert.ToString(await CountsService.SymbolCount(EnteredTxtBox.Text))}");
            }
        }

        private async void WordsCountBtn_Checked(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";
            if (TextCheckService.IsNull(EnteredTxtBox.Text)) return;
            if (!SaveInFile) InfoTxtBlock.Text = $"Words Count : {Convert.ToString(await CountsService.WordCount(EnteredTxtBox.Text))}";
            else
            {
                using FileStream fs = new("Hw.txt", FileMode.Truncate);
                using StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Words Count : {Convert.ToString(await CountsService.WordCount(EnteredTxtBox.Text))}");
            }
        }

        private async void QuestionSentencesCountBtn_Checked(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";
            if (TextCheckService.IsNull(EnteredTxtBox.Text)) return;
            if (!SaveInFile) InfoTxtBlock.Text = $"Questions Sentence Count : {Convert.ToString(await CountsService.QuestionSentencesCount(EnteredTxtBox.Text))}";
            else
            {
                using FileStream fs = new("Hw.txt", FileMode.Truncate);
                using StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Questions Sentence Count : {Convert.ToString(await CountsService.QuestionSentencesCount(EnteredTxtBox.Text))}");
            }
        }

        private async void ExclamatorySentencesCountBtn_Checked(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";
            if (TextCheckService.IsNull(EnteredTxtBox.Text)) return;
            if (!SaveInFile) InfoTxtBlock.Text = $"Exclamatory Sentences Count : {Convert.ToString(await CountsService.ExclamatorySentencesCount(EnteredTxtBox.Text))}";
            else
            {
                using FileStream fs = new("Hw.txt", FileMode.Truncate);
                using StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"Exclamatory Sentences Count : {Convert.ToString(await CountsService.ExclamatorySentencesCount(EnteredTxtBox.Text))}");
            }

        }

        private void ShowThereBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";

            ShowThereBtn.Background = Brushes.Green;
            SaveInFileBtn.Background = Brushes.Red;
            SaveInFile = false;
        }


        private void SaveInFileBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowAllBtn.Content = "Find All";

            ShowThereBtn.Background = Brushes.Red;
            SaveInFileBtn.Background = Brushes.Green;
            SaveInFile = true;
        }

        private async void Button_Click(object sender, RoutedEventArgs e) // MAKE DOUBLE CLICK TO STOP
        {
    

            if (TextCheckService.IsNull(EnteredTxtBox.Text)) return;
   
            if (ShowAllBtn.Content == "Stop")
            {
                ShowAllBtn.Content = "Find All";
                InfoTxtBlock.Text = "";
                return;
            }


            ShowAllBtn.Content = "Stop";


            InfoTxtBlock.Text = await TextCheckService.ShowAll(EnteredTxtBox.Text);
        }
    }
}