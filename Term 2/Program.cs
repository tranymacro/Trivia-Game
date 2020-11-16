using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Terms
{
    class Program

    {

        public static string [] testQuestins = new string[10];
        public static string [] testAnswer = new string [10];
        public static string [] userAnswer = new string [10];



        static void Main(string[] args)

            
        {


            WriteLine("Hello insert person name here and welome to my game where\n you will learn some of the basics terms of C# ");
            WriteLine("\nPress enter to continue");
            ReadLine();


            int choose;

            WriteLine("If you are ready to start enter 1 two time to confirm\nif not and you want to stop the game enter 2");
            _ = Convert.ToInt32(ReadLine());

            try
            {
                choose = Convert.ToInt32(ReadLine());

                switch (choose)
                {


                    case 1:
                        Clear();
                        setTest();

                        break;

                    case 2:


                       
                Environment.Exit(0);
                        break;

                    default:
                        WriteLine("Can not be done");


                        break;

                }

            }
            catch
            {
                WriteLine("Can not be done");
                ReadLine();
            }







        }
        private static void setTest()
        {
            string question1, question2, question3, question4, question5, question6, question7, question8, question9, question10;

            Write("\n What is the difference between public, static, and void?:");
            question1 = ReadLine();

            Write("\nWhat is an object? :");
            question2 = ReadLine();

            Write("\n Can a private virtual method can be overridden? 3 :");
            question3 = ReadLine();

            Write("\nWhat's the difference between the System.Array.CopyTo() and System.Array.Clone() ?:");
            question4 = ReadLine();

            Write("\nIs C# code is managed or unmanaged code? :");
            question5 = ReadLine();

            Write("\nWhat is Console application? :");
            question6 = ReadLine();

            Write("\nWhat is a loop? :");
            question7 = ReadLine();

            Write("\nWhat is a Do/While Loop?:");
            question8 = ReadLine();

            Write("\nWhat is array element c#?:");
            question9 = ReadLine();

            Write("\nWhat is array index number c#? :");
            question10 = ReadLine();




            testQuestins[0] = question1;
            testQuestins[1] = question2;
            testQuestins[2] = question3;
            testQuestins[3] = question4;
            testQuestins[4] = question5;
            testQuestins[5] = question6;
            testQuestins[6] = question7;
            testQuestins[7] = question8;
            testQuestins[8] = question9;
            testQuestins[9] = question10;

            WriteLine("Test question: " + testQuestins[0] + "\nquestion2" + testQuestins[1]
                + "\nquestion2" + testQuestins[2]
                + "\nquestion2" + testQuestins[3]
                + "\nquestion2" + testQuestins[4]
                + "\nquestion2" + testQuestins[5]
                + "\nquestion2" + testQuestins[6]
                + "\nquestion2" + testQuestins[7]
                + "\nquestion2" + testQuestins[8]
                + "\nquestion2" + testQuestins[9]);

            ReadLine();

            testQuestins[0] = question1;
            testQuestins[1] = question2;
            testQuestins[2] = question3;
            testQuestins[3] = question4;
            testQuestins[4] = question5;
            testQuestins[5] = question6;
            testQuestins[6] = question7;
            testQuestins[7] = question8;
            testQuestins[8] = question9;
            testQuestins[9] = question10;



           
            createAnswers();




        }




        private static void createAnswers()
        {
            string answerQ1, answerQ2, answerQ3, answerQ4, answerQ5, answerQ6, answerQ7, answerQ8, answerQ9, answerQ10;


            WriteLine("\n\n=================Show test answes");


            Write("\n1 Public declared variables or methods are accessible anywhere in the application. Static declared variables or methods are globally accessible without creating an instance of the class.\n " +
                "Static member are by default not globally accessible it depends upon the type of access modified used.\n" );
            answerQ1 = ReadLine();

            Write("\n2 An object is an instance of a class through which we access the methods of that class. \n");
            answerQ2 = ReadLine();

            Write("\n3 No, because they are not accessible outside the class. \n");
            answerQ3 = ReadLine();

            Write("\n4 Using Clone() method, we creates a new array object containing all the elements in the original Array and using CopyTo() method. \n");
            answerQ4 = ReadLine();

            Write("\n5 C# is managed code because Common language runtime can compile C# code to Intermediate language.\n");
            answerQ5 = ReadLine();

            Write("\n6 A console application is an application that can be run in the command prompt in Windows. For any beginner on .Net, \n" +
                "building a console application is ideally the first step, to begin with. \n");
            answerQ6 = ReadLine();

            Write("\n7 Loops can execute a block of code as long as a specified condition is reached.\nLoops are handy because they save time, reduce errors, and they make code more readable.\n");
            answerQ7 = ReadLine();

            Write("\n8 The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true,\n" +
                " then it will repeat the loop as long as the condition is true. \n");
            answerQ8 = ReadLine();

            Write("\n9 Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value. \n");
            answerQ9 = ReadLine();

            Write("\n10 Arrays in C act to store related data under a single variable name with an index, also known as a subscript. \n");
            answerQ10 = ReadLine();


            testAnswer[0] = answerQ1;
            testAnswer[1] = answerQ2;
            testAnswer[2] = answerQ3;
            testAnswer[3] = answerQ4;
            testAnswer[4] = answerQ5;
            testAnswer[5] = answerQ6;
            testAnswer[6] = answerQ7;
            testAnswer[7] = answerQ8;
            testAnswer[8] = answerQ9;
            testAnswer[9] = answerQ10;

            Clear();
            int choose;

            Write("press [1] to end test.");
            choose = Convert.ToInt32(ReadLine());


            switch (choose)

            {
                case 1:

                    Environment.Exit(0);


                    break;

                case 2:

                    



                    break;

                default:


                    break;

            }



        }

        private static void playerTakequiz()
        {
            string playerAnwserQ1, playerAnwserQ2, playerAnwserQ3, playerAnwserQ4, playerAnwserQ5, playerAnwserQ6, playerAnwserQ7, playerAnwserQ8, playerAnwserQ9, playerAnwserQ10;
            Write("Enter your answer: ");
            playerAnwserQ1 = ReadLine();

            Write("\nQuestion 2: " + testQuestins[1]);
            Write("Enter your answer: ");
            playerAnwserQ2 = ReadLine();

            Write("\nQuestion 3 " + testQuestins[2]);
            Write("Enter your answer: ");
            playerAnwserQ3 = ReadLine();

            Write("\nQuestion 4: " + testQuestins[3]);
            Write("Enter your answer: ");
            playerAnwserQ4 = ReadLine();

            Write("\nQuestion 5: " + testQuestins[4]);
            Write("Enter your answer: ");
            playerAnwserQ5 = ReadLine();

            Write("\nQuestion 6: " + testQuestins[5]);
            Write("Enter your answer: ");
            playerAnwserQ6 = ReadLine();

            Write("\nQuestion 7: " + testQuestins[6]);
            Write("Enter your answer: ");
            playerAnwserQ7 = ReadLine();

            Write("\nQuestion 8: " + testQuestins[7]);
            Write("Enter your answer: ");
            playerAnwserQ8 = ReadLine();

            Write("\nQuestion 9: " + testQuestins[8]);
            Write("Enter your answer: ");
            playerAnwserQ9 = ReadLine();

            Write("\nQuestion 10: " + testQuestins[9]);
            Write("Enter your answer: ");
            playerAnwserQ10 = ReadLine();


            testAnswer[0] = playerAnwserQ1;
            testAnswer[1] = playerAnwserQ2;
            testAnswer[2] = playerAnwserQ3;
            testAnswer[3] = playerAnwserQ4;
            testAnswer[4] = playerAnwserQ5;
            testAnswer[5] = playerAnwserQ6;
            testAnswer[6] = playerAnwserQ7;
            testAnswer[7] = playerAnwserQ8;
            testAnswer[8] = playerAnwserQ9;
            testAnswer[9] = playerAnwserQ10;


            WriteLine("Test Anwer Here: " + testAnswer[0] +
                "\nAnwers 2:" + testAnswer[1] +
                "\nAnwers 3:" + testAnswer[2] +
                "\nAnwers 4:" + testAnswer[3] +
                "\nAnwers 5:" + testAnswer[4] +
                "\nAnwers 6:" + testAnswer[5] +
                "\nAnwers 7:" + testAnswer[6] +
                "\nAnwers 8:" + testAnswer[7] +
                "\nAnwers 9:" + testAnswer[8] +
                "\nAnwers 10:" + testAnswer[9]);

            ReadLine();









        }
    }

}


