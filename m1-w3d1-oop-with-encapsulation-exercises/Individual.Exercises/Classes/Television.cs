using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        //Variables
        private bool isOn = false;
        private int currentChannel = 3;
        private int currentVolume = 2;
        private int lowestChannel = 3;
        private int highestChannel = 18;
        private int lowestVolume = 0;
        private int maxVolume = 10;


        //Properties
        public bool IsOn
        {
            get
            {
                return isOn;
            }
            private set
            {
                isOn = value;
            }
        }

        public int CurrentChannel
        {
            get
            {
                return currentChannel;
            }
            private set
            {
                currentChannel = value;
            }
        }

        public int CurrentVolume
        {
            get
            {
                return currentVolume;
            }
            private set
            {
                currentVolume = value;
            }
        }



        //Constructors 

        //Methods
        public void TurnOff()
        {
            isOn = false;
        }
        public void TurnOn()
        {
            isOn = true;
            currentChannel = 3;
            currentVolume = 2;

        }
        public void ChangeChannel(int newChannel)
        {
            if (isOn == true && newChannel >= lowestChannel && newChannel <= highestChannel)
            {
                currentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (isOn == true && currentChannel != highestChannel)
            {
                currentChannel++;
            }
            else if (isOn == true && currentChannel == 18)
            {
                currentChannel = 3;
            }
        }
        public void ChannelDown()
        {
            if (isOn == true && currentChannel != lowestChannel)
            {
                currentChannel--;
            }
            else if (isOn == true && currentChannel ==3)
            {
                currentChannel = 18;
            }
        }
        public void RaiseVolume()
        {
            if (isOn == true && currentVolume < maxVolume)
            {
                currentVolume++;
            }
        }
        public void LowerVolume()
        {
            if (isOn == true && currentVolume > lowestVolume)
            {
                currentVolume--;
            }
        }
    }
}
