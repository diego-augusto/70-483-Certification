﻿using System.IO;

namespace AddDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // With Directory
            //
            DirectoryInfo directory1 = Directory.CreateDirectory("Directory01");

            //
            // With DirectoryInfo
            //
            DirectoryInfo directory2 = new DirectoryInfo("Directory02");
            directory2.Create();
        }
    }
}
