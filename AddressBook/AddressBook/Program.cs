using System;
using System.IO;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                try
                {
                    Console.WriteLine("Add entry or see existing entries?");
                    var Start = Console.ReadLine();

                    if (Start.ToLower() == "add" || Start.ToLower() == "add entry")
                    {
                        Console.WriteLine("Enter first and last name of new contact: ");
                        var Name = Console.ReadLine();
                        Console.WriteLine("Enter phone number of contact:");
                        var Phone = Console.ReadLine();
                        Console.WriteLine("Enter address of contact: ");
                        var Address = Console.ReadLine();
                        Console.WriteLine("Enter email of contact: ");
                        var Email = Console.ReadLine();
                        string Contact = "Name:" + Name + "  Phone number:" + Phone + "  Address:" + Address + "  Email:" + Email;
                        using (StreamWriter sw = File.AppendText("\\contacts.txt"))
                        {
                            sw.WriteLine(Contact, true);
                        }
                            Console.WriteLine(Contact);
                        
                        continue;
                    }
                    if (Start.ToLower() == "see existing" || Start.ToLower() == "see")
                    {
                        string printList = File.ReadAllText("\\contacts.txt");
                        Console.WriteLine(printList);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not vaild input");
                    continue;
                }
            }
        }
    }
 }
