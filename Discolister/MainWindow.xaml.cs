using Discolister.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Discolister
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
        SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
        private void Login_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 3b95cd1 (version1.0.0)
            connection.Table<Users>().ToList().ForEach((each) =>
>>>>>>> parent of 3b95cd1 (version1.0.0)
            {
                if (!ValidLogin)
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    string Username = txtUsername.Text;
                    string Password = txtPassword.Text;
                    
                    string Statment;
                    //DBConnections
                    SQLiteConnection connection = new SQLiteConnection(App.sDataBasePath);
                    {
                        //SQLite.Open();
                        Statment = $"SELECT EXISTS FROM Users WHERE Username='eUserName'";
                        if((Int64) new SQLiteCommand(Statment, sSQLite).ExecuteScalar() == 0) 
                        {
                            
                        }
                    }
                    
=======
=======
>>>>>>> parent of 3b95cd1 (version1.0.0)

                    
             /*   }
                else if (!Regex.IsMatch(each.eUserName, int.Users.User_ID == each.ePassword, int.Users.User_ID))
                {*/
                    GrantedAcces(); return;

                }
                else
                {
                    Messagebox.Text = " inlog has failed"; //displayed message if login has failed
>>>>>>> parent of 3b95cd1 (version1.0.0)
                }
            }
       
                  
<<<<<<< HEAD
           
        }
=======
            });
          }
<<<<<<< HEAD
>>>>>>> parent of 3b95cd1 (version1.0.0)
=======
>>>>>>> parent of 3b95cd1 (version1.0.0)
        // butti to go to Registation window  new
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ShowDialog();
        }

<<<<<<< HEAD
<<<<<<< HEAD
        //=====================================func validi login========================
        private bool ValidLogin()
        {
            string message = "Enter a ";
            if(txtUsername.Text == "")
            {
                message += "Username";
            }
            if (txtPassword.Text == "")
            {
                if (txtUsername.Text == "")
                {
                    message += "and a ";
                }
                message += "password";
                }
                if (Message != "Enter a ")
                {
                    LoginLabelError.Text = Message;
                LoginLabelError.Left = (LoginPanel.Width - LoginLabelError.Width) / 2;
                LoginLabelError.Visible = true;
                return false;
            }
            }
        //=====================================func validi login========================





=======
>>>>>>> parent of 3b95cd1 (version1.0.0)
=======
>>>>>>> parent of 3b95cd1 (version1.0.0)
        public void GrantedAcces() 
        {
        MenuScreen menuScreen = new MenuScreen();
            menuScreen.ShowDialog();
        }
    }
}
