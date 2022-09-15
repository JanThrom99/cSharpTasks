using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1 
            //var a = 3;
            //var b = 4;
            //var sum = a + b;
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //task 2
            //Console.WriteLine("welche beiden Zahlen willst du addieren?");
            //Console.WriteLine("zahl 1: ");
            //var number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("zahl 2: ");
            //var number2 = Convert.ToInt32(Console.ReadLine());
            //var addedNumbers = number1 + number2;
            //Console.WriteLine("Die Summe ist: " + addedNumbers);
            //Console.ReadKey();

            //task 3 
            //Console.WriteLine("gib einen Text ein und ich ersetze alle U's durch G's");
            //var userString = Console.ReadLine();
            //var replacedUserString = userString.Replace("U", "G").Replace("u", "g");
            //Console.WriteLine(replacedUserString);
            //Console.ReadKey();

            //task 4
            //Console.WriteLine("gib einen Text ein und ich sage dir wie lang er ist");
            //var uString = Console.ReadLine();
            //var lengthWithSpaces = uString.Length;
            //var lengthWithoutSpaces = uString.Replace(" ", "").Length;
            //Console.WriteLine("Länge mit Leerzeichen: " + lengthWithSpaces);
            //Console.WriteLine("Länge ohne Leerzeichen: " + lengthWithoutSpaces);
            //Console.ReadKey();

            //task 2b
            //Console.WriteLine("welche beiden Fließkomma Zahlen willst du addieren?");
            //Console.WriteLine("zahl 1: ");
            //var number11 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("zahl 2: ");
            //var number22 = Convert.ToDouble(Console.ReadLine());
            //var addedDoubles = number11 + number22;
            //Console.WriteLine("Die Summe ist: " + addedDoubles);
            //Console.ReadKey();

            //task 5
            //Console.WriteLine("gib einen Text ein");
            //var uString = Console.ReadLine();
            //var newString = uString.PadLeft(20,'y');
            //Console.WriteLine(newString);
            //Console.ReadKey();

            //task 6
            //Console.WriteLine("gib einen Text ein");
            //var uString = Console.ReadLine();
            //var newString = uString.PadRight(30, 'y');
            //Console.WriteLine(newString);
            //Console.ReadKey();

            //task 7
            //Console.WriteLine("gib einen Text mit Leerzeichen am Anfang und am Ende ein");
            //var uString = Console.ReadLine();
            //var newString = uString.Trim();
            //Console.WriteLine(":" + newString + ":");
            //Console.ReadKey();

            //task 8
            //Console.WriteLine("gib einen Text mit Semikolons darin ein");
            //var uString = Console.ReadLine();
            //var splittedStrings = uString.Split(';');
            //Console.WriteLine("deine substrings sind: ");
            //foreach (var split in splittedStrings)
            //{
            //    Console.WriteLine(split);
            //}
            //Console.ReadKey();

            //task 9 
            //Console.WriteLine("gib einen Text ein");
            //var uString = Console.ReadLine();
            //if (uString.Contains("abc"))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            //Console.ReadKey();

            //task 10
            //Console.WriteLine("gib einen Text ein");
            //var uString = Console.ReadLine();
            //Console.WriteLine(uString.ToUpper());
            //Console.WriteLine(uString.ToLower());
            //Console.ReadKey();


            //FOR SCHLEIFE TASKS 
            //task 1
            //var wert1 = 0;

            //Console.WriteLine("bitte gib eine Zahl ein");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < userInput; i++)
            //{
            //    wert1 = wert1 + i;
            //    Console.WriteLine(wert1);
            //}

            //Console.ReadKey();

            //task 2
            //Console.WriteLine("bitte gib eine Zahl ein");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            //for (int i = userInput; i >=0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //task 3 
            //Console.WriteLine("Bitte gib einen Buchstaben ein");
            //var userChar = Console.ReadLine();
            //var namen = new string[] {"Jonas","Philipp","Niklas","Marcello","Andreas","Robin","Robert","Marie","Leon","Erwin","Jan","Mona","Lukas","Johannes"};

            //foreach (var name in namen)
            //{
            //    if (name.Contains(userChar))
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //Console.ReadKey();

            //task 4
            //Console.WriteLine("wie groß soll das array sein?");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            //var userInput2 = 0;
            //var array = new int[userInput];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("welche Zahl soll ins Array?");
            //    userInput2= Convert.ToInt32(Console.ReadLine());
            //    array[i] = userInput2;
            //}

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();

            //task 4b
            //Console.WriteLine("wie groß soll das array sein?");
            //var userInput = Convert.ToInt32(Console.ReadLine());
            //var userInput2 = 0;
            //var array = new int[userInput];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("welche Zahl soll ins Array?");
            //    userInput2 = Convert.ToInt32(Console.ReadLine());
            //    array[i] = userInput2;
            //}

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("max: "+array.Max());
            //Console.WriteLine("min: " + array.Min());
            //Console.WriteLine("average: " + array.Average());
            //Console.ReadKey();

            //task 5 
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine(i + " FizzBuzz");
            //    }
            //    else
            //    {
            //        if (i%5 == 0)
            //        {
            //            Console.WriteLine(i + " Buzz");
            //        }

            //        if (i%3 == 0)
            //        {
            //            Console.WriteLine(i + " Fizz");
            //        }

            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadKey();


            //TAG 3
            //Einstiegsaufgabe
            //Console.WriteLine("Gib eine Zeichenfolge ein");
            //var zeichenfolge = Console.ReadLine();
            //Console.WriteLine("Gib an wo der substring starten soll");
            //var subStringStart = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Gib an wie lange der substring sein soll");
            //var subStringlaenge = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(zeichenfolge.Substring(subStringStart,subStringlaenge));
            //Console.ReadKey();

            //NAMEN AUFGABE 
            //Console.WriteLine("wie heisst du? ");
            //var userInput = Console.ReadLine();
            //if (userInput.Trim().Length == 0)
            //{
            //    Console.WriteLine("Gib deinen Namen ein!!! \n _______/]_________[\\______ \n|    ____     ___|-----------|===== \n|_ /      /  /_| | \n         /_/   \\_\\");
            //    userInput = Console.ReadLine();
            //}

            //var counter = 0;
            //var newArray = userInput.ToCharArray();
            //foreach (var character in newArray)
            //{
            //    Console.WriteLine(character);
            //    if (character.ToString().Contains('a'))
            //    {
            //        counter++; 

            //    }
            //}

            //Console.WriteLine("Der Buchstabe a kommt "+counter+" Mal vor");

            //Console.WriteLine("gib nochmal zwei zahlen ein");
            //Console.WriteLine("zahl1: ");
            //var zahl1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("zahl2: ");
            //var zahl2 = Convert.ToInt32(Console.ReadLine());
            //if (zahl1 > zahl2)
            //{
            //    Console.WriteLine("Zahl1 ist größer");
            //}
            //else if (zahl1 == zahl2)
            //{
            //    Console.WriteLine("Die Zahlen sind gleich groß");
            //}
            //else
            //{
            //    Console.WriteLine("Zahl2 ist größer");
            //}
            //Console.ReadKey();



            //ZEITAUFGABE
            //Console.WriteLine("Gib die Anzahl der Sekunden an");
            //var sekunden = Convert.ToDouble(Console.ReadLine());
            //var timeSpan = TimeSpan.FromSeconds(sekunden);
            //string timeString = string.Format("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s",timeSpan.Days,timeSpan.Hours,timeSpan.Minutes,timeSpan.Seconds);
            //Console.WriteLine(timeString);
            //Console.ReadKey();


            //BUCHSTABENANZAHL
            IDictionary<char, int> dictionary = new Dictionary<char, int>();
            Console.WriteLine("bitte gib eine wort ein");
            var input = Console.ReadLine();

            foreach (var c in input)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] = dictionary[c] + 1;
                }
                else
                {
                    dictionary.Add(c,1);
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " kommt " + item.Value + " mal vor");
            }

            Console.ReadKey();
        }
    }
}
