namespace POSS
{
    partial class ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passworddntmatchlbl = new System.Windows.Forms.Label();
            this.wrngpasslbl = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.conPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.currentPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 650);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passworddntmatchlbl);
            this.panel2.Controls.Add(this.wrngpasslbl);
            this.panel2.Controls.Add(this.c);
            this.panel2.Controls.Add(this.b);
            this.panel2.Controls.Add(this.a);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.conPass);
            this.panel2.Controls.Add(this.newPass);
            this.panel2.Controls.Add(this.currentPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(262, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 583);
            this.panel2.TabIndex = 0;
            // 
            // passworddntmatchlbl
            // 
            this.passworddntmatchlbl.AutoSize = true;
            this.passworddntmatchlbl.ForeColor = System.Drawing.Color.Red;
            this.passworddntmatchlbl.Location = new System.Drawing.Point(33, 442);
            this.passworddntmatchlbl.Name = "passworddntmatchlbl";
            this.passworddntmatchlbl.Size = new System.Drawing.Size(118, 13);
            this.passworddntmatchlbl.TabIndex = 9;
            this.passworddntmatchlbl.Text = "Password do not match";
            // 
            // wrngpasslbl
            // 
            this.wrngpasslbl.AutoSize = true;
            this.wrngpasslbl.ForeColor = System.Drawing.Color.Red;
            this.wrngpasslbl.Location = new System.Drawing.Point(33, 246);
            this.wrngpasslbl.Name = "wrngpasslbl";
            this.wrngpasslbl.Size = new System.Drawing.Size(87, 13);
            this.wrngpasslbl.TabIndex = 8;
            this.wrngpasslbl.Text = "Wrong password";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(32, 368);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(162, 24);
            this.c.TabIndex = 7;
            this.c.Text = "Confirm Password";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(32, 271);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(136, 24);
            this.b.TabIndex = 6;
            this.b.Text = "New Password";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(32, 172);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(159, 24);
            this.a.TabIndex = 5;
            this.a.Text = "Current Password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(119, 479);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(198, 52);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // conPass
            // 
            this.conPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass.Location = new System.Drawing.Point(36, 395);
            this.conPass.Name = "conPass";
            this.conPass.Size = new System.Drawing.Size(378, 44);
            this.conPass.TabIndex = 3;
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass.Location = new System.Drawing.Point(36, 298);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(378, 44);
            this.newPass.TabIndex = 2;
            // 
            // currentPass
            // 
            this.currentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPass.Location = new System.Drawing.Point(36, 199);
            this.currentPass.Name = "currentPass";
            this.currentPass.Size = new System.Drawing.Size(378, 44);
            this.currentPass.TabIndex = 1;
            this.currentPass.Leave += new System.EventHandler(this.currentPass_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Change Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox conPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.TextBox currentPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wrngpasslbl;
        private System.Windows.Forms.Label passworddntmatchlbl;
    }
}