using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Person
    {
        //POCO: object, properties, and constructore
        //the oject is person
        //after you creat the bejct you ucreat propety 
        
        // name is the *name* of the property 
        public string Name { get; set; }
        //
        public int Age { get; set; }
        
        public GradeType Grade { get; set; }
        //empty constructor
        public Person() { }

        public Person(string name, int age, GradeType grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        

    }

    public enum GradeType
    {
       ninth = 1,
       tenth,
       eleventh,
       twelfth
           
    }

    
}
