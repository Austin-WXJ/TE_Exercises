using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {

        private int[] collection = new int[5];
        private int[] books;
        private int totalBooks;
        private decimal totalPrice;

        public int[] Collection
        {
            get
            {
                return collection;
            }
        }

        public KataPotter(int[] books)
        {
            this.books = books;
            totalBooks = books.Sum();
            collection = CollectionSort(books);
            totalPrice = totalBooks * 8;
        }

        public int[] CollectionSort(int[] books)
        {
            int Q = 0;

            while (books.Sum() != 0)
            {
                int X = 0;

                for (int i = 0; i < books.Length; ++i)
                {
                    if (books[i] != 0)
                    {
                        books[i]--;
                        X++;
                    }

                }
                Q++;
                collection[X - 1]++;
            }

            int reorder = Math.Min(collection[2], collection[4]);
            if (reorder != 0)
            {
                collection[2] -= reorder;
                collection[4] -= reorder;
                collection[3] += reorder * 2;
            }

            return collection;
        }

        public decimal GetCost()
        {
            decimal price = 0M;

            price += collection[0] * 8;
            price += collection[1] * .95M * 8;
            price += collection[2] * 0.90M * 8;
            price += collection[3] * 0.80M * 8;
            price += collection[4] * 0.75M * 8;
            totalPrice -= price;

            return totalPrice;
        }

    }
}
