﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===================================================================
 * Exception Handling in C# | Try | Catch | Finally | Throw | Overview
 * ===================================================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
 *      https://www.w3schools.com/cs/cs_exceptions.php
 *      
 *      When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
 *      
 *      When an error occurs, C# will normally stop and generate an error message. The technical term fro this is: "C# will throw an exception(throw an error)".
 *      
 *      The C# language's exception handling features helo you deal with any unexcepted or exceptional situations that occur when a program is running. Exception handling
 *  uses 'try', 'catch', and 'finally' keywords to try actions that may not succeed, to handle failures when you decide that it's reasonable to do so, and to clean up resources
 *  afterward. Exceptions can be generated by the common language runtime(CLR), by .NET or third-party libraries, or by application code. Exceptions are created by using the 'throw' keyword.
 *  
 *      In many cases, an exception may be thrown not by a method that your code has called directly, but by another method further down in the call stack. When an exception
 *  is thrown, the CLR will unwind the stack, looking for a method with a 'catch' block for the specific exception type, and it will execute the first such 'catch' blick that
 *  it finds. If it finds no appropriate 'catch' block anywhere is the call stack, it will terminate the process and display a message to the user.
 * 
 * --------------------
 * Exceptions Overview:     #| Exceptions are types that all ultimately derive from System.Exception
 * --------------------     
 *                          #| Use a try block around the statement that might throw exceptions
 *                          
 *                          #| Once an exception occurs in the try block, the flow of control jumps to the first associated exception handler that
 *                             is present anywhere in the call stack. In C#, the 'catch' keyword is used to define an exception handler.
 *                          
 *                          #| If no exception handler for a given exception is present, the program stops executing with an error message.
 *                          
 *                          #| Don't catch an exception unless you can handle it and leave the application in a known state. If you catch System.Exception,
 *                             rethrow it using the 'throw' keyword at the end of the 'catch' block.
 *                          
 *                          #| If a 'catch' block defines an exception variable, you can use it to obtain more information about the type of exception that occured.
 *                          
 *                          #| Exceptions can be explicitly generated by a program by using the 'throw' keyword.
 *                          
 *                          #| Exception objects contain detailed information about the error, such as the state of the call stack and a text description of the error.
 *                          
 *                          #| Code in a 'finally' block is executed regardless of if an exception if thrown. Use 'finally' block to release resources, 
 *                             for example to close any streams or files that were opened in the 'try' block.
 * 
 *      The 'try' statement allows you to define a block of code to be tested for errors while it's being executed.
 *      
 *      The 'catch' statement allows you to define a block of code to be executed, if an error occurs in the 'try' block
 * 
 *      The 'finally' statement lets you execute code, after 'try...catch', regardless of the result.
 *      
 *      The 'throw' statement allows you to create a custom error.
 *  The 'throw' statement is used together with an exception class. There are many exception classes available in C#: - ArithmeticException, 
 *                                                                                                                    - FileNotFoundException, 
 *                                                                                                                    - IndexOutOfRangeException, 
 *                                                                                                                    - TimeOutException, 
 *                                                                                                                      etc.
 *                                                                                                                      
 *      In this following example, a method tests for division by zero and catches the error. Without the exception handling, this program would terminate with a
 *  DivideByZeroException was unhandled error:
 * 
 */

namespace MyProject_144
{
    public class Program
    {
            static double SafeDivision(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();
                return x / y;
            }
        static void Main(string[] args)
        {
            // Input for test purposes. Change the values to see exception handling behavior
            double a = 98, b = 0;
            double result;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero");
            }
        }
    }
}