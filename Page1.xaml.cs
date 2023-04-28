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

namespace Calendary
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public DateTime time;
        public static string date;
        public int month, year;      
        public Page1()
        {
            InitializeComponent();
            time = DateTime.Now;
            Refresh_data();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            time = time.AddMonths(-1);
            Refresh_data();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            time = time.AddMonths(1);
            Refresh_data();
        }

        private void Refresh_data()
        {
            Data.SelectedDate = time;
            date = time.ToString("d MMMMMM");
            textData.Text = date;

            DayPanel.Children.Clear();
            int daysCount = DateTime.DaysInMonth(((DateTime)Data.SelectedDate).Year, ((DateTime)Data.SelectedDate).Month);
            for (int i = 1; i <= daysCount; i++)
            {
                UserControl day = new UserControl();
                day.Width = 70;
                day.Height = 70;
                day.DayBtn.Click += DayButton;
                day.daytext.Text = i.ToString();
                day.DayBtn.Name = "daybtn" + i.ToString();
                DayPanel.Children.Add(day);
            }
        }

        private void dataSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Data.SelectedDate != null)
            {
                time = Data.SelectedDate.Value;
                Refresh_data();
            }
        }

        private void DayButton(object sender, RoutedEventArgs e)
        {
            var emotionsDataPage = new UserControlEat();
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.FramePage.Content = emotionsDataPage;
            }
        }
    }
}
