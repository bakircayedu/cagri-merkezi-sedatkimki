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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ResultTable.Rows.Clear();

        }

        private bool Contains(string Notes, string SearchKey) // lineer search algoritmasi ile icerme durumunu öğrenme
        {
            string[] SplittedByWords = Notes.ToLower().Split(' ');
            for (int i = 0; i < SplittedByWords.Length; i++)
            {
                if (SplittedByWords[i] == SearchKey.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void AraBtn_Click(object sender, EventArgs e) // tamamlanmış çağrılarda aranan kelimenin içerip içermediği
        {
            string SearchKey = SearchTxtBox.Text.ToLower();
            ResultTable.Rows.Clear();
            Stack temp = (Stack)Globals.EndedCalls.Clone();
            while (temp != null && !temp.IsEmpty())
            {

                Call call = (Call)temp.Pop();
                if (Contains(call.Notes, SearchKey))
                {
                    ResultTable.Rows.Add(call.Id, call.CallTime.ToLongTimeString(), call.CustomerRepresentative.Name, call.Notes);
                }

            }
        }
    }
}
