using System;

namespace collectionspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold integer values 0 through 9
            int[] numArray1 = {1,2,3,4,5,6,7,8,9};

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray1 = new string[4] { "Tim", "Martin", "Nikki", "Sara"};

            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] array = new bool[10];
                array[0] = true;
                array[2] = true;
                array[4] = true;
                array[6] = true;
                array[8] = true;


            //With the values 1-10, use code to generate a multiplication table like the one below.
            int[,] array2D = new int[12,10];
                for(int x = 1; x <= 10; x++){

                }



        }
    }
}
