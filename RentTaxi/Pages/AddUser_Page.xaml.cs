using RentTaxi.AdminModule;
using RentTaxi.LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace RentTaxi.Pages
{
    /// <summary>
    /// Interaction logic for AddUser_Page.xaml
    /// </summary>
    public partial class AddUser_Page : Page
    {
        Random rand = new Random();
        public AddUser_Page()
        {
            InitializeComponent();
        }

        private void btAddUser_Click(object sender, RoutedEventArgs e)
        {
            ServicesXML sx = new ServicesXML();
            string temp = "";
            
            TBL_User tuser = new TBL_User();
            tuser.UserId = rand.Next(1000,9999);
            tuser.UserName = string.Format("{0}{1}", tbSoname.Text, tbName.Text.Substring(0, 1));
            tuser.Password = rand.Next().ToString();
            tuser.DOB =(DateTime)tbDOB.SelectedDate;
            tuser.Gender = (Gender)(lbGender.SelectedIndex);

           if(!sx.AddUser(tuser, out temp))
            {
                ErrorMessage.Foreground = new SolidColorBrush(Colors.Red);
                ErrorMessage.Content = temp;
            } else
            {
                ErrorMessage.Foreground = new SolidColorBrush(Colors.Green);
                ErrorMessage.Content = temp;
                Thread.Sleep(3000);
               // adminWindow aw = new adminWindow();
                adminWindow.mf.Source = new Uri("Pages/ListUsersPage.xaml", UriKind.RelativeOrAbsolute); 

            }


        }
    }
}
