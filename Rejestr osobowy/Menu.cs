using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Linq;
using System.IO;

namespace Rejestr_osobowy
{
    class Menu
    {
        private Manager _Manager;
        public Menu()
        {
            _Manager = new Manager();
        }
        public void Run()
        {

            /*try
                {

                    Person t= new Person(ToolboxClass.EnterNumber("Podaj Wiek:", 0, 150),
                                            ToolboxClass.EnterText("Podaj imie:", false, 30));


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Person p = new Person();
                p.Name = "Staszek"; p.Age = 30;
                XmlSerializer xs = new XmlSerializer(typeof(Person));
                using (Stream s = File.Create("Person.xml"))
                xs.Serialize(s, p);*/
            //Person p = _Manager.CreatePerson("Andrzej", "Jan", 33, "asd");
            int x = 99;
            while (x != 0)
            {
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("1.Odczyt danych");
                Console.WriteLine("2.Zapis danych");
                Console.WriteLine("3.Dodaj osobę");
                Console.WriteLine("4.Modyfikuj osobę");
                Console.WriteLine("5.Usuń osobę");
                Console.WriteLine("6.Wyszukaj osobę");
                Console.WriteLine("0.Wyjdz z programu");
                x = ToolboxClass.EnterNumber("Podaj opcje", 0, 6);
                switch (x)
                {
                     case 3:

                        Person p = _Manager.CreatePerson(ToolboxClass.EnterText("Podaj imię", true, 30), ToolboxClass.EnterText("Podaj nazwisko", true, 50), ToolboxClass.EnterNumber("Podaj wiek", 0, 150), ToolboxClass.EnterText("Podaj płeć", true, 20));
                        Console.Clear();

                        Console.WriteLine("Wszystkie osoby:");
                        foreach (Person person in _Manager.GetAll())
                        {
                            Console.WriteLine(person);
                        }
                        /*string filePath = "person";
                        DataSerializer dataSerializer = new DataSerializer();
                        dataSerializer.X*/
                        break;
                    case 1:
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Wszystkie osoby:");
                        foreach (Person person in _Manager.GetAll())
                        {
                            Console.WriteLine(person);
                        }
                        XmlSerializer xs = new XmlSerializer(typeof(Person));
                        using (Stream s = File.Create("Personx.xml"))
                            xs.Serialize(s, p);
                        /*XmlSerializer xs = new XmlSerializer(typeof(Person));
                        using (Stream s = File.Create("Person.xml"))
                            xs.Serialize(s, p);*/


                            //Person p;
                            //using (Stream s = File.OpenRead("Person2.xml"))
                            //   p = (Person)xs.Deserialize(s);
                            //Console.WriteLine(p.Name + " " + p.Age); // Staszek 30


                        break;
                    case 4:
                        Console.WriteLine(_Manager.generateId());
                        break;
                    case 5:
                        break;
                }
            }
        }
    }
}
