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

namespace WpfAppActionDelegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EvenSubscriber1 subscriber1 = new EvenSubscriber1();
            EvenSubscriber2 subscriber2 = new EvenSubscriber2();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Demo");
           PublishEvent publishEvent = new PublishEvent();
        }
    }
}