namespace FileIODemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\DELL\source\repos\FileIODemo\FileIODemo\Demo.txt ";
            FileExistsInPath(path);
            ReadAllLinesFromFile(path);
            ReadAllTextFromFile(path);
            FileCopytoanother(path);
            Deleteile(path);
            ReadFromStreamReader(path);
            WriteToStreamWriter(path);

            BinarySerialization binarySerialization = new BinarySerialization();
            binarySerialization.Seralization();

            binarySerialization.DeSeralization();


        }
        public static void FileExistsInPath(string path)
            { 
            if(File.Exists(path))
            {
                Console.WriteLine("file exists");
            }
            else
            {
                Console.WriteLine("file not exists");
            }
        }
        public static void ReadAllLinesFromFile(string path)
        {
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
        }

        public static void ReadAllTextFromFile(string path)
        {
            string line;
            line = File.ReadAllText(path);

            Console.WriteLine(line);
            
        }

        public static void FileCopytoanother(string path)
        {
            string copypath = @"C:\Users\DELL\source\repos\FileIODemo\FileIODemo\Demo.txt";
            File.Copy(path, copypath);

        }

        public static void Deleteile(string path)
        {
            string copypath = @"C:\Users\DELL\source\repos\FileIODemo\FileIODemo\Demo.txt ";
            File.Delete(copypath);
        }

        public static void ReadFromStreamReader(string path)
        {
            using (StreamReader sr=File.OpenText(path))
            {
                string s = " ";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }

            }
        }

        public static void WriteToStreamWriter(string path)
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("iam learning .net");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));

            }
        }

    }
}