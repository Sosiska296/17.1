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
using System.Windows.Threading;
namespace WpfApp17;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private DispatcherTimer timer;
    private int counter;
    private bool counting;
    public MainWindow()
    {
        InitializeComponent();
        timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(0.5);
        timer.Tick += (sender, args) =>
        {
            Поле.Text = counter.ToString();
            counter++;
        };
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (counting)
        {
            timer.Stop();
            counting = false;
        }
        else
        {
            timer.Start();
            counting = true;
        }
    }

}