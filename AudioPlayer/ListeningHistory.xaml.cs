using System.Windows;
using System.Windows.Controls;
using static AudioPlayer.MainWindow;

namespace AudioPlayer
{
    /// <summary>
    /// Логика взаимодействия для ListeningHistory.xaml
    /// </summary>
    public partial class ListeningHistory : Window
    {
        public string SelectedAudio { get; set; }


        public ListeningHistory()
        {
            InitializeComponent();
        }

        private void ListBoxHistory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxHistory.SelectedItem != null)
            {
                SelectedAudio = ListBoxHistory.SelectedItem.ToString();
                DialogResult = true;
            }
        }     
    }    
}


