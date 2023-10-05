using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class PRNCalc
    {
        static public double Calculate(string input)
        {
            string output = GetExpression(input);
            Console.WriteLine(output);
            double result = Counting(output);
            return result;
        }

        static private string GetExpression(string input)
        {
            string output = String.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (IsDelimiter(input[i]))
                {
                    continue;
                }

                if (Char.IsDigit(input[i]))
                {

                    while (!IsDelimiter(input[i]) && !IsOperator(input[i]))
                    {

                        output += input[i];
                        i++;
                        if (i == input.Length) break;
                    }

                    i--;
                    output += ' ';

                }

                if (IsOperator(input[i]))
                {

                    if (input[i] == '(')
                    {
                        operStack.Push(input[i]);
                    }

                    else if (input[i] == ')')
                    {
                        char s = operStack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0)
                        {
                            if (GetPrioruty(input[i]) <= GetPrioruty(operStack.Peek()))
                            {
                                output += operStack.Pop().ToString();

                            }
                        }
                        operStack.Push(char.Parse(input[i].ToString()));
                    }
                }
            }

            while (operStack.Count != 0)
            {
                output += operStack.Pop().ToString();
            }
            return output;
        }

        static private double Counting(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    string a = String.Empty;

                    while (!IsDelimiter(input[i]) && !IsOperator(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }

                    temp.Push(Convert.ToDouble(a));
                    i--;
                }

                if (IsOperator(input[i]))
                {
                    double a = temp.Pop();
                    double b = temp.Pop();
                    switch (input[i])
                    {
                        case '+':
                            result = b + a;
                            break;
                        case '-':
                            result = b - a;
                            break;
                        case '*':
                            result = b * a;
                            break;
                        case '/':
                            result = b / a;
                            break;
                        case '^':
                            result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString());
                            break;
                    }
                    temp.Push(result);
                }
            }
            return temp.Peek();

        }

        static private bool IsDelimiter(char c)
        {
            if (" =".IndexOf(c) != -1) return true;
            return false;
        }

        static private bool IsOperator(char c)
        {
            if ("+-*/^()".IndexOf(c) != -1) return true;
            return false;
        }

        static private int GetPrioruty(char c)
        {
            switch (c)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 6;
            }
        }
    }
}
