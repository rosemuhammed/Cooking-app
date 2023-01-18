using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    /// 

    public partial class LoginPage : Page
    {

        public static LoginPage instance;
        public static bool userIsLoggedIn = false;


        public LoginPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void btn_closed(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(MainWindow.homePage);

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            string[] validemails = { "pleasegiveusgoodgrades@gmail.com", "christopheristhebest@gmail.com", "havemercyonus@gmail.com" };

            if (validemails.Contains(LoginEmailTextBox.Text) && userIsLoggedIn == false)
            {
                ErrorMessage.Foreground = Brushes.White;                
                TextBlockShowOnLogIn.Visibility = Visibility.Hidden;
                LoginEmailTextBox.Visibility = Visibility.Hidden;
                MessageBox.Show("You are now logged in!");
                btnLogin.Content = "Log Out";

                userIsLoggedIn = true;
                

            } else if(validemails.Contains(LoginEmailTextBox.Text) && userIsLoggedIn == true)
            {
                userIsLoggedIn = false;
                TextBlockShowOnLogIn.Visibility = Visibility.Visible;
                LoginEmailTextBox.Visibility = Visibility.Visible;
                btnLogin.Content = "Log In";
            }          
            else {
                ErrorMessage.Foreground = Brushes.Red;
            }

           

            MainWindow.NavigateToPage(MainWindow.homePage);
        }
    }
}
