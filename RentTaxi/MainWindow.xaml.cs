using RentTaxi.LIB;
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

namespace RentTaxi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          //  BaseGrid.Background = new ImageSource();
        }

        private void btnLogOn_Click(object sender, RoutedEventArgs e)
        {
            ServicesXML service = new ServicesXML("users.xml");
            if(service.GetUser(txblogin.Text, txbpassword.Password))
            {
                adminWindow aw = new adminWindow();
                aw.Show();
                this.Close();
            }


        }
    }
}
