using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dNATEDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dNATEDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dNATEDataSet1.Customers);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = " Male" ;
           else if (genderCheckBox.CheckState == CheckState.Unchecked)
                genderCheckBox.Text = " Female" ;
           else
                genderCheckBox.Text = "??" ;

        }
    }
}
