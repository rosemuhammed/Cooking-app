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
using System.Xml.Linq;

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for SubmittedComment.xaml
    /// </summary>
    public partial class RecipePageSubmittedComment : UserControl
    {
        public static string userName = "";
        public static string userComment = "";
        public static int userRating = 0;

        /*string userName_, string userComment_, int userRating_*/
        public RecipePageSubmittedComment()
        {
            InitializeComponent();

            /*userName=userName_;
            userComment=userComment_;
            userRating=userRating_; */          

        }

        public void addUserName()
        {
            UserNameContainer.Text=userName;
        }

        public void addComment()
        {
            UserCommentContainer.Text = userComment;
        }

        public void addUserRating(int rating)
        {
            UserControl noStar = new SetNoStarRating();
            UserControl oneStar = new SetOneStarRating();
            UserControl twoStar = new SetTwoStarRating();
            UserControl threeStar = new SetThreeStarRating();
            UserControl fourStar = new SetFourStarRating();
            UserControl fiveStar = new SetFiveStarRating();

            if (rating== 0)
            {
                UserRatingContainer.Items.Add(noStar);
            }
            else if(rating == 1)
            {
                UserRatingContainer.Items.Add(oneStar);
            }
            else if (rating== 2)
            {
                UserRatingContainer.Items.Add(twoStar);
            }
            else if (rating== 3)
            {
                UserRatingContainer.Items.Add(threeStar);
            }
            else if (rating== 4)
            {
                UserRatingContainer.Items.Add(fourStar);
            }
            else if (rating== 5)
            {
                UserRatingContainer.Items.Add(fiveStar);
            }
            
        }



    }
}
