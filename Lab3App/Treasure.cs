using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        private int score;

        public Treasure(string desc, int score) : base(desc)
        {

            this.score = score;
        }

        public void updateTotalScore()
        {
            base.Board.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + base.Board.TotalScore);

        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            updateTotalScore();
        }
    }
}
