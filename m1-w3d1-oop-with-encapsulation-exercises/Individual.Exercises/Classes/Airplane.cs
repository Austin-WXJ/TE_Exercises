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
        private int bookedFirstClassSeats;
        private int availableFirstClassSeats;
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

        }

        public int AvailableFirstClassSeats
        {
            get
            {
                return availableFirstClassSeats = totalFirstClassSeats - bookedFirstClassSeats;
            }
        }

        public int TotalFirstClassSeats
        {
            get
            {
                return totalFirstClassSeats;
            }
            private set
            {
                totalFirstClassSeats = value;
            }
        }

        public int BookedCoachSeats
        {
            get
            {
                return bookedCoachSeats;
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
            private set
            {
                totalCoachSeats = value;
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
        public void ReservedSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass == true)
            {
                bookedFirstClassSeats += totalNumberOfSeats;
            }
            else
            {
                bookedCoachSeats += totalNumberOfSeats;
            }
        }
    }
}
