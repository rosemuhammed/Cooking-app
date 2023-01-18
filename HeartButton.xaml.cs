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
    /// Interaction logic for HeartButton.xaml
    /// </summary>
    public partial class HeartButton : UserControl
    {
        public HeartButton()
        {
            InitializeComponent();
        }

        private void heart_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/MisoRamen.jpg", UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);

            SavedRecipesPage page = SavedRecipesPage.instance;

            page.addSavedRecipe("Miso Ramen", "30 MIN", "EASY", "3.0", imgSource);

            //MainWindow.NavigateToPage(page);

        }
    }
}
