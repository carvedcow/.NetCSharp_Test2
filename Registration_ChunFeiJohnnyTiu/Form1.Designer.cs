namespace Registration_ChunFeiJohnnyTiu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_PostalCode = new System.Windows.Forms.Label();
            this.lb_Country = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_PostalCode = new System.Windows.Forms.TextBox();
            this.tb_Country = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.mandatoryErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mandatoryErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(52, 56);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(61, 13);
            this.lb_FirstName.TabIndex = 0;
            this.lb_FirstName.Text = "First Name*";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Location = new System.Drawing.Point(52, 82);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(62, 13);
            this.lb_LastName.TabIndex = 1;
            this.lb_LastName.Text = "Last Name*";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(52, 108);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(36, 13);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "Email*";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Location = new System.Drawing.Point(52, 134);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(45, 13);
            this.lb_Address.TabIndex = 3;
            this.lb_Address.Text = "Address";
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(52, 160);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(24, 13);
            this.lb_City.TabIndex = 4;
            this.lb_City.Text = "City";
            // 
            // lb_PostalCode
            // 
            this.lb_PostalCode.AutoSize = true;
            this.lb_PostalCode.Location = new System.Drawing.Point(52, 186);
            this.lb_PostalCode.Name = "lb_PostalCode";
            this.lb_PostalCode.Size = new System.Drawing.Size(64, 13);
            this.lb_PostalCode.TabIndex = 5;
            this.lb_PostalCode.Text = "Postal Code";
            // 
            // lb_Country
            // 
            this.lb_Country.AutoSize = true;
            this.lb_Country.Location = new System.Drawing.Point(52, 212);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(43, 13);
            this.lb_Country.TabIndex = 6;
            this.lb_Country.Text = "Country";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(52, 238);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(38, 13);
            this.lb_Phone.TabIndex = 7;
            this.lb_Phone.Text = "Phone";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(135, 53);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(176, 20);
            this.tb_FirstName.TabIndex = 8;
            this.tb_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_FirstName_Validation);
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(135, 79);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(176, 20);
            this.tb_LastName.TabIndex = 9;
            this.tb_LastName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_LastName_Validation);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(135, 105);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(176, 20);
            this.tb_Email.TabIndex = 10;
            this.tb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Email_Validation);
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(135, 131);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(176, 20);
            this.tb_Address.TabIndex = 11;
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(135, 157);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(176, 20);
            this.tb_City.TabIndex = 12;
            // 
            // tb_PostalCode
            // 
            this.tb_PostalCode.Location = new System.Drawing.Point(135, 183);
            this.tb_PostalCode.Name = "tb_PostalCode";
            this.tb_PostalCode.Size = new System.Drawing.Size(176, 20);
            this.tb_PostalCode.TabIndex = 13;
            // 
            // tb_Country
            // 
            this.tb_Country.Location = new System.Drawing.Point(135, 209);
            this.tb_Country.Name = "tb_Country";
            this.tb_Country.Size = new System.Drawing.Size(176, 20);
            this.tb_Country.TabIndex = 14;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(135, 235);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(176, 20);
            this.tb_Phone.TabIndex = 15;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(294, 281);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 41);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(415, 281);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(115, 41);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // mandatoryErrorProvider
            // 
            this.mandatoryErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 354);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_Country);
            this.Controls.Add(this.tb_PostalCode);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.lb_PostalCode);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.lb_FirstName);
            this.Name = "Form1";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.mandatoryErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_City;
        private System.Windows.Forms.Label lb_PostalCode;
        private System.Windows.Forms.Label lb_Country;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_PostalCode;
        private System.Windows.Forms.TextBox tb_Country;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ErrorProvider mandatoryErrorProvider;
    }
}

