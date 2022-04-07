using System;
using System.IO;
using File_Directory_Serialization.Models;
using Newtonsoft.Json;

namespace File_Directory_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"/Users/yusifnazarbayov/Visual Studio/Projects/File_Directory_Serialization/Files");
            if (!File.Exists(@"/Users/yusifnazarbayov/Visual Studio/Projects/File_Directory_Serialization/Files/Database.json"))
            {
                File.Create(@"/Users/yusifnazarbayov/Visual Studio/Projects/File_Directory_Serialization/Files/Database.json");
            }

            do
            {
                Console.WriteLine("***********Menu**********");
                Console.WriteLine("|1.    Add employee     |");
                Console.WriteLine("|2.  Get employee by id |");
                Console.WriteLine("|3.   Remove employee   |");
                Console.WriteLine("|0.        Quit         |");

                int choice = Convert.ToInt32(Console.ReadLine());
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Employee employee1 = new Employee(1, "JavaScript", 30);
                        Department department = new Department();

                        department.AddEmployee(employee1);
                       
                        string jsonString = JsonConvert.SerializeObject(department);
                        using (StreamWriter sw = new StreamWriter(@"/Users/yusifnazarbayov/Visual Studio/Projects/File_Directory_Serialization/Files/Database.json"))
                        {
                            sw.WriteLine(jsonString);
                        }
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 0:

                        break;

                    default:
                        break;
                }
            } while (false);
            
        }
    }
}

