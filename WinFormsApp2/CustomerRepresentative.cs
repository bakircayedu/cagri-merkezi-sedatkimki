using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    [Serializable]
    public class CustomerRepresentative
    {

        private static int NextId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ECustomerType TypeOfService { get; set; }
        public bool OnCall { get; set; }
        public int CallCount = 0;
        public Call CurrentCall { get; set; }

        public CustomerRepresentative(string name,ECustomerType typeofservice)
        {

            Id = NextId;
            NextId = NextId + 1;
            Name = name;
            TypeOfService = typeofservice;
            OnCall = false;

        }

        
    }
}
