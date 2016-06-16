using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ul
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] {"Zbieranie nektaru","Wytwarzanie miodu" });
            workers[1] = new Worker(new string[] { "Pielęgnacja Jaj", "Nauczanie Pszczółek" });
            workers[2] = new Worker(new string[] { "Utrzymanie Ula", "Patrol z Żądłami" });
            workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja Jaj", "Nauczanie Pszczółek", "Utrzymanie Ula", "Patrol z Żądłami" });

          queen = new Queen(workers);

          
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownZmiany_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void assignWorkButton_Click(object sender, EventArgs e)
        {
            
            queen.AssignWork(comboBox1.Text, (int)numericUpDownZmiany.Value);
            
            
        }


        private void nextShiftButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = queen.WorkTheNextShift();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TESTY

            Console.WriteLine("## TESTS ## \n  Wybrana wartosc (Praca): {0}  \n  Wybrana Zmiana: {1}", comboBox1.SelectedItem.ToString(), numericUpDownZmiany.Value);

            //for(int i = 0; i < queen.workers.Length; i++)
            //{
            //    for(int j = 0; j < queen.workers[i].jobsICanDo.Length; j++)
            //    {
            //        Console.WriteLine(string.Format("Pszczola nr {0}, praca : {1}",i,queen.workers[i].jobsICanDo[j]));
            //    }
            //}
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
