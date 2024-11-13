using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class stack
    {
        int top;
        int size;
        int[] arre1;
        public stack(int len)
        {
            size = len;
            arre1 = new int[size];
            top = -1;
        }
        public bool istmpty()
        {
            return (top == -1);
        }
        public bool isfull()
        {
            return (top == size - 1);
        }
        public void push(int elm)
        {
            arre1[++top] = elm;
        }
        public int pop()
        {
            return arre1[top--];
        }
       
        public int stacksize()
        {
            return top + 1;
        }
        public void display()
        {
            for(int i = top; i > -1; i--)
            {
                Console.WriteLine(arre1[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter stack elements");
            stack ste1 = new stack(5);
            stack steven = new stack(5);
            stack stodd = new stack(5);
                for(int i=0; i<5; i++)
            {
                int elm = int.Parse(Console.ReadLine());
                ste1.push(elm);
            }
            Console.WriteLine();
            ste1.display();
            for (int i = 0; i < 5; i++)
            {
                int elmn = ste1.pop();
                if (elmn % 2 == 0)
                {
                    steven.push(elmn);
                }
                else
                {
                    stodd.push(elmn);
                }
            }
                Console.WriteLine("the even stack elements are : ");
                steven.display();
                Console.WriteLine("the odd stack elemnts are : ");
                stodd.display();
                Console.ReadKey();
            }
        }
    }

