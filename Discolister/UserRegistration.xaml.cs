using Discolister.Classes;
using SQLite;
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
using System.Windows.Shapes;

namespace Discolister
{
    /// <summary>
    /// Interaction logic for UserRegistration.xaml
    /// </summary>
    public partial class UserRegistration : Window
    {
        public UserRegistration()
        {
            InitializeComponent();
        }
        private void RegisterSubmit_Click(object sender, RoutedEventArgs e)
        {

            //ToDo Save Content To DataBase
            Users users = new Users()
            {
                eUserName = txtUserName.Text,
                eEmail = txtEmail.Text,
                ePassword = txtPasswordBox1.Text
            };
            //database principe

            //Destanation
            using (SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath))
            {
                //input in database
                connection.CreateTable<Users>();

                //Confirm
                connection.Insert(users);
            }

            Close();

        }

        private void RegisterReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
        public void Reset()
        {

            txtUserName.Text = "";
            txtEmail.Text = "";
            txtPasswordBox1.Text = "";
            txtPasswordBoxConfirm.Text = "";

        }

        private void RegisterCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
