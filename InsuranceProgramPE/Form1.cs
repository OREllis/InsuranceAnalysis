using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceProgramPE
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        //declaring class
        InsuranceAnalysis IA = new InsuranceAnalysis();

        private void btnAdd_Click(object sender, EventArgs e) {
            //passing String from txtPremium to add to list in class file
            IA.addPremium(txtPremium.Text);

            //empty listbox
            lstPremiums.DataSource = null;
            lstPremiums.DataSource = IA.allPremiums;

            //display list info in labels
            setLabels();
        }

        private void btnSort_Click(object sender, EventArgs e) {
            //empty listbox
            lstSorted.DataSource = null;
            lstSorted.DataSource = IA.sortPremiums();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void setLabels() {
            //setting label text to itself + returned values respective functions converted to currency
            lblPremiums.Text = "Total Premiums entered are: " + IA.allPremiums.Count();
            lblMax.Text = "Largest Premium entered is: " + IA.maxList().ToString("C");
            lblMin.Text = "Smallest Premium entered is: " + IA.minList().ToString("C");
            lblAvg.Text = "The Average Premium is: " + IA.avgList().ToString("C");
            lblTotal.Text = "The total of the premiums is: " + IA.totalList().ToString("C");
        }
    }
}
