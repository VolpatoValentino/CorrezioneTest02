using System;

namespace CorrezioneTest1
{
    internal class Program
    {
        public string? nameSaved;
        public int numberSaved;
        public string? emailSaved;
        public static List<Contact> contacts;
        static void Main(string[] args)
        {
            contacts = new List<Contact>();
            Operations op = new Operations();
            Console.WriteLine($"Choose operations \nPress 1 to add a new contact \nPress 2 to add an advancedcontact \nPress 3 to find a contact already added \nPress 4 to remove a contact\nPress 5 to edit a contact\nPress 6 to see the full List of contacts");
            string opchoosen = String.Empty;
            if (opchoosen != null)
            {
                
                do
                {
                    opchoosen = Console.ReadLine();

                    switch (opchoosen)
                    {
                        case "1":
                            Console.WriteLine($"\nNow Adding new standard contact");
                            op.AddStandardContact();
                            Console.WriteLine("What would you like to do now?");
                            
                            opchoosen =String.Empty;
                            break;
                        case "2":
                            Console.WriteLine($"\nNow Adding new advanced contact");
                            op.AddAdvancedContact();
                            Console.WriteLine("What would you like to do now?");
                            opchoosen = String.Empty;
                            break;
                        case "3":
                            Console.WriteLine($"\nNow finding a contact");
                            op.FindContact(op.indexOfPersonfound);
                            Console.WriteLine("What would you like to do now?");
                            opchoosen = String.Empty;

                            break;
                        case "4":
                            Console.WriteLine($"\nNow Removing an existing contact");
                            op.RemoveContact();
                            Console.WriteLine("What would you like to do now?");
                            opchoosen = String.Empty;
                            break;
                        case "5":
                            op.EditContact();
                            Console.WriteLine("What would you like to do now?");
                            opchoosen = String.Empty;
                            break;
                        case "6":
                            op.DisplayInfo();
                            Console.WriteLine("What would you like to do now?");
                            opchoosen = String.Empty;
                            break;
                        default:
                            break;
                    }
                } while (opchoosen != null);
            }
            else
                opchoosen = Console.ReadLine();
                return;
        }


        public void SaveName()
        {
            string s =String.Empty;
            s = Console.ReadLine();
            if (s != String.Empty)
                nameSaved= s;
            else
                do
                {
                    Console.WriteLine("You didn't type anything!");
                    s = Console.ReadLine();
                } while (s == string.Empty);
        }
        public void SaveNumber()
        {
            bool isValid = false;
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out int number);
            if (isValid)
                 numberSaved = number;
            else
                do
                {
                    Console.WriteLine("You didn't input a number!");
                    isValid = int.TryParse(Console.ReadLine(), out number);
                    numberSaved = number;
                }while(!isValid);
        }
        public void SaveEmail()
        {
            string s = "";
            s = Console.ReadLine();
            if (s != null)
                emailSaved = s;
            else
                do
                {
                    Console.WriteLine("You didn't type anything!");
                    s = Console.ReadLine();
                    
                    emailSaved = s;
                } while (s == null);
            

        }
    }
}