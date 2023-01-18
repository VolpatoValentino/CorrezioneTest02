using CorrezioneTest1;
using System;
using System.Collections.Generic;

public class Operations
{
    public int indexOfPersonfound;
    Program program = new Program();

    public void AddStandardContact()
	{
        program.SaveName();
        program.SaveNumber();
        StandardContact standardcontact = new StandardContact(program.nameSaved,program.numberSaved);
		Program.contacts.Add(standardcontact);
    }
    public void AddAdvancedContact()
    {
        program.SaveName();
        program.SaveNumber();
        program.SaveEmail();
        AdvancedContact advancedcontact = new AdvancedContact(program.nameSaved, program.numberSaved, program.emailSaved);
        Program.contacts.Add(advancedcontact);
    }
    public void RemoveContact()
	{
        FindContact(indexOfPersonfound);
        Console.WriteLine("do you want to cancel this contact?");
        string choice = Console.ReadLine();
        if (choice == "yes")
            Program.contacts.RemoveAt(indexOfPersonfound);
        else
            Console.WriteLine("you didn't cancel the contact");
    }
    public void EditContact()
    {
        FindContact(indexOfPersonfound);
        Console.WriteLine("would you like to edit this contact?");
        string choosen =string.Empty;
        choosen = Console.ReadLine();
        if (choosen == "yes")
        {
            program.SaveName();
            program.SaveNumber();
            Program.contacts[indexOfPersonfound].name = program.nameSaved;
            Program.contacts[indexOfPersonfound].number = program.numberSaved;
            Console.WriteLine("Do you want to add/edit an email?");
            string choice = Console.ReadLine();
            if (choice == "yes")
                program.SaveEmail();
            Program.contacts[indexOfPersonfound].email = program.emailSaved;
        }
        else
            return;
             

    }
    public void FindContact(int indexOfPersonfound)
    {
        string typeOfContact = "";
        Console.WriteLine("Type 1 to choose a standard contract, type 2 choose an advanced contact");
        typeOfContact = Console.ReadLine();
        switch (typeOfContact) {
            case "1":
                {
                    try
                    {
                        program.SaveName();
                        program.SaveNumber();
                        Contact? findPerson = Program.contacts.Find(contacts => contacts.name == $"{program.nameSaved}" &&
                                                            contacts.number == program.numberSaved);
                        if (findPerson != null)
                        {
                            indexOfPersonfound = Program.contacts.IndexOf(findPerson);
                            Console.WriteLine($"Contact Found {program.nameSaved} , number   {program.numberSaved} ");
                        }
                        else
                            Console.WriteLine("No person was found with that name");
                    } catch (Exception e) { Console.WriteLine(e); } 
                }break;
            case "2":
                {
                    try
                    {
                        program.SaveName();
                        program.SaveNumber();
                        program.SaveEmail();
                        Contact? findPerson = Program.contacts.Find(contacts => contacts.name == $"{program.nameSaved}" &&
                                                           contacts.number == program.numberSaved &&
                                                           contacts.email == program.emailSaved
                                                           );
                        if (findPerson != null)
                        {
                            indexOfPersonfound = Program.contacts.IndexOf(findPerson);
                            Console.WriteLine($"Contact Found, Name: {program.nameSaved},  Number: {program.numberSaved} ");
                        }
                        else
                            Console.WriteLine("No person was found with that name");
                    }
                    catch (Exception e) { Console.WriteLine(e); }
                }
                break;
        }
	}
   
    public void DisplayInfo()
    {
        if (Program.contacts == null)
            Console.WriteLine("You don't have any contacts saved");
        else
        {
            Console.WriteLine("You have these contacts saved");
            foreach (Contact con in Program.contacts)
            {
                Console.WriteLine($"Name : {con.name}   Number: { con.number}   Email: { con.email}");
            }
        }
    }
  
}
