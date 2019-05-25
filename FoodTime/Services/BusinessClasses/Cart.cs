﻿using Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.BusinessClasses
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public List<CartLine> Lines { get; set; }
        public void AddItem(FoodDto food, int quantity, string userID)
        {

            CartLine line = lineCollection.Where(f => f.Food.Id == food.Id).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine { Food = food, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(FoodDto food)
        {
            lineCollection.RemoveAll(f => f.Food.Id == food.Id);
        }
        public double ComputeTotalValue()
        {
            return Lines.Sum(f => f.Food.Price * f.Quantity);
        }
        public void Clear()
        {
            lineCollection.Clear();
        }



    }
    public class CartLine
    {
        public FoodDto Food { get; set; }
        public int Quantity { get; set; }
    }

}
