using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public enum ECustomerType
    {
        Individual,
        Commercial
    }

    public enum CustomerRepresentatives
    {
        Sedat,
        Ali,
        Deniz,
        Okan
    }
    public static class Globals // tüm uygulama içinde kullanılan global değişkenler sınıfı
    {
        public static bool isSampleDataLoad;
        public static CustomerRepresentative Cr1 { get; set; }
        public static CustomerRepresentative Cr2 { get; set; }
        public static CustomerRepresentative Cr3 { get; set; }
        public static CustomerRepresentative Cr4 { get; set; }
        public static object[] CustomerRepresentatives { get; set; }

        public static ArrayQueue CallQueue { get; set; }

        public static Stack EndedCalls{ get; set; }

        public static LinkedList OnCallList { get; set; }
        static Globals()
        {
            isSampleDataLoad = false;
            Cr1 = new CustomerRepresentative("Sedat", ECustomerType.Individual);
            Cr2 = new CustomerRepresentative("Ali", ECustomerType.Individual);
            Cr3 = new CustomerRepresentative("Deniz", ECustomerType.Commercial);
            Cr4 = new CustomerRepresentative("Okan", ECustomerType.Commercial);
            CustomerRepresentatives = new object[] {Cr1, Cr2, Cr3, Cr4};
            CallQueue = new ArrayQueue(100);
            EndedCalls = new Stack(100);
            OnCallList = new LinkedList();
            
        }
    }
}
