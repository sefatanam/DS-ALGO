using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONotation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //=============> O(n) - Big O-Notation Understanding <========= 

        //O(1) -> Constant
        void Function1(List<string> data)
        {
            string str = data[0];
        }

        //O(n)  ---> Linear representation
        void Fucntion2(List<string> data)
        {
            foreach (string item in data)
            {
                if (item == "Sefat") return;

            }
        }

        // O(2n) or O(n^2)  --> Quadratic
        void Fucntion3(List<string> data)
        {
            foreach (string item in data)
            {
                foreach (string item2 in data)
                {
                    if (item2 == "Sefat") return;

                }

            }
        }
    }
}
