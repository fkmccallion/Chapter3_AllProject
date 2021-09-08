using System;

//// Display a simple message to the user.
//Console.WriteLine("***** My First C# App *****");
//Console.WriteLine("Hello World!");
//Console.WriteLine();

//// Wait for Enter key to be pressed before shutting down.
//Console.ReadLine();


// Note we are explicitly returning an int, rather than void.
// Display a message adn wait for Enter key to be pressed.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine();
// Process any incoming args.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}
Console.ReadLine();

// Return an arbitrary error code.
return 0;

