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
        public decimal totalPriceAfterTaxes;

        //These take the selected combo-box value.
        Beverage beveragePlaceHolder = new Beverage();
        Appetizer appetizerPlaceHolder = new Appetizer();
        MainCourse maincoursePlaceHolder = new MainCourse();
        Dessert dessertPlaceHolder = new Dessert();

        Beverage beverageNone = new Beverage("Beverage", "None", 0m);
        Appetizer appetizerNone = new Appetizer("Appetizer", "None", 0m);
        MainCourse maincourseNone = new MainCourse("Main Course", "None", 0m);
        Dessert dessertNone = new Dessert("Dessert", "None", 0m);

        public MainWindow()
        {
            InitializeComponent();

            beverages.Add(beverageNone);
            beverages.Add(new Beverage("Beverage", "Soda", 1.95m));
            beverages.Add(new Beverage("Beverage", "Tea", 1.50m));
            beverages.Add(new Beverage("Beverage", "Coffee", 1.25m));
            beverages.Add(new Beverage("Beverage", "Mineral Water", 2.95m));
            beverages.Add(new Beverage("Beverage", "Juice", 2.50m));
            beverages.Add(new Beverage("Beverage", "Milk", 1.50m));

            appetizers.Add(appetizerNone);
            appetizers.Add(new Appetizer("Appetizer", "Buffalo Wings", 5.95m));
            appetizers.Add(new Appetizer("Appetizer", "Buffalo Fingers", 6.95m));
            appetizers.Add(new Appetizer("Appetizer", "Potato Skins", 8.95m));
            appetizers.Add(new Appetizer("Appetizer", "Nachos", 8.95m));
            appetizers.Add(new Appetizer("Appetizer", "Mushroom Caps", 10.95m));
            appetizers.Add(new Appetizer("Appetizer", "Shrimp Cocktail", 12.95m));
            appetizers.Add(new Appetizer("Appetizer", "Chips and Salsa", 6.95m));

            mainCourses.Add(maincourseNone);
            mainCourses.Add(new MainCourse("Main Course", "Seafood Alfredo", 15.95m));
            mainCourses.Add(new MainCourse("Main Course", "Chicken Alfredo", 13.95m));
            mainCourses.Add(new MainCourse("Main Course", "Chicken Picatta", 13.95m));
            mainCourses.Add(new MainCourse("Main Course", "Turkey Club", 11.95m));
            mainCourses.Add(new MainCourse("Main Course", "Lobster Pie", 19.95m));
            mainCourses.Add(new MainCourse("Main Course", "Prime Rib", 20.95m));
            mainCourses.Add(new MainCourse("Main Course", "Shrimp Scampi", 18.95m));
            mainCourses.Add(new MainCourse("Main Course", "Turkey Dinner", 13.95m));
            mainCourses.Add(new MainCourse("Main Course", "Stuffed Chicken", 14.95m));

            desserts.Add(dessertNone);
            desserts.Add(new Dessert("Dessert", "Apple Pie", 5.95m));
            desserts.Add(new Dessert("Dessert", "Sundae", 3.95m));
            desserts.Add(new Dessert("Dessert", "Carrot Cake", 5.95m));
            desserts.Add(new Dessert("Dessert", "Mud Pie", 4.95m));
            desserts.Add(new Dessert("Dessert", "Apple Crisp", 5.95m));

            beverageComboBox.ItemsSource = beverages;
            appetizerComboBox.ItemsSource = appetizers;
            mainCourseComboBox.ItemsSource = mainCourses;
            dessertComboBox.ItemsSource = desserts;

            beverageComboBox.SelectedItem = beverageNone;
            appetizerComboBox.SelectedItem = appetizerNone;
            mainCourseComboBox.SelectedItem = maincourseNone;
            dessertComboBox.SelectedItem = dessertNone;
           
        }

        private void beverageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void priceButton_Click(object sender, RoutedEventArgs e)
        {
            beveragePlaceHolder = (Beverage)beverageComboBox.SelectedItem;
            appetizerPlaceHolder = (Appetizer)appetizerComboBox.SelectedItem;
            maincoursePlaceHolder = (MainCourse)mainCourseComboBox.SelectedItem;
            dessertPlaceHolder = (Dessert)dessertComboBox.SelectedItem;

            totalPrice =
                this.beveragePlaceHolder.Price +
                this.appetizerPlaceHolder.Price +
                this.maincoursePlaceHolder.Price +
                this.dessertPlaceHolder.Price;
           

            totalPriceText.Text = totalPrice.ToString();

            totalPriceAfterTaxes = totalPrice + (totalPrice * .0565m);
            totalPriceAfterTaxesText.Text = totalPriceAfterTaxes.ToString();
                      
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            totalPrice = 0;
            totalPriceText.Text = totalPrice.ToString();
            totalPriceAfterTaxes = 0;
            totalPriceAfterTaxesText.Text = totalPriceAfterTaxes.ToString();
            beverageComboBox.SelectedItem = beverageNone;
            appetizerComboBox.SelectedItem = appetizerNone;
            mainCourseComboBox.SelectedItem = maincourseNone;
            dessertComboBox.SelectedItem = dessertNone;

        }
    }

 

}
