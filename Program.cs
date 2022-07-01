// See https://aka.ms/new-console-template for more information
//Q1
    // Public
        //Allows the objects to be accessable everywhere in the project files
    // Private
        //only limits the objects to be accessed by the current structure
    // Protected
        //allows object to be accessed in the current structure and any child structures
    // Internal
        //allows the object to be accessed through that current project file
    // Protected Internal
        //allows the object to be accessed through that current project file and any children even if the children aren't in that file
    // Private Protected
        //allows the object to be accessed by the current structure and any children but only if the children are in the same file.
//Q2
    //static
        //allows varible to be accessed through the class and not an object
    //const
        //can't be changed after made, can be accessed through class and not an object
    //readonly
        //can only be initalized or changed in the constructor but can't be changed during run time. only be accessed through object not class
//Q3
    //constructor is a special function that shares the same name as the class and is used to initalize the class fields
//Q4
    //partial allows the implimentation of a class over multiple files. these files get combined to make a single class when complied
//Q5
    //a Tuple is a data type that allow us to store elements like an array or a list but it can hold as many elements as you like and they can be any type.
//Q6
    //record allows for the user to create an object with specific attributes without having to make a class
//Q7
    //Overloading means methods can have the same name but different params and outputs
    //Overridding is when you changed the method entirely
//Q8
    //field
        //varible within the class
    //property
        //lets the user view, change, or execute something related to the field. it's a level of abstraction
//Q9
    //to make a method param optional, you have to set the varible to a value in the param option
    //ex. staic void hello(int i = 0){}
    //here, int i is optional
//Q10
    //interface 
        //only allows you to decalare a method but not define what it does
    //abstract
        //it's a class that cannot make an object and is usually used when you don't want to make an object from a class because you want them to make objects from the child classes
//Q11
    //public by default
//Q12
    //true
//Q13
    //true
//Q14
    //false
//Q15
    //true
//Q16
    //true
//Q17
    //true
//Q18
    //true
//Q19
    //false
//Q20
    //false
//Q21
    //true
//Q22
    //false
//Q23
    //false

using System;
using Antra_HW_05;
//WORKING WITH METHODS
static void Main(string[] args)
{
    //Q1
    int[] numbers = ReverseNums.GenerateNumbers();
    ReverseNums.Reverse(numbers);
    ReverseNums.PrintNumbers(numbers);


    //Q2
    int[] fibseq = FibonacciSeq.fib(10);
    for (int i = 0; i < fibseq.Length; i++)
    {
        Console.WriteLine(fibseq[i]);
    }
    Console.WriteLine(FibonacciSeq.fibLoc(6));

    //DESIGNING AND BUILDING CLASSES USING OBJECT ORIENTED PRINCIPLES
    //Q1,2,3,4,5,6
        //Person class and interface
    //Q7
    Color c1 = new Color(100,240,23);
    Color c2 = new Color(0, 0, 255);
    Color c3 = new Color(130, 0, 255);
    Ball b1 = new Ball(25,c1);
    Ball b2 = new Ball(5, c2);
    Ball b3 = new Ball(15, c3);
    b1.popped();
    b2.throwBall();
    b2.throwBall();
    b2.throwBall();
    b3.throwBall();
    Console.WriteLine(b1.timesThrown());
    Console.WriteLine(b2.timesThrown());
    Console.WriteLine(b3.timesThrown());

}
Main(args);

