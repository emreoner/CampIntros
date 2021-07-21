using System;
using System.Collections.Generic;

namespace MyDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
           
            keyValuePairs.Add("oner", "emre");
         
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("oner", "emre");
            myDictionary.Add("soner", "emre");
        }
    }
}
