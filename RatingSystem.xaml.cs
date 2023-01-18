using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for RatingSystem.xaml
    /// </summary>
    public partial class RatingSystem : UserControl
    {
        public static int numberOfStars=0;
        public RatingSystem()
        {
            InitializeComponent();
        }

        public int getNoOfStars()
        {
            return numberOfStars;
        }

        public void ChangeRating(object sender, RoutedEventArgs e)
        {
            IEnumerable<ToggleButton> stars = RatingSystemStars.Children.OfType<ToggleButton>();

            if (sender.Equals(FirstStar))
            {
                
                if (stars.ElementAt(0).IsChecked ?? false)
                {
                    stars.ElementAt(0).IsChecked = true;
                    numberOfStars = 1;                    
                }
                else
                {
                    stars.ElementAt(0).IsChecked = false;
                    stars.ElementAt(1).IsChecked = false;
                    stars.ElementAt(2).IsChecked = false;
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                    numberOfStars = 0;
                }

            }
            else if (sender.Equals(SecondStar))
            {
                stars.ElementAt(0).IsChecked = true;

                if (stars.ElementAt(1).IsChecked ?? false)
                {
                    stars.ElementAt(1).IsChecked = true;
                    numberOfStars = 2;
                }
                else
                {
                    stars.ElementAt(1).IsChecked = false;
                    stars.ElementAt(2).IsChecked = false;
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                    numberOfStars = 1;
                }

            }
            else if (sender.Equals(ThirdStar))
            {
                stars.ElementAt(0).IsChecked = true;
                stars.ElementAt(1).IsChecked = true;

                if (stars.ElementAt(2).IsChecked ?? false)
                {
                    stars.ElementAt(2).IsChecked = true;
                    numberOfStars = 3;
                }
                else
                {
                    stars.ElementAt(2).IsChecked = false;
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                    numberOfStars = 2;
                }
            }
            else if (sender.Equals(FourthStar))
            {
                stars.ElementAt(0).IsChecked = true;
                stars.ElementAt(1).IsChecked = true;
                stars.ElementAt(2).IsChecked = true;

                if (stars.ElementAt(3).IsChecked ?? false)
                {
                    stars.ElementAt(3).IsChecked = true;
                    numberOfStars = 4;
                }
                else
                {
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                    numberOfStars = 3;
                }
            }
            else if (sender.Equals(FifthStar))
            {
                stars.ElementAt(0).IsChecked = true;
                stars.ElementAt(1).IsChecked = true;
                stars.ElementAt(2).IsChecked = true;
                stars.ElementAt(3).IsChecked = true;
                if (stars.ElementAt(4).IsChecked ?? false)
                {
                    stars.ElementAt(4).IsChecked = true;
                    numberOfStars = 5;
                }
                else
                {
                    stars.ElementAt(4).IsChecked = false;
                    numberOfStars = 4;
                }

            }

        }
    }
}
