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
        public List<Appetizer> appetizers = new List<Appetizer>();
        public List<MainCourse> mainCourses = new List<MainCourse>();
        public List<Dessert> desserts = new List<Dessert>();
        public decimal totalPrice;
        public MainWindow()
        {
            InitializeComponent();

            beverages.Add(new Beverage("Beverage", "Soda", 1.95m));
            beverages.Add(new Beverage("Beverage", "Tea", 1.50m));
            beverages.Add(new Beverage("Beverage", "Coffee", 1.25m));
            beverages.Add(new Beverage("Beverage", "Mineral Water", 2.95m));
            beverages.Add(new Beverage("Beverage", "Juice", 2.50m));
            beverages.Add(new Beverage("Beverage", "Milk", 1.50m));

            appetizers.Add(new Appetizer("Appetizer", "Buffalo Wings", 5.95m));
            appetizers.Add(new Appetizer("Appetizer", "Buffalo Fingers", 6.95m));
            appetizers.Add(new Appetizer("Appetizer", "Potato Skins", 8.95m));
            appetizers.Add(new Appetizer("Appetizer", "Nachos", 8.95m));
            appetizers.Add(new Appetizer("Appetizer", "Mushroom Caps", 10.95m));
            appetizers.Add(new Appetizer("Appetizer", "Shrimp Cocktail", 12.95m));
            appetizers.Add(new Appetizer("Appetizer", "Chips and Salsa", 6.95m));

            mainCourses.Add(new MainCourse("Main Course", "Seafood Alfredo", 15.95m));
            mainCourses.Add(new MainCourse("Main Course", "Chicken Alfredo", 13.95m));
            mainCourses.Add(new MainCourse("Main Course", "Chicken Picatta", 13.95m));
            mainCourses.Add(new MainCourse("Main Course", "Turkey Club", 11.95m));
            mainCourses.Add(new MainCourse("Main Course", "Lobster Pie", 19.95m));
            mainCourses.Add(new MainCourse("Main Course", "Prime Rib", 20.95m));
            mainCourses.Add(new MainCourse("Main Course", "Shrimp Scampi", 18.95m));
            mainCourses.Add(new MainCourse("Main Course", "Turkey Dinner", 13.95m));
            mainCourses.Add(new MainCourse("Main Course", "Stuffed Chicken", 14.95m));

            desserts.Add(new Dessert("Dessert", "Apple Pie", 5.95m));
            desserts.Add(new Dessert("Dessert", "Sundae", 3.95m));
            desserts.Add(new Dessert("Dessert", "Carrot Cake", 5.95m));
            desserts.Add(new Dessert("Dessert", "Mud Pie", 4.95m));
            desserts.Add(new Dessert("Dessert", "Apple Crisp", 5.95m));



            beverageComboBox.ItemsSource = beverages;
            appetizerComboBox.ItemsSource = appetizers;
            mainCourseComboBox.ItemsSource = mainCourses;
            dessertComboBox.ItemsSource = desserts;
        }

        private void beverageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void priceButton_Click(object sender, RoutedEventArgs e)
        {
            beverageComboBox.SelectedItem
        }
    }

 

}
