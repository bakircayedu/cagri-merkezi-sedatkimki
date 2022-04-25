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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReportTable.Rows.Clear();
            Sort(Globals.CustomerRepresentatives);
            foreach (CustomerRepresentative c in Globals.CustomerRepresentatives.Reverse())
            {
                if (c.CurrentCall!=null)
                {
                    ReportTable.Rows.Add(c.Name, c.Id, c.TypeOfService, c.CallCount, c.CurrentCall.Id.ToString() );
                }
                else
                {
                    ReportTable.Rows.Add(c.Name, c.Id, c.TypeOfService, c.CallCount, " ");
                }
            }
            
        }

        private void Sort(object[] CustomerRepresentatives) { // bubble sort algoritması ile müşteri temsilcilerini tamamlanan arama sayısına göre sıralama
            int scan;
            bool swapped = false;
            for ( scan = 0; scan< CustomerRepresentatives.Length; scan++) {
                swapped = false;
                for (int i = 0; i < (CustomerRepresentatives.Length-scan-1); i++)
                {
                    if (((CustomerRepresentative)CustomerRepresentatives[i]).CallCount > ((CustomerRepresentative)CustomerRepresentatives[i+1]).CallCount)
                    {
                        object temp = CustomerRepresentatives[i];
                        CustomerRepresentatives[i] = CustomerRepresentatives[i+1];
                        CustomerRepresentatives[i+1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            
        }
    }
}
