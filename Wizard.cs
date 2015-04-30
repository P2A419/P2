using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace P2
{
    class Wizard
    {
        public static void wizard_start()
        {
            Console.WriteLine("Velkommen til vored wizard\r\n"+
                              "Her kan du defniere diverse data til algoritmen\r\n"+
                              "Her skal du blandt andet også vise hvor dit test data er\r\n"+
                              "Tryk på en vilkårlig knap for at forsætte");
            Console.ReadKey();
            readfromfile(data_location(file_name()));
        }
        public static string file_name()
        {
            Console.Clear();
            Console.WriteLine("Hvad hedder filen med dine test\r\n"+
                              "Et eksempel kan være 'test.txt'");
            string filename=@"\"+Console.ReadLine();
            if (filename.EndsWith(".txt") == false)
            {
                return filename+".txt";
            }
            else
            {
                return filename;
            }
        }
        static string uppercasefirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        public static string manual_file()
        {
            string drev, user, folder, path;
            ConsoleKeyInfo temp;
            Console.WriteLine("Hvilket drev ligger filen på: ");
            drev = Console.ReadLine().ToUpper();
            Console.WriteLine("Hvilken bruger ligger filen under: ");
            user = uppercasefirst(Console.ReadLine());
            Console.WriteLine("Hvilke mappe ligger filen i, måske ligger den i flere,\r\n" +
                "men start mappen skal være en mappen under det navn på brugeren du gav");
            folder = Console.ReadLine();
            path = drev + @":\Users\" + user + @"\" + folder;
            Console.WriteLine("Er dette den rigtige vej til filen {0}",path);
            temp = Console.ReadKey();
            if (temp.Key == ConsoleKey.N)
            {
                Console.Clear();
                manual_file();
            }

            return path;
        }
        public static string file_location(string temp, string filename)
        {
            if (temp == "1")
            {
                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +  filename);
                return  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + filename;
            }
            else if (temp == "2")
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + filename;
            }
            else
            {
                return  manual_file() + @"\" + filename;;
            }
        }
        public static string data_location(string filename)
        {
            string temp,path;
            Console.Clear();
            Console.WriteLine("Nu vil vi finde filen med test data,\r\n\r\n"+
            "Er filen i din dokument mappe(1), eller på dit skrivebord(2)?\r\n"+
            "Eller vil du intaste stigen manuelt(vilkårlig knap)?");
            temp = Console.ReadLine();
            path = file_location(temp,filename);
            if (File.Exists(path))
            {
                Console.WriteLine("Vi fandt filen og går nu videre i wizarden");
            }
            else
            {
                Console.WriteLine("Vi fandt ikke filen og går nu tilbage for at finde den\r\n"+
                    "Tryk på en hvilkårlig knap for at forsætte");
                Console.ReadKey();
                data_location(file_name());
            }

            return path;
        }
        static List<TestData> readfromfile(string path)
        {
            string line;
            int i = 0;
            List<TestData> listTestData = new List<TestData>();

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                i++;
                string[] nums = line.Split(' ');
                listTestData.Add(new TestData(i, Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1])));
            }
            file.Close();

            return listTestData;
        }
    }
}
