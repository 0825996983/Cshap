using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hocC_
{
    abstract class people
    {
        public abstract void MakeSound();


        public void run()
        {
            Console.WriteLine("dog ");
        }
     

    }
      class person : people
    {
        public override void MakeSound()
        {
            Console.WriteLine("gau gau");    
        }
    }

 }


