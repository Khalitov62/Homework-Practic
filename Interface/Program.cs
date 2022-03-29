using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MainPrintFile exel = new Exel();
            exel.Print();

            MainPrintFile word = new Word();
            word.Print();

            MainPrintFile pdf = new Pdf();
            pdf.Print();
            


        }
    }
}
