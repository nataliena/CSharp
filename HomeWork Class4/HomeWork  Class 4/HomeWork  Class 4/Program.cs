using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Class_4
{
    class Program
    {
        static int Vowels(string word)
              {  int total=0;
              {
               for (int i = 0; i < word.Length; i++)
                {
                if (word[i]  == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                 total++;
                }
              
                            
              }   Console.WriteLine("The number of vowels in {0} is {1} ",word,total);
                  return  total;
               
                
             }
        static void NumericDigits(string word)
            {
            
            string outputString = String.Join("", word.Where(Char.IsDigit));
            Console.WriteLine("The number of numeric digits in {0} is {1}", word,outputString.Length);
            }
          
         static void LowerToUpperAndViceVersa(string sentence)
           {
            
            char[] array=sentence.ToCharArray();
            for (int i = 0; i < array.Length; i++)
			 {
                char ch=array[i];
                if(Char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
			    } else if (Char.IsUpper(ch))

                {
                Console.Write(Char.ToLower(ch));
                }
                
            } 
              
              
            }
       
        public static void CheckCharIsLetter(char b)
        {
            if (Char.IsLetter(b))
            {
                Console.WriteLine("Character is a Letter ");
            } else
            {
                Console.WriteLine("Character is not a Letter");
            }
        }
        public static int CountStringOccurrences(string text, string substringText)
        {
            
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(substringText, i)) != -1)
            {
                i += substringText.Length;
                count++;
            }
            Console.WriteLine("The substring {0} appears in a given string {1} {2} times", substringText,text,count);
            return count;
        }

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
        public static string CalcDaysOfWeek(int x)
        {
            DateTime dt = DateTime.Now;
            DateTime newDay = dt.AddDays(x);
            string DayOfWeeks = newDay.DayOfWeek.ToString();
            return DayOfWeeks;

        }
        public static string CalculatePastDay(int x)
        {
            DateTime dt = DateTime.Now;
            DateTime  pastYear = dt.AddYears(-x);
            string pastDay = pastYear.DayOfWeek.ToString();
            return pastDay;


        }

        public static void GameGuessTheNumber(string levelChoice)

        {
            Random random = new Random();
            switch (levelChoice)
            {
                case "easy":
                    Console.WriteLine("You  choice the easy level.You have 9 tries to guess the number between 0-100");
                    int randomEasy = random.Next(0, 100);
                    Console.WriteLine(randomEasy);/*za proverka*/
                    for (int i = 1; i < 9; i++)
                    {
                        Console.WriteLine("Please enter your number");
                        int enterNum = int.Parse(Console.ReadLine());
                        if (enterNum == randomEasy)
                        {
                            if (i == 1 && enterNum == randomEasy)
                            {
                                Console.WriteLine("Lucky guess. number entered: {0}", enterNum);
                                break;
                            }
                            else if (enterNum == randomEasy)
                            {
                                Console.WriteLine("Nailed it. number entered: {0}", enterNum);
                                break;

                            }
                           
                        }
                        
                        else 
                        {
                            if (enterNum > randomEasy)
                            {
                                if (((enterNum - randomEasy) <= 5))
                                {
                                    Console.WriteLine("Your guess is a little bit higher, number entered:{0}", enterNum);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far to high, number entered:{0}", enterNum);
                                }
                            }
                            else if (randomEasy > enterNum)
                            {
                                if ((randomEasy - enterNum) <= 5)
                                {
                                    Console.WriteLine("Your guess is a little bit lower, number entered:{0}", enterNum);
                                }
                                else
                                {
                                    Console.WriteLine("Your guess is far to low, number entered:{0}", enterNum);
                                }

                            }
                            
                        }
                    }
                    break;

                case "normal":
                    {
                        Console.WriteLine("You  choice the normal  level.You have 7 tries to guess the number between 0-500");
                        int randomNormal = random.Next(0, 100);
                       Console.WriteLine(randomNormal); /*za proverka */
                        for (int i = 1; i <= 7; i++)
                        {
                            Console.WriteLine("Please enter your number");
                            int enterNum = int.Parse(Console.ReadLine());

                            if (enterNum == randomNormal)
                             {
                                if (i==1 && enterNum == randomNormal)
                                {
                                    Console.WriteLine("Lucky guess. number entered: {0}", enterNum);
                                    break;
                                }
                                else if(enterNum == randomNormal)
                                {
                                    Console.WriteLine("Nailed it. number entered: {0}", enterNum);
                                    break;
                                   
                                }
                            }
                           
                            else
                            {
                                if (enterNum > randomNormal)
                                {
                                    if (((enterNum - randomNormal) <= 5))
                                    {
                                        Console.WriteLine("Your guess is a little bit higher, number entered:{0}", enterNum);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your guess is far to high, number entered:{0}", enterNum);
                                    }
                                }

                                else if (randomNormal > enterNum)
                                {
                                    if ((randomNormal - enterNum) <= 5)
                                    {
                                        Console.WriteLine("Your guess is a little bit lower, number entered:{0}", enterNum);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your guess is far to low, number entered:{0}", enterNum);
                                    }
                                }
                            }
                        }
                        break;
                    }

                        case "hard":
                    {
                        Console.WriteLine("You  choice the hard  level.have 5 tries to guess the number between 0-1000");
                        int randomHard = random.Next(0, 1000);
                        Console.WriteLine(randomHard);
                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine("Please enter your number");
                            int enterNum = int.Parse(Console.ReadLine());

                            if (enterNum == randomHard)
                            {
                                if (i == 1 && enterNum == randomHard)
                                {
                                    Console.WriteLine("Lucky guess. number entered: {0}", enterNum);
                                    break;
                                }
                                else if (enterNum == randomHard)
                                {
                                    Console.WriteLine("Nailed it. number entered: {0}", enterNum);
                                    break;

                                }
                            }
                            else
                            {
                                if (enterNum > randomHard)
                                {
                                    if (((enterNum - randomHard) <= 5))
                                    {
                                        Console.WriteLine("Your guess is a little bit higher, number entered:{0}, random number {1}", enterNum, randomHard);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your guess is far to high, number entered:{0}, random number is {1}", enterNum, randomHard);
                                    }
                                }

                                else if (randomHard > enterNum)
                                {
                                    if ((randomHard - enterNum) <= 5)
                                    {
                                        Console.WriteLine("Your guess is a little bit lower, number entered:{0}, random number is {1}", enterNum, randomHard);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your guess is far to low, number entered:{0}, random number  is {1}", enterNum, randomHard);
                                    }
                                }
                            }
                        }
                        break;



                    }


            } 
        }





        static void Main(string[] args)
        {
            #region Task 1(factoriel)
            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());
            //int fact = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine($"Factoriel of a number {number} is {fact}");
            //Console.ReadLine();
            #endregion Task 1(factoriel)

            #region Dates.cs
            //Create datetime            
            //DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);

            //Example how it looks like in the output
            //var t = String.Format("{0:t}", dt); // "6:50 PM" ShortTime

            //Console.WriteLine(t);
            //var d = String.Format("{0:d}", dt); // 2/21/2018
            //Console.WriteLine(d);
            //var T = String.Format("{0:T}", dt); // 6:50:23 PM
            //Console.WriteLine(T);
            //var D = String.Format("{0:D}", dt); // Wednesday, February 21,2018
            //Console.WriteLine(D);
            //var f = String.Format("{0:f}", dt); // Wednesday, February 21,2018 6:50 PM
            //Console.WriteLine(f);            
            //var F = String.Format("{0:F}", dt); // "Wednesday, February 21, 2018 6:50:23 PM"
            //Console.WriteLine(F);
            //var g = String.Format("{0:g}", dt); // 2/21/2018 6:50 PM
            //Console.WriteLine(g);
            //var G = String.Format("{0:G}", dt); // 2/21/2018 6:50:23 PM
            //Console.WriteLine(G);
            //var m = String.Format("{0:m}", dt); // February 21
            //Console.WriteLine(m);
            //var y = String.Format("{0:y}", dt); // February 2018
            //Console.WriteLine(y);
            //var r = String.Format("{0:r}", dt); // Wed, 21 Feb 2018 18:50:23 GMT
            //Console.WriteLine(r);
            //var s = String.Format("{0:s}", dt); // 2018-02-21T18:50:23
            //Console.WriteLine(s);
            //var u = String.Format("{0:u}", dt); // 2018-02-21  18:50:23Z
            //Console.WriteLine(u);

            //Console.WriteLine("--------------");

            //DateTime TimeNow = DateTime.Now;
            //DateTime TimeUtc = DateTime.UtcNow;
            //DateTime TimeToday = DateTime.Today;
            //Console.WriteLine("Current DateTime: {0} ", TimeNow);  	//3/16/2019 8:19:12 PM
            //Console.WriteLine("UTC DateTime:     {0} ", TimeUtc); 	//3/16/2019 7:19:12 PM
            //Console.WriteLine("Today:            {0} ", TimeToday); //3/16/2019 12:00:00 AM
            //Console.WriteLine();

            //DateTime yesterday;
            //yesterday = TimeNow.AddDays(-1);
            //Console.WriteLine("Yesterday: {0}", yesterday);								//3/15/2019  8:22:24 PM
            //Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);		//20:22:24.5738766
            //Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));              //3/16/2019 6:24:20 PM

            //int mDays = DateTime.DaysInMonth(2016, 2);
            //Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);							//29 days
            //Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018, 2));  //28 days
            //Console.ReadLine();
            #endregion Dates.cs

            #region Task3
            /*Console.WriteLine("Vnesi tekst");
            string sentence=Console.ReadLine();
            int words = sentence.Split(' ').Length;
            Console.WriteLine("These sentense has {0} words", words);
            int countSpaces=sentence.Count(Char.IsWhiteSpace);
            Console.WriteLine("These sentence has {0} spasec",countSpaces);
            int all=words+countSpaces;
            Console.WriteLine("These sentence Length (with leading and trailing spaces) is {0} ",all);
            Console.ReadLine();*/
            #endregion Task 3

            #region Task 1
            /*Create a function to say whether a string is symmetric (a palindrome). 
            For example, "RADAR" is a palindrome. hint try using recursion.*/

            /* Console.WriteLine("Enter some word");
            string word=Console.ReadLine();
            string word1=word.ToUpper();            
            string  reversed = new string(word1.Reverse().ToArray());

            if(word1 == reversed)
            {
               Console.WriteLine("The word {0} is palindrome",word);
            } else 
               {
               Console.WriteLine("The word {0} is'nt palindrome",word);
             }
             Console.ReadLine();*/
            #endregion Task 1

            #region Task 2
            /*Create a function which returns the greatest value stored in an array 
             * of real numbers which is specified as parameter.*/
            /* int[] array=new int[]{1,5,9,7,3,100,99};
             int max=array.Max();
            Console.WriteLine($"{max}");
            Console.ReadLine();*/
            #endregion Task 2

            #region Task 3
            /*Create a two function that calculates the amount of numeric digits and vowels(samoglaski) 
            that a text string contains.
            It will accept one parameter parameter: the string that we want to search,
            Function 1 should return the number of digits, function 2 should return the number of vowels. 
            Do not name them function1 and 2 :)*/
            /*Console.WriteLine("Enter some word");
             string word =Console.ReadLine();
             Vowels(word);
             NumericDigits(word);
             Console.ReadLine();*/
            #endregion Task 3

            #region Task 4
            /*Console.WriteLine("Type a sentence");
            string sentence =Console.ReadLine();          
            LowerToUpperAndViceVersa(sentence);         
            Console.ReadLine();*/
            #endregion Task 4

            #region Task 5
            /*Task 5:
            Create a function to check whether a character is an alphabet and not and if so,
            go to check for the case.*/
            //Console.WriteLine("Enter a character: ");
            //string a = Console.ReadLine();
            //char b = char.Parse(a);
            //CheckCharIsLetter(b);
            //Console.ReadLine();
            #endregion

            #region Task 6
            /* Create a function to find the number 
             * of times a substring appears in a given string.*/
            //Console.WriteLine("Enter some text");
            //string text = Console.ReadLine();
            //Console.WriteLine("Enter some characters");
            //string substringText = Console.ReadLine();
            //CountStringOccurrences(text,substringText);
            //Console.ReadLine();

            #endregion

            #region Task 7
            /*Create a function that calculates the result of raising an integer to another 
            integer(eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125). 
            This function must be created recursively.*/
            //Console.Write("Input the base value:");
            //int baseNum = int.Parse(Console.ReadLine());
            //Console.Write(" Input the exponent : ");
            //int pwr = int.Parse(Console.ReadLine());
            //int result=CalcuOfPower(baseNum, pwr);
            //Console.WriteLine(" The value of {0} to the power of {1} is : {2} \n\n", baseNum, pwr, result);
            //Console.ReadLine();
            #endregion

            #region Task 8
            /*Create a function to take one parameter n and calculate 
               what day of the week is n days from this moment.*/
            //DateTime dt = DateTime.Now;
            //Console.WriteLine("Now {0}", dt);
            //Console.WriteLine("Enter a number of days to calculate what day of the week is ");
            //int days = int.Parse(Console.ReadLine());
            //CalcDaysOfWeek(days);
            //Console.WriteLine("It was {0}", CalcDaysOfWeek(days));
                       

            Console.ReadLine();

            #endregion

            #region Task 9

            /*Create a function to take one parameter n to display the date of past n years from current date and 
             to tell what day it was. The parameter should not be larger that 20.*/
            //Console.WriteLine("Please enter  number of  years");
            //int pastYear = int.Parse(Console.ReadLine());
            //CalculatePastDay(pastYear);
            //Console.WriteLine("Before {0} years it was  {1}" , pastYear,CalculatePastDay(pastYear) );
            //Console.ReadLine();


            #endregion


            #region Guess the number
            Console.WriteLine("Welcome! Please type easy, normal or  hard to choose level of difficultyy");
            string levelChoice = Console.ReadLine().ToLower();
            
            GameGuessTheNumber(levelChoice);
            Console.WriteLine("Press 1 to start a new game, press 2 to quit game");
            int optional = int.Parse(Console.ReadLine().ToLower());
            if (optional == 1)
            {
                Console.WriteLine("Welcome! Please type easy, normal or  hard to choose level of difficultyy");
                string NewlevelChoice = Console.ReadLine().ToLower();
                GameGuessTheNumber(NewlevelChoice);
            } else
            {
                Console.WriteLine("Game OVER");
            }

            Console.ReadLine();






            #endregion

        }
    }
}
