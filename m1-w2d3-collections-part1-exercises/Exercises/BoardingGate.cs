using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given a list of Integers representing seat numbers, group them into ranges 1-10, 11-20, and 21-30.
         (Any seat number less than 1, or greater than 30 is invalid, and can be ignored.) Preserve the order
         in which the seat number entered their associated group. Return a list of the grouped Integers 1-10,
         11-20, and 21-30. (Hint: Think multiple queues)
         DIFFICULTY: HARD
		 boardingGate( [1, 13, 43, 22, 8, 11, 30, 2, 4, 14, 21] ) -> [1, 8, 2, 4, 13, 11, 14, 22, 30, 21]
         boardingGate( [29, 19, 9, 21, 11, 1, 0, 25, 15, 5, 31] ) -> [9, 1, 5, 19, 11, 15, 29, 21, 25]
         boardingGate( [0, -1, 44, 31, 17, 7, 27, 16, 26, 6] ) -> [7, 6, 17, 16, 27, 26]
         */
        public List<int> BoardingGate(List<int> seatNumberList)
        {
            List<int> seatOrder = new List<int>();
            Queue<int> temp1To10 = new Queue<int>();
            Queue<int> temp11To20 = new Queue<int>();
            Queue<int> temp21To30 = new Queue<int>();

            foreach (int seat in seatNumberList)
            {  if (seat >= 1 && seat <= 10)//seats 1-10
                { temp1To10.Enqueue(seat);
                }
                else if (seat > 10 && seat <= 20)//seats 11-20
                { temp11To20.Enqueue(seat);
                }
                else if (seat >= 21 && seat <= 30)//seats 21-30
                { temp21To30.Enqueue(seat);
                }
                //seatOrder.AddRange(temp1To10.Dequeue);
            }

            while (temp1To10.Count != 0)
            { seatOrder.Add(temp1To10.Dequeue());
            }
            while (temp11To20.Count != 0)
            { seatOrder.Add(temp11To20.Dequeue());
            }
            while (temp21To30.Count != 0)
            { seatOrder.Add(temp21To30.Dequeue());
            }


            return seatOrder;
        }
    }
}
