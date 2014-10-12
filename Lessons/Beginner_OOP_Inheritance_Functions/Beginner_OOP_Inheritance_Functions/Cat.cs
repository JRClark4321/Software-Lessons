/**************************************************************************************
 * Author:      Jeffrey Clark
 * Class:       Cat
 * Purpose:     To show the basic concept of objects/classes, and using functions
 *              in an Object-Oriented enviornment. Also to show the concept of
 *              inheritance and overriding an abstract/virtual parent function
 *************************************************************************************/
using System;

namespace Beginner_OOP_Inheritance_Functions
{
    //The ":" means that Cat will inherit from Animal. Cat has access to EVERYTHING that Animal
    //has, and is only overriding the Speak() function of Animal.
    class Cat : Animal
    {
        //THe override keyword means that it will use this function instead of Animal's Speak() function
        public override void Speak()
        {
            Console.WriteLine("I am a Cat!");
        }
    }
}
