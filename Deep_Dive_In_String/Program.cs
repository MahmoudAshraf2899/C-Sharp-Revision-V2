using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Deep_Dive_In_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Show Binary and ASCII Table
            //for (byte c = 0; c < 255; c++)
            //{
            //    char ch = (char)c;
            //    string dec = c.ToString().PadLeft(3, '0');
            //    string hex = c.ToString("X");
            //    string binary = Convert.ToString(c, 2).PadLeft(8, '0');
            //    Console.WriteLine($"{dec,-12} {binary,-12} , {hex,-12} {ch,-12}");
            //} 
            #endregion

            #region Text Encoding & UniCode
            //Task.Run(() => GetDataAssciFormat());
            #endregion

            #region String Comparison
            //StreamWriter sw = new StreamWriter(@".\output.txt");//Store All Out Put on this file
            //string char1 = "\u0061"; //output => a (u0061 = a || in unicode format)
            //string char2 = "\u03080"; //output => ¨

            //sw.WriteLine(char1);
            //sw.WriteLine(char2);

            //string grapheme = "\u0061\u0308";
            //sw.WriteLine(grapheme); //output => ä

            //string singleChar = "\u00e4";
            //sw.WriteLine(singleChar); //output => ä

            ////Current Culture => Make The equality on the final result..
            //sw.WriteLine("{0} = {1} (Culture-sensitive) : {2}", grapheme, singleChar,
            //                                                  String.Equals(grapheme, singleChar,
            //                                                  StringComparison.CurrentCulture));//Out Put => T


            ////Ordinal Will Compare between values (\u0061\u0308 && \u00e4 )
            //sw.WriteLine("{0} = {1} (Culture-sensitive) : {2}", grapheme, singleChar,
            //                                                  String.Equals(grapheme, singleChar,
            //                                                  StringComparison.Ordinal));//Out Put => F



            ////Normalize : it return the new string whose textual value is the same as this string
            ////it try to edit the values to be at the same representation ..
            //sw.WriteLine("{0} = {1} (Culture-sensitive) : {2}", grapheme, singleChar,
            //                                                  String.Equals(grapheme.Normalize(),
            //                                                  singleChar.Normalize(),
            //                                                  StringComparison.Ordinal));//Out Put => T
            #endregion

            #region String Intern Pool
            //Using As Pool That contain all duplicated strings in one place
            string s1 = "Nabwy";
            string s2 = String.Intern(s1); //Out Put => Nabwy
            Console.WriteLine($"S2 is {s2}");

            string s3 = new string("Mahmoud");
            string s4 = String.Intern(s3);

            Console.WriteLine($"S3 is {s3}");
            Console.WriteLine($"S4 is {s4}");


            Console.WriteLine($"Reference Equals :  {ReferenceEquals(s1, s2)}");

            #endregion

            Console.ReadKey();
        }
        static async Task GetDataAssciFormat()
        {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            var filePath = $"{path}\\asciiNewsContent.txt";
            using (var client = new HttpClient())
            {
                Uri uri = new Uri("https://1-a1072.azureedge.net/");
                using (HttpResponseMessage response = await client.GetAsync(uri))
                {
                    var byteArray = await response.Content.ReadAsByteArrayAsync();
                    //TRY To Search those bytes data value at ascii table
                    var result = Encoding.ASCII.GetString(byteArray);
                    File.WriteAllText(filePath, result);
                }
            }
        }
    }
}
