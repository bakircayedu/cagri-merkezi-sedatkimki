using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    [Serializable]
    public class Stack : IStact, ICloneable
    {
        private object[] items;
        private int top = -1;

        public Stack(int size)
        {
            this.items = new object[size];
        }
        public int Top { get { return top; } set { top=value; } }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public object Peek()
        {
            return items[Top];
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: stack bos... downflow");
            }
            Object temp = items[Top--];
            return temp;
        }

        public void Push(object item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Hata: stack doldu... overflow");
            }
            items[++Top] = item;
        }
        public object Clone()// Stack yapısını kopyalamamızı sağlar
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }
                return null;
            }
        }
    }
}
