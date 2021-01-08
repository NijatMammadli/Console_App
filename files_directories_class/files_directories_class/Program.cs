using System;
using System.IO;
using System.Net;
using System.Text; 

namespace files_directories_class
{
    class Program
    {
        static void Main(string[] args)
        {





            #region folders
            //Directory.CreateDirectory("example");
            //for(int k =0; k<20; k++)
            //{

            //    Random random = new Random();
            //    int a = random.Next(555, 1000);

            //    Directory.CreateDirectory(Path.Combine("example", a.ToString()));

            //}


            //int i = 1;
            //foreach(string directory in Directory.GetDirectories("example"))
            //{

            //    Directory.Move(directory, $@"example\{i}");
            //    i++;
            //}




            //for(int i = 0; i<20; i++)
            //{
            //    string input = paths[i];
            //    string input2 = $"example /{i}";
            //    Directory.Move(input, input2);
            //}
            #endregion

            #region 
            //Directory.CreateDirectory(@"D:\windows_secure\programming\Nijat");
            //File.Create(@"D:\windows_secure\programming\1.txt");
            //File.Create(@"D:\windows_secure\programming\1.xlsx");
            //Console.WriteLine(Environment.CurrentDirectory);


            //string[] directories = Directory.GetDirectories(@"D:\windows_secure");
            //foreach(string item in directories)
            //{
            //    string filename = Path.GetFileName(item);

            //    Console.WriteLine(item);
            //    Console.WriteLine(filename);

            //    foreach(var file in Directory.GetFiles(item, "*.xlsx"))
            //    {
            //        Console.WriteLine(Path.GetFileName(file));
            //    }
            //}

            //    GetAllFiles(@"D:\windows_secure");



            //}
            //static void GetAllFiles(string directory_name)
            //{
            //    string[] directories = Directory.GetDirectories(directory_name);
            //    foreach (var directory in directories)
            //    {
            //        string filename = Path.GetFileName(directory);

            //        Console.WriteLine(directory);
            //        Console.WriteLine(filename);

            //        foreach (var file in Directory.GetFiles(directory, "*.xlsx"))
            //        {
            //            Console.WriteLine(Path.GetFileName(file));
            //        }

            //        GetAllFiles(directory);
            //    }

            #endregion




        }

    }
}
