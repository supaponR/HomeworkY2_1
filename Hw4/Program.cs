using System;

namespace Hw4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            string InputName , destination;
            int Inputdistance;
            int InputNumberCity;
            string[] InputNameCity;



            int[] distanceCount1 = new int [1] ;
            int[] distanceCount2 = new int [2] ; 
            int[] distanceCount3 = new int [3] ;
            int[] distanceCount4 = new int [4];
            int[] distanceCount5 = new int [5];


            bool Input = true  ;

            List list = new List();
            
            while (Input == true)
            {
                InputNumberCity = int.Parse(Console.ReadLine());
                InputNameCity = new string[InputNumberCity];
                for (int i = 0; i < InputNumberCity; i++)
                {
                    InputName = Console.ReadLine();
                    InputName = InputNameCity[i];

                    

                }
                Console.WriteLine();
                for( int j = 0; j < distanceCount1.Length; j++)
                {
                    Inputdistance = int.Parse(Console.ReadLine());
                    Inputdistance = distanceCount2[j];
                }

                Console.WriteLine();

                for (int j = 0; j < distanceCount2.Length; j++)
                {
                    Inputdistance = int.Parse(Console.ReadLine());
                    Inputdistance = distanceCount2[j];
                }

                Console.WriteLine();

                for (int j = 0; j < distanceCount3.Length; j++)
                {
                    Inputdistance = int.Parse(Console.ReadLine());
                    Inputdistance = distanceCount3[j];
                }

                Console.WriteLine();

                for (int j = 0; j < distanceCount4.Length; j++)
                {
                    Inputdistance = int.Parse(Console.ReadLine());
                    Inputdistance = distanceCount4[j];
                }

                Console.WriteLine();

                for (int j = 0; j < distanceCount5.Length; j++)
                {
                    Inputdistance = int.Parse(Console.ReadLine());
                    Inputdistance = distanceCount5[j];
                }
                Console.WriteLine();
                destination = Console.ReadLine();


                
                Input = false;
            }
            
            









        }
    }
}
