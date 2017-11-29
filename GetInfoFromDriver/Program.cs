using System;
using System.IO;

namespace GetInfoFromDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo driver = new DriveInfo(@"C:\");

            Console.WriteLine("Name: {0}", driver.Name);
            Console.WriteLine("DriveType: {0}", driver.DriveType);

            if (driver.IsReady)
            {
                Console.WriteLine("DriveFormat: {0}", driver.DriveFormat);
                Console.WriteLine("VolumeLabel: {0}", driver.VolumeLabel);
                Console.WriteLine("AvailableFreeSpace: {0} bytes", driver.AvailableFreeSpace);
                Console.WriteLine("TotalFreeSpace: {0} bytes", driver.TotalFreeSpace);
                Console.WriteLine("TotalSize: {0} bytes", driver.TotalSize);
            }
        }
    }
}
