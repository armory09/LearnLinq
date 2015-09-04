using System;
using System.Collections;

namespace LearnLINQ.Collections
{
    public class ArrayLists
    {
        public ArrayLists()
        {
            ArrayList arryList1 = new ArrayList();  

            //add() to add individual at the end of data
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryList1.Add(4.5);

            ArrayList arryList2 = new ArrayList();
            arryList2.Add(100);
            arryList2.Add(200);

            //adding an entire collection
            ArrayList arrylist = new ArrayList();
            arrylist.AddRange(arryList2);

            //access individual
            var firstElement = (int) arryList1[0];
            var secondElement = (string) arryList1[1];
            var thirdElement = (int) arryList1[2];
            var forthElement = (float) arryList1[3];

            //accesss using loop
            foreach (var val in arryList1)
            {
                Console.WriteLine(val);
            }

            for (int i = 0; i < arryList1.Count; i++)
            {
                Console.WriteLine(arryList1[i]);
            }

            //remove item using index
            arryList1.RemoveAt(2); //remove value two

            arryList1.RemoveRange(0,2); //remove two elements starting from 1st item (0 index)
        }
    }
}
