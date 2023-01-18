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

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class MenuButtons : UserControl
    {
        
        public static Page searchSavedPage = new SearchSavedPage();
        public static Page savedResults = new SearchSavedRecipesResuts();
        


        public static bool onSavedRecipesPage = false;
        public static bool onSearchResultsPage = false;
        public static bool onHomePage = false;
        public static bool onSearchPage = false;
        public static string generalSearch="";
        public static string savedSearch="";

        public static bool durationFilterClicked = false;
        public static string durationFilterText = "5Min";

        public MenuButtons()
        {
            InitializeComponent();
        }

        public void ProfileButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(MainWindow.loginPage);
        }

        public void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(MainWindow.homePage);
        }

        public void SavedRecipesButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(MainWindow.savedRecipesPage);
        }
    }
}
