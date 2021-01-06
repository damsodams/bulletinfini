using MahApps.Metro.Controls;
namespace Bulletinfini
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            // WPromo a = new WPromo();
            WMatiere m = new WMatiere();

            //a.Show();
            m.Show();
        }
    }
}
