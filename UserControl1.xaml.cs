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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.TitleText.Content = this.title;
            }

        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                this.DurationText.Content = this.duration;
            }

        }

        private string rating;
        public string Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                this.RatingText.Content = this.rating;
            }

        }

        private string difficulty;
        public string Difficulty
        {
            get { return difficulty; }
            set
            {
                difficulty = value;
                this.DifficultyText.Content = this.difficulty;
            }

        }

        private ImageSource img;
        public ImageSource ImageCard
        {
            get { return img; }
            set
            {
                img = value;
                this.ImgCard.Source = this.img;
            }

        }


        public UserControl1()
        {
            InitializeComponent();
        }

        public void cardBtnClick(object sender, RoutedEventArgs e)
        {
            if (title.Contains("Chocolate Cake", StringComparison.InvariantCultureIgnoreCase))
            {
                MenuButtons.onHomePage = true;
                MainWindow.NavigateToPage(MainWindow.chocolateCake);
            }
            else if (title.Contains("Miso Ramen", StringComparison.InvariantCultureIgnoreCase))
            {
                MenuButtons.onHomePage = true;
                MainWindow.NavigateToPage(MainWindow.misoRamen);
            }
            else if (title.Contains("Mac and Cheese", StringComparison.InvariantCultureIgnoreCase))
            {
                MenuButtons.onHomePage = true;
                MainWindow.NavigateToPage(MainWindow.macAndCheese);
            }
            else if (title.Contains("Jollof Rice", StringComparison.InvariantCultureIgnoreCase))
            {
                MenuButtons.onHomePage = true;
                MainWindow.NavigateToPage(MainWindow.jollofRice);
            }
            else if (title.Contains("Bubble Tea", StringComparison.InvariantCultureIgnoreCase))
            {
                MenuButtons.onHomePage = true;
                MainWindow.NavigateToPage(MainWindow.bobaTea);
            }

            HomePage page = HomePage.instance;
            page.addSavedRecipe(title, duration, difficulty, rating, img);
        }

        public void btn_Saved(object sender, RoutedEventArgs e)
        {
            SavedRecipesPage page = SavedRecipesPage.instance;
            page.addSavedRecipe(title, duration, difficulty, rating, img);
        }
    }
}
