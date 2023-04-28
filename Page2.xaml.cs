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
using Path = System.IO.Path;

namespace Calendary
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        List<UserControlEat> eating = new List<UserControlEat>();
        public Page2()
        {
            InitializeComponent();
            string path = Path.GetFullPath(@"..\..\..\");
            path = path + "Calendary\\Debug\\";

            UserControlEat chicken = new UserControlEat();
            chicken.checkEmoji.Content = "Курица";
            chicken.EatIcon.Source = new BitmapImage(new Uri(path + "142-1422264_pavo-de-accion-de-gracias-icon-turkey-icon.png"));
            
            UserControlEat soup = new UserControlEat();
            soup.checkEmoji.Content = "Суп";
            soup.EatIcon.Source = new BitmapImage(new Uri(path + "kisspng-tomato-soup-butter-chicken-dish-5ae45cf2d98459.508236841524915442891.jpg"));

            UserControlEat salad = new UserControlEat();
            salad.checkEmoji.Content = "Салат";
            salad.EatIcon.Source = new BitmapImage(new Uri(path + "png-clipart-fast-food-salad-sushi-restaurant-salad-purple-food.png"));

            UserControlEat pizza = new UserControlEat();
            pizza.checkEmoji.Content = "Пицца";
            pizza.EatIcon.Source = new BitmapImage(new Uri(path + "png-clipart-scalable-graphics-computer-icons-encapsulated-postscript-computer-icons-encapsulated-postscript.png"));

            eating.Add(chicken);
            eating.Add(soup);
            eating.Add(salad);
            eating.Add(pizza);
            Eat.ItemsSource = eating;
        }

        private void SaveExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Window.GetWindow(this);
            Page1 pageCalendar = new Page1();
            UserControl userControl = new UserControl();
            userControl.DayBtn.Content = eating[0];
            window.FramePage.Content = pageCalendar;
        }

        private void ToMainPage_Click(object sender, RoutedEventArgs e)
        {
            FramePage.Content = new Page1();
        }

    }
    
}

