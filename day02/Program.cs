using System;

namespace day02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,10,1,19,1,19,9,23,1,23,6,27,1,9,27,31,1,31,10,35,2,13,35,39,1,39,10,43,1,43,9,47,1,47,13,51,1,51,13,55,2,55,6,59,1,59,5,63,2,10,63,67,1,67,9,71,1,71,13,75,1,6,75,79,1,10,79,83,2,9,83,87,1,87,5,91,2,91,9,95,1,6,95,99,1,99,5,103,2,103,10,107,1,107,6,111,2,9,111,115,2,9,115,119,2,13,119,123,1,123,9,127,1,5,127,131,1,131,2,135,1,135,6,0,99,2,0,14,0";
            Console.WriteLine($"{input}");
            var output = Compute(input);
            Console.WriteLine($"{output}");
        }

        private static string Compute(string program)
        {
            var splitProgram = program.Split(",");
            var computedProgram = string.Empty;
            
            var index = 0;

            for (int i = 0; i < splitProgram.Length; i += 4)
            {
                var isNum = int.TryParse(splitProgram[i], out int operation);
                
                if (isNum) 
                {
                    switch (operation)
                    {
                        case 1:
                            // read value from position i + 1
                            
                            // read value from position i + 2
                            // add those two positions together
                            // store value from in position i + 3 with result
                            break;
                        case 2:
                            // read value from position i + 1
                            // read value from position i + 2
                            // add those two positions together
                            // store value from in position i + 3 with result
                            break;
                        case 99:
                            // end of program, stop
                            Console.WriteLine("End of Program command seen");
                            computedProgram = String.Join(",", splitProgram);
                            return computedProgram;
                        default:
                            Console.WriteLine("Unknown operation, stopping program");
                            return splitProgram.ToString();                            
                    }

                }
                
            }

            Console.WriteLine("Did not see end of program command");
            return computedProgram = String.Join(",", splitProgram);
        }
    }
}
