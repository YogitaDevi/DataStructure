using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace DataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            SortList<string> orderedList = new SortList<string>();
            orderedList.sortList();

            SortList<int> sList = new SortList<int>();

            //Adds data to the list  
            sList.addNode(31);
            sList.addNode(77);
            sList.addNode(17);
            sList.addNode(93);
            sList.addNode(26);
            sList.addNode(54);

            //Displaying original list  
            Console.WriteLine("Original list: ");
            sList.display();

            //Sorting list  
            sList.sortList();

            //Displaying sorted list  
            Console.WriteLine("Sorted list: ");
            sList.display();
        }
         
    }
   
}
