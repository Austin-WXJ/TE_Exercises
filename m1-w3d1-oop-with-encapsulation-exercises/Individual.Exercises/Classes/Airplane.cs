using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        //Variables
        private string planeNumber;
        private int bookedFirstClassSeats = 0;
        private int totalFirstClassSeats;
        private int bookedCoachSeats;
        private int availableCoachSeats;
        private int totalCoachSeats;

        //Properties
        public string PlaneNumber
        {
            get
            {
                return planeNumber;
            }
        }

        public int BookedFirstClassSeats
        {
            get
            {
                return bookedFirstClassSeats;
            }
            private set
            {
                bookedFirstClassSeats = value;
            }

        }

        public int AvailableFirstClassSeats
        {
            get
            {
                return totalFirstClassSeats - bookedFirstClassSeats;
            }
        }

        public int TotalFirstClassSeats
        {
            get
            {
                return totalFirstClassSeats;
            }
            //private set
            //{
            //    totalFirstClassSeats = value;
            //}
        }

        public int BookedCoachSeats
        {
            get
            {
                return bookedCoachSeats;
            }
            private set
            {
                bookedCoachSeats = value;
            }

        }

        public int AvailableCoachSeats
        {
            get
            {
                return availableCoachSeats = totalCoachSeats - bookedCoachSeats;
            }
        }

        public int TotalCoachSeats
        {
            get
            {
                return totalCoachSeats;
            }

        }

        //Constructors
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;
        }

        //Methods
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool canReserve = false;
            if (forFirstClass == true && AvailableFirstClassSeats > totalNumberOfSeats)
            {
                bookedFirstClassSeats += totalNumberOfSeats;
                canReserve = true;
            }
            else if (AvailableCoachSeats > totalNumberOfSeats)
            {
                bookedCoachSeats += totalNumberOfSeats;
                canReserve = true;
            }
            return canReserve;
        }
    }
}
