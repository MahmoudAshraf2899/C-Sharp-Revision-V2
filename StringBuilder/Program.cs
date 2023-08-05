using System;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using StringBuilder;
namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string GenerateWithString()
        {
            //String is Immutable
            //Immutable : Any update on the string value will create new object in memory

            //Imagine it's a complicated process to Generate 'METIGATOR'
            //using string

            //declare string
            string str = null;

            //append three characters 'E','T' and 'I'
            str += String.Concat(new char[] { 'E', 'T', 'I' }); //This Create New Object in memory

            //append a format string to the end of the string
            str += String.Format("GAT{0}{1}{2}", 'O', 'P', 'S'); // GATOPS //This Create New Object in memory

            //insert 'M' To the beginning of a string 
            str = "M" + str; // METIGATOPS //This Create New Object in memory

            //Replace 'P' with 'R'
            str = str.Replace('P', 'R'); //METIGATORS //This Create New Object in memory

            //Remove 'S' from the string
            str = str.Remove(str.Length - 1); // METIGATOR  //This Create New Object in memory
            return str;

        }
        static string GenerateWithStringBuilder()
        {
            //String Builder are mutable
            //Mutable :Any updates on string builder it changes on the same object in memory not creating new object as string
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //append three characters 'E','T' and 'I' To String builder
            sb.Append(new char[] { 'E', 'T', 'I' }); // ETI

            //append a format string to the end of the String builder
            sb.AppendFormat("GAT{0}{1}{2}", 'O', 'P', 'S'); // ETIGATOPS

            //insert 'M' To the beginning of a String builder
            sb.Insert(0, "M"); // METIGATOPS

            //Replace 'P' with 'R'
            sb.Replace('P', 'R'); //METIGATORS

            //Remove 'S' from the String builder
            sb.Remove(sb.Length - 1, 1); // METIGATOR 

            return sb.ToString();
        }
    }
}
