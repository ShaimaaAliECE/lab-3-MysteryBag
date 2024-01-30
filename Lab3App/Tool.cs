using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {
        public Tool(string desc) : base(desc)
        {
        }
         public virtual void DoAction()
         {

         }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            DoAction();
        }
    }
}
