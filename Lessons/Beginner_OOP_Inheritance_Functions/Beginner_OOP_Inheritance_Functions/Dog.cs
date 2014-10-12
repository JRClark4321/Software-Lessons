/**************************************************************************************
 * Author:      Jeffrey Clark
 * Class:       Dog
 * Purpose:     To show the concepts of overriding a virtual/abstract parent function
 *              and overloaded constructors, 
 *************************************************************************************/
using System;

namespace Beginner_OOP_Inheritance_Functions
{
    //Dog inherits from Animal
    class Dog : Animal
    {
        //This function is a "Constructor", also known as a "Ctor". What makes this a constructor is
        //the fact that the function has the same name as the class. Here, you put special logic
        //that will happen with EVERY new Dog object you create. In this case, every new Dog object
        //will have an owner named "Darth Vader"
        public Dog()
        {
            _OwnerName = "Darth Vader";
        }

        //This is a "one argument constructor", meaning that it has one argument. Here, we allow 
        //you to write Dog variable = new Dog("Bill"). That will create a new dog object that
        //automatically have an owner name of Bill.
        public Dog(string ownerName)
        {
            _OwnerName = ownerName;
        }

        //This is also a one argument constructor, but it sets the dog's number of legs, but
        //sticks the default owner name.
        public Dog(int numberLegs)
        {
            _NumberOfLegs = numberLegs;
            _OwnerName = "Darth Vader";
        }

        //Here, we override the Speak() function.
        public override void Speak() 
        {
            Console.WriteLine("I am a Dog!");
        }

        //Here, we just call a function that will write the owner's name. This isn't really
        //necessary, but just fun and for practice.
        public void WriteOwnerName()
        {
            Console.WriteLine(_OwnerName);
        }

        //Here is the ownername data member declaration. Notice how this one is private
        //because right now there is no class that is going to inherit from Dog. If you
        //decide to make child classes like "Poodle" and "Pitbull" that inherit from dog, 
        //you will want to change this to protected
        private string _OwnerName;
        public string OwnerName
        {
            //set the owner name
            set { _OwnerName = value; }
            //get the owner name 
            get { return _OwnerName; }
        }
    }
}
