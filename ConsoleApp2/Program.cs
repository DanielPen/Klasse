using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            MyPerson person1 = new MyPerson(55);
            MyPerson person2 = new MyPerson(108);
            MyPerson person3 = new MyPerson(23);
            MyPerson person4 = new MyPerson(14);

            //MyPerson[] myArrayPerson = new MyPerson[20];

            Console.WriteLine($"der Unterschied {person2.GetAge() - person1.GetAge()}");

            Console.ReadKey();
            #region // person
            Person myFirstPerson = new Person();// im speicher angelegt
            Person myNextPerson = new Person("Roman", "Schneider");// im speicher angelegt
            #endregion

            #region //not calss
            int arraySize = 0;
            string inputFromUSer = "";
            int convertInput = 0;
                                 // 0, 1, 2, 3   // index
            int[] myFilledArray = { 1, 2, 3, 5 };// Werte
            #endregion

            #region //loops
            do
            {
                Console.Write("Bitte geben Sie eine Zahl ein: ");
            } while (!int.TryParse(Console.ReadLine(), out convertInput));

            Console.WriteLine($"Sie haben die Zahl {convertInput} eingetragen");
            Console.WriteLine("Sie haben die Zahl {0} eingetragen {1} zahl {2}", convertInput, 100, 200);

            Console.Write("bitte geben Sie eien text ein: ");
            inputFromUSer = Console.ReadLine();

            for (int i = 0; i < inputFromUSer.Length; i++)
            {
                Console.WriteLine($"An der Position {i} befindet sich der Wert / Buchstabe {inputFromUSer[i]}");
            }

            #endregion
            
            ///////////////////////////////////////
            myFirstPerson.SetPLZ(4944);

            myFirstPerson.PrintPerson();
            myNextPerson.PrintPerson();

            Console.WriteLine($"die PLZ der Person {myNextPerson.GetPLZ()}");

            ///////////////////////////////////////

            // working with arrays in functions
            arraySize = GetSizeofArray(0);
            int[] myEmtyArray = new int[arraySize];
        }

        static int GetSizeofArray(int test)
        {
            int retSize = 0;

            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein, damit Sie die groesse festlegen können");
                Console.Write("Bitte legen sie die Arraygroesse fest:");
            } while (!int.TryParse(Console.ReadLine(), out retSize));

            return retSize;
        }
    }
}
