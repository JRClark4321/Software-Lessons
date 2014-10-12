/**************************************************************************************
 * Author:      Jeffrey Clark
 * Class:       Animal
 * Purpose:     To be the base/super/parent class
 *************************************************************************************/

//This will include a basic library called "System". In this context, we are using for
//the "Console" class.  If you comment the line out below, you can see that Visual Studio 
//no longer knows what the "Console" class is!
using System;

//Namespaces can hold multiple classes and can be used in multiple files.
namespace Beginner_OOP_Inheritance_Functions
{

    //This is the declaration of the class
    public class Animal
    {
        //Each animal made will be a part of the animal kingdom. Functions will almost always be "Public"
        //It is "void" because there is nothing to return
        public void SayKingdom() 
        {
            Console.WriteLine("I am an Animal");
        }

        //This function is "virtual", because we want the child classes to override this function.
        //For instance, look at the "Cat.cs" class. The keyword "virtual" must be in the function
        //declaration to allow for it to be overridden.
        public virtual void Speak()
        {
            Console.WriteLine("Loud Noises!");
        }

        //Here we are declaring a data member. It is "protected" instead of private, because
        //"protected" allows the children classes to also see this data member
        protected int _NumberOfLegs;

        //This is what we call a "getter". It will "get", also known as "return" the desired data member.
        //It only has one reason to exist, and that is to return the data member. Getters usually begin
        //with the word "Get".
        public int GetNumberOfLegs()
        {
            return _NumberOfLegs;
        }


        //This is what we call a "setter". It will "set" the desired data member to the value that
        //is passed into the function. Setters usually begin with the word "Set"
        public void SetNumberOfLegs(int numberLegs)
        {
            _NumberOfLegs = numberLegs;
        }
        

        //Same as the "_NumberOfLegs" variable above.
        protected string _FavoriteToy;

        //Here we are doing a short-hand for the getter and setter above. When used, the function(s)
        //will not begin with "Set" or "Get", but rather just "FavoriteToy". The compiler will
        //interpret whether it should use the get or set function on the fly. For instance,
        //grumpyCat.FavoriteToy = 3 will call the setter, and Console.Writeline(grumpyCat.FavoriteToy)
        //will call the getter.
        public string FavoriteToy
        {
            //set the owner name
            set { _FavoriteToy = value; }
            //get the owner name 
            get { return _FavoriteToy; }
        }
    }
}
