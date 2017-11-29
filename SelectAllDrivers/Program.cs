using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectAllDrivers
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();

            foreach (var driver in drivers)
            {
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

                Console.WriteLine();
                Console.WriteLine("##########################################");
                Console.WriteLine();
            }
        }
    }
}
