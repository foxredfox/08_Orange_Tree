using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Orange_Tree
{
    class OrangeTree
    {

        public int Age;
        public int Height;
        public bool TreeAlive { 
            get {
                if (Age >= 80)
                    return false;
                return true;
            }
        }
        public int NumOranges
        {
            set { }
            get {
                if (Age > 1)
                    return (Age - 1) * 5;
                return 0;
            }
        }
        public int OrangesEaten;

        public OrangeTree(int a, int b)
        {

        }

        public void OneYearPasses()
        {
            Age++;
            Height += 8;
        }

        public void EatOrange(int i)
        {
            if(NumOranges < 1)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
            else
            {
                NumOranges -= i;
                OrangesEaten += i;
            }
            
        }

    }
}
