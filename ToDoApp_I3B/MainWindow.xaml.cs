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
using ToDoApp_I3B.Manage;

namespace ToDoApp_I3B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ToDoManager _manager;
        public MainWindow()
        {
            _manager = new ToDoManager(new Databaze ToDoDbContext());
            InitializeComponent();
        }
    }
}