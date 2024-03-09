using Microsoft.UI.Xaml;
using System.Collections.ObjectModel;
using CommunityToolkit.WinUI.UI.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MVVM_Learning
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; set; }
        public MainWindow()
        {
            this.InitializeComponent();
            this.populatePeople();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }

        private void populatePeople() {
            People = new ObservableCollection<Person>()
            {
                new Person("John Doe", 30, "Software Engineer"),
                new Person("Jane Smith", 25, "Data Scientist"),
                new Person("Alice Johnson", 35, "Project Manager"),
                new Person("Bob Brown", 40, "Teacher")
            };
            dataListView.ItemsSource = People;
        }
    }
}
