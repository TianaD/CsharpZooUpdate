1. Define what an interface is in your own words


2. Describe what your interfaces are, where are they being implemented, and why. Provide Examples.


3. Updated diagram with your interfaces mapped out.


Here, I have answered the previous questions (via an example).

An interface is a contract that defines the methods and properties that a class must implement. It is a way of specifying the behavior and functionality of a class without providing the implementation details. An interface can be seen as a blueprint or a template for a class.

In my program, I have two interfaces: ISpeakable and IMovable. They are implemented by the concrete animal classes to provide polymorphism and abstraction.

ISpeakable: This interface defines a method called Speak() that returns a string. It is implemented by the BabySeal, Giraffe, and Pigeon classes to provide different sounds for each animal type. For example, the BabySeal class implements the Speak() method as follows:

```csharp
public string Speak()
{
    return "Arf arf!";
}
```

IMovable: This interface defines a method called Move() that returns a string. It is implemented by the BabySeal, Giraffe, and Pigeon classes to provide different movements for each animal type. For example, the Pigeon class implements the Move() method as follows:

```csharp
public string Move()
{
    return "I fly in the sky!";
}
```

Here is an updated diagram with my interfaces mapped out:

![Class Diagram](#graphic_art("a class diagram with Animal, Mammal, Bird, BabySeal, Giraffe, Pigeon, ISpeakable, and IMovable"))

&nbsp;

&nbsp;


## Introduction
The Lab06 - Zoo Console Application is a fun and simple program that simulates a zoo. It shows the basic concepts of Object-Oriented Programming (OOP) by using inheritance, polymorphism, encapsulation, and abstraction to create a hierarchy of animal classes.

## Class Structure
The program's class design is based on an inheritance hierarchy with a base class called Animal and five concrete classes that represent different animals in the zoo. Each concrete class inherits from the Animal class and uses or modifies its properties and methods.

## Features
Animal Class: The Animal class is the base class and defines the common characteristics of an animal, such as Name, Color, NumOfLegs, Sound, and more.

Mammal and Bird Classes: The Mammal and Bird classes are derived from the Animal class. They further refine the animal hierarchy by adding specific behaviors and characteristics for mammals and birds.

Concrete Animal Classes: The program has three concrete animal classes: BabySeal, Giraffe, and Pigeon. These classes represent specific animals in the zoo.

Polymorphism: The Speak(), Eat(), Sleep(), and Move() methods are modified in the concrete classes to provide specialized behavior for each animal type.

Encapsulation: The properties in each class are encapsulated to ensure data security and controlled access.

## How to Use
Copy the repository to your local machine.

Open the solution in a C# compatible IDE, such as Visual Studio.

Go to the Program.cs file in the console application project.

Run the program.

The console will ask you to interact with different animals in the zoo. You can choose options to make each animal speak, eat, sleep, and move.

See how the program shows OOP principles by using inheritance and polymorphism to display different behaviors for each animal type.

Don't forget to run the unit tests!

## Conclusion

The Lab06 - Zoo Console Application provides an interactive and educational experience, showcasing the power of OOP concepts in designing a simple zoo model. It demonstrates the practical applications of inheritance, polymorphism, encapsulation, and abstraction to create a well-structured and maintainable codebase. Enjoy exploring the virtual zoo and understanding the behaviors of various animals in a fun and engaging manner!


###### Courtesy of ChatGPT