using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class FilterPage : Page
    {
        public static FilterPage instance;

        private List<Object> rbList = new List<Object>();
        public static String[] appliedFilters = new String[6];

        public String[,] testReciepe = new String[3, 6] {
                                            { "Breakfast", "Easy", "Vegan", "Italian", "5", "120"},
                                            { "Lunch", "Easy", "Low-Carbs", "Italian", "35", "120" },
                                            { "Dinner", "Medium", "", "Italian", "40", "60"}
                                        };
        private string MealFil = "";
        private string DiffLevelFil = "";
        private string dietFil = "";
        private string cuisineFil = "";
        private double minduration = 5;
        private double maxduration = 120;


        public static SearchResultsPage srpage = new SearchResultsPage();

        public FilterPage()
        {
            InitializeComponent();
            instance = this;
        }

        string searchResults;
        public FilterPage(string strfromp) : this()
        {
            searchResults = strfromp;
            //this.Loaded += new RoutedEventHandler(displayResults);
        }

        String[] appliedFiltersText;

        // can have null values and last element of the list are double converted into string
        private void Back_Click(object sender, RoutedEventArgs e)
        {

            appliedFilters[0] = MealFil;
            appliedFilters[1] = DiffLevelFil;
            appliedFilters[2] = dietFil;
            appliedFilters[3] = cuisineFil;
            if (minduration > maxduration)
                MessageBox.Show("Minimum Duration cannot be greater than Maximum Duration");
            else
            {
                appliedFilters[4] = minduration.ToString();
                appliedFilters[5] = maxduration.ToString();
            }

            appliedFiltersText = appliedFilters;
            NavigationService.Navigate(new SearchResultsPage(searchResults, appliedFilters));

            // foreach (String f in appliedFilters)
            //   {
            // if (appliedFilters[i] != null && (appliedFilters[4] != "5" && appliedFilters[5] != "120"))
            //         MessageBox.Show(appliedFilters[i], i.ToString());
            // }

            //for (int i = 0; i < 3; i++)
            /** {

                 if (
                             testReciepe[i, 0].ToUpper() == appliedFilters[0].ToUpper()
                                         &&
                             testReciepe[i, 1].ToUpper() == appliedFilters[1].ToUpper()

                                         &&
                             testReciepe[i, 2].ToUpper() == appliedFilters[2].ToUpper()
                                         &&

                             testReciepe[i, 3].ToUpper() == appliedFilters[3].ToUpper()

                                         &&
                             (testReciepe[i, 4] == appliedFilters[4]  && testReciepe[i, 5] == appliedFilters[5] )

                  ) { }
             }
            **/
            //ApplicationSwitcher.filterSwitcher = this;
            //ApplicationSwitcher.Switch(srpage);

            //MainWindow.NavigateToPage(MenuButtons.searchResultPage); 


        }

        int click = 0;
        private void Meal_click(object sender, RoutedEventArgs e)
        {
            rbList.Add(sender);
            RadioButton radioButton = (RadioButton)sender;

            try
            {
                click++;

                radioButton.IsChecked = click % 2 == 1;    // click = 1

                if (radioButton.IsChecked == true)
                    MealFil = radioButton.Content.ToString();
                else
                    MealFil = "";

                click %= 2;



            }
            catch (Exception) { MessageBox.Show("invalid Meal filter selection"); }


        }

        int dLclick1 = 0;
        private void DiffLevel_click(object sender, RoutedEventArgs e)
        {
            rbList.Add(sender);
            RadioButton radioButton = (RadioButton)sender;

            try
            {
                dLclick1++;

                radioButton.IsChecked = dLclick1 % 2 == 1;    // click = 1

                if (radioButton.IsChecked == true)
                    DiffLevelFil = radioButton.Content.ToString();
                else
                    DiffLevelFil = "";

                dLclick1 %= 2;                   // click = 0



            }
            catch (Exception) { MessageBox.Show("invalid Difficulty Level filter selection"); }

        }
        int DietClick1 = 0;
        private void Diet_Click(object sender, RoutedEventArgs e)
        {
            rbList.Add(sender);

            RadioButton radioButton = (RadioButton)sender;

            try
            {
                DietClick1++;

                radioButton.IsChecked = DietClick1 % 2 == 1;    // click = 1

                if (radioButton.IsChecked == true)
                    dietFil = radioButton.Content.ToString();
                else
                    dietFil = "";

                DietClick1 %= 2;                   // click = 0



            }
            catch (Exception) { MessageBox.Show("invalid Diet filter selection"); }


        }

        int Cus_Click1 = 0;
        public void Cusine_Click(object sender, RoutedEventArgs e)
        {
            rbList.Add(sender);

            RadioButton radioButton = (RadioButton)sender;

            try
            {
                Cus_Click1++;

                radioButton.IsChecked = Cus_Click1 % 2 == 1;    // click = 1

                if (radioButton.IsChecked == true)
                    cuisineFil = radioButton.Content.ToString();
                else
                    cuisineFil = "";

                Cus_Click1 %= 2;                   // click = 0



            }
            catch (Exception) { MessageBox.Show("invalid Diet filter selection"); }
        }

        public void minDuration_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            minduration = MinDuration.Value;



        }
        public void maxDuration_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            maxduration = MaxDuration.Value;
        }

        public void clear_click(object sender, RoutedEventArgs e)
        {


            foreach (Object s in rbList)
            {
                RadioButton radioButton = (RadioButton)s;
                radioButton.IsChecked = false;
            }

            dietFil = "";
            MealFil = "";
            DiffLevelFil = "";
            cuisineFil = "";
            MinDuration.Value = 5;
            MaxDuration.Value = 120;

            click = 0;
            dLclick1 = 0;
            DietClick1 = 0;
            Cus_Click1 = 0;

            rbList.Clear();




        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {


        }
    }
}
