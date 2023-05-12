//Welcome to C#! Let's go over some of the most basic parts of coding. 

Console.WriteLine("Hello World!"); 
/*Console.WriteLine is how we print things to the console with C#
 * when you write a line in C#, you must finish lines with the end statement semi-colon. There are cases where you don't write a semicolon however. 
 * A semicolon is known as an "end statement." When we look at things like making functions and using loops or if-statements, it'll make sense why we don't use an end-statement there.
 * For now, just always remember to finish a line with a semi-colon
*/

Console.ReadLine(); 
/* Console.ReadLine is how we receive input from the user in the console in C#
 * Not only do we want to write things to the user, but for it to be an application, the user has to be able to interact with your program.
 * The most basic way we can interact with a program on a computer is through typing things out in the console.
 * In fact, almost all software when computers were just starting out were used entirely through typing things in with a keyboard.
*/

// when you declare/assign variables in C#, you need to tell C# which type of data this variable is going to use

int number1  = 0; //int is a number without decimal points, and can be negative or positive
string word1 = "Hello World!"; //string is anything between quotes. This is known as a string because it is a string of characters
string word2 = "10"; //since a string is ANYTHING between quotes, that includes numbers. This may seem confusing, but we'll a look at the different between a string number and int number
float number2 = 0.0f; //a float is a number, but unlike an int, it can accept decimals
bool trueOrFalse = false; //bool is a data type that just accepts the keywords true or false

// there are many more data types than these in C#
// later, we'll look at number types like long, decimal, byte, etc. and see why they are important
// for now, all we need to use are the four above, int, float, string, and bool

// All of these lines with green "//" forward slashes and words after are called comments. Comments are something you should use very often to help yourself understand what your program does.
// Comments do not get run as code. They are purely for the coder to see, and not for the computer to run. 



//let's make a simple program that asks the user's name in the console, and replies with "Hello, ~your name~!"