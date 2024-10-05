using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lek01
{
    internal class MyList
    {
        List<int> myList = new List<int>();

        public MyList() { }

        public void AddNumber(int x)
        {
            myList.Add(x);
        }

        public void PrintNumbers()
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
