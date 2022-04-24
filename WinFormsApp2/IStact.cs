using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public interface IStact
    {
        void Push(Object item);
        object Pop();
        object Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}
