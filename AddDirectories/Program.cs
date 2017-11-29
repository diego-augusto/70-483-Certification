using System.IO;

namespace AddDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory1 = Directory.CreateDirectory("Directory01");
            DirectoryInfo directory2 = new DirectoryInfo("Directory02");
            directory2.Create();
        }
    }
}
