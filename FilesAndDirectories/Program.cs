using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *      Fichier texte (.txt) 
             */
            using (TextWriter writer = File.CreateText("data.txt"))     // création du fichier texte
            {
                writer.WriteLine("Ceci est un fichier texte !");        // ecriture ligne de texte
            }
            using (TextWriter writer = File.AppendText("data.txt"))     // ajouter un ligne au fichier deja créé
            {
                writer.WriteLine("Ceci est un fichier texte ajouté !"); //  ecriture ligne de texte
            }
            Console.WriteLine("fichier texte créé !");
            using (TextReader reader = File.OpenText("data.txt"))       // ouverture d'un fichier texte
            {
                string content = reader.ReadToEnd();                    // stocker la lecture dans le content
                Console.WriteLine(content);                             // afficher le contenu
            }
            byte[] byteArray = new byte[50];
            File.WriteAllBytes("test.data", byteArray);
            File.Copy("test.data", "test2.data");
            File.Move("test.data", "test3.data");
            File.Encrypt("test3.data");
            File.Decrypt("test3.data");
            File.Delete("test.data");
            Console.ReadKey();

            if (!Directory.Exists("c:\\temp"))
            {
                Directory.CreateDirectory("c:\\temp");
            }

            Directory.Delete("c:\\temp");

            DirectoryInfo info = Directory.GetParent("c:\\temp");
            FileInfo[] files = info.GetFiles();
            // files[0].FullName

            Console.ReadLine();
        }
    }
}
