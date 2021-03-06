﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Registration_ChunFeiJohnnyTiu.FileManager;

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

        // Delegate Declaration Custom Method
        public delegate void submitAction(string s);

        // Display String to Message Box Custom Method
        public static void ShowStringToMessageBox(string s)
        {
            MessageBox.Show(s, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Clear All Text Custom Method
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

        // Email Validator Custom Method
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // First Name Mandatory Validation Method
        private void tb_FirstName_Validation(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(tb_FirstName.Text))
            {
                e.Cancel = true;
                mandatoryErrorProvider.SetError(tb_FirstName, "Please enter your First Name.");
            }

            else
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_FirstName, null);
            }
        }

        // Last Name Mandatory Validation Method
        private void tb_LastName_Validation(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tb_LastName.Text))
            {
                e.Cancel = true;
                mandatoryErrorProvider.SetError(tb_LastName, "Please enter your Last Name.");
            }

            else
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_LastName, null);
            }
        }

        // Email Mandatory Validation Method
        private void tb_Email_Validation(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Email.Text))
            {
                e.Cancel = true;
                mandatoryErrorProvider.SetError(tb_Email, "Please enter your Email.");
            }

            else
            {
                if (IsValidEmail(tb_Email.Text))
                {
                    e.Cancel = false;
                    mandatoryErrorProvider.SetError(tb_Email, null);
                }
                else
                {
                    e.Cancel = true;
                    mandatoryErrorProvider.SetError(tb_Email, "Please enter your Email.");
                }
            }
        }

        // Postal Code Regex Validation Method
        private void tb_PostalCode_Validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_PostalCode.Text))
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_PostalCode, null);
            }
            else
            { 
                var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";

                if (Regex.Match(tb_PostalCode.Text, _caZipRegEx).Success)
                {
                    e.Cancel = false;
                    mandatoryErrorProvider.SetError(tb_PostalCode, null);
                }

                else
                {
                    e.Cancel = true;
                    tb_PostalCode.Focus();
                    mandatoryErrorProvider.SetError(tb_PostalCode, "Please enter a valid Postal Code.");
                }
            }
        }

        // Phone Number Regex Validation Method
        private void tb_Phone_Validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Phone.Text))
            {
                e.Cancel = false;
                mandatoryErrorProvider.SetError(tb_Phone, null);
            }
            else
            {
                var _phoneRegEx = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

                if (Regex.Match(tb_Phone.Text, _phoneRegEx).Success)
                {
                    e.Cancel = false;
                    mandatoryErrorProvider.SetError(tb_Phone, null);
                }

                else
                {
                    e.Cancel = true;
                    tb_Phone.Focus();
                    mandatoryErrorProvider.SetError(tb_Phone, "Please enter a valid Phone Number.");
                }
            }
        }

        // Reset Button Clicked Event
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            // Clear Form
            ClearAllText(this);
        }

        //Submit Button Clicked Event
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Validation Conditions
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please enter valid answers.", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Saving Values Into a Local File with Delegation
            submitAction saveToFile = new submitAction(SaveStringToFile);
            string regInfo = null;

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    saveToFile(((TextBox)c).Text + "\n");
                    regInfo += ((TextBox)c).Text + "\n";
                }
            }

            // Show String in Message Box with Delegation
            submitAction showMessageBox = new submitAction(ShowStringToMessageBox);
            showMessageBox(regInfo);

            // Clear Form
            ClearAllText(this);
        }
    }
}
