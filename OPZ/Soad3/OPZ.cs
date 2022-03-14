using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soad3
{
    class OPZ
    {
        static private bool IsDelimeter(char c)
        {
            if ((" ".IndexOf(c) != -1))
                return true;
            return false;
        }

        static private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }

        static private byte GetPriority(char s)
        {
            switch (s)
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

        static public string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> Stack = new Stack<char>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                
                if (IsDelimeter(input[i]))
                    continue; 

                
                if (Char.IsDigit(input[i])) //Записываем число
                {
                    
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i]; 
                        i++; 

                        if (i == input.Length) break; 
                    }

                    output += " "; 
                    i--;
                    continue;
                }

                
                if (IsOperator(input[i])) 
                {
                    if (input[i] == '(')  { Stack.Push(input[i]); continue; }
                    if (input[i] == ')')
                    {
                        char s = Stack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = Stack.Pop();
                        }
                        continue;
                    }
                    
                    {
                        if (Stack.Count > 0)
                            if (GetPriority(input[i]) <= GetPriority(Stack.Peek())) //И если приоритет нашего оператора меньше или равен приоритету оператора на вершине стека
                                output += Stack.Pop().ToString() + " "; //То добавляем последний оператор из стека в строку с выражением

                        Stack.Push(char.Parse(input[i].ToString())); //Если стек пуст, или же приоритет оператора выше - добавляем операторов на вершину стека

                    }
                }
            }

            
            while (Stack.Count > 0)
                output += Stack.Pop() + " ";

            return output; 
        }

        static public double Counting(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i])) //Пока не разделитель,записываем все число
                    {
                        a += input[i]; 
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); //Записываем в стек
                    i--;
                }
                else if (IsOperator(input[i])) //Если символ - оператор
                {
                    
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (input[i]) //Делаем наше действие
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                    }
                    temp.Push(result); //Записываем результат вычисления
                }
            }
            return temp.Peek(); //Берем конечный ответ (последнее в стеке)
        }

        static public double Calculate(string input)
        {
            string output = GetExpression(input); 
            double result = Counting(output); 
            return result;
        }
    }
}
