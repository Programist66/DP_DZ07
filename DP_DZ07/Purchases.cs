using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP07
{
    public class Purchases : IEnumerable<Product>
    {
        private Product head;

        public Purchases()
        {
        }

        public Purchases(Product head)
        {
            this.head = head;
        }

        public void Insert(string name)
        {
            Product newPurchase = new Product(name);
            if (head == null)
            {
                head = newPurchase;
            }
            else
            {
                Product current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newPurchase;
            }
        }
        
        public void Add(string name)        
        {
            Product newPurchase = new Product(name, head);
            head = newPurchase;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            for (Product? product = head; product != null; product = product.Next)
            {
                yield return product;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}