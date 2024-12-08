namespace POSS
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.form = new System.Windows.Forms.Panel();
            this.confirmation = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.BackColor = System.Drawing.Color.White;
            this.form.Controls.Add(this.confirmation);
            this.form.Controls.Add(this.email);
            this.form.Controls.Add(this.contact);
            this.form.Controls.Add(this.showpass);
            this.form.Controls.Add(this.label1);
            this.form.Controls.Add(this.confirm_pass);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.btn_confirm);
            this.form.Controls.Add(this.password);
            this.form.Controls.Add(this.username);
            this.form.Controls.Add(this.btn_login);
            this.form.Controls.Add(this.btn_reg);
            this.form.Controls.Add(this.pictureBox1);
            this.form.Location = new System.Drawing.Point(28, 23);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(950, 650);
            this.form.TabIndex = 0;
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.BackColor = System.Drawing.Color.Transparent;
            this.confirmation.Location = new System.Drawing.Point(61, 365);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(0, 13);
            this.confirmation.TabIndex = 24;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.Location = new System.Drawing.Point(64, 442);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(298, 38);
            this.email.TabIndex = 23;
            this.email.Text = "Email";
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.Color.Silver;
            this.contact.Location = new System.Drawing.Point(64, 388);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(298, 38);
            this.contact.TabIndex = 22;
            this.contact.Text = "Contact";
            this.contact.Enter += new System.EventHandler(this.contact_Enter_1);
            this.contact.Leave += new System.EventHandler(this.contact_Leave_1);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(261, 365);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(101, 17);
            this.showpass.TabIndex = 19;
            this.showpass.Text = "Show password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome";
            // 
            // confirm_pass
            // 
            this.confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_pass.ForeColor = System.Drawing.Color.Silver;
            this.confirm_pass.Location = new System.Drawing.Point(64, 321);
            this.confirm_pass.Name = "confirm_pass";
            this.confirm_pass.Size = new System.Drawing.Size(298, 38);
            this.confirm_pass.TabIndex = 16;
            this.confirm_pass.Text = "Confirm password";
            this.confirm_pass.Enter += new System.EventHandler(this.confirm_pass_Enter);
            this.confirm_pass.Leave += new System.EventHandler(this.confirm_pass_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(249, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Login here";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Already have account?";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(130, 507);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(163, 40);
            this.btn_confirm.TabIndex = 13;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(64, 266);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(298, 38);
            this.password.TabIndex = 12;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(64, 212);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(298, 38);
            this.username.TabIndex = 11;
            this.username.Text = "Enter username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(205, 157);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 34);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reg.ForeColor = System.Drawing.Color.White;
            this.btn_reg.Location = new System.Drawing.Point(102, 157);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(103, 34);
            this.btn_reg.TabIndex = 9;
            this.btn_reg.Text = "Register";
            this.btn_reg.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(334, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 627);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.Leave += new System.EventHandler(this.frmRegister_Leave);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox confirm_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label confirmation;
    }
}