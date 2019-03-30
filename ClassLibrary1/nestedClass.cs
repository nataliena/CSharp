using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class NestedClass
    {



        private List<OrderLine> _orderLines = new List<OrderLine>();
      
        
        
        
        public double TotalPrice() /*vkupna cena za cela lista*/
        {
            double total=0;
            foreach (var item in _orderLines)
            {
                total += item.OrderLineTotal();

            }  return total;

            
        }

        public void AddNewItem (string product, int quantity,double price)/*dodava novi proizvodi vo listata*/
        {
            OrderLine line = new OrderLine();
            line.Product = product;
            line.Quantity = quantity;
            line.Price = price;
            _orderLines.Add(line);
        }

        private class OrderLine  /* mi vraka eden proizvod so cenata*/
        {
            public string Product { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }

            public double OrderLineTotal()
            {
                return Quantity * Price;
            }
        }

    }
}
