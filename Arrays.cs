using System;

namespace term_paper
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // One-dimensional array declaration of 8 elements
            int[] intArray = new int[8];
            intArray[0] = 125;
            intArray[3] = 538;

            // Iterating through one-dimensional array with foreach
            Console.Write("An int array: ");
            foreach (int i in intArray) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // One-dimensional array declaration and setting
            string[] animals = {"Dogs", "Cats", "Birds", "Penguins"};

            // Iterating through one-dimensional array with foreach
            Console.Write("The animals array: ");
            foreach (string i in animals) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Accessing a single array element
            Console.WriteLine($"The third element of the animals array is {animals[2]}.");
            Console.WriteLine();

            // Three-dimensional array declaration and setting
            int[, ,] arrayThreeDimensional = new int[,,] { { {2, 4}, {3, 6}, {4, 8} } };

            // Iterating through three-dimensional array with for loop
            Console.WriteLine("A 3D array: ");
            for (int i=0; i<arrayThreeDimensional.GetLength(0); i++) 
            {
                for (int j=0; j<arrayThreeDimensional.GetLength(1); j++)
                {
                    for (int k=0; k<arrayThreeDimensional.GetLength(2); k++)
                    {
                        Console.Write(arrayThreeDimensional[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            // Jagged three-dimensional array declaration and setting
            int[][] arrayJagged = 
            {
                new int[] {1, 2, 3, 4, 5},
                new int[] {6, 7, 8},
                new int[] {9, 10, 11, 12}
            };
            
            // Iterating through three-dimensional jagged array with a different for loop
            Console.WriteLine("A jagged array: ");
            for (int i=0; i<arrayJagged.Length; i++)  
            {  
                for (int j=0; j<arrayJagged[i].Length; j++)  
                {  
                    Console.Write(arrayJagged[i][j] + " ");  
                }  
                Console.WriteLine();  
            }  
            Console.WriteLine();

        }

    }
}
