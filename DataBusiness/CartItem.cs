using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness
{
    public class CartItem
    {
        private string productId;
        private int quantity;
        
        public CartItem(string productId, int quantity)
        {
            this.ProductId = productId;
            this.Quantity = quantity;
        }

        public string ProductId { get => productId; set => productId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
