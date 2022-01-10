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

            connection.Table<Users>().ToList().ForEach((each) =>

                         if (each.eUserName == txtUsername.Text && each.ePassword == txtPassword.Text)
                {

                    
             /*   }
                else if (!Regex.IsMatch(each.eUserName, int.Users.User_ID == each.ePassword, int.Users.User_ID))
                {*/
                    GrantedAcces(); return;

                    


                    
             /*   }
                else if (!Regex.IsMatch(each.eUserName, int.Users.User_ID == each.ePassword, int.Users.User_ID))
                {*/
                    GrantedAcces(); return;

                }
                else
                {
                    Messagebox.Text = " inlog has failed"; //displayed message if login has failed

            }
       
                  

           
        }

            });
          }

        // butti to go to Registation window  new
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ShowDialog();
        }

        //=====================================func validi login========================
        // private bool ValidLogin()
        // {
        //     string message = "Enter a ";
        //     if(txtUsername.Text == "")
        //     {
        //         message += "Username";
        //     }
        //     if (txtPassword.Text == "")
        //     {
        //         if (txtUsername.Text == "")
        //         {
        //             message += "and a ";
        //         }
        //         message += "password";
        //         }
        //         if (Message != "Enter a ")
        //         {
        //             LoginLabelError.Text = Message;
        //         LoginLabelError.Left = (LoginPanel.Width - LoginLabelError.Width) / 2;
        //         LoginLabelError.Visible = true;
        //         return false;
        //     }
        //     }
        //=====================================func validi login========================






        public void GrantedAcces() 
        {
        MenuScreen menuScreen = new MenuScreen();
            menuScreen.ShowDialog();
        }
    }
}
