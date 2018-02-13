// Notice this is csx (c# script) file. It does not need namespaces, and we generally do not care if it fails compilation
using System.

// Press Ctrl+E, Ctrl+E to evaluate the line in interactive
Console.WriteLine("Hello World");
// If you try to type it out, you will get (limited) intellisense and code completion


// Interactive can also run code that would not normally compile
//"Hello World"

// do some basic operations
//1 + 1
//1 + ""

// assign and call variables
var one = 1;
var two = 2;
Console.WriteLine(one + two);

// Be mindful those variables will get overwritten (and their type may change)
var one = "this now is a string";
one.GetType();

// Interactive has also fairly convenient way of displaying lists:
var sampleList = new[] { 1, 2, 3, 4, 5, 6, 8 };
// sampleList

// and displaying complex records
var obj = new { Name = "Spotlight", Address = "7 Leicester Place", EstablishedIn = new DateTime(1927,1,1)};


// define functions:
public void SayHello(string name) {
    Console.WriteLine($"Hello {name}");
}

SayHello("Ben");

// If you need help
//#help

// useful commands:
//#cls
//#reset

