namespace Register1
{
    partial class Form2
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRePassword = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textRePassword = new System.Windows.Forms.TextBox();
            this.textAddr = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(225, 82);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(225, 149);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelRePassword
            // 
            this.labelRePassword.AutoSize = true;
            this.labelRePassword.Location = new System.Drawing.Point(225, 211);
            this.labelRePassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRePassword.Name = "labelRePassword";
            this.labelRePassword.Size = new System.Drawing.Size(162, 20);
            this.labelRePassword.TabIndex = 2;
            this.labelRePassword.Text = "Re-enter Password";
            this.labelRePassword.Click += new System.EventHandler(this.labelRePassword_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(225, 272);
            this.labelGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(69, 20);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(225, 345);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 20);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(225, 406);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(92, 20);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone No.";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(403, 76);
            this.textUser.Margin = new System.Windows.Forms.Padding(5);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(379, 26);
            this.textUser.TabIndex = 6;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(403, 143);
            this.textPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(379, 26);
            this.textPassword.TabIndex = 7;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textRePassword
            // 
            this.textRePassword.Location = new System.Drawing.Point(403, 205);
            this.textRePassword.Margin = new System.Windows.Forms.Padding(5);
            this.textRePassword.Name = "textRePassword";
            this.textRePassword.Size = new System.Drawing.Size(379, 26);
            this.textRePassword.TabIndex = 8;
            this.textRePassword.TextChanged += new System.EventHandler(this.textRePassword_TextChanged);
            // 
            // textAddr
            // 
            this.textAddr.Location = new System.Drawing.Point(403, 339);
            this.textAddr.Margin = new System.Windows.Forms.Padding(5);
            this.textAddr.Name = "textAddr";
            this.textAddr.Size = new System.Drawing.Size(379, 26);
            this.textAddr.TabIndex = 10;
            this.textAddr.TextChanged += new System.EventHandler(this.textAddr_TextChanged);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(403, 403);
            this.textPhone.Margin = new System.Windows.Forms.Padding(5);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(379, 26);
            this.textPhone.TabIndex = 11;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(403, 272);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(65, 24);
            this.radioMale.TabIndex = 12;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(524, 272);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(86, 24);
            this.radioFemale.TabIndex = 13;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(512, 469);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 36);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(399, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "* Fields are mandatory";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textAddr);
            this.Controls.Add(this.textRePassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelRePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRePassword;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textRePassword;
        private System.Windows.Forms.TextBox textAddr;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}