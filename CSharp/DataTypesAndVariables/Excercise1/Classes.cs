using System.Collections.Generic;
using System;
namespace DataTypesAndVariables.Excercise1
 {
    //create a class called Human
    public class Human {
        //add two properties. One is a string and it should be called FirstName with a public get and a private set the other is an int and should be Age
        public String FirstName { get; private set; }
        public int age { get; set; }

        //Add a default constructor that sets the FirstName property to Crowley and then add a constructor that takes in a string and sets the FirstName property
        public Human()
        {
            FirstName = "Crawley";
        }

        public Human(String name)
        {
            FirstName = name;
        }

        //create methods
        //create a method called UpdateAge that takes in an integer and sets Age to that value
        public void UpdateAge(int number)
        {
            age = number;
        }

        //create another method called NameMashup that takes in a string lastName
        //   inside this method, create a variable called mashup and display it to the screen
        public void NameMashUp (string lastname)
        {
            string mashup = FirstName + lastname;
            Console.WriteLine($"{mashup}");
        }
    }

    public class Classes
    {
        public static void Main(string[] args)
        {
            //Todo in answer code, explain diff between variable and properties

            //instance of a class/object
            //Now that you have defined a class (Human), create an instance of Human called dean and use the default/no argument constructor
            Human dean = new Human("Dean");

            //then create another instance called sam but use the constructor that takes a string argument
            Human sam = new Human();

            //invoke the method UpdateAge on both of your instances, provide different values for both and then print the age of each instance
            dean.UpdateAge(31);
            sam.UpdateAge(32);


            //sam.FirstName = "sam"; will not work because set is private

            Console.WriteLine(sam.FirstName);
            Console.WriteLine(dean.age);
            Console.WriteLine(sam.age);

            //invoke the method NameMashup for both of your instances
            dean.NameMashUp("John");
            sam.NameMashUp("Josh");
            //todo in answer code, describe difference between reference and primitive types
            //use class from other namespace
            //In the SolutionExplorer, under DataTypesAndVariables project, create a new file in the DiffNamespace folder
            //In that file, define a class with 3 properties and a default constructor. Set the properties in the constructor
            //Back in your main program, create an instance of that newly created class and display the variables on the screen
        }
    }
}
