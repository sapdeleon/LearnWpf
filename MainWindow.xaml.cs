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

namespace LearnWpf
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

        public void CreateTable(string[] headers)
        {
            dgMain.Columns.Clear();
            foreach (string header in headers)
            {
                DataGridTextColumn c = new DataGridTextColumn();
                c.Header = header;
                dgMain.Columns.Add(c);
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            List<UserModel> users = new List<UserModel>();

            users.Add(new UserModel() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), Address = "123 Pike Lane" });
            users.Add(new UserModel() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 2), Address = "123 Pike Lane" });
            users.Add(new UserModel() { Id = 3, Name = "Thomas Lee", Birthday = new DateTime(1967, 7, 23), Address = "123 Pike Lane" });

            dgMain.ItemsSource = users;
        }
    }
}
