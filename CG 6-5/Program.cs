using System;

namespace CG_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday (MM-DD-YYYY).");  //Asks user to enter birthday and gives format to be used for entry
            string userBirthday = Console.ReadLine();  //takes in user input

            DateTime Birthday = Convert.ToDateTime(userBirthday);     //Uses user input date to determine day of the week they were born on
            Console.WriteLine("You were born on a " + Birthday.DayOfWeek);


            while (Birthday < DateTime.Now)   //create a while loop to determine day of the week the users next birthday will be on
            {
                Birthday = Birthday.AddYears(1);
            }

            Console.WriteLine("Your next birthday will be on a " + Birthday.DayOfWeek + "!");   //output from while loop

            //start horoscope date if statements with horoscope and sign to be printed to screen
            // These all work now, but one section of entry prints two different horoscopes
            if (Birthday.Month == 1)
            {
                if (Birthday.Day <= 19)
                {
                    Console.WriteLine("You are a Capricorn.");
                    Console.Write("You will find true love on Flag Day.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 20)
                {
                    Console.WriteLine("You are an Aquarius");
                    Console.Write("You will die a terrible, terrible death.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 2)
            {
                if (Birthday.Day <= 18)
                {
                    Console.WriteLine("You are an Aquarius.");
                    Console.Write("You will die a terrible, terrible death.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 19)
                {
                    Console.WriteLine("You are a Pisces");
                    Console.Write("Your store is being robbed.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 3)
            {
                if (Birthday.Day <= 20)
                {
                    Console.WriteLine("You are a Pisces");
                    Console.Write("Your store is being robbed.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 21)
                {
                    Console.WriteLine("You are an Aries.");
                    Console.Write("Geese can be troublesome.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 4)
            {
                if (Birthday.Day <= 19)
                {
                    Console.WriteLine("You are an Aries.");
                    Console.WriteLine("Geese can be troublesome.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 20)
                {
                    Console.WriteLine("You are a Taurus.");
                    Console.WriteLine("You will enjoy a short sea voyage.");
                    Console.ReadLine();

                }
            }
            else if (Birthday.Month == 5)
            {
                if (Birthday.Day <= 20)
                {
                    Console.WriteLine("You are a Taurus.");
                    Console.WriteLine("You will enjoy a short sea voyage.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 21)
                {
                    Console.WriteLine("You are a Gemini.");
                    Console.WriteLine("Your best friend will kill you today.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 6)
            {
                if (Birthday.Day <= 20)   //This prints an extra horoscope????
                {
                    Console.WriteLine("You are a Gemini.");
                    Console.WriteLine("Your best friend will kill you today."); 
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 21)
                    Console.WriteLine("You are a Cancer.");
                    Console.WriteLine("Your suspicions are right...Your spouse is cheating on you.");
                    Console.ReadLine();
            }
            else if (Birthday.Month == 7)
            {
                if (Birthday.Day <= 21)
                {
                    Console.WriteLine("You are a Cancer.");
                    Console.WriteLine("Your suspicions are right...Your spouse is cheating on you.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 22)
                {
                    Console.WriteLine("You are a Leo.");
                    Console.WriteLine("Today will be the best day of your life. Tomorrow you will die.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 8)
            {
                if (Birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Leo.");
                    Console.WriteLine("Today will be the best day of your life. Tomorrow you will die.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 23)
                {
                    Console.WriteLine("You are a Virgo.");
                    Console.WriteLine("Someday you won't be a disappointment. Today is not that day.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 9)
            {
                if (Birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Virgo.");
                    Console.WriteLine("Someday you won't be a disappointment. Today is not that day.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 23)
                {
                    Console.WriteLine("You are a Libra.");
                    Console.WriteLine("Your deeply held religious beliefs are wrong.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 10)
            {
                if (Birthday.Day <= 22)
                {
                    Console.WriteLine("You are a Libra.");
                    Console.WriteLine("Your deeply held religious beliefs are wrong.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 23)
                {
                    Console.WriteLine("You are a Scorpio.");
                    Console.WriteLine("You smell funny.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 11)
            {
                if (Birthday.Day <= 21)
                {
                    Console.WriteLine("You are a Scorpio.");
                    Console.WriteLine("You smell funny.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 22)
                {
                    Console.WriteLine("You are a Sagittarius.");
                    Console.WriteLine("You are as ugly as you think you are.");
                    Console.ReadLine();
                }
            }
            else if (Birthday.Month == 12)
            {
                if (Birthday.Day <= 21)
                {
                    Console.WriteLine("You are a Sagittarius.");
                    Console.WriteLine("You are as ugly as you think you are.");
                    Console.ReadLine();
                }
                else if (Birthday.Day >= 22)
                {
                    Console.WriteLine("You are a Capricorn.");
                    Console.WriteLine("You will find true love on Flag Day.");
                    Console.ReadLine();
                }

            }
                Console.ReadLine();

            }
        }
    } 

