using System;
using System.Collections.Generic;
using System.Linq;

namespace Q
{
    public class FindOperations
    {
        private string[] _operations = new string[] { "+", "-", "/", "*" };
        private Stack<string> _store = new Stack<string>();
        private int _count = 0;

        public FindOperations()
        {
            Find("2,3,5,6", "/*-+", 24);
        }

        public bool Find(string numbers, string operations, int total)
        {
            _count++;
            var arr = numbers.Split(',');
            if(arr.Length == 1 && Convert.ToInt32(arr[0]) == total)
            {
                return true;
            }

            for (int i = 0; i < operations.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    var a = Convert.ToInt32(arr[j]);
                    var b = Convert.ToInt32(arr[j+1]);
                    int newNumber = 0;
                    switch (operations[i])
                    {
                        case '+': { newNumber = a + b; } break;
                        case '-': { newNumber = a - b; } break;
                        case '/': 
                        { 
                            //newNumber = a / b;
                            if((a%b) == 0)
                            {
                                newNumber = a / b;
                            } 
                            else
                            {
                                continue;
                            }
                        } break;
                        case '*': { newNumber = a * b; } break;
                    }

                    var result = Find(numbers.Replace($"{arr[j]},{arr[j+1]}", newNumber.ToString()), operations.Remove(i, 1), total);
                    //var result = Find(numbers.Replace($"{arr[j]},{arr[j+1]}", newNumber.ToString()), operations, total);
                    if(result)
                    {
                        _store.Push($"{a}{operations[i]}{b}");
                        return true;
                    }
                }
            }

            return false;
        }
    }
}