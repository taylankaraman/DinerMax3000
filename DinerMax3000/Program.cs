﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Program
    {       

        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";            
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with butter", 25.50);
            summerMenu.AddMenuItem("Taco", "Mexican miracle", 10.00);
            summerMenu.HospitalDirections = "45 Albert Street";

            DrinksMenu outsideDrinks = new DrinksMenu();
            outsideDrinks.Name = "Outside Drinks";
            outsideDrinks.Disclaimer = "Do not drink and code";
            outsideDrinks.AddMenuItem("Cuba Libre", "Something light", 10.00);
            outsideDrinks.AddMenuItem("Belvedere", "Fancy Vodka", 50.00);

            Order hungryGuestOrder = new Order();

            for(int x = 0; x < summerMenu.items.Count(); x++)
            {
                hungryGuestOrder.AddToOrder(summerMenu.items[x]);                
            }

            foreach(MenuItem item in outsideDrinks.items)
            {
                hungryGuestOrder.AddToOrder(item);
            }

            Console.WriteLine("Order total:{0}", hungryGuestOrder.Total);

            try
            {
                outsideDrinks.AddMenuItem("Beer", "Helping ugly people have sex since 1950", 0);
            }
            catch(Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }
            
        }


    }
}