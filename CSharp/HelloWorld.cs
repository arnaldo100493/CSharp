// See https://aka.ms/new-console-template for more information
using System;


namespace CSharpHelloWorld
{

    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hola Mundo  
            Console.WriteLine("Hello, C#!");

            /*
            Este
            es
            un
            comentario.
            */

            string myString = "Esto es una cadena de texto.";
            myString = "Aquí cambia el valor de la cadena de texto.";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myDouble + myFloat);

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinámico ";
            Console.WriteLine(myDynamic + myFloat);

            var myVar = "Mi variable tipo inferido.";
            //myVar = 6; Error
            Console.WriteLine(myVar);

            Console.WriteLine($"El valor de mi entero {myInt} es y el de mi bool {myBool}");

            const string MyConst = "Mi constante.";
            Console.WriteLine(MyConst);

            //Estructuras

            var myArray = new string[] { "Brais", "Moure", "MoureDev" };
            Console.WriteLine(myArray[0]);

            myArray[2] = "36";
            Console.WriteLine(myArray[2]);

            var myDictionary = new Dictionary<string, int>
          {
              {"mouredev", 36},
              {"brookslynx", 5},
              {"cabreragreta", 25}
          };

            Console.WriteLine(myDictionary["mouredev"]);

            var mySet = new HashSet<string> { "Brais", "Moure", "MoureDev", "MoureDev" };

            var myTuple = ("Brais", "Moure", "MoureDev", "MoureDev");
            Console.WriteLine(myTuple);

            //Bucles

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            //Flujos

            myInt = 12;

            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11.");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12.");
            }
            else
            {
                Console.WriteLine("El valor no es 11 ni 12.");
            }


            /*long myLong = 6L;

            bool myBool = false;
            myBool = true;

            Console.WriteLine(myInt + myDouble + myFloat + myDynamic, myLong, myBool);*/

            //Funciones

            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            //Clases

            var myClass = new MyClass("Brais");
            myClass.myName = "MoureDev";
            Console.WriteLine(myClass.myName);

        }

        static void MyFunction()
        {
            Console.WriteLine("Mi función.");
        }

        static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        class MyClass
        {
            public string myName{ get; set; }

            public MyClass(string myName)
            {
                this.myName = myName;
            }
        }
    }
}

//Console.WriteLine("Hello, C#!");

