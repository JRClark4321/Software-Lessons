/*****************************************************************************
 * Author:      Jeffrey Clark
 * FileName:    Beginner_OOP_Inheritance_Functions
 * Purpose:     To teach the basic principles of a Namespace/Library, Objects, 
 *              Inheritance, and how to use them.
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_OOP_Inheritance_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //A new cat default. This calls the default constructor for Cat.
            Cat grumpyCat = new Cat();

            //Here we are just testing things out. You can see that although we didn't define a function
            //called "SayKingdom" in Cat, it was inherited from Animal.
            grumpyCat.SayKingdom();

            //This will call the Cat's Speak() function instead of Animal's Speak() function
            //because we created an "override" Speak() function in the Cat class.
            grumpyCat.Speak();

            //Here we are testing out writing out the number of legs the animal has to the console screen.
            //We are using the grumpyCat "getter" with the Console.WriteLine function to accomplish it.
            Console.WriteLine(grumpyCat.GetNumberOfLegs());

            //Here, we are using a "setter" to set grumpyCat's number of legs. Just cause, ya know, why not :)
            grumpyCat.SetNumberOfLegs(3);

            //Here, this uses the getter and setter of the Cat class, which is inherited from Animal. Notice how
            //this doesn't use "Get" or "Set" before "FavoriteToy"? If you go back to the Animal class, you will
            //see that the c# shorthand is used for the setter and getter. The Visual Studio compiler will
            //decide on the fly wheter to use the setter or getter. If "FavoriteToy" is on the left side of
            //an "=" sign, it will use the setter. If not, it will use the getter.
            Console.WriteLine(grumpyCat.FavoriteToy);
            grumpyCat.FavoriteToy = "Cat Nip";

            //Just playing around with the different constructors of the Dog class.
            Dog butch = new Dog();
            Dog tripod = new Dog(3);
            Dog sammy = new Dog("Bill");



            Console.WriteLine(tripod.OwnerName);
         }
    }
}
