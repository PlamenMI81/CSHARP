using System;

class InstructionSet_broken
{
    static void Main()
    {
        while (true)
        {
            string instruction = Console.ReadLine();
            string[] codeArgs = instruction.Split(' ');

            long result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = (long)operandOne + 1;
                        break;
                    }
                case "DEC":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = (long)operandOne-1;
                        break;
                    }
                case "ADD":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = ((long)operandOne * operandTwo);
                        break;
                    }
                case "END":return ;
            }

            Console.WriteLine(result);
        }
    }
}