﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
            Beverage soda = new Beverage("Beverage", "Soda", 1.95m);
            Beverage[] beverages = new Beverage[]
            {
                new Beverage("Beverage", "Soda", 1.95m)

            };

        }
        
    }

    public class Beverage
    {
        private string Category { get; set; }
        private string Name { get; set; }
        private decimal Price { get; set; }

        public Beverage (string category, string name, decimal price)
        {
            Category = category;
            Name = name;
            Price = price;
        }

        public string GetNameAndPrice()
        {
            return $"{Name}   ${Price}";
        }

        public string GetCategory ()
        {
            return Category;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price;
        }

    }

}
