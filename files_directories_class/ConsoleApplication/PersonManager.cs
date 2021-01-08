using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication
{
   
   public static class PersonManager
    {

        public static List<Person> personList = new List<Person>();
        public static List<Person> templist = new List<Person>();
        
        
        public static void AddPerson()
        {
            Console.WriteLine("Please provide name");
            
            string name = Console.ReadLine();


            Console.WriteLine("provide age");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);
            personList.Add(person);
        }

        public static void SearchPerson()
        {
            Console.WriteLine($"Please provide search option: \n a) based on name  \n b) for age");
            
            string choice = Console.ReadLine();
            if (choice == "a")
            {
                Console.WriteLine("Provide name");
                string name = Console.ReadLine();

                int counter = 1;
                templist = personList.Where(person => person.Name == name).ToList();
                foreach (var item in templist)
                {
                    Console.WriteLine($"{counter}) {item.Name}, {item.Age}");
                    counter++;
                }
                
            }else if(choice == "b")
            {
                Console.WriteLine("Provide age");
                int age = Convert.ToInt32(Console.ReadLine());

                int counter = 1;
                templist = personList.Where(person => person.Age == age).ToList();
                foreach (var item in templist )
                {
                    Console.WriteLine($"{counter}) {item.Name}, {item.Age}");
                    counter++;
                }
            
                
            }

            
        }

        public static void SaveData() 
        {
            DateTime date = DateTime.Now;
            
           DirectoryInfo directoryInfo = Directory.CreateDirectory($"Saved--{date.ToString("dd--MM--yyyy")}");

            BinaryFormatter formatter = new BinaryFormatter();

            Console.WriteLine("Provide file name" );
            string file_name = Console.ReadLine();

            using (FileStream fs = new FileStream(Path.Combine(directoryInfo.Name, file_name + ".dat"), FileMode.OpenOrCreate))
            {
               
                formatter.Serialize(fs, personList.ToArray());
                              
            }

        }

        public static void LoadData()
        {
            Console.WriteLine("Please pr filename");
            string fn = Console.ReadLine();
            string searchFile = ""; 
            foreach(var item in Directory.GetDirectories(Environment.CurrentDirectory))
            {
               searchFile = Path.GetFullPath(Path.Combine(item, fn));

                if (searchFile != null)
                {
                    break;
                }
             
            }

            if (searchFile != null)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(searchFile + ".dat", FileMode.OpenOrCreate))
                {
                    Person[] deserilizePeople = (Person[])formatter.Deserialize(fs);
                    personList = deserilizePeople.ToList();
                }

            }
            
                      

        }

        public static void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine($"Please make your choice:");
            Console.WriteLine("1. Elave et");
            Console.WriteLine("2. Search et");
            Console.WriteLine("3. Save et");
            Console.WriteLine("4. Load et");
            Console.WriteLine("5. Display data");
            Console.WriteLine("6. Exit program");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddPerson();
                    DisplayMenu();
                    break;
                case 2:
                    SearchPerson();
                    DisplayMenu();
                    break;
                case 3:
                    SaveData();
                    DisplayMenu();
                    break;
                case 4:
                    LoadData();
                    DisplayMenu();
                    break;
                case 5:
                    DisplayData();
                    DisplayMenu();
                    break;
                case 6:
                    break; 
                default:
                    Console.WriteLine("bele bir emeliyyat yoxdur");
                    break;
            }
           
        }

        public static void DisplayData()
        {
            foreach(var item in personList)
            {
                Console.WriteLine($"name is :{item.Name}");
                Console.WriteLine($"age is :{item.Age}");
            }
        }

    }
}
