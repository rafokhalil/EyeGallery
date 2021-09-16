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

namespace IGalery
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Page
    {
        //public MainWindow main=new MainWindow();
        public int selectedIndex{ get; set; }
        public Info()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            
        }

      

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            MainWindow main = new MainWindow();         
            var nextIndex = selectedIndex + 1;
            selectedIndex = nextIndex;
            var nextItem = main.ListBox.Items[nextIndex] as Image;
            TxtBlck.Text = nextItem.Detals + " " + nextItem.PublishDate.ToShortDateString();
            ImagePage.Source = new BitmapImage(new Uri(nextItem.ImagePath, UriKind.Relative));

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }


        }
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            try{ 
            MainWindow main = new MainWindow();
            var nextIndex = selectedIndex - 1;
            selectedIndex = nextIndex;
            var nextItem = main.ListBox.Items[nextIndex] as Image;
            TxtBlck.Text = nextItem.Detals + " " + nextItem.PublishDate.ToShortDateString();
            ImagePage.Source = new BitmapImage(new Uri(nextItem.ImagePath, UriKind.Relative));
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }


        }
    }
}
