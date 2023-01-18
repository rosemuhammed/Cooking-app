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
    /// Interaction logic for FilterButton.xaml
    /// </summary>
    public partial class FilterButton : UserControl
    {
        private string filterText;
        public string FilterText
        {
            get { return filterText; }
            set
            {
                filterText = value;
                this.filterButton.Content = this.filterText;
            }

        }

        public void btnFilter_Clicked(object sender, RoutedEventArgs e)
        {
            FilterPage page = new FilterPage();

            (this.Parent as Panel).Children.Remove(this);
        }

        public FilterButton()
        {
            InitializeComponent();
        }
    }
}