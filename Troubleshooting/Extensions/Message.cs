using System;
using System.Diagnostics;

namespace Troubleshooting
{
    /// <summary>
    /// Class using method chaining
    /// </summary>
    public class Message
    {
        private string Content { get; set; }

        public Message(string content)
        {
            this.Content = content; 
        }

        public Message Print()
        {
            Console.WriteLine(this);
            return this;
        }

        public Message Output()
        {
            Debug.WriteLine(this);
            return this;
        }
    }
}
