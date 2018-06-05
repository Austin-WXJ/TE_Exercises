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
        private int startingPiecesOfFruit = 0;
        private int numberOfPiecesToRemove;
        public int piecesOfFruitLeft = 0;
        private bool pickFruit = true;

        //Constructors
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            PiecesOfFruitLeft = startingPiecesOfFruit;
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

        public int PiecesOfFruitLeft
        {
            get
            {
                return piecesOfFruitLeft;
            }
            private set
            {
                piecesOfFruitLeft = value;
            }
        }

        //Methods
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (piecesOfFruitLeft == 0)
            {
                pickFruit = false;
            }

            else if (numberOfPiecesToRemove > 0)
            {
                piecesOfFruitLeft -= numberOfPiecesToRemove;

            }
            return pickFruit;
        }
    }
}
