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
        private int currentLevel;
        private int numberOfLevels;



        //Properties
        public int CurrentLevel
        {
            get
            {
                return currentLevel;
            }
            private set
            {
                currentLevel = value;
            }
        }

        public int NumberOfLevels
        {
            get
            {
                return numberOfLevels;
            }

        }

        public bool DoorIsOpen
        {
            get
            {
                return isDoorOpen;
            }
            private set
            {
                isDoorOpen = value;
            }
        }

        //Constructors
        public Elevator(int numberOfLevels)
        {
            /* elevator starts on floor one
             * number of levels is an arguement for how many floors the elevator services
             */
            this.numberOfLevels = numberOfLevels;
            currentLevel = 1;
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
            if (isDoorOpen == false && currentLevel < numberOfLevels)
            {
                currentLevel += (desiredFloor - currentLevel);
            }
        }

        public void GoDown(int desiredFloor)
        {
            if (isDoorOpen == false  && desiredFloor > 0 && (numberOfLevels - desiredFloor)>= 1)
            {
                CurrentLevel -= (currentLevel - desiredFloor);
            }
        }

    }

}
