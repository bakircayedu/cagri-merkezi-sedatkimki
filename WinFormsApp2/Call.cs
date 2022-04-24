using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    [Serializable]
    public class Call
    {
        private static int NextId { get; set; }
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime CallTime { get; set; }

        public CustomerRepresentative CustomerRepresentative { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes{ get; set; }
        public Call(Customer c)
        {
            Id = NextId;
            NextId = NextId + 1;
            CallTime = DateTime.Now;
            Customer = c;
            
        }

        public void AssignCall(CustomerRepresentative cr) { // Müşteri temsilcisi ile bir görüşme başlatılır.
            
            CustomerRepresentative = cr;
            cr.CallCount++;
            cr.CurrentCall = this;
            cr.OnCall = true;
            StartTime = DateTime.Now;
        }

        public void EndCall(string notes)// Müşteri temsilcisi yapılan görüşme bitirilir.
        {
            CustomerRepresentative.OnCall = false;
            CustomerRepresentative.CurrentCall= null;
            EndTime = DateTime.Now;
            Notes = notes;
        }
        

    }
}
