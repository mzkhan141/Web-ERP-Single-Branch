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
using System.Windows.Forms.Integration;
using Zaid;

namespace Web_ERP_Single_Branch
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private readonly Login login = new Login();

        public Page1()
        {
            InitializeComponent();
            WindowsFormsHost wfh = new WindowsFormsHost();
            stkPnl.Width = 1000;
            stkPnl.Height = 700;
            wfh.Width = 1000;
            wfh.Height = 700;
            login.TopLevel = false;
            wfh.Child = login;
            stkPnl.Children.Add(wfh);
        }
    }
}
