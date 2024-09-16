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

        public int Count { get; private set; } = 0;

        public void Add(string name)
        {
            Product newPurchase = new Product(name);
            if (head == null)
            {
                head = newPurchase;
                Count++;
            }
            else
            {
                Product current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newPurchase;
                Count++;
            }
        }    

        public IEnumerator<Product> GetEnumerator()
        {
            Product current = head;
            while (current.Next != null)
            {
                yield return current;
                current = current.Next;
            }
            yield return current;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}