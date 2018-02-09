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
            //listbox = allPremiums List converted to Currency
            lstPremiums.DataSource = IA.allPremiums.ConvertAll<string>(x => x.ToString("C"));

            setLabels();
        }

        private void btnSort_Click(object sender, EventArgs e) {
            //empty listbox
            lstSorted.DataSource = null;
            //listbox = returned value from .sortPremiums() converted to currency
            lstSorted.DataSource = (IA.sortPremiums()).ConvertAll<string>(x => x.ToString("C"));
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void setLabels() {
            //setting label text to itself with the returned values of their respective functions converted to 
            //currency contatenated to the end of it
            lblPremiums.Text = "Total Premiums entered are: " + IA.allPremiums.Count();
            lblMax.Text = "Largest Premium entered is: " + IA.allPremiums.Max().ToString("C");
            lblMin.Text = "Smallest Premium entered is: " + IA.allPremiums.Min().ToString("C");
            lblAvg.Text = "The Average Premium is: " + IA.allPremiums.Average().ToString("C");
            lblTotal.Text = "The total of the premiums is: " + IA.allPremiums.Sum().ToString("C");
        }
    }
}
