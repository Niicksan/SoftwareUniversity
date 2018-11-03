using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            this.data = new List<string>();
        }

        public void Push(string element)
        {
            this.data.Add(element);
        }

        public string Pop()
        {
            if (data.Count > 0)
            {
                string element = this.data.Last();
                this.data.Remove(element);
                return element;
            }

            return "Stack is emoty";
        }

        public string Peek()
        {
            if (data.Count > 0)
            {
                string element = this.data.Last();
                return element;
            }

            return "Stack is emoty";
        }

        public bool IsEmpty()
        {
            if (data.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
