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
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;


namespace cooking_app
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public static HomePage instance;

        List<string> recentlyViewedListTitle = RecipeCard1.recentlyViewedListTitle;
        public static List<string> recentlyViewedListDuration = new List<string>();
        //List<string> recentlyViewedListRating = new List<string>();
        //List<string> recentlyViewedListDifficulty = new List<string>();
        //List<ImageSource> recentlyViewedListImage = new List<ImageSource>();

        // TRENDING RECIPES 
        string[] trendingTitle = { "Baked Potatoes", "Baked Ziti", "Hashbrown Waffle", "Over-Baked Salmon", "One-Pan Baked Pasta", "Cheese Danish", "Chicken Marsala", "Red Velvet Cake", "Scallops Provencal", "Chicken Scampi Pasta" };
        string[] trendingTitleAdded = { "Shrimp Linguini", "Chocolate Cake", "Stuffed Bell Peppers", "Funeral Potatoes", "Baked Ziti", "Hashbrown Waffle", "Over-Baked Salmon", "One-Pan Baked Pasta", "Cheese Danish", "Chicken Marsala" };

        string[] trendingImg = { "bakedPotatoe.jpeg", "bakedZiti.jpeg", "hashWaffle.jpeg", "overBakedSalmon.jpeg", "Pasta.jpg", "cheeseDanish.jpeg", "chickenMarsala.jpeg", "redVelvet.jpeg", "scallopsProvencal.jpeg", "chickenScampi.jpeg" };
        string[] trendingImgAdded = { "trending/shrimpLinguini.jpeg", "chocolateCake.jpg", "newRecommended/classicStuffedPeppers.jpg", "trending/funeralPotatoes.jpeg", "trending/bakedPotatoe.jpeg", "trending/bakedZiti.jpeg", "trending/hashWaffle.jpeg", "trending/overBakedSalmon.jpeg", "trending/Pasta.jpg", "trending/cheeseDanish.jpeg" };

        string[] trendingRating = { "4.5", "5.0", "4.8", "4.8", "4.3", "4.7", "4.2", "4.0", "5.0", "4.3" };

        string[] trendingDifficulty = { "MED", "EASY", "MED", "HARD", "EASY", "EASY", "HARD", "HARD", "HARD", "MED" };

        string[] trendingDuration = { "30 MIN", "2 HR", "30 MIN", "1 HR", "30 MIN", "30 MIN", "1 HR", "2 HR", "30 MIN", "30 MIN" };

        // RECOMENDED RECIPES NEW 
        string[] RecommendedTitle = { "Vegan Lasagna", "Baked Lemon Risotto", "Feta Pasta", "Breakfast Tostadas", "Honey Glazed Salmon", "Pad Thai", "Chicken Fried Rice", "Black Bean Tostadas", "Classic Stuffed Peppers", "Air Fry Pork Chops" };

        string[] RecommendedImg = { "veganLasagna.jpg", "bakedLemonRisotto.jpg", "fetaPasta.jpg", "breakfastTostadas.jpeg", "glazedSalmon.jpg", "padThai.jpg", "chickenFriedRice.png", "blackbeantostadas.jpg", "classicStuffedPeppers.jpg", "airFryPorkChops.png" };

        string[] RecommendedRating = { "5.0", "4.0", "4.2", "4.8", "4.3", "4.7", "4.6", "4.2", "5.0", "4.7" };

        string[] RecommendedDuration = { "1 HR", "30 MIN", "30 MIN", "1 HR", "30 MIN", "30 MIN", "1 HR", "1 HR", "30 MIN", "30 MIN" };

        public HomePage()
        {
            InitializeComponent();
            instance = this;

            for (int i = 0; i < 10; i++)
            {
                UserControl1 rcard = new UserControl1();
                rcard.Title = trendingTitle[i];
                rcard.Difficulty = trendingDifficulty[i];
                rcard.Rating = trendingRating[i];
                rcard.Duration = trendingDuration[i];
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/trending/" + trendingImg[i], UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                rcard.ImageCard = imgSource;
                this.Trending.Children.Add(rcard);
            }

            for (int i = 0; i < 10; i++)
            {

                UserControl1 rcard = new UserControl1();
                rcard.Title = RecommendedTitle[i];
                rcard.Difficulty = "EASY";
                rcard.Rating = RecommendedRating[i];
                rcard.Duration = RecommendedDuration[i];
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/newRecommended/" + RecommendedImg[i], UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                rcard.ImageCard = imgSource;
                this.Recommended.Children.Add(rcard);
            }

            for (int i = 0; i < 10; i++)
            {
                EmptyRecipeCard ercard = new EmptyRecipeCard();
                this.RecentlyViewed.Children.Add(ercard);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        string filterText;
        string[] filter = new string[1];
        private void btn1Hr_Click(object sender, RoutedEventArgs e)
        {
            filterText = "1hr";
            filter[0] = "1 HR";
            NavigationService.Navigate(new SearchResultsPage(filterText, filter));
        }

        private void btn5Min_Click(object sender, RoutedEventArgs e)
        {
            filterText = "5min";
            filter[0] = "5 MIN";
            NavigationService.Navigate(new SearchResultsPage(filterText, filter));
        }

        private void btnAddTrending(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                UserControl1 rcard = new UserControl1();
                rcard.Title = trendingTitleAdded[i];
                rcard.Difficulty = trendingDifficulty[i];
                rcard.Rating = trendingRating[i];
                rcard.Duration = trendingDuration[i];
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/" + trendingImgAdded[i], UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                rcard.ImageCard = imgSource;
                this.Trending.Children.Add(rcard);
            }
        }

        private void btnAddRecommend(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                UserControl1 rcard = new UserControl1();
                rcard.Title = RecommendedTitle[i];
                rcard.Difficulty = "EASY";
                rcard.Rating = RecommendedRating[i];
                rcard.Duration = RecommendedDuration[i];
                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/newRecommended/" + RecommendedImg[i], UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                rcard.ImageCard = imgSource;
                this.Recommended.Children.Add(rcard);
            }

        }

        private void searchBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MenuButtons.onHomePage = true;
            MainWindow.NavigateToPage(MainWindow.searchPage);

        }

        public void addSavedRecipe(string title, string duration, string difficulty, string rating, ImageSource img)
        {
            UserControl1 recipe = new UserControl1();

            recipe.Title = title;
            recipe.DurationText.Content = duration;
            recipe.DifficultyText.Content = difficulty;
            recipe.RatingText.Content = rating;
            recipe.ImageCard = img;

            this.RecentlyViewed.Children.Insert(0,recipe);
        }
    }
}
