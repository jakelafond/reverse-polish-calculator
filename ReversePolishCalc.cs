using System;
using System.Collections;
using System.Collections.Generic;

namespace Daily_Project_Reverse_Polish_Calculator
{
public class ReversePolishCalc {

    // You'll need a variable here to keep track of the top of the stack
    private string TopOfStack;

    // The array of the input string split up
    private String[] tokens;

    // The stack
    private Stack<string> stack = new Stack<string>();

    public double Calculate(String input) {

        // 1. Use the String split method to split the string into tokens at the commas
        tokens = input.Split(',');
        
        // 3. write the algorithm
        for(int i = 0; i < tokens.Length; ++i) {
            // calls to push() and pop() and do the math here
            if(tokens[i] == "+"){
               var a = double.Parse(stack.Pop());
               var b = double.Parse(stack.Pop());
               var result = a+b;
               var realResult = result.ToString();
               stack.Push(realResult);
            }
            else if (tokens[i] == "-")
            {
               var a = double.Parse(stack.Pop());
               var b = double.Parse(stack.Pop());
               var result = a-b;
               var realResult = result.ToString();
               stack.Push(realResult);
            }
                        else if (tokens[i] == "/")
            {
               var a = double.Parse(stack.Pop());
               var b = double.Parse(stack.Pop());
               var result = a/b;
               var realResult = result.ToString();
               stack.Push(realResult);
            }
                        else if (tokens[i] == "*")
            {
               var a = double.Parse(stack.Pop());
               var b = double.Parse(stack.Pop());
               var result = a*b;
               var realResult = result.ToString();
               stack.Push(realResult);
            }
            else {
                stack.Push(tokens[i]);
            }

        }
        var finalResult = stack.Pop();

        // 4. return the result
        return double.Parse(finalResult);
    }

    // private void Push(String number) {
    //     // push on the stack
    //     stack.Push(number);
    // }

    // private void Push(double d) {
    //     // change the double to a string and then push it on the stack
    // }

    // private double Pop() {
    //     // remove the string from the top of the stack and convert it to a double and return it
    // }
}
    
}
