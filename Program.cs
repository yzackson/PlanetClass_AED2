using System;
using System.IO;

namespace Planet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira o caminho do arquivo ou apenas o nome para criar no próprio diretório atual.");
            string path = Console.ReadLine();

            List<CelestBody> bodys = new List<CelestBody>();

            string[] file = File.ReadAllLines(path);
            if (file.Length > 0)
            {
                for(int i = 1; i <= int.Parse(file[0]); i++)
                {
                    string[] data = file[i].Split(";");
                    CelestBody newBody = new CelestBody(data[0], data[1], data[2]);
                    bodys.Add(newBody);
                }
            } else {
                Console.WriteLine("Arquivo não tem dados");
            }
        }
    }
}