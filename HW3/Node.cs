using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    

    

    class InformationChar
    {
        public char Instruction;
        public char Data;
        public InformationChar Next;
        public InformationChar(char instruction , char data)
        {
            Instruction = instruction;
            Data = data;
        }

        public override string ToString()
        {
            return String.Format("",Instruction,Data);
        }
    }
}

       



