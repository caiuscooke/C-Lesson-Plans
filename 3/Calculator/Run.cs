using System;
/* From here on out, every new C# file we make will start with this using System; line.
 * Don't worry too much about what this line does for now. Just know that we'll need it at the top of each file
*/

class CalculatorApp
/* C# files are very organized. Similar to how the computer's file explorer (or finder on MacOS) works, you have a list of folders, that open up into individual files.
 * You can think of our classes in C# as a folder for code. Our classes will store our variables and functions, and pretty much everything that our program will run.
 * The first two things we did as a class (to know Console.WriteLine and variables) were written in a Top-Level format. This just means we didn't use a class or function to 
 * store all of our code. We will rarely make programs like that in C#, so it's good to get used to doing it this way. 
 * To make your class, all you have to write is the keyword "class" and the name of the class. Make sure when you're naming classes, you stick to CamelCase, meaning you
 * capitlize the first letter of each word, and there are no spaces. 
*/

/*
 * Like we said earlier, each line ends with a ; except for a few things. Classes are not ended with a ; but a pair of {} instead. If you recall, a ; in C# is known as an end-statment. 
 * Since classes are basically a folder for a lot of code, it makes sense the we don't use an end statement here, because we are not trying to tell C# to stop here. 
 * Brackets in C# are the way we tell the computer to treat the code between {} as one thing storing a lot of code. In the same way, your file browser can have a folder called Applications
 * with a bunch of apps in them. Each app can be thought of as a line of code, ending with a ; because your file browser can't go any further when you double-click that app.
 * The folder called Applications, however, is like our classes. When you double click on it, you see it storing a bunch of apps. Here is a visual representation of that.
 * 
 * Applications
 * {
 *      Minecraft;
 *      MicrosoftWord;
 *      GoogleChrome;
 *      Steam;
 *      VisualStudio;
 * }
 * 
 * The ending bracket } is telling our computer that this is the end of the classes' (or folder, in our analogy) contents. 
 * Putting something beneath the last bracket is known as being out-of-scope. Like this.
 * 
 * Applications
 * {
 *      Minecraft;
 * }
 * MicrosoftWord;
 * 
 * We want to make sure that we keep things in the scope we want them to be in. Let's now take a look at our first function. 
*/
{
    static void Main(string[] args)
    /* 
     * This is our first function we are going to define. Defining a function and a class are a little different, but the concept used before is the same.
     * A class is still like a folder, but it's a folder with other folders inside of it. In code, our classes hold functions, and those functions have the code
     * that will be run by our computer. Right now we're defining a special kind of function called the Main function. When we declare a main function, we're
     * telling the computer to start running our program with the code between this main function's brackets. The way it's written may be scary at first,
     * but we'll write this static void Main(string[] args) part so many times you'll never forget it. For now, don't worry about the specific meaning behind each word,
     * just know this is where we're going to make our first program. 
    */
    {
        /* Let's get started making our calculator app! What are some things you think we'll need? Our calculator will be very basic. It will take the numbers the 
         * user wants to do math with in seperate lines, and the operation (aka addition or subtraction) will be in the third line the user takes. 
         * Try to pseudocode it out with comments like this.
         * 
         * 1. Variable to store the user's input for the first number
         * 2. Variable to store the user's input for the second number
         * 3. Varaible to store the user's operation
         * 4. If the variable storing the user's operation is addition, the write into the Console the two number variables added together
         * 5. Repeat Line 4 for each operation (subtraction, multiplication, division)
         * 
         * Make sense? If so, go ahead and write out your code.
        */
        
        Console.WriteLine("Welcome to the Calculator app. Write the equation you need solved.");

        Console.Write("Enter first number: ");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        /*
         * This is something new, and if you got this first try, congrats! You may have ran into the problem of trying to figure out how to get an int from a Console.ReadLine()
         * By default, the Console.ReadLine can only accept a string. So trying to write
         * int firstNum = Console.ReadLine() 
         * is impossible. The creators of this language knew that people weren't going to only try to input a string, so they made the Convert.ToInt32 function.
         * This function takes a string, and if it's possible, convert that to an Int. 
        */
        Console.Write("Enter second number: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter your operation. Type + for addition, - for subtraction, * or x for multiplication, and / for division.");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine(firstNum + secondNum);
        }
        else if (operation == "-")
        {
            Console.WriteLine(firstNum - secondNum);
        }
        else if (operation == "*" || operation == "x")
        {
            Console.WriteLine(firstNum * secondNum);
        }
        else if (operation == "/")
        {
            Console.WriteLine(firstNum / secondNum);
        }
        else
        {
            Console.WriteLine("I don't understand that operation! Please run again and enter a different operation.");
        }
    }
}
