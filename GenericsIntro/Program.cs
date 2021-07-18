using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> myList = new MyList<string>();
            myList.Add("Emre");
            Console.WriteLine(myList.Length);
            myList.Add("Ebrar Alya");
            Console.WriteLine(myList.Length);
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
