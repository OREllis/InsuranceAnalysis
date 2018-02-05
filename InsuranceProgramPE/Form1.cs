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

        InsuranceAnalysis IA = new InsuranceAnalysis();

        private void btnAdd_Click(object sender, EventArgs e) {
            IA.addPremium(txtPremium.Text);

            lstPremiums.DataSource = null;
            lstPremiums.DataSource = IA.allPremiums.ConvertAll<string>(x => x.ToString("C"));

            setLabels();
        }

        private void btnSort_Click(object sender, EventArgs e) {
            lstSorted.DataSource = null;
            lstSorted.DataSource = (IA.sortPremiums()).ConvertAll<string>(x => x.ToString("C"));
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void setLabels() {
            lblPremiums.Text = "Total Premiums entered are: " + IA.allPremiums.Count().ToString("C");
            lblMax.Text = "Largest Premium entered is: " + IA.allPremiums.Max().ToString("C");
            lblMin.Text = "Smallest Premium entered is: " + IA.allPremiums.Min().ToString("C");
            lblAvg.Text = "The Average Premium is: " + IA.allPremiums.Average().ToString("C");
            lblTotal.Text = "The total of the premiums is: " + IA.allPremiums.Sum().ToString("C");
        }
    }
}
