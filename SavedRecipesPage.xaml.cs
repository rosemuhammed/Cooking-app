using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for SavedRecipesPage.xaml
    /// </summary>
    
    public partial class SavedRecipesPage : Page
    {
        public static SavedRecipesPage instance = null;
        public static StackPanel SPRef = null;

        

        // The inital saved recipes 
        string[] title = { "Mac and Cheese", "Pizza", "Bubble Tea", "Japanese Udon" };
        string[] duration = { "30 MIN", "1 HR", "5 MIN", "45 MIN" };
        string[] difficulty = { "EASY", "HARD", "EASY", "MEDIUM" };
        string[] rating = { "4.5", "4.1", "4.8", "4.0" };
        string[] image = { "mac/mac2.jpg", "Pizza.jpg", "5Min/bubbleTea.jpg", "Udon.jpg" };
        public SavedRecipesPage()
        {

            InitializeComponent();
            instance = this;

            SPRef = SavedRecipesStackPanel;

            // Create a few default saved recipes initally 
            for (int i = 0; i < 4; i++)
            {
                RecipeCard2 recipe = new RecipeCard2();

                recipe.Title = title[i];
                recipe.DurationText.Content = duration[i];
                recipe.DifficultyText.Content = difficulty[i];
                recipe.RatingText.Content = rating[i];
                recipe.Duration = "1 HR";
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/" + image[i], UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;
                this.SavedRecipesStackPanel.Children.Add(recipe);
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

            SPRef.Children.Insert(2,recipe);
        }

        string buttonResults;

        // When the user clicks to filter the saved recipes 
        private void breakfast_Click(object sender, RoutedEventArgs e)
        {
            buttonResults = "breakfast";
            NavigationService.Navigate(new SearchSavedRecipesResuts(buttonResults));


            //SPRef.Children.RemoveRange(2, SPRef.Children.Count - 1);
        }

        private void lunch_Click(object sender, RoutedEventArgs e)
        {
            /*SPRef.Children.RemoveRange(2, SPRef.Children.Count - 1);

            RecipeCard2 recipe = new RecipeCard2();

            recipe.Title = "Mac and Cheese";
            recipe.DurationText.Content = "30 MIN";
            recipe.DifficultyText.Content = "EASY";
            recipe.RatingText.Content = "4.5";
            recipe.Duration = "30 MIN";
            Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/mac/mac2.jpg", UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            recipe.ImageCard = imgSource;
            this.SavedRecipesStackPanel.Children.Add(recipe);*/

            buttonResults = "lunch";
            NavigationService.Navigate(new SearchSavedRecipesResuts(buttonResults));


        }

        private void dinner_Click(object sender, RoutedEventArgs e)
        {
            /*SPRef.Children.RemoveRange(2, SPRef.Children.Count - 1);

            RecipeCard2 recipe = new RecipeCard2();

            recipe.Title = "Miso Ramen";
            recipe.DurationText.Content = "30 MIN";
            recipe.DifficultyText.Content = "EASY";
            recipe.RatingText.Content = "3.0";
            recipe.Duration = "30 MIN";
            Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/MisoRamen.jpg", UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            recipe.ImageCard = imgSource;
            this.SavedRecipesStackPanel.Children.Add(recipe);

            RecipeCard2 recipe2 = new RecipeCard2();

            recipe.Title = "Pizza";
            recipe.DurationText.Content = "1 HR";
            recipe.DifficultyText.Content = "HARD";
            recipe.RatingText.Content = "4.8";
            recipe.Duration = "1 HR";
            Uri uri1 = new Uri("pack://application:,,,/cooking-app;component/img/pizza.jpg", UriKind.Absolute);
            ImageSource imgSource1 = new BitmapImage(uri);
            recipe2.ImageCard = imgSource;
            this.SavedRecipesStackPanel.Children.Add(recipe2);

            RecipeCard2 recipe3 = new RecipeCard2();

            recipe.Title = "Japanese Udon";
            recipe.DurationText.Content = "45 MIN";
            recipe.DifficultyText.Content = "MED";
            recipe.RatingText.Content = "4.0";
            recipe.Duration = "45 MIN";
            Uri uri3 = new Uri("pack://application:,,,/cooking-app;component/ramen/MisoRamen.jpg", UriKind.Absolute);
            ImageSource imgSource3 = new BitmapImage(uri);
            recipe.ImageCard = imgSource;
            this.SavedRecipesStackPanel.Children.Add(recipe3);*/

            buttonResults = "dinner";
            NavigationService.Navigate(new SearchSavedRecipesResuts(buttonResults));


        }

        private void snacks_Click(object sender, RoutedEventArgs e)
        {
            //SPRef.Children.RemoveRange(2, SPRef.Children.Count - 1);
            buttonResults = "snack";
            NavigationService.Navigate(new SearchSavedRecipesResuts(buttonResults));
        }

        private void dessert_Click(object sender, RoutedEventArgs e)
        {
            //SPRef.Children.RemoveRange(2, SPRef.Children.Count - 1);
            buttonResults = "dessert";
            NavigationService.Navigate(new SearchSavedRecipesResuts(buttonResults));

        }

        private void drinks_Click(object sender, RoutedEventArgs e)
        {
            //SPRef.Children.RemoveRange(2, SPRef.Children.Count - 1);
            buttonResults = "drinks";
            NavigationService.Navigate(new SearchSavedRecipesResuts(buttonResults));



            /*RecipeCard2 recipe = new RecipeCard2();

            recipe.Title = "Bubble Tea";
            recipe.DurationText.Content = "5 MIN";
            recipe.DifficultyText.Content = "EASY";
            recipe.RatingText.Content = "4.0";
            recipe.Duration = "5 MIN";
            Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/5Min/bubbletea.jpg", UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            recipe.ImageCard = imgSource;
            this.SavedRecipesStackPanel.Children.Add(recipe);*/
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
            MainWindow.NavigateToPage(MainWindow.searchSavedPage);
        }


    }
}
