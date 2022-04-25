using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // Comboboxlara müşteri temsilcileri tanımlanır.
            CustomerRepresentativeComboBox.Items.AddRange(new object[] { Globals.Cr1.Name + " - " + Globals.Cr1.TypeOfService, Globals.Cr2.Name + " - " + Globals.Cr2.TypeOfService, Globals.Cr3.Name + " - " + Globals.Cr3.TypeOfService, Globals.Cr4.Name + " - " + Globals.Cr4.TypeOfService });
            CustomerRepresentativeComboBox2.Items.AddRange(new object[] { Globals.Cr1.Name + " - " + Globals.Cr1.TypeOfService, Globals.Cr2.Name + " - " + Globals.Cr2.TypeOfService, Globals.Cr3.Name + " - " + Globals.Cr3.TypeOfService, Globals.Cr4.Name + " - " + Globals.Cr4.TypeOfService });

        }

        private void AssignCallBtn_Click(object sender, EventArgs e)
        {
            if (AssignCallInputIsValid(CustomerRepresentativeComboBox.SelectedItem)) 
            {
                CustomerRepresentatives Representative = (CustomerRepresentatives)Enum.Parse(typeof(CustomerRepresentatives), (string)CustomerRepresentativeComboBox.SelectedItem.ToString().Split(' ')[0]);
                int CustomerRepresentativeId = (int)Representative;
                CustomerRepresentative ChosenRepresentative = (CustomerRepresentative)FindCustomerRepresentativeById(CustomerRepresentativeId);

                Call call = (Call)Globals.CallQueue.Remove();
                call.AssignCall(ChosenRepresentative);
                Globals.OnCallList.InsertFirst(call);
                this.Close();
   
            }
            
            
        }
        private void AssignSpecificCallBtn_Click(object sender, EventArgs e) 
        {
            string CustomerId = CustomerIdTextBox.Text;
            if (AssignSpecificCallInputIsValid(CustomerRepresentativeComboBox2.SelectedItem,CustomerId))
            {
                CustomerRepresentatives Representative = (CustomerRepresentatives)Enum.Parse(typeof(CustomerRepresentatives), (string)CustomerRepresentativeComboBox2.SelectedItem.ToString().Split(' ')[0]);
                int CustomerRepresentativeId = (int)Representative;
                CustomerRepresentative ChosenRepresentative = (CustomerRepresentative)FindCustomerRepresentativeById(CustomerRepresentativeId);


                Call call = (Call)FindCallById(CustomerId);
                call.AssignCall(ChosenRepresentative);
                Globals.OnCallList.InsertFirst(call);
                FindCallByIdAndRemove(CustomerId);
                this.Close();

            }

        }
        private bool AssignSpecificCallInputIsValid(object rp,string CustomerId) // specific id girilmiş çağrıların inputlarını kontrol eder
        {
            if (Globals.CallQueue.IsEmpty())
            {
                MessageBox.Show("Bekleyen çağrı bulunmamaktadır.");
                return false;
            }
            Call call = (Call)FindCallById(CustomerId);

            if (rp == null)
            {
                MessageBox.Show("Müşteri Temsilcisi seçmelisiniz.");
                return false;
            }else if(call == null) {
                MessageBox.Show("Girdiğiniz çağrı id'si bulunamadı");
                return false;
            }
            CustomerRepresentatives Representative = (CustomerRepresentatives)Enum.Parse(typeof(CustomerRepresentatives), (string)rp.ToString().Split(' ')[0]);
            int CustomerRepresentativeId = (int)Representative;
            CustomerRepresentative ChosenRepresentative = (CustomerRepresentative)FindCustomerRepresentativeById(CustomerRepresentativeId);

            
            if (ChosenRepresentative.TypeOfService != call.Customer.CustomerType)
            {
                MessageBox.Show("Seçtiğiniz müşteri temsilcisi sıradaki müşteriye bakamaz");
                return false;
            }
            else if (ChosenRepresentative.OnCall)
            {
                MessageBox.Show("Seçtiğiniz müşteri temsilcisi şuan başka bir çağrı ile meşgul.");
                return false;
            }
            return true;
        }

        private bool AssignCallInputIsValid( object rp)// sırada bekleyen çağrıların combobox'ını kontrol eder
        {
            if (Globals.CallQueue.IsEmpty())
            {
                MessageBox.Show("Bekleyen çağrı bulunmamaktadır.");
                return false;
            }
            Call call = (Call)Globals.CallQueue.Peek();

            if (rp == null)
            {
                MessageBox.Show("Müşteri Temsilcisi seçmelisiniz.");
                return false;
            }

            CustomerRepresentatives Representative = (CustomerRepresentatives)Enum.Parse(typeof(CustomerRepresentatives), (string)rp.ToString().Split(' ')[0]);
            int CustomerRepresentativeId = (int)Representative;
            CustomerRepresentative ChosenRepresentative = (CustomerRepresentative)FindCustomerRepresentativeById(CustomerRepresentativeId);

            
            if (ChosenRepresentative.TypeOfService != call.Customer.CustomerType)
            {
                MessageBox.Show("Seçtiğiniz müşteri temsilcisi sıradaki müşteriye bakamaz");
                return false;
            }
            else if (ChosenRepresentative.OnCall)
            {
                MessageBox.Show("Seçtiğiniz müşteri temsilcisi şuan başka bir çağrı ile meşgul.");
                return false;
            }
            return true;
        }

        private object FindCustomerRepresentativeById(int Id)// verilen Id ile müşteri temsilcisini bulur.
        {

            CustomerRepresentative ChosenRepresentative = null;
            foreach (CustomerRepresentative cr in Globals.CustomerRepresentatives)
            {
                if (cr.Id == Id)
                {
                    ChosenRepresentative = cr;
                }
            }
            return ChosenRepresentative;
        }
        private object FindCallById(string Id) // Verilen id ile Aranan çağrıyı bulur
        {
            ArrayQueue temp = (ArrayQueue)Globals.CallQueue.Clone();
            while (!temp.IsEmpty())
            {
                Call call = (Call)temp.Remove();
                if (call.Id.ToString() == Id)
                {
                    return call;
                }
            }
            return null;
        }
        private void FindCallByIdAndRemove(string Id) // verilen id ile aranan çağrıyı bulur ve kuyruktan çıkarır.
        {
            ArrayQueue empty = new ArrayQueue(100);
            ArrayQueue temp = (ArrayQueue)Globals.CallQueue.Clone();
            while (!temp.IsEmpty())
            {
                Call call = (Call)temp.Remove();
                if (call.Id.ToString() == Id)
                {
                    // do nothing
                }
                else
                {
                    empty.Insert(call);
                }
            }
            Globals.CallQueue = empty;
        }


    }
}
