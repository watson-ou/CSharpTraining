using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * This class demonstrates various scopes for variables
 * Chris Barker
 * January 2017
 * ****************************************************************************/

namespace Module01
{
    class VariableScopes
    {
        // These variables are scoped to the class
        int age = 7;
        string name = "Chris Barker";
        DateTime created = DateTime.Now;

        void aMethod()
        {
            // These variables are scoped to the "aMethod()" method
            int sum = 0;
            decimal factor = 0.0M;
            string message = String.Empty;

            for (int retryCount = 0; retryCount < 3; retryCount++)
            {
                // These variables are scoped to the for loop construct
                // They go out of scope at the closing curly brace - }
                Random rand = new Random();
                int randomNumber = rand.Next();
            } // for
        } // aMethod
    } // VariableScopes class
} // namespace
