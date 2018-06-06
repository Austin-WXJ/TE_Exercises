using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        //Variables
        private bool isDoorOpen;
        

        //Properties
        //public int CurrentLevel
        //{
        //    get
        //    {

        //    }
        //    private set
        //    {

            //}
        //}

        //public int NumberOfLevels
        //{
        //    get
        //    {

        //    }

        //}

        //public bool DoorIsOpen
        //{
        //    get
        //    {

        //    }
        //    private set
        //    {

        //    }
        //}

        //Constructors
        public Elevator (int numberOfLevels)
        {

        }

        //Methods
        public void OpenDoor()
        {
            isDoorOpen = true;
        }

        public void CloseDoor()
        {
            isDoorOpen = false;
        }

        public void GoUp(int desiredFloor)
        {

        }

        public void GoDown(int desiredFloor)
        {

        }

    }

}
