using System;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    internal class PRNCalc
    {
        static public double Calculate(string input)
        {
            string output = GetExpression(input);
            double result = Counting(output);
            return result;
        }

        static private string GetExpression(string input) //функция, приводящая выражение стандартного вида к виду обратной польской нотации
        {
            string output = String.Empty;
            Stack<char> operStack = new Stack<char>(); //объявление стэка операторов

            for (int i = 0; i < input.Length; i++) //проход по символам строки
            {
                if (IsDelimiter(input[i])) //если разделитель - пропустить
                {
                    continue;
                }

                if (Char.IsDigit(input[i])) //инструкции если символ - цифра
                {

                    while (!IsDelimiter(input[i]) && !IsOperator(input[i])) //цикл выполняется, пока символ не разделитель, равно или оператор
                    {

                        output += input[i]; //добавление к строке-результату цифры
                        i++;
                        if (i == input.Length) break; //если символ - последний, то прерываем цикл
                    }

                    i--; //возвращаемся к символу до оператора или разделителя
                    output += ' '; //добавляем пробел между значениями в строку

                }

                if (IsOperator(input[i])) //инструкции если символ - оператор 
                {

                    if (input[i] == '(') //если оператор - открывающая скобка
                    {
                        operStack.Push(input[i]); //добавляем её в стек
                    }

                    else if (input[i] == ')') //если оператор - закрывающая строка
                    {
                        char s = operStack.Pop(); //извлекаем из стека операторов последнее значение
                        while (s != '(') //проходим по стеку операторов до последней добавленной открывающей скобки
                        {
                            output += s.ToString() + ' '; //добавляем к строке-результату оператор из стека
                            s = operStack.Pop(); //извлекаем из стека операторов следующее значение
                        }
                    }
                    else
                    {
                        if (operStack.Count > 0) //если в стеке операторов есть значение
                        {
                            if (GetPrioruty(input[i]) <= GetPrioruty(operStack.Peek())) //и если оператор на входящей строке имеет меньший или равный приоритет, что у последнего оператора в стеке  
                            {
                                output += operStack.Pop().ToString(); //извлекаем и добавляем к строке-результату оператор из стека

                            }
                        }
                        operStack.Push(char.Parse(input[i].ToString())); //добавляем в стек операторов текущий оператор из ввода
                    }
                }
            }

            while (operStack.Count != 0) //пока в стеке есть символы
            {
                output += operStack.Pop().ToString(); //добавляем к строке-результату операторы, извлечённые из стека операторов
            }
            return output; //возвращаем строку-результат 
        }

        static private double Counting(string input) //Функция подсчёта значения, получает на вход выражение в обратной польской нотации и вычисляет результат на его основе
        {
            double result = 0;
            Stack<double> temp = new Stack<double>(); //создание временного стека

            for (int i = 0; i < input.Length; i++) //проход по символам строки
            {
                if (Char.IsDigit(input[i])) //если символ - цифра
                {
                    string a = String.Empty; //строка для временного размещения числа перед добавлением в стек

                    while (!IsDelimiter(input[i]) && !IsOperator(input[i])) //цикл прохода по знакам, пока не встретится разделитель, равно или оператор
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break; //если знак - последний в строке, прерываем цикл
                    }

                    temp.Push(Convert.ToDouble(a)); //добавление временной строки с числом в стек 
                    i--; //возвращение к знаку до разделителя или оператора
                }

                if (IsOperator(input[i])) //если символ - оператор
                {
                    double a = temp.Pop(); //вынос воторго операнда из стека 
                    double b = temp.Pop(); //вынос первого операнда из стека
                    switch (input[i]) //совершение операции в зависимости от оператора
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
                    temp.Push(result); //замена пары операндов на результат операции над ними
                }
            }
            return temp.Peek(); //возврат последнего значения из стека(результата) 

        }

        static private bool IsDelimiter(char c) //функция проверки символа на то, является ли он пробелом-резделителем или знаком равно
        {
            if (" =".IndexOf(c) != -1) return true;
            return false;
        }

        static private bool IsOperator(char c) //функция проверки, является ли символ оператором
        {
            if ("+-*/^()".IndexOf(c) != -1) return true;
            return false;
        }

        static private int GetPrioruty(char c) //функция проверки приоритета оператора
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