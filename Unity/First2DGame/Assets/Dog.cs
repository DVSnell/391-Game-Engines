using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class Dog
    {
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dog(string name)
        {
            this.name = name;
        }

        //public Ask(string questions)
        //{
        //    this.questions = questions;
        //}


        //public string getName()
        //{
        //    return name;
        //}
    }
}
