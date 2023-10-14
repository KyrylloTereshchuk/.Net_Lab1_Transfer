using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ExecutionProcess : IExecutionProcess
    {
          private readonly MenuDictionary _dictionary;

          public ExecutionProcess(MenuDictionary dictionary)
          {
              _dictionary = dictionary;
          }

        public void Process()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Menu\n");
            foreach (Enums.QueriesNames queryName in Enum.GetValues(typeof(Enums.QueriesNames)))
            {
                Console.WriteLine($"{(int)queryName}." + queryName);
            }

               while (true)
              {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.Write("\nEnter query number (1-21) or 0 to exit: ");
                  Console.ResetColor();

                  string? input = Console.ReadLine();


                  var menuChoices = _dictionary.MenuCreate();

                    if (Enum.TryParse(input, out Enums.QueriesNames choice) && menuChoices.TryGetValue(choice, out var selected))
                    {
                       selected();
                    }
                      
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

               }

        }

    }

}
