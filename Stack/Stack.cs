using System;
using System.Collections.Generic;


namespace Stack
{
    public class Stack
    {


        private List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Cannot add null object to stack!");
            }
            else
            {
                _stack.Add(obj);
            }

        }

        public object Pop()
        {
            int count = _stack.Count;
            object output;

            if (count > 0)
            {
                output = _stack[count - 1];
                _stack.RemoveAt(count - 1);
                return output;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty!");
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
