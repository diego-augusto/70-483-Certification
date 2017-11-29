using System;
using System.IO;

namespace DeleteDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory1 = Directory.CreateDirectory("Directory01");

            DirectoryInfo directory2 = new DirectoryInfo("Directory02");
            directory2.Create();

            if (Directory.Exists("Directory01"))
            {
                Directory.Delete("Directory01");
            }

            if (directory2.Exists)
            {
                directory2.Delete();
                //Update object state
                directory2.Refresh();
            }

            Console.WriteLine("Directory01 is deleted: {0}", !Directory.Exists("Directory01"));
            Console.WriteLine("Directory02 is deleted: {0}", !directory2.Exists);
        }
    }
}
