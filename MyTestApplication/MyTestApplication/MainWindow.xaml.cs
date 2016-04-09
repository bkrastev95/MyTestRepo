using MyTestApplication.Models;
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

namespace MyTestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new MyContext())
            {
                var car = new Car { BrandId = 1, CarTypeId = 1, ColorId = 2, RegNumber = "test" };
                ctx.Cars.Add(car);
                ctx.SaveChanges();

                var numbers = from c in ctx.Cars select c.RegNumber;
                myButton.Content = numbers.FirstOrDefault<string>();
            }
        }
    }
}
