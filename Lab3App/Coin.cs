using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure, Displayable
    {
        private int value;
        public Coin(string desc, int score, int value) : base(desc, score)
        {
            this.value = value;
        }

        public void updateTotalValue()
        {
            base.Board.TotalValue += value;
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            updateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }


}


