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
        public Form1()
        {
            InitializeComponent();
        }

        InsuranceAnalysis IA = new InsuranceAnalysis();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IA.addPremium(txtPremium.Text);

            lstPremiums.DataSource = null;
            foreach(int i in IA.allPremiums)
                lstPremiums.item
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lstSorted.DataSource = null;
            lstSorted.DataSource = IA.sortPremiums();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
