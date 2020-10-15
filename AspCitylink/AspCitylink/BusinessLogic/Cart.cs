using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspCitylink.Domains;

namespace AspCitylink.BusinessLogic
{
    public class Cart
    {
        public int Count => Records.Sum(r => r.Quantity);

        public List<CartRecord> Records { get; set; }

        public int TotalCost => Records.Sum(r => r.Cost);

        public Cart()
        {
            Records = new List<CartRecord>();
        }

        public void Add(Product product, int count = 1)
        {
            var existingRecord = Records
                .FirstOrDefault(r => r.Product.ProductId == product.ProductId);

            if (existingRecord == null)
            {
                var record = new CartRecord()
                {
                    Product = product,
                    Quantity = count
                };
                Records.Add(record);
            }
            else
            {
                existingRecord.Quantity += count;

                if (existingRecord.Quantity <= 0)
                {
                    Records.Remove(existingRecord);
                }
            }
        }
    }

    public class CartRecord
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public int Cost => Product.Price * Quantity;
    }
}