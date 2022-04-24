using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    
    [Serializable]
    public class Customer
    {

        public string Id { get; set; }
        public ECustomerType CustomerType { get; set; }
        public Customer(ECustomerType customertype,string id)
        {
            CustomerType = customertype;
            Id = id;
        }
    }
}
