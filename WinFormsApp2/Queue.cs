using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    [Serializable]
    public class ArrayQueue: IQueue,ICloneable
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count= 0;

        public ArrayQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }

        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
                throw new Exception("queue is full");
            if (front == -1)
            {
                front = 0;
            }
            Queue[++rear] = o;
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front++;
            count--;
            return temp;
        }

        public object Clone() // Queue yapısını kopyalamamızı sağlar
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
