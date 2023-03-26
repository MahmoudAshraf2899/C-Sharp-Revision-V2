using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Services
{
    internal class UpdateProcessor
    {
        [Obsolete("This Method Not In Use currently, we Recommand to use DownloadAndInstall Method", false)]
        public static void DownloadUpdate(Update[]updates)
        {
            foreach (var item in updates)
            {
                Console.WriteLine($"Downloading : {item}");
                System.Threading.Thread.Sleep(750);
            }
            
        }
        [Obsolete("This Method Not In Use currently, we Recommand to use DownloadAndInstall Method", false)]

        public static void InstallUpdates(Update[] updates)
        {
            foreach (var item in updates)
            {
                Console.WriteLine($"Installing : {item}");
                System.Threading.Thread.Sleep(750);
            }
        }
        /// <summary>
        /// لو عاوز اعمل ميثود مسؤوله عن العمليتين تحميل وتثبيت
        /// </summary>
        public static void DownloadAndInstall(Update[]updates)
        {
            foreach (var item in updates)
            {
                Console.WriteLine($"Downloading : {item}");
                System.Threading.Thread.Sleep(750);
                Console.WriteLine($"Installing : {item}");
            }
        }
    }
}
