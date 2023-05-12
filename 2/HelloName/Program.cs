/* what do you think we'll need to get our program to ask the user's name, then say "Hello ~your name~!"?
 * We're going to do something called pseudocoding before we write the actual code. 
 * Pseudocoding is a word that means 'fake code.' Developers often use pseudocoding to help themselves plan out the logic behind their program.
 * Pseudocoding is also very useful for discovering errors we may have before we even write our code.
 * Just like our code, our pseudocode needs to be written in the order that it will be executed, one line at a time. Let's look at an example for our task.
 * 
 * 1. Write a line telling the user to input their name.
 * 2. Store the name the user inputs in a variable.
 * 3. Write a line that says "Hello ~your name~!"
 * 
 * In this case, pseudocoding is a very short and simple process considering we're making a very simple program. 
 * As we go through this class, your pseudocode will become longer and longer, so it's good to refine your pseudocoding skills early on. 
*/


Console.WriteLine("Welcome to my first C# program. What's your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name + "!");

/* 
 * lets reflect on what we did here. First, we wrote the prompt for the user to input their name.
 * Next, we stored whatever the user typed in a string variable called name.
 * Then, we performed what looks like addition to words.
 * This is known as string concatenation. Anything that is between the quotes turns into the finished line of text.
 * Therefore, if we concatenated "Hello" and "World", what do you think those two would look like?
 * If you guessed that it'd say "HelloWorld" you're correct! 
 * "But why didn't it print "Hello World"?" you may be wondering. It's simply because a string is only the text that is written explicitly. Your code
 * will not automatically add a space. If you want a space between to words, the words have to look like
 * "Hello "
 * "World"
 * Otherwise you'll just be smushing the words together. Now then, let's move on to the next project. We're going to make a simple calculator, and introduce
 * a few things that may seem like a lot at first, but you'll surely get the hang of soon.
*/
