using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursividadporKEY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\"; 
            ListFilesRecursively(directoryPath);
            Console.ReadLine();
        }
        static void ListFilesRecursively(string directoryPath)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directoryPath))
                {
                    Console.WriteLine($"ARCHIVO: {Path.GetFileName(file)}, EXTENSION: {Path.GetExtension(file)}");
                }

                foreach (string subdirectory in Directory.GetDirectories(directoryPath))
                {
                    ListFilesRecursively(subdirectory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Error al acceder a {directoryPath}: {e.Message}");
            }
        }
    }
}
