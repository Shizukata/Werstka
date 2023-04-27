using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wersta
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User(1, "Ivan", "Ivanov", 19, "Kazan"));
            users.Add(new User(2, "Albert", "Biven", 5, "Kazan"));
            users.Add(new User(3, "Kirill", "Izvini", 29, "Kazan"));
            users.Add(new User(4, "Ivan", "Galunov", 129, "Kazan"));
            LvList.ItemsSource = users;
        }
    }
}
