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

namespace RestaurantBillCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Beverage> beverages = new List<Beverage>();
        public MainWindow()
        {
            InitializeComponent();

            beverages.Add(new Beverage("Beverage", "Soda", 1.95m));
            beverages.Add(new Beverage("Beverage", "Tea", 1.50m));
            beverages.Add(new Beverage("Beverage", "Coffee", 1.25m));
            beverages.Add(new Beverage("Beverage", "Mineral Water", 2.95m));
            beverages.Add(new Beverage("Beverage", "Juice", 2.50m));
            beverages.Add(new Beverage("Beverage", "Milk", 1.50m));

            beverageComboBox.ItemsSource = beverages;

        }
        
    }

 

}
