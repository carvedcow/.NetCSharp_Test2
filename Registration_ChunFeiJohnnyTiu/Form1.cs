using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_ChunFeiJohnnyTiu
{
    public partial class Form1 : Form
    {
        // Properties
        //-------------------------------------------------------------
        // Constructor
        //-------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        // Methods
        //-------------------------------------------------------------

        // Clear All Text Method
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        // First Name Mandatory Validation
        private void tb_FirstName_Validation(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(tb_FirstName.Text))
            {
                e.Cancel = true;
                tb_FirstName.Focus();
                mandatoryErrorProvider.SetError(tb_FirstName, "Please enter your First Name.");
            }

            else
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_FirstName, null);
            }
        }

        // Last Name Mandatory Validation
        private void tb_LastName_Validation(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tb_LastName.Text))
            {
                e.Cancel = true;
                tb_LastName.Focus();
                mandatoryErrorProvider.SetError(tb_LastName, "Please enter your Last Name.");
            }

            else
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_LastName, null);
            }
        }

        // Email Mandatory Validation
        private void tb_Email_Validation(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Email.Text))
            {
                e.Cancel = true;
                tb_Email.Focus();
                mandatoryErrorProvider.SetError(tb_Email, "Please enter your Email.");
            }

            else
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_Email, null);
            }
        }

        // Reset Button Clicked
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        //Submit Button Clicked
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please enter the mandatory fields.", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            ClearAllText(this);
        }
    }
}
