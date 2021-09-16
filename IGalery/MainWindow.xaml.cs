using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Index { get; set; }
        public ObservableCollection<Image> Images { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Images = new ObservableCollection<Image> {
        new Image{
            Name="Biden is hiding",
            Price=1000,

            PublishDate=new DateTime(2019,8,10),
             ImagePath="Images/BidenIsHiding.jpg",
             Detals="Biden is hiding form Puting"
        },
          new Image{
            Name="Mans is flying",
            Price=1000,
              PublishDate=new DateTime(1965,8,20),
             ImagePath="Images/BraveInHeart.jpg",
             Detals="OMG mans is flying"
        },
          new Image{
            Name="Desert mission",
            Price=1000,PublishDate=new DateTime(2018,11,15),
             ImagePath="Images/DesertMission.jpg",
             Detals="They are trying to find terorists"
        },
          new Image{
            Name="Earth explotion",
            Price=1000,PublishDate=new DateTime(1958,8,18),
             ImagePath="Images/EarthExplotion.jpg",
             Detals="Atom bomb on ocean"
        },
          new Image{
            Name="Fire in piru",
            Price=1000,PublishDate=new DateTime(2019,8,16),
             ImagePath="Images/FireInPiru.jpg",
             Detals="Died a lot of people"
        },
          new Image{
            Name="Man who is trying to go work",
            Price=1000,PublishDate=new DateTime(2015,5,15),
             ImagePath="Images/GoingTOWork.jpg",
             Detals="Be hurry"
        },
          new Image{
            Name="Woman is trying to survive",
            Price=1000,PublishDate=new DateTime(2019,4,14),
             ImagePath="Images/WomanFallingFromFire.jpg",
             Detals="Very sad"
        },
          new Image{
            Name="Human's violence",
            Price=1000,PublishDate=new DateTime(2002,2,23),
             ImagePath="Images/HumansViolence.jpg",
             Detals="This image is another Pulitzer Prize-winning image. As famous for its social impact, as it is the ethical issues it raised."
        },

        };

            ListBox.ItemsSource = Images;


        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Info info = new Info();

            BigPicture.Visibility = Visibility.Visible;
            BigPicture.Navigate(info);
            var item = ListBox.SelectedItem as Image;
            info.TxtBlck.Text = item.Detals;
            info.selectedIndex = Images.IndexOf(item);

            info.ImagePage.Source = new BitmapImage(new Uri(item.ImagePath, UriKind.Relative));
            



        }
    }
}
