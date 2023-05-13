using Stream_IO.Services;
using System;
using System.IO;

namespace Stream_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UnSafe Code
            //currencyService currency = new currencyService();
            //var result = currency.getCurrencies();
            //currency.Dispose();
            //Console.WriteLine(result);
            #endregion

            #region Second Way
            //currencyService currency = null;
            //try
            //{
            //    currency = new currencyService();
            //    var result = currency.getCurrencies();
            //    Console.WriteLine(result);
            //    Console.ReadKey();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error");
            //}
            //finally
            //{
            //    //? = to check if currency is null or not
            //    currency?.Dispose();
            //} 
            #endregion

            #region Third Way (Recommended)
            ////Using will converted to try & catch & finally
            //using (currencyService currency = new currencyService())
            //{
            //    //Using Automatic will call dispose method..
            //    var result = currency.getCurrencies();
            //    Console.WriteLine(result);
            //}
            #endregion

            #region File Stream (Back Store)
            long length=0;
            byte[] data = new byte[length];

            string path = "C:\\Users\\Mahmoud\\OneDrive\\Desktop\\sample.txt";
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                #region Read & Count & Write
                //Console.WriteLine($"Length : { fs.Length} Bytes");
                //Console.WriteLine($"Length : { fs.CanRead}");
                //Console.WriteLine($"Length : { fs.CanWrite}");
                //Console.WriteLine($"Length : { fs.CanSeek}");
                //Console.WriteLine($"Length : { fs.CanTimeout}");
                //Console.WriteLine($"Length : { fs.Position}");
                //fs.WriteByte(65); //Will Write (A)  Char 
                #endregion
                length = fs.Length;
                data = new byte[length];
                int noBytesToRead = (int)fs.Length;
                int noReadedBytes = 0;
                while (noBytesToRead > 0)//طول مافي حاجة يقراها هيخش جوا اللوب
                {
                    int n = fs.Read(data, noReadedBytes, noBytesToRead);
                    if (n == 0)
                    {
                        break;
                    }
                    noBytesToRead -= n;
                    noReadedBytes += n;
                }
                foreach (var item in data)
                {
                    Console.WriteLine(item);//Result will be in bytes 
                }
            }
            //Another Using To Take Bytes Result and Store it in new file
            var newPath = "C:\\Users\\Mahmoud\\OneDrive\\Desktop\\newSample.txt";

            using (var fs = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.Write(data,0,data.Length);
            }


            #endregion


            Console.ReadKey();
        }
    }
}
