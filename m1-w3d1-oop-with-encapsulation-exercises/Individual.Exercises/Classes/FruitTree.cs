using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        //Variables
        public string typeOfFruit = "";
        //private int startingPiecesOfFruit = 0;
        //private int numberOfPiecesToRemove;
        public int piecesOfFruitLeft = 0;
        private bool pickFruit = false;

        //Constructors
        public FruitTree(int startingPiecesOfFruit, string typeOfFruit)
        {
            this.startingPiecesOfFruit = startingPiecesOfFruit;
            this.typeOfFruit = typeOfFruit;
        }


        //Properties
        public string TypeOfFruit
        {
            get
            {
                return typeOfFruit;
            }

        }
        public int startingPiecesOfFruit
        {
            get
            {
                return startingPiecesOfFruit;
            }
            set
            {
                //startingPiecesOfFruit = value;
                piecesOfFruitLeft = value;
            }

        }


        private int PiecesOfFruitLeft
        {
            get
            {
                return piecesOfFruitLeft;
            }
            set
            {
                if (pickFruit == true)
                {
                    piecesOfFruitLeft--;
                }
                piecesOfFruitLeft = value;
            }
        }

        //Methods
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (piecesOfFruitLeft == 0 || numberOfPiecesToRemove > 0)
            {
                pickFruit = true;
            }
            return pickFruit;
        }
    }
}
