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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ReportTable.Rows.Clear();
            Stack temp = (Stack)Globals.EndedCalls.Clone();
            while (temp != null && !temp.IsEmpty())
            {
                Call call = (Call)temp.Pop();
                ReportTable.Rows.Add(call.Id,call.Customer.Id,call.Customer.CustomerType,call.CallTime.ToLongTimeString(), call.StartTime.ToLongTimeString(), call.EndTime.ToLongTimeString(), call.CustomerRepresentative.Name,call.Notes);
            }
        }
    }
}
