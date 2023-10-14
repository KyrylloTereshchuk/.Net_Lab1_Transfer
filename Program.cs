using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program 
    {    
        
        static void Main()
        {
  
            ICollections Collections = new Collections();

            IQueries querys = new Queries(Collections);

            ICommands commands = new Commands(querys);

            MenuDictionary dictionary = new MenuDictionary(commands);

            IExecutionProcess executionProcess = new ExecutionProcess(dictionary);

            executionProcess.Process();

        }

    }

}