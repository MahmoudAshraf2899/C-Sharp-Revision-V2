using Attributes.Services;
using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Update[] updates =
            {
                new Update (1,"Securitry"),
                new Update (2,"UI"),
                new Update (3,"Bug Fix"),
                new Update (4,"Memory Fix"),

            };
            UpdateProcessor.DownloadUpdate(updates);
            UpdateProcessor.InstallUpdates(updates);
            UpdateProcessor.DownloadAndInstall(updates);



        }
    }
     
}
