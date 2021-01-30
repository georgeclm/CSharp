using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome to the Final Exam Program. There is 2 file .cs in this program the other one for my movie class that i create in new .cs
            int k = 1;
            int limit = 0;
            int seclimit = 0;
            bool valid = true;
            bool maxLimit = true;
            Console.WriteLine("Welcome to my final project");
            Console.WriteLine("First program is create a table base on your row and column (number)");
            Console.WriteLine("Note that you are going to input all the number inside the table so i limit it to maximum 5,5 row and column");
            Console.WriteLine("I add a feature if your row and column is same then i will count the diagonal difference");
            // use this while valid to keep repeating ask for invalid input and combine it with try catch for any invalid input the program will keep repeating so when the user input and invalid input it wont exit the program
            // there is a lot of validation while loop in this program becasue for wrong input the program will crash so to prevent that it use a lot of validation input
            while (valid) 
            {
                try
                { 
                    do
                    {
                        // user input for the row and then store it 
                        Console.Write("Enter how many rows: ");
                        limit = Convert.ToInt32(Console.ReadLine());
                        // column input
                        Console.Write("Enter how many columns: ");
                        seclimit = Convert.ToInt32(Console.ReadLine());
                        // limit for the value will repeat
                        if(limit > 5 || seclimit > 5)
                        {
                            Console.WriteLine("Invalid input number range from 1-5 ");
                            maxLimit = true;
                        }
                        else
                        {
                            if (limit <= 0 || seclimit <= 0) 
                            {
                                Console.WriteLine("Invalid negative number or zero ");
                                maxLimit = true;
                            }
                            else
                            {
                                // exit the function if got the value 
                                maxLimit = false;
                            }
                        }
                        // use 2 while loop for the exception error input and the limit value inside 
                    } while (maxLimit);
                    valid = false;
                }
                catch 
                {
                    // wrong input will repeat
                    Console.WriteLine("Wrong Input");
                    valid = true;
                }
            }
            // create the 2d array for the matrix 
            double[,] array = new double[limit, seclimit];
            Console.WriteLine("Enter your number inside : ");
            bool validdd = true;
            // for validation input
            while (validdd)
            {

                try
                { 
                    // loop for the array inside to take all the user input inside the matrix 2d array
                    // first layer
                    for (int i = 0; i < limit; i++)
                    {
                        // second layer
                        for (int j = 0; j < seclimit; j++)
                        {
                            array[i, j] = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("{0} stored", array[i,j]);
                        }
                    }
                    validdd = false;
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }
            }
            // to output all the user input also create the sum of all the number and the rasio function for postive negative and zero
            double otherresult = 0;
            double positive = 0;
            double negative = 0;
            double zero = 0;

            foreach (double a in array){
                Console.WriteLine("Your Input Number inside the array is {0}: {1}",k, a);
                k += 1;
                otherresult += a;
                if (a == 0)
                {
                    zero += 1;
                }
                else if (a > 0)
                {
                    positive += 1;
                }
                else
                {
                    negative += 1;
                }

            }
            // to check if same then take diagonal diff
            if (limit == seclimit)
            {           
                Console.WriteLine("Okay your row and column is the same (press Enter) ");
                Console.ReadLine();
                // variable
                double prim = 0;
                double sec = 0;
                double result = 0;
                // take all the value inside the array diagonally 
                for (int l = 0; l < limit; l++)
                {
                    // input the value diagonally use logic array value
                    prim += array[l, l];
                    sec += array[l,limit- l- 1];
                }
                // take the absolute result because this take the difference
                result = Math.Abs(prim - sec);
                Console.WriteLine("The diagonal diiference from your table is {0}", result);
            }
            // if the row and column is not the same the diagonal is not logical because there will be a row or column that is not used
            else
            {

                Console.WriteLine("Well your row and column is not same so instead iam going to sum all your number (press Enter)");
                Console.ReadLine();
                Console.WriteLine("The total of all the number you have inputed is {0}", otherresult);
            }
            // make the function to take all the positive negative and zero and create the percentage
            Console.WriteLine("Now i am going to count the ratios of your number that are positive, negative and zero (press Enter)");
            Console.ReadLine();
            double thepositive = positive / array.Length *100;
            double thenegative = negative / array.Length *100;
            double thezero = zero / array.Length *100;
            Console.WriteLine("The ratio of positive in your table is {0} %", thepositive);
            Console.WriteLine("The ratio of negative in your table is {0} %", thenegative);
            Console.WriteLine("The ratio of zero in your table is {0} %", thezero);
            Console.ReadLine();
            // for rock paper scissors game
            string inputPlayer, playAgain, drawPlay;
            int randomPick;
            int playerScore = 0;
            int compScore = 0;
            bool play = true;
            Console.WriteLine("Now lets play a litte rock, paper, scissors game (press Enter)");
            Console.ReadLine();
            bool trueinput = false;
            // for validation
            while (play) 
            {
                do
                {
                    Console.WriteLine("Choose between\n(r) Rock \n(p) Paper \n(s) Scissors ");
                    inputPlayer = Console.ReadLine().ToLower();
                    // take random value from c# function 
                    Random theRandom = new Random();
                    // add range for the random number
                    randomPick = theRandom.Next(1, 4);
                    // switch case for the game
                    switch (randomPick)
                    {
                        case 1:
                            if (inputPlayer == "r")
                            {
                                Console.WriteLine("Both Rock then it is a draw !!");
                                trueinput = false;

                            }
                            else if (inputPlayer == "p")
                            {
                                Console.WriteLine("Paper covers Rock You Winn!!");
                                playerScore++;
                                trueinput = false;

                            }
                            else if (inputPlayer == "s")
                            {
                                Console.WriteLine("Scissors is broken by rock You Lose !!");
                                compScore++;
                                trueinput = false;

                            }
                            else
                            {
                                Console.WriteLine("Invalid input choice");
                                trueinput = true;

                            }
                            break;
                        case 2:
                            if (inputPlayer == "r")
                            {
                                Console.WriteLine("Rock is covered by Paper You Lose!!");
                                compScore++;
                                trueinput = false;

                            }
                            else if (inputPlayer == "p")
                            {
                                Console.WriteLine("Both Paper then it is a draw");
                                trueinput = false;

                            }
                            else if (inputPlayer == "s")
                            {
                                Console.WriteLine("Scissors cut paper You win!!");
                                playerScore++;
                                trueinput = false;

                            }
                            else
                            {
                                Console.WriteLine("Invalid input choice");
                                trueinput = true;

                            }

                            break;
                        case 3:
                            if (inputPlayer == "r")
                            {
                                Console.WriteLine("Rock breaks Scissors You Win!!");
                                trueinput = false;

                                playerScore++;
                            }
                            else if (inputPlayer == "p")
                            {
                                Console.WriteLine("Paper is cut by Scissors You Lose!!");
                                trueinput = false;

                                compScore++;
                            }
                            else if (inputPlayer == "s")
                            {
                                Console.WriteLine("Both Scissors then it is a draw");
                                trueinput = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input choice");
                                trueinput = true;
                            }
                            break;
                        default:
                            break;
                    }
                } while (trueinput);
                // input the score
                Console.WriteLine("Score now is you {0} against the computer genius {1}", playerScore, compScore);
                bool otherValidation = true;
                bool theotherValidation = true;
                // validation for the user input 
                while (otherValidation) 
                { 
                    // ask to play again or not
                    Console.WriteLine("Do You want to play again \n(Y) Yes  \n(N) No");
                    playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "y")
                    {
                        play = true;
                        otherValidation = false;
                    }
                    else if (playAgain == "n")
                    {
                        // validation for the endgame 
                        otherValidation = false;
                        // for user win game
                        if (playerScore > compScore)
                        {
                            Console.WriteLine("Well thats the end of the game and I admit my loss");
                            play = false;

                        }
                        // for computer win game
                        else if (compScore > playerScore)
                        {
                            Console.WriteLine("See, you cant beat the computer genius");
                            play = false;

                        }
                        // for draw game ask to play again
                        else
                        {
                            while (theotherValidation)
                            { 
                                Console.WriteLine("Nobody win the game yet you really just going to leave? Coward \n(Y) Yes \n(N) Not a chance ");
                                drawPlay = Console.ReadLine().ToLower();
                                // quit the game 
                                if (drawPlay == "y")
                                {
                                    theotherValidation = false;
                                    Console.WriteLine("Well good game");
                                    play = false;
                                }
                                // play again the game
                                else if (drawPlay == "n")
                                {
                                    theotherValidation = false;
                                    Console.WriteLine("I know you are not going to just leave");
                                    play = true;
                                }
                                // invalid input
                                else
                                {
                                    theotherValidation = true;
                                    Console.WriteLine("Invalid input only Y or N");
                                }

                            }
                        }
                    }
                    else
                    {
                        // invalid input
                        Console.WriteLine("Invalid Input only Y or N");
                        otherValidation = true;
                    }
                
                }
            }
            // for the movie class function
            Console.WriteLine("Now i already create a class template for movie and you can fill it with your favorite movie");
            Console.WriteLine("This use class Movie, constructors and getters and setters on the ratings so the rating is not editable (press Enter)");
            Console.ReadLine();
            bool movieAgain = true;
            bool anotherValidation = true;
            // validation to create class again or not
            while (movieAgain)
            {

                Console.Write("The title of the movie: ");
                string thetitle = Console.ReadLine();
                Console.Write("The main character of the movie: ");
                string themainCharacter = Console.ReadLine();
                Console.Write("The rating of the movie it is only allowed with this input (G, PG-13, R, NC-17, PG,NR): ");
                string therating = Console.ReadLine().ToUpper();
                // constructor inside the class and input all user input using the constructor inside the class
                Movie movie1 = new Movie(thetitle, themainCharacter, therating);
                // print the class user input using the print
                movie1.printMovie();
                anotherValidation = true;
                // to honorable mention loop
                while(anotherValidation)
                { 
                    Console.WriteLine("Want to mention other movie or your honorable mention? \n(Y) Yes \n(N) No");
                    string thevalid = Console.ReadLine().ToLower();
                    if (thevalid == "y")
                    {
                        anotherValidation = false;
                        movieAgain = true;
                    }else if (thevalid == "n")
                    {
                        // after user done input my favorite
                        Console.WriteLine("Then now my favorite movie");
                        Movie mymovie = new Movie("Wonder Woman 1984", "Wonder Woman", "PG");
                        // print my favorite movie
                        mymovie.printMovie();
                        anotherValidation = false;
                        movieAgain = false;
                    }
                    // for invalid input case
                    else
                    {
                        Console.WriteLine("Invalid Inputt");
                        anotherValidation = true;
                    }
                }
            }
            // sum 4 out of 5
            Console.WriteLine("Now i am going to count the biggest total of 4 out of 5 number you give to me the biggest and the smallest (press Enter)");
            Console.ReadLine();
            // create the array with my set of maximum length
            double[] sumArray = new double[5];
            double sum = 0;
            Console.WriteLine("Input your 5 number: ");
            bool validd = true;
            // validation input
            while (validd)
            {
                try
                {       
                    // ask input loop to fill the array also add the sum
                    for (int l = 0; l < 5; l++)
                    {
                        sumArray[l] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} stored", sumArray[l]);
                        sum += sumArray[l];

                    }
                    // the logic to create the highest sum from 4 and the lowest by minus max then it will be the smallest sum and minus min it will be the biggest sum
                    // but this trick only work with 5 array of maximum, this simple logic 
                    double smallest = sum - sumArray.Max();
                    double highest = sum - sumArray.Min();
                    // print the value
                    Console.WriteLine("Your highest 4 total number  out of 5 is {0} and the lowest sum is {1}", highest,smallest);
                    validd = false;
                }
                catch
                {
                    // for invalid 
                    Console.WriteLine("Wrong Input");
                }
            }
            // for the grading system logic
            Console.WriteLine("Now the next one is a grading system that round from 83 to 85 but wont round if the grade is below 38 ");
            Console.WriteLine("It will round if the difference bwetween the grade and the next multiple of 5 is less than 3");
            Console.WriteLine("It will be great if you use this grading system for your student, they will thank you... (press Enter)");
            Console.ReadLine();
            bool tryvalid = true;
            int studentCount = 0;
            // for validation input 
            while (tryvalid) { 
                // limit the maximum grade because user have to input all the grade
                Console.Write("Input how many students you want to grade (Max 50): ");
                studentCount = Convert.ToInt32(Console.ReadLine());
                if(studentCount > 50)
                {
                    Console.WriteLine("Too many students");
                }
                else
                {
                    tryvalid = false;
                }
            }
            // create the array for the user input and the new student grade and length of the student
            double[] grade = new double[studentCount];
            double[] resultGrade = new double[studentCount];
            bool validddd = true;
            int countStudent = 1;

            // for validation input
            while (validddd)
            {
                try
                {
                    // loop for the input inside the array and for the new array 
                    for (int n = 0; n < studentCount; n++)
                    {
                        Console.Write("Input {0} Student Grade: ",countStudent);
                        grade[n] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("{0} grade is {1}",countStudent, grade[n]);
                        countStudent++;
                        /// the logic for every input 
                        if(grade[n] > 37)
                        {
                            if((grade[n] + 1) % 5 == 0)
                            {
                                resultGrade[n] = grade[n] + 1;
                            }
                            else if((grade[n] + 2) % 5 == 0)
                            {
                                resultGrade[n] = grade[n] + 2;
                            }
                            else
                            {
                                resultGrade[n] = grade[n];
                            }
                        }
                        else
                        {
                            resultGrade[n] = grade[n];
                        }

                    }
                    validddd = false;
                }
                catch
                {
                    // for invalid 
                    Console.WriteLine("Wrong Input");
                }
            }
            Console.WriteLine("The result grade for your student is ");
            int countresult = 1;
            // print the new grade user input array 
            for(int o = 0; o < studentCount; o++)
            {
                Console.WriteLine("New {0} grade is {1}", countresult, resultGrade[o]);
                countresult++;

            }
            // logic for the kangaroo game
            Console.WriteLine("Now kangaroo game which your input will be female kangaroo position, female kangaroo jump and male kangaroo");
            Console.WriteLine("I am going to count where  the kangaroos is going to meet or not (press Enter)");
            Console.ReadLine();
            bool validinput = true;
            double x1 = 0;
            double v1 = 0;
            double x2 = 0;
            double v2 = 0;
            // for validation
            while (validinput) 
            {
                try { 
                    // input all user value and store it
                    Console.Write("Female kangaroo position: ");
                    x1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Female kangaroo jump: ");
                    v1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Male kangaroo position: ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Male kangaroo jump: ");
                    v2 = Convert.ToDouble(Console.ReadLine());
                    validinput = false;
                }

                catch
                {
                    Console.WriteLine("Invalid Input");
                    validinput = true;
                }


            }
            /// the logic for the kangaroo game 
            /// i create a function to print the line for each input so dont need to repeat
            if (x2 > x1 && v2 > v1)
            {
                YesorNoKang("NO");
            }
            else
            {
                if(v2-v1 == 0)
                {
                    YesorNoKang("NO");
                }
                else
                {
                    double result = (x1 - x2) % (v2 - v1);
                    if(result == 0)
                    {
                        YesorNoKang("YES");
                    }
                    else
                    {
                        YesorNoKang("NO");
                    }
                }
            }
            /// for breaking the record function
            Console.WriteLine("Now breaking the records program");
            Console.WriteLine("So everytime you broke a new record (number) for the best record and worst I will count how many times you broke the record ");
            Console.WriteLine("For example how many kills each game (press Enter)");
            Console.ReadLine();
            bool forvalid = true;
            // use list because the array have unlimited length that only work by using list 
            List<double> listpoint = new List<double>();
            // validation
            while (forvalid)
            {
                // user input and store it inside the list
                Console.Write("Input your point at the game i.e could  be kill or other: ");
                double value = Convert.ToDouble(Console.ReadLine());
                // add the value to the list that has been created 
                listpoint.Add(value);
                // ask to add more to the list or not 
                Console.WriteLine("Want to input your next game? \n(y) Yes \n(n) No\nother input mean yes");
                string toinput = Console.ReadLine();
                if(toinput.ToLower() == "y")
                {
                    forvalid = true;
                }else if (toinput.ToLower() == "n")
                {
                    forvalid = false;
                }else
                {
                    Console.WriteLine("Invalid Input mean yes");
                }

            }
            // to take all the value inside the list and put it inside new array 
            double[] arraypoint = listpoint.ToArray();
            int breakhigh = 0;
            int breaklow = 0;
            double maxpoint = arraypoint[0];
            double minpoint = arraypoint[0];
            // for each input in the array and use the logic to create the point logic
            foreach(double theinput in arraypoint)
            {
                if(theinput > maxpoint)
                {
                    breakhigh++;
                    maxpoint = theinput;
                }else if (theinput < minpoint)
                {
                    breaklow++;
                    minpoint = theinput;
                }
            }
            // print value for no break
            if(breaklow == 0) { 
                Console.WriteLine("Okay your highest record is {0} and your worst is {1} and you break your best record {2} times and you never break your worst recod. Impressive one",maxpoint,minpoint,breakhigh);
            }
            else
            {
                Console.WriteLine("Okay your highest record is {0} and your worst is {1} and you break your best record {2} times and your worst records {3} times", maxpoint, minpoint, breakhigh, breaklow);

            }
            // for the pairs of divisible number function
            Console.WriteLine("Now you create a list of number and I am going to count total all pairs where the total of the numbers is divisible by your number (press Enter)");
            Console.ReadLine();
            Console.Write("First input your length of array: ");
            int arrlength = Convert.ToInt32(Console.ReadLine());
            // make the array and input the length of the array
            double[] countarray = new double[arrlength];
            // for loop for input inside the array
            for(int i = 0 ; i < arrlength; i++)
            {
                Console.Write("Input your number: ");
                countarray[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0} Stored", countarray[i]);
            }
            // ask for the dividers
            Console.Write("Now input your the number to divide the sum by: ");
            double divided = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            // the logic for this function to count all pairs that can happened and if divided by the number completly then print the count
            for(int z = 0; z< arrlength; z++)
            {
                for(int y = z+1; y< arrlength; y++)
                {
                    if((countarray[z] + countarray[y]) % divided == 0)
                    {
                        Console.WriteLine("{0} and {1} is divisible by {2}",countarray[z],countarray[y],divided);
                        count++;
                    }
                }
            }
            Console.WriteLine("The total sum pairs that can be divided by your number is {0} pairs", count);
            Console.WriteLine("You reach the end of our journey.That is it for all my program for final exam");
            Console.WriteLine("Thank you. For all the code is inside the Program cs and also commentary and there is 1 class for the movie inside Movie.cs ");
            Console.WriteLine("For all the logic that i made it is based on the question that i already answered on the hackerrank platform in python language");

            Console.ReadLine();

        }
        // the function to print out result so dont need to repeat 
        static void YesorNoKang(string answer)
        {
            if (answer == "NO")
            {
                Console.WriteLine("Your kangaroo wont meet. That is sad");
            }
            else
            {
                Console.WriteLine("Your kangaroo will meet. Cheer for them");
            }
        }

    }
}
