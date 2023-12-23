using System.Diagnostics.Metrics;

namespace ovning_12_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övning 10: Skriva ett program som skriver ut ett meddelande till användaren där texten inte
            //skrivs ut direkt utan under en längre tidsperiod.
            //Console.WriteLine("Hello, World!");
            //Thread.Sleep(4000);
            //Console.WriteLine("Goodbye, World!");
            //string[] fraudulentOrderIDs = new string[3];

            //fraudulentOrderIDs[0] = "A123";
            //fraudulentOrderIDs[1] = "B456";
            //fraudulentOrderIDs[2] = "C789";
            // fraudulentOrderIDs[3] = "D000";

            //string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
            //Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            //Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            //Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            //fraudulentOrderIDs[0] = "F000";

            //Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            //Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            //string[] names = { "Rowena", "Robin", "Bao" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //int[] inventory = { 200, 450, 700, 175, 250 };
            //int sum = 0;
            //int bin = 0;
            //foreach (int items in inventory)
            //{
            //    sum += items;
            //    bin++;
            //    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            //}
            //Console.WriteLine($"We have {sum} items in inventory.");

            //string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            //Console.WriteLine("Dåliga id: ");
            //foreach (string orderID in fraudulentOrderIDs){
            //    if (orderID.StartsWith("B"))
            //    {
            //        Console.WriteLine(orderID);
            //    }
            //}


            //Random random = new Random();
            //int current = 0;

            //do
            //{
            //    current = random.Next(1, 11);
            //    Console.WriteLine(current);
            //} while (current != 7);



            //Random random = new Random();
            //int current = random.Next(1, 11);

            //do
            //{
            //    current = random.Next(1, 11);

            //    if (current >= 8) continue;

            //    Console.WriteLine(current);
            //} while (current != 7);

            /*
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */

            //int hero = 10;
            //int monster = 10;

            //Random dice = new Random();

            //do
            //{
            //    int roll = dice.Next(1, 11);
            //    monster -= roll;
            //    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            //    if (monster <= 0) continue;

            //    roll = dice.Next(1, 11);
            //    hero -= roll;
            //    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            //} while (hero > 0 && monster > 0);

            //Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

            //string? readResult;
            //Console.WriteLine("Enter a string:");
            //do
            //{
            //    readResult = Console.ReadLine();
            //} while (readResult == null);

            //string? readResult;
            //bool validEntry = false;
            //Console.WriteLine("Enter a string containing at least three characters:");
            //do
            //{
            //    readResult = Console.ReadLine();
            //    if (readResult != null)
            //    {
            //        if (readResult.Length >= 3)
            //        {
            //            validEntry = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your input is invalid, please try again.");
            //        }
            //    }
            //} while (validEntry == false);

            //Enter an integer value between 5 and 10
            //two
            //Sorry, you entered an invalid number, please try again
            //2
            //You entered 2.Please enter a number between 5 and 10.
            //7
            //Your input value(7) has been accepted.


            //do
            //{
            //    Console.WriteLine("Enter an integer value between 5 and 10");

            //    if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 5 && userInput <= 10)
            //    {
            //        Console.WriteLine($"You entered {userInput}. Your input value ({userInput}) has been accepted.");
            //        break; // Exit the loop since a valid input has been provided
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
            //    }

            //} while (true);



            //string? readResult;
            //string roleName = "";
            //bool validEntry = false;

            //do
            //{
            //    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            //    readResult = Console.ReadLine();
            //    if (readResult != null)
            //    {
            //        roleName = readResult.Trim();
            //    }

            //    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
            //    {
            //        validEntry = true;
            //    }
            //    else
            //    {
            //        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
            //    }

            //} while (validEntry == false);

            //Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            //readResult = Console.ReadLine();

            //string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            //int stringsCount = myStrings.Length;

            //string myString = "";
            //int periodLocation = 0;

            //for (int i = 0; i < stringsCount; i++)
            //{
            //    myString = myStrings[i];
            //    periodLocation = myString.IndexOf(".");

            //    string mySentence;

            //    // extract sentences from each string and display them one at a time
            //    while (periodLocation != -1)
            //    {

            //        // first sentence is the string value to the left of the period location
            //        mySentence = myString.Remove(periodLocation);

            //        // the remainder of myString is the string value to the right of the location
            //        myString = myString.Substring(periodLocation + 1);

            //        // remove any leading white-space from myString
            //        myString = myString.TrimStart();

            //        // update the comma location and increment the counter
            //        periodLocation = myString.IndexOf(".");

            //        Console.WriteLine(mySentence);
            //    }

            //    mySentence = myString.Trim();
            //    Console.WriteLine(mySentence);
            //}



            //Console.WriteLine("a" == "a");
            //Console.WriteLine("a" == "A");
            //Console.WriteLine(1 == 2);

            //string myValue = "a";
            //Console.WriteLine(myValue == "a");

            //string value1 = " a";
            //string value2 = "A ";
            //Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            //Console.WriteLine("a" != "a");
            //Console.WriteLine("a" != "A");
            //Console.WriteLine(1 != 2);

            //string myValue = "a";
            //Console.WriteLine(myValue != "a");

            //Console.WriteLine(1 > 2);
            //Console.WriteLine(1 < 2);
            //Console.WriteLine(1 >= 1);
            //Console.WriteLine(1 <= 1);

            //string pangram = "The quick brown fox jumps over the lazy dog.";
            //Console.WriteLine(pangram.Contains("fox"));
            //Console.WriteLine(pangram.Contains("cow"));
            //string pangram = "The quick brown fox jumps over the lazy dog.";
            //Console.WriteLine(!pangram.Contains("fox"));
            //Console.WriteLine(!pangram.Contains("cow"));

            //int a = 7;
            //int b = 6;
            //Console.WriteLine(a != b); // output: True
            //string s1 = "Hello";
            //string s2 = "Hello";
            //Console.WriteLine(s1 != s2); // output: False



            //int[] myArray = new int[5];
            //for (int i = 0; i < 5; i++ ) 
            //{
            //    Console.WriteLine("Ange ett nummer:");
            //    int input = int.Parse(Console.ReadLine());
            //    myArray[i] = input;
            //}
            //Console.WriteLine("`\nDu matade in följande:");
            //foreach (int input in myArray)
            //{
            //    Console.WriteLine(input);
            //}

            //int[] array = new int[] { 4, 5, 6, 7, 8, 9, 10 };
            //int currentSmallest = int.MaxValue;
            //for (int index = 0; index < array.Length; index++)
            //{
            //    if (array[index] != currentSmallest)
            //    {
            //        currentSmallest = array[index];
            //    }
            //}
            //Console.WriteLine(currentSmallest);

            //int[] array = new int[] { 1, 2, 3 };
            //int total = 0;
            //for (int index  = 0; index < array.Length; index++)
            //{
            //    total += array[index];
            //}
            //float avarage = (float)total / array.Length;
            //Console.WriteLine(avarage);


            //static void QuickSort(int[] data, int left, int right)
            //{
            //    //Välj det tal som avgör indelningen i "högre" och "lägre"
            //    int pivot = data[(left + right) / 2];
            //    //Välj det område som skall bearbetas
            //    int leftHold = left;
            //    int rightHold = right;

            //    //Så länge vi har ett område kvar
            //    while (leftHold < rightHold)
            //    {
            //        //Hitta ett tal på vänster sida som skall ligga i den "högre" delen
            //        while ((data[leftHold] < pivot) && (leftHold <= rightHold)) leftHold++;
            //        //Hitta ett tal på höger sida som skall ligga i den "lägre" delen
            //        while ((data[rightHold] > pivot) && (rightHold >= leftHold)) rightHold--;

            //        //Om vi nu har ett område kvar så skall talen på 
            //        //vänster kant och höger kant byta plats
            //        if (leftHold < rightHold)
            //        {
            //            //Byta plats
            //            int tmp = data[leftHold];
            //            data[leftHold] = data[rightHold];
            //            data[rightHold] = tmp;
            //            //Minska området om vi flyttat två pivot-tal
            //            if (data[leftHold] == pivot && data[rightHold] == pivot)
            //                leftHold++;
            //        }
            //    }
            //    //Nu när området är bearbetat så skall "lägre" delen bearbetas
            //    //om sådan finns därefter detsamma med en eventuell "högre" del
            //    if (left < leftHold - 1) QuickSort(data, left, leftHold - 1);
            //    if (right > rightHold + 1) QuickSort(data, rightHold + 1, right);
            //    }

            //static void BubbleSort(int[] data)
            //{
            //    bool needsSorting = true;
            //    //Gör en loop för varje tal som skall sorteras, avbryt om talen är sorterade
            //    for (int i = 0; i < data.Length - 1 && needsSorting; i++)
            //    {
            //        //Signalera att vi börjar om en ny vända med sortering
            //        needsSorting = false;
            //        //Gå igenom alla tal fram till och med de tal som ev. 
            //        //redan är sorterade (variabeln i)
            //        for (int j = 0; j < data.Length - 1 - i; j++)
            //        {
            //            //Flytta större tal fram i vektorn
            //            if (data[j] > data[j + 1])
            //            {
            //                //Signalera att vi kommer att behöva fortsätta sortera
            //                needsSorting = true;
            //                //Byt plats på tal
            //                int tmp = data[j + 1];
            //                data[j + 1] = data[j];
            //                data[j] = tmp;
            //            }
            //        }
            //        //Har vi nu inte behövt sortera några tal så är 
            //        //needsSorting == false och loop'en kommer att avbrytas
            //    }
            //}

            //static void InsertionSort(int[] data)
            //{
            //    //Gör en loop för varje tal som skall sorteras 
            //    //börja på index 1 då vi kommer att titta "bakåt" i vektorn
            //    for (int i = 1; i < data.Length; i++)
            //    {
            //        //Stega bakåt från position i ned till 1 om så behövs
            //        for (int j = i; j > 0; j--)
            //        {
            //            //jämför med talet "bakom" och se om det är större
            //            if (data[j] < data[j - 1])
            //            {
            //                //byt plats på tal
            //                int tmp = data[j - 1];
            //                data[j - 1] = data[j];
            //                data[j] = tmp;
            //            }
            //            //annars avsluta innerloop'en 
            //            else
            //                break;
            //        }
            //    }
            //}

        }
    }
}
