using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Session06
{
    internal class Generics
    {
        public Generics()
        {
            var stackInt = new StackInt();
            stackInt.Push(1);
            stackInt.Push(2);
            stackInt.Push(3);

            var x = stackInt.Pop(); // x = 3

            stackInt.Push(4);            

            var a = stackInt.Pop(); // a = 4
            var b = stackInt.Pop(); // b = 2


            var s1 = new StackGeneric<int>();
            s1.Push(1);

            var s2 = new StackGeneric<string>();
            s2.Push("hi");

            var s3 = new StackGeneric<bool>();
            s3.Push(false);

            var s4 = new StackGeneric<AppSettings>();
        }

    }

    //Stack - LIFO (Last In, First Out)



    class StackGeneric<T>
    {
        List<T> list = new List<T>();

        public void Push(T val)
        {
            list.Add(val);
        }

        public T Pop()
        {
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }

    class StackInt
    {
        List<int> list = new List<int>();

        public void Push(int val)
        {
            list.Add(val);
        }

        public int Pop()
        {
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }

    class StackString
    {
        List<string> list = new List<string>();

        public void Push(string val)
        {
            list.Add(val);
        }

        public string Pop()
        {
            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return result;
        }
    }
}
