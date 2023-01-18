using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for SearchSavedRecipesResults.xaml
    /// </summary>
    public partial class SearchSavedRecipesResuts : Page
    {
        public static SearchSavedRecipesResuts instance = null;
        public SearchSavedRecipesResuts()
        {

            InitializeComponent();
            instance = this;

        }

        string str;
        public SearchSavedRecipesResuts(string strfromp) : this()
        {
            str = strfromp;
            displayResults();
        }

        public void displayResults()
        {
            if (str.Contains("ramen", StringComparison.InvariantCultureIgnoreCase)
)
            {
                RecipeCard2 recipe = new RecipeCard2();
                recipe.Title = "RAMEN";
                recipe.DurationText.Content = "30 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "4.0";
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/MisoRamen.jpg", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;

                this.SavedRecipes.Children.Add(recipe);

            }

            else if (str.Contains("chocolate cake", StringComparison.InvariantCultureIgnoreCase)
)
            {
                RecipeCard2 recipe = new RecipeCard2();
                recipe.Title = "CHOCOLATE CAKE";
                recipe.DurationText.Content = "30 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "4.0";
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/chocolatecake.jpg", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;
                this.SavedRecipes.Children.Add(recipe);

            }
            else if (str.Contains("lunch", StringComparison.InvariantCultureIgnoreCase)
)
            {
                RecipeCard2 recipe = new RecipeCard2();

                recipe.Title = "Mac and Cheese";
                recipe.DurationText.Content = "30 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "4.5";
                recipe.Duration = "30 MIN";
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/mac/mac2.jpg", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;
                this.SavedRecipes.Children.Add(recipe);

            }

            else if (str.Contains("dinner", StringComparison.InvariantCultureIgnoreCase)
)
            {
                RecipeCard2 recipe = new RecipeCard2();

                recipe.Title = "Miso Ramen";
                recipe.DurationText.Content = "30 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "3.0";
                recipe.Duration = "30 MIN";
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/MisoRamen.jpg", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;
                this.SavedRecipes.Children.Add(recipe);

                RecipeCard2 recipe2 = new RecipeCard2();

                recipe.Title = "Pizza";
                recipe.DurationText.Content = "1 HR";
                recipe.DifficultyText.Content = "HARD";
                recipe.RatingText.Content = "4.8";
                recipe.Duration = "1 HR";
                Uri uri1 = new Uri("pack://application:,,,/cooking-app;component/img/pizza.jpg", UriKind.Absolute);
                ImageSource imgSource1 = new BitmapImage(uri);
                recipe2.ImageCard = imgSource;
                this.SavedRecipes.Children.Add(recipe2);

                RecipeCard2 recipe3 = new RecipeCard2();

                recipe.Title = "Japanese Udon";
                recipe.DurationText.Content = "45 MIN";
                recipe.DifficultyText.Content = "MED";
                recipe.RatingText.Content = "4.0";
                recipe.Duration = "45 MIN";
                Uri uri3 = new Uri("pack://application:,,,/cooking-app;component/ramen/MisoRamen.jpg", UriKind.Absolute);
                ImageSource imgSource3 = new BitmapImage(uri);
                recipe.ImageCard = imgSource;
                this.SavedRecipes.Children.Add(recipe3);

            }

            else if (str.Contains("drinks", StringComparison.InvariantCultureIgnoreCase)
)
            {
                RecipeCard2 recipe = new RecipeCard2();

                recipe.Title = "Bubble Tea";
                recipe.DurationText.Content = "5 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "4.0";
                recipe.Duration = "5 MIN";
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/5Min/bubbletea.jpg", UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;
                this.SavedRecipes.Children.Add(recipe);

            }
        }

        // This will be called when the user clicks to save a recipe
        public void addSavedRecipe(string title, string duration, string difficulty, string rating, ImageSource img)
        {
            RecipeCard2 recipe = new RecipeCard2();

            recipe.Title = title;
            recipe.DurationText.Content = duration;
            recipe.DifficultyText.Content = difficulty;
            recipe.RatingText.Content = rating;
            recipe.ImageCard = img;

            this.SavedRecipes.Children.Insert(0, recipe);

        }


        // When the user clicks to filter the saved recipes 
        private void catergory1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void generalSearch_Click(object sender, RoutedEventArgs e)
        {
            MenuButtons.onSavedRecipesPage = true;
            MainWindow.NavigateToPage(MainWindow.searchPage);

        }

        // Only searches through the saved recipes 
        private void searchSaved_Click(object sender, RoutedEventArgs e)
        {
            MenuButtons.onSavedRecipesPage = true;
            MainWindow.NavigateToPage(MenuButtons.searchSavedPage);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(SavedRecipesPage.instance);
        }
    }
}
