using System.Runtime.InteropServices.WindowsRuntime;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System;
using System.Globalization;
namespace Week5
{
    public class InclassNode
    {
        public InclassNode next;
        public int value{
            get { return this.value; } 
            set { this.value = value; }
            };

        public InclassNode()
        {
            this.next = null;
            this.value = 0;
        }
    

    }
    public inclassStack(int value)
    {
        this.next = null;
        this.value = value; 
    }
    public void setValue(int value)
    {
        this.value = value;
    }
    public int getValue()
    {
        return this.value;
    }

    public class InclassStack
    {
        public InclassNode top;
        public int count;

        public InclassStack()
        {
            this.top = null;
            this.count = 0;

        }

        public InclassStack(int value)
        {
            this.top = new InclassNode(value);
            this.count++;
        }

        public void Push(int value)
        {
            InclassNode newNote = new InclassNode(value);
            newNote.next = this.top;
            this.top = newNote;
            this.count++;

        }

        public int Pop()
        {
            InclassNode temp = this.top.next;
            this.top = this.top.next;
            this.count--;
            return temp.value;
        }

        public int StackTop()
        {
            if (this.top == null)
                return -1;
            
            return this.top.value;
        
        }
    }
    
}