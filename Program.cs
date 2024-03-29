﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Prateek_chadha
{
    public class InventoryItem
    {
        // Properties
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        // Constructor
        public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
        {
            // TODO: Initialize the properties with the values passed to the constructor.

            this.ItemName = itemName;
            this.ItemId = itemId;
            this.Price = price;
            this.QuantityInStock = quantityInStock;
        }

        // Methods

        // Update the price of the item
        public void UpdatePrice(double newPrice)
        {
            // TODO: Update the item's price with the new price.
            this.Price = newPrice;
        }

        // Restock the item
        public void RestockItem(int additionalQuantity)
        {
            // TODO: Increase the item's stock quantity by the additional quantity.
            this.QuantityInStock = this.QuantityInStock + additionalQuantity;
            Console.WriteLine($"Quantity restocked for {ItemName} is {additionalQuantity} and current quantity for {ItemName} in stock is {QuantityInStock}");

        }

        // Sell an item
        public void SellItem(int quantitySold)
        {
            // TODO: Decrease the item's stock quantity by the quantity sold.
            // Make sure the stock doesn't go negative.
            this.QuantityInStock = this.QuantityInStock - quantitySold;
            if (this.QuantityInStock < 0)
            {
                this.QuantityInStock = 0;
            }
            Console.WriteLine($"Quantity sold for {ItemName} is {quantitySold} and available stock for {ItemName} is {QuantityInStock}");
        }

        // Check if an item is in stock
        public bool IsInStock()
        {
            // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
            if (this.QuantityInStock > 0) return true;
            else return false;
        }

        // Print item details
        public void PrintDetails()
        {
            // TODO: Print the details of the item (name, id, price, and stock quantity).
            Console.WriteLine($"Name of the item is {ItemName}\nID of the item is {ItemId} \nPrice of the item is {Price}\nstock avaiable for {ItemName} is {QuantityInStock}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of InventoryItem
            InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
            InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

            // TODO: Implement logic to interact with these objects.
            // Example tasks:
            // 1. Print details of all items.
            item1.PrintDetails();
            item2.PrintDetails();
            // 2. Sell some items and then print the updated details.
            item1.SellItem(5);
            item2.SellItem(12);
            // 3. Restock an item and print the updated details.
            item1.RestockItem(10);
            item2.RestockItem(15);
            // 4. Check if an item is in stock and print a message accordingly.
            if (item1.IsInStock() )
            {
                Console.WriteLine($"{item1.ItemName} is in stock with quantity {item1.QuantityInStock}");
               
            }
            if (item2.IsInStock() )
            {
                Console.WriteLine($"{item2.ItemName} is in stock with quantity {item2.QuantityInStock}");
            }

        }
    }

}

