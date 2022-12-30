using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class UnOrderedList<T> where T : IComparable
    {
        Node<T> head;
        public void UnOrderedListOperation()
        {
            string text = File.ReadAllText(@"E:\RFP231\DataStructure\DataStructure\Word.txt");
            string[] fileList = text.Split(" ");

            foreach (string word in fileList)
            {
                T element = (T)Convert.ChangeType(word, typeof(T));
                Insert(element);
            }
            Console.Write("\nThe content in the list is:");
            Display();

            Console.Write("\n\nEnter the word need to be search in file: ");
            string Word = Console.ReadLine();
            T searchWord = (T)Convert.ChangeType(Word, typeof(T));

            //search word in linked list 
            if (Search(searchWord))
            {
                Delete(searchWord);
            }
            else
            {
                Insert(searchWord);
            }

            Console.Write("\nThe content in the list is: " + searchWord);
            Display();

            string resultText = ReturnString();
            File.WriteAllText(@"E:\RFP231\DataStructure\DataStructure\Word.txt", resultText);           
        }
        /// This Method is For Adding Elements Into LinkedList
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        /// This Method Is For Deleting Element
        public void Delete(T data)
        {
            if (this.head != null)
            {
                Node<T> temp = this.head;
                Node<T> prev = null;
                while (temp != null)
                {
                    if ((temp.data).CompareTo(data) == 0)
                    {
                        prev.next = temp.next;
                        break;
                    }
                    prev = temp;
                    temp = temp.next;
                }
            }

        }
        /// This Method Is For Searching Word
        public bool Search(T value)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    Console.WriteLine("\n" + value + " Found");
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        /// This Method Is For Displaying LinkedList Elements
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /// This Method Is For Saving LinkedList into file
        public string ReturnString()
        {
            Node<T> temp = this.head;

            string finaltext = " ";
            while (temp != null)
            {
                if (temp.next != null)
                {
                    finaltext = finaltext + temp.data + " ";
                }
                else
                {
                    finaltext = finaltext + temp.data;
                }
                temp = temp.next;
            }
            return finaltext;
        }
        /// This Method Is For Sorting
        public void Sort()
        {
            Node<T> i;
            Node<T> j;
            T temp;
            for (i = this.head; i != null; i = i.next)
            {
                for (j = i.next; j != null; j = j.next)
                {

                    if ((i.data).CompareTo(j.data) > 0)
                    {
                        temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }

            }
        }
    }
}
