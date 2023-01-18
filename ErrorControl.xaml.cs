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
    /// Interaction logic for ErrorControl.xaml
    /// </summary>
    public partial class ErrorControl : UserControl
    {

        private string errMsg;
        public string ErrorMsg
        {
            get { return errMsg; }
            set
            {
                errMsg = value;
                this.errorMsg.Text = this.errMsg;
            }

        }

        public ErrorControl()
        {
            InitializeComponent();
        }
    }
}
