using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataPotter
    {

        private int[] uniqueSets = new int[5];
        private int[] books;
        private int totalBooks;
        private decimal totalPrice;

        public int[] Collection
        {
            get
            {
                return uniqueSets;
            }
        }

        public KataPotter(int[] books)
        {
            this.books = books;
            totalBooks = books.Sum();
            uniqueSets = CollectionSort(books);
            totalPrice = totalBooks * 8;
        }

        public int[] CollectionSort(int[] books)
        {
            //int Q = 0;

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
               // Q++;
                uniqueSets[X - 1]++;
            }

            int reorder = Math.Min(uniqueSets[2], uniqueSets[4]);
            if (reorder != 0)
            {
                uniqueSets[2] -= reorder;
                uniqueSets[4] -= reorder;
                uniqueSets[3] += reorder * 2;
            }

            return uniqueSets;
        }

        public decimal GetCost()
        {
            totalPrice -= uniqueSets[1] * 0.95M * 8;
            totalPrice -= uniqueSets[2] * 0.90M * 8;
            totalPrice -= uniqueSets[3] * 0.80M * 8;
            totalPrice -= uniqueSets[4] * 0.75M * 8;
            return totalPrice;
        }

    }
}
