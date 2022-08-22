using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula07Q01
{
    public class Base
    {

        public List<string> ReadAllLinesCSV(string path)
        {
            List<string> lines = new List<string>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) is null)
                {
                    lines.Add(line);

                }
            }
            return lines;
        }

        public void RewriteCSV(string path, List<string> lines)
        {
            using (StreamWriter output = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }

        delegate string FolderSpliter(string[] text);
        /// <summary>
        ///  Criar uma pasta
        /// </summary>
        /// <param name="path"></param>
        public static void CreateFolderFile(string path)
        {
            string[] separatedPath = path.Split('/');
            FolderSpliter getFolder = delegate (string[] textArray) {
                string Directory = "";
                int index = 0;
                foreach ( string text in textArray)
                {
                    if (index < textArray.Length - 1)
                    {
                        Directory += text;
                        Directory += "/";
                    }
                    index++;
                }
                return Directory;
            };
            string folder = getFolder(separatedPath);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!Directory.Exists(path))
            {
                File.Create(path).Close();
            }
            Console.WriteLine(folder);

        }
    }
}
