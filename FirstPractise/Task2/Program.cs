using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            // в качестве параметра метод Add() принимает тип object.

            arrayList.Add(45);        //будет, упаковка
            arrayList.Add(true);      //будет, упаковка
            arrayList.Add("Hello");   //не будет ни упаковки, ни распаковки
            arrayList.Add(23.45);     //будет, упаковка

            foreach (object obj in arrayList) // для целей демонстрации, какие типы приходят на упаковку
            {
                Console.WriteLine(obj.GetType().FullName);
            }
        }
    }
}
