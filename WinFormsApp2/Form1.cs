using System.Collections;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeRepresentatives() // M��teri temsilcisi i�lemlerinin y�netildi�i kutular� aktif �a�r�lara g�re d�zenler.
        {
            Cr1Lbl.Visible = false;
            Cr1TxtBox.Visible = false;
            Cr1Btn.Visible = false;

            Cr2Btn.Visible = false;
            Cr2Lbl.Visible = false;
            Cr2TxtBox.Visible = false;

            Cr3Btn.Visible = false;
            Cr3TxtBox.Visible = false;
            Cr3Lbl.Visible = false;

            Cr4Btn.Visible = false;
            Cr4TxtBox.Visible = false;
            Cr4Lbl.Visible = false;

            Node head = Globals.OnCallList.Head;
            while (head != null)
            {
                if (head.Data.CustomerRepresentative.Name == "Sedat")
                {
                    Cr1Lbl.Visible = true;
                    Cr1TxtBox.Visible = true;
                    Cr1Btn.Visible = true;
                }
                else if (head.Data.CustomerRepresentative.Name == "Ali")
                {
                    Cr2Btn.Visible = true;
                    Cr2Lbl.Visible = true;
                    Cr2TxtBox.Visible = true;
                }
                else if (head.Data.CustomerRepresentative.Name == "Deniz")
                {
                    Cr3Btn.Visible = true;
                    Cr3TxtBox.Visible = true;
                    Cr3Lbl.Visible = true;
                }
                else if (head.Data.CustomerRepresentative.Name == "Okan")
                {
                    Cr4Btn.Visible = true;
                    Cr4TxtBox.Visible = true;
                    Cr4Lbl.Visible = true;
                }
                head = head.Next;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdateQueueList(Globals.CallQueue);
            InitializeRepresentatives();
        }
        private void LoadSampleData() // �rnek 15 tane �a�r� ekler.
        {
            if (!Globals.isSampleDataLoad)
            {

                // Call Queue
                // Customers
                Customer cust1 = new Customer(ECustomerType.Commercial, "123sgs3");
                Customer cust2 = new Customer(ECustomerType.Individual, "dfgj1231");
                Customer cust3 = new Customer(ECustomerType.Commercial, "asdf123");
                Customer cust4 = new Customer(ECustomerType.Individual, "123dkc132");
                Customer cust5 = new Customer(ECustomerType.Commercial, "4325fdasdf");
                Customer cust6 = new Customer(ECustomerType.Individual, "324dgasd23");
                Customer cust7 = new Customer(ECustomerType.Commercial, "dfgsd2412fasd");
                Customer cust8 = new Customer(ECustomerType.Individual, "34534sdfsdf34");
                Customer cust9 = new Customer(ECustomerType.Commercial, "sdg234f");
                Customer cust10 = new Customer(ECustomerType.Individual, "sdf321");
                Customer cust11 = new Customer(ECustomerType.Commercial, "123czds231");
                Customer cust12 = new Customer(ECustomerType.Individual, "sdf134rs4");
                Customer cust13 = new Customer(ECustomerType.Commercial, "sdf452vd");
                Customer cust14 = new Customer(ECustomerType.Individual, "as452asd");
                Customer cust15 = new Customer(ECustomerType.Commercial, "231as45y5");
                // Calls
                Call newCall = new Call(cust1);
                newCall.CallTime = DateTime.Now.AddMinutes(-15);
                Call newCall2 = new Call(cust2);
                newCall2.CallTime = DateTime.Now.AddMinutes(-14);
                Call newCall3 = new Call(cust3);
                newCall3.CallTime = DateTime.Now.AddMinutes(-13);
                Call newCall4 = new Call(cust4);
                newCall4.CallTime = DateTime.Now.AddMinutes(-12);
                Call newCall5 = new Call(cust5);
                newCall5.CallTime = DateTime.Now.AddMinutes(-11);
                Call newCall6 = new Call(cust6);
                newCall6.CallTime = DateTime.Now.AddMinutes(-10);
                Call newCall7 = new Call(cust7);
                newCall7.CallTime = DateTime.Now.AddMinutes(-9);
                Call newCall8 = new Call(cust8);
                newCall8.CallTime = DateTime.Now.AddMinutes(-8);
                Call newCall9 = new Call(cust9);
                newCall9.CallTime = DateTime.Now.AddMinutes(-7);
                Call newCall10 = new Call(cust10);
                newCall10.CallTime = DateTime.Now.AddMinutes(-6);
                Call newCall11 = new Call(cust11);
                newCall11.CallTime = DateTime.Now.AddMinutes(-5);
                Call newCall12 = new Call(cust12);
                newCall12.CallTime = DateTime.Now.AddMinutes(-4);
                Call newCall13 = new Call(cust13);
                newCall13.CallTime = DateTime.Now.AddMinutes(-3);
                Call newCall14 = new Call(cust14);
                newCall14.CallTime = DateTime.Now.AddMinutes(-2);
                Call newCall15 = new Call(cust15);
                newCall15.CallTime = DateTime.Now.AddMinutes(-1);
                // Inserts
                Globals.CallQueue.Insert(newCall);
                Globals.CallQueue.Insert(newCall2);
                Globals.CallQueue.Insert(newCall3);
                Globals.CallQueue.Insert(newCall4);
                Globals.CallQueue.Insert(newCall5);
                Globals.CallQueue.Insert(newCall6);
                Globals.CallQueue.Insert(newCall7);
                Globals.CallQueue.Insert(newCall8);
                Globals.CallQueue.Insert(newCall9);
                Globals.CallQueue.Insert(newCall10);
                Globals.CallQueue.Insert(newCall11);
                Globals.CallQueue.Insert(newCall12);
                Globals.CallQueue.Insert(newCall13);
                Globals.CallQueue.Insert(newCall14);
                Globals.CallQueue.Insert(newCall15);

                Globals.isSampleDataLoad = true;
            }

        }


        private void MakeCallBtn_Click(object sender, EventArgs e)
        {
            
            if (MakeCallInputsIsValidate(CustomerIdTextBox.Text, CustomerTypeComboBox.SelectedItem))
            {
                string customerId = CustomerIdTextBox.Text;
                ECustomerType customerType = (ECustomerType)Enum.Parse(typeof(ECustomerType), (string)CustomerTypeComboBox.SelectedItem.ToString());
                Customer newCustomer = new Customer(customerType, customerId);
                Call newCall = new Call(newCustomer);
                Globals.CallQueue.Insert(newCall);
                UpdateQueueList(Globals.CallQueue);
            }
            CustomerIdTextBox.Clear();
            CustomerTypeComboBox.SelectedIndex = -1;
        }

        // Queue yap�s� kullan�larak olu�turulmu� �a�r� s�ras�n� Form uygulamas� �st�ndeki DataGridView'da g�r�nt�ler
        public void UpdateQueueList(ArrayQueue q)
        {
            CallTable.Rows.Clear();
            int count = 1;
            ArrayQueue temp = (ArrayQueue)q.Clone();

            while (!temp.IsEmpty())
            {
                Call call = (Call)temp.Remove();
                CallTable.Rows.Add(count, call.Id.ToString(), call.Customer.CustomerType.ToString(), call.Customer.Id.ToString(), call.CallTime.ToLongTimeString());
                count++;
            }

        }
        // Yeni �a�r� olu�turma i�lemindeki inputlar�n do�ru girilip girilmedi�ini kontrol eder.
        private bool MakeCallInputsIsValidate(string customerId, object customerType)
        {
            if (customerId == "" && customerType == null)
            {
                MessageBox.Show("L�tfen m��teri t�r� se�iniz ve id giriniz");
                return false;
            }
            else if (customerType == null)
            {
                MessageBox.Show("M��teri t�r�n� se�melisiniz.");
                return false;
            }
            else if (customerId == "")
            {
                MessageBox.Show("L�tfen id giriniz.");
                return false;
            }
            else
            {
                foreach (DataGridViewRow row in CallTable.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(customerId))
                    {
                        MessageBox.Show("Ayn� id'e sahip ba�ka bir m��teri olamaz.");
                        return false;
                    }
                }
            }
            return true;
        }
        // �a�r�lar� atama ekran�na y�nlendirir
        private void AssignCallBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        // �a�r� bekleme listesini ve M��teri temsilcelerinin durumunu g�nceller.
        private void Form1_Activated(object sender, EventArgs e)
        {
            UpdateQueueList(Globals.CallQueue);
            InitializeRepresentatives();
        }
        // buradaki 4 fonksiyon m��teri temsilcilerinin �a�r�y� bitirmesini sa�lar.
        private void Cr1Btn_Click(object sender, EventArgs e)
        {
            EndCall(Globals.Cr1.CurrentCall, Cr1TxtBox);

        }

        private void Cr2Btn_Click(object sender, EventArgs e)
        {
            EndCall(Globals.Cr2.CurrentCall, Cr2TxtBox);
            
        }

        private void Cr3Btn_Click(object sender, EventArgs e)
        {
            EndCall(Globals.Cr3.CurrentCall, Cr3TxtBox);
            
        }

        private void Cr4Btn_Click(object sender, EventArgs e)
        {
            EndCall(Globals.Cr4.CurrentCall, Cr4TxtBox);
            
        }
        // �a�r�lar�n bitirilip  Stacke at�lmas�n� sa�lar
        private void EndCall(Call call,TextBox txt)
        {
            Call CurrentCall = call;
            Globals.EndedCalls.Push(CurrentCall);
            int pos = Globals.OnCallList.GetElementPos(CurrentCall);
            Globals.OnCallList.RemovePos(pos);
            InitializeRepresentatives();
            CurrentCall.EndCall(txt.Text.ToString());
        }

        // M��teri temsilcilerinin s�ralanm�� halini g�steren bir form a�ar.
        private void SortedCallsBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        // Bitirilmi� �a�r�lar�n bilgilerini raporlayan bir form uygulamas�na y�nlendirir.
        private void EndedCallsLogBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        // �rnek veri setini y�klenmesini ve formun tekrar yenilenmesini sa�lar
        private void LoadSampleDataBtn_Click(object sender, EventArgs e)
        {
            LoadSampleData();
            UpdateQueueList(Globals.CallQueue);
            InitializeRepresentatives();
        }
        // notlar i�inde arama ekran�na y�nlendirir
        private void SearchBySenteceBtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}