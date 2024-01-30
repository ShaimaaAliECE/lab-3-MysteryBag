using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        private String description;

        public String Description
        {
            get { return description; }
            set { description = value; }
        }


        public CollectionBoard Board;

        public Collectable(String desc)
        {
            this.description = desc;
        }

        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine(description + " Collected, Congrats!!!!");

        }

        public virtual void Display()
        {
           
        }
    }
}
