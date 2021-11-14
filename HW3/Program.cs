using System;

namespace HW3
{
    
   

    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            CPU cpu_1 = new CPU();
            CPU cpu_2 = new CPU();
            CPU cpu_3 = new CPU();
            CPU cpu_4 = new CPU();
            char[] checkcpu1 = new char[0];
            char[] checkcpu2 = new char[0];
            char[] checkcpu3 = new char[0];
            char[] checkcpu4 = new char[0];

            int count = 0;
            int countRound = 0;
            
            
            string inputcharacter;
            char instruction, data;

            while (true)
            {
                inputcharacter = Console.ReadLine();
                instruction = inputcharacter[0];
                if (inputcharacter == "?")
                {
                    break;
                }
                data = inputcharacter[1];
                queue.Push(new InformationChar(instruction, data));
                InformationChar cpu = new InformationChar(inputcharacter[0], inputcharacter[1]);
                queue.Push(cpu);
                
                
                
            }
            



            Console.WriteLine("CPU cycles needed: "+countRound);
        }
    }
}
