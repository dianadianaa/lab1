using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"/Users/dee/Desktop/papka"; //adding directory where to create file
            string path = Path.Combine(folderName, "test2"); //directory and new file's name

            string source = @"/Users/dee/Desktop/NewDir"; //directory where to copy file
            using (File.Create(path)) //creating
            {


            }

            File.Copy(path, Path.Combine(source, "test2")); //copying

            File.Delete(path);
        }
    }
}


