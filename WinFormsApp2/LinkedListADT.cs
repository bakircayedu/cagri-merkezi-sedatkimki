using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size=0;
        public abstract void InsertFirst(Call value);
        public abstract void InsertLast(Call value);
        public abstract void InsertPos(int pos, Call value);
        public abstract void RemoveFirst();
        public abstract void RemoveLast();
        public abstract void RemovePos(int pos);
        public abstract Node GetElementAt(int pos);

        public abstract int GetElementPos(object obj);
        public abstract string DisplayElements();
    }
}
