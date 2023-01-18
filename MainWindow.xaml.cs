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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Page homePage = new HomePage();
        public static Page searchPage = new SearchPage();
        public static Page searchResultPage = new SearchResultsPage();
        public static Page filterPage = new FilterPage();
        public static Page misoRamen = new RecipeMisoRamenPage();
        public static Page bobaTea = new RecipeBobaTeaPage();
        public static Page jollofRice = new RecipeJollofRicePage();
        public static Page chocolateCake = new RecipeChocolateCakePage();
        public static Page macAndCheese = new RecipeMacAndCheesePage();
        public static Page savedRecipesPage = new SavedRecipesPage();
        public static Page loginPage = new LoginPage();
        public static Page searchSavedPage = new SearchSavedPage();
   

        public static bool onSavedRecipesPage = false;
        public static bool onSearchResultsPage = false;
        public static bool onHomePage = false;
        public static bool onSearchPage = false;
        public static string generalSearch;
        public static string savedSearch;

        public static bool durationFilterClicked = false;
        public static string durationFilterText = "5Min";


        public MainWindow()
        {

            InitializeComponent();
            CookingApplication.Content = new HomePage();
            //CookingApplication.Content = new RecipeCard1();
            //CookingApplication.Content = new SearchResultsPage();
            //CookingApplication.Content = new FilterPage();
            //CookingApplication.Content = new RecipeMisoRamenPage();
            //CookingApplication.Content = new RecipeJollofRicePage();
            //CookingApplication.Content = new RecipeChocolateCakePage();
            //CookingApplication.Content = new RecipeMacAndCheesePage();
            //CookingApplication.Content = new RecipeBobaTeaPage();
            //CookingApplication.Content = new SavedRecipesPage();
            //CookingApplication.Content = new SearchPage();

        }

        public static void NavigateToPage(Page page)
        {
            //Need to set CookingApplication on an instance of the MainWindow class
            if(page == SavedRecipesPage.instance && MenuButtons.onSavedRecipesPage == false )
            {
                //MenuButtons.onSavedRecipesPage = true;
                //MenuButtons.onHomePage = false;
                ((MainWindow)Application.Current.MainWindow).CookingApplication.Content = page;
            }else if(page == MainWindow.homePage && MenuButtons.onHomePage == false)
            {
                //MenuButtons.onHomePage = true;
               MenuButtons.onSavedRecipesPage = false;
                ((MainWindow)Application.Current.MainWindow).CookingApplication.Content = page;
            }
            else
            {
                //MenuButtons.onSavedRecipesPage = false;
                //MenuButtons.onHomePage = false;
                ((MainWindow)Application.Current.MainWindow).CookingApplication.Content = page;
            }
        }

    }
}
