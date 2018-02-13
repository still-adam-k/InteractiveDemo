// you can do using statements to help with writing and intellisense
using System; // this is actually loaded by default
using System.IO;

// Working with file system. Interactive by default starts in your personal folder:
Console.WriteLine(Directory.GetCurrentDirectory());

// There is no convenient shorcut to get script location directory, so you have to add it manually
Directory.SetCurrentDirectory(@"c:/projects/InteractiveDemo");
Console.WriteLine(Directory.GetCurrentDirectory());


// loading (and executing) other script files:
#load "00_introduction.csx"

// or right click on project and Initialize Interactive with project
// this does change directory to your project, and loads all the code from library and nuget packages

