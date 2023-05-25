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
         * By default, the Console.ReadLine can only accept a string. This is a problem for our calculator because if you recall, using the + operator with strings
         * does concatenation, not addition. So unless you wanted your users' numbers to be smashed together like "1010" you'll need to convert this to an Int. But, trying to write
         * int firstNum = Console.ReadLine() 
         * is impossible. The creators of this language knew that people weren't going to just need strings from input, so they made the Convert.ToInt32 function.
         * This function takes a string, and if it's possible, convert that to an Int. The "32" part of this just means it is an int that takes up 32 bits of RAM (or 4 bytes). 
         * 
         * Also, you may have noticed that I'm using Console.Write() here instead of WriteLine. This is just a stylistic choice I made. Console.WriteLine() will move the users cursor
         * to the next line after the string between () gets written. Console.Write() does not move the cursor to the next line. Try to use both Console.WriteLine() and Console.Write() to 
         * see the difference.
        */
        Console.Write("Enter second number: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter your operation. Type + for addition, - for subtraction, * or x for multiplication, and / for division.");
        string operation = Console.ReadLine();

        /*
         * Up next we have if statements. If statements check whether a condition is True or False, and executes or doesn't execute the code based on what it finds.
         * For instance, we know that 1 + 1 = 2 is a true statement. So, if you put If (1 + 1 = 2) in a metaphorical If-statement, the code between the {} would run.
         * However, I said that was metaphorical specifically because we wouldn't use "=" in If statements. In coding, there are many key words and symbols that have a specific function.
         * We've already seen quite a lot like int, string, class, void, and even the {} and ;. The = symbol is also a special symbol used for making variables. In math, the equals sign is used
         * to compare two things. The math statement 1 + 1 = 2 is comparing the left side of the equals symbol to the right side. If the left side and the right side are the same after the calculation,
         * we say that it equals that thing and that the left side equalling the right side is true. In coding, the = symbol does not compare things, it is known as the assignment operator. 
         * The assignment operator in coding tells the computer to take the information on the right side of the equals sign, and store it in the name on the left side of the equals sign. If you want
         * to compare two things the way we do in math, we use the == operator. So, based on our earlier example, it would actually be written like 
         * 
         * if (1 + 1 == 2) 
         * { 
         *      do some code 
         * }
         * 
         * But in our case we don't have just one condition. We need to check multiple conditions, because there are 4 operations the user can do in math. So, how do we check multiple conditions? Well,
         * the most simple version of this is using the Else keyword. Else immediately follows the If statement, and tells the computer that if the condition in the if() part is false, always do this
         * instead. You can think of this as a kind of default code that should be ran. Here's an example
         * 
         * if (operation == "+")
         * {
         *      Console.WriteLine(firstNum + secondNum);
         * }
         * else 
         * {
         *      Console.WriteLine("I only know how to do addition right now.");
         * }
         * 
         * This If-Else statement says if the operator the user inputs is a plus symbol, then write the two numbers added together in the console. But, if they write anything other than a plus symbol,
         * write "I only know how to do addition right now." to the console. In a lot of cases, all you need is the If-Else. In our case, we need to check 4 conditions. 
         * 
         * else if is a key word in C# that basically just adds another condition to check for. This is perfect for our calculator. The way an If-Else If works is the same as the rest of code, meaning
         * it is a line by line process, from top to bottom. Our computer will go line by line and check the topmost condition. In what I have written, the condition that is being checked first is if the 
         * operation variable is a plus symbol. If that is false, then it'll check the next condition, and so on until it finds one that is true. If none of them are true, it will execute the code in 
         * the else statement. 
        */
        if (operation == "+")
        {
            Console.WriteLine(firstNum + secondNum);
        }
        else if (operation == "-")
        {
            Console.WriteLine(firstNum - secondNum);
        }
        else if (operation == "*" || operation == "x")
        /*
         * This condition has something you have not seen before. The symbol || is the way we say OR in C#. By this, I mean you can check if two conditions are true. The way an OR keyword functions is by
         * checking both sides of the || symbol, and if either one of them are true the code below will execute. When you use ||, only ONE condition needs to be met for the code to execute. If you needed
         * to check if BOTH conditions are true, you would use the && symbol. For our case, we want to accept the user entering * or x to mean multiplication, so if the operation variable has either 
         * of those strings stored, then our code will write the product in the console.
        */ 
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
        // It's worth noting that you don't need an else or else if to have a functioning if statement. You can have just one if(){} and have functioning code, depending on your application. 
    }
}
