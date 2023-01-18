using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrezioneTest1
{

    public class Contact
    {
        
        public string? name { get; set; }
        public int? number { get; set; }
        public string? email { get; set; }
        
    }
    public class StandardContact : Contact
    {
        public  StandardContact (string name, int number) 
        {
            this.name = name;
            this.number = number;
        }
    }
    public class AdvancedContact : Contact
    {
        public AdvancedContact(string name, int number, string email)
        {
            this.name=name;
            this.number = number;
            this.email = email;
        }
    }
}
