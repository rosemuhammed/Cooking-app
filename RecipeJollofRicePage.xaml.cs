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
    /// Interaction logic for RecipeJollofRicePage.xaml
    /// </summary>
    public partial class RecipeJollofRicePage : Page
    {
        public static RecipeJollofRicePage instance = null;

        public static string userNameForComment = "";
        public RecipeJollofRicePage()
        {
            InitializeComponent();
            instance = this;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (MenuButtons.onHomePage)
            {
                MainWindow.NavigateToPage(MainWindow.homePage);
            }
            else if (MenuButtons.onSavedRecipesPage)
            {
                MainWindow.NavigateToPage(MainWindow.savedRecipesPage);
            }
            else if (MenuButtons.onSearchResultsPage)
            {
                MainWindow.NavigateToPage(MainWindow.searchResultPage);
            }
            else
            {
                MainWindow.NavigateToPage(MainWindow.homePage);
            }

            MenuButtons.onHomePage = false;
            MenuButtons.onSavedRecipesPage = false;
            MenuButtons.onSearchResultsPage = false;

        }


        private void ScrollToIngredients(object sender, RoutedEventArgs e)
        {
            Ingredients.BringIntoView();
            IEnumerable<Button> tabs = TabSection.Children.OfType<Button>();

            if (sender.Equals(IngredientsTab))
            {
                tabs.ElementAt(0).Background = Brushes.LightGray;
                tabs.ElementAt(1).Background = Brushes.White;
                tabs.ElementAt(2).Background = Brushes.White;
                tabs.ElementAt(3).Background = Brushes.White;
            }
        }

        private void ScrollToInstructions(object sender, RoutedEventArgs e)
        {
            Instructions.BringIntoView();
            IEnumerable<Button> tabs = TabSection.Children.OfType<Button>();

            if (sender.Equals(InstructionsTab))
            {
                tabs.ElementAt(0).Background = Brushes.White;
                tabs.ElementAt(1).Background = Brushes.LightGray;
                tabs.ElementAt(2).Background = Brushes.White;
                tabs.ElementAt(3).Background = Brushes.White;
            }
        }

        private void ScrollToNutrition(object sender, RoutedEventArgs e)
        {
            Nutrition.BringIntoView();
            IEnumerable<Button> tabs = TabSection.Children.OfType<Button>();

            if (sender.Equals(NutritionTab))
            {
                tabs.ElementAt(0).Background = Brushes.White;
                tabs.ElementAt(1).Background = Brushes.White;
                tabs.ElementAt(2).Background = Brushes.LightGray;
                tabs.ElementAt(3).Background = Brushes.White;
            }
        }
        private void ScrollToReviews(object sender, RoutedEventArgs e)
        {
            Reviews.BringIntoView();
            IEnumerable<Button> tabs = TabSection.Children.OfType<Button>();

            if (sender.Equals(ReviewsTab))
            {
                tabs.ElementAt(0).Background = Brushes.White;
                tabs.ElementAt(1).Background = Brushes.White;
                tabs.ElementAt(2).Background = Brushes.White;
                tabs.ElementAt(3).Background = Brushes.Gray;
            }
        }

        private void EggsPopup(object sender, RoutedEventArgs e)
        {
            if (EggPopup.IsOpen == true)
            {
                EggPopup.IsOpen = false;
            }
            else
            {
                EggPopup.IsOpen = true;
            }

        }

        private void DisplayUserComment(object sender, RoutedEventArgs e)
        {
            RecipePageSubmittedComment comment = new RecipePageSubmittedComment();
            LoginPage page = LoginPage.instance;
            if (page.LoginEmailTextBox.Text == "")
            {
                comment.UserNameContainer.Text = "anonymous";
            }
            else
            {
                comment.UserNameContainer.Text = page.LoginEmailTextBox.Text;
            }
            comment.UserCommentContainer.Text = UserComment.Text;
            comment.addUserRating(UserRating.getNoOfStars());

            UserCommentsAdded.Items.Add(comment);
        }
    }
}
