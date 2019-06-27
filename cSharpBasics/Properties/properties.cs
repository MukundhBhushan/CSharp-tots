using System;

namespace cSharpBasic
{
    class properties
    {
        public int Id { get; set; } //normal init
        public string Name //under the hood imp of get and set
        { 
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }
    }
    class baseClass
    {
       static void Main(string[] args)
        {
            properties prop = new properties(); //create an object and assign values
            prop.Id = 1;
            prop.Name = "Mukundh";

            properties prop2 = new properties(){ //assign values while creating an obj;
                Id = 2,
                Name = "Mukundh"
            };
        } 
    }
}