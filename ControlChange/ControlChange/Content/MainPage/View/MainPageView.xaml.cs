using System.Windows;
using ControlChange.ViewModel;

namespace ControlChange.Content.MainPage.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainPageView : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainPageView()
        {
            
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}