namespace project_cnpm
{
    partial class Fsignup
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
            this.SignUp = new System.Windows.Forms.Label();
            this.UserNameSU = new System.Windows.Forms.Label();
            this.PassWordSU = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.DarkOrange;
            this.SignUp.Location = new System.Drawing.Point(309, 44);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(177, 42);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "SIGN UP";
            // 
            // UserNameSU
            // 
            this.UserNameSU.AutoSize = true;
            this.UserNameSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameSU.Location = new System.Drawing.Point(186, 120);
            this.UserNameSU.Name = "UserNameSU";
            this.UserNameSU.Size = new System.Drawing.Size(107, 25);
            this.UserNameSU.TabIndex = 1;
            this.UserNameSU.Text = "User name";
            this.UserNameSU.Click += new System.EventHandler(this.label2_Click);
            // 
            // PassWordSU
            // 
            this.PassWordSU.AutoSize = true;
            this.PassWordSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordSU.Location = new System.Drawing.Point(186, 182);
            this.PassWordSU.Name = "PassWordSU";
            this.PassWordSU.Size = new System.Drawing.Size(98, 25);
            this.PassWordSU.TabIndex = 2;
            this.PassWordSU.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(186, 245);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(169, 25);
            this.ConfirmPassword.TabIndex = 3;
            this.ConfirmPassword.Text = "Confirm password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 22);
            this.textBox3.TabIndex = 6;
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.BackColor = System.Drawing.Color.Orange;
            this.SignUpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtn.ForeColor = System.Drawing.Color.White;
            this.SignUpbtn.Location = new System.Drawing.Point(191, 332);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(424, 33);
            this.SignUpbtn.TabIndex = 7;
            this.SignUpbtn.Text = "Signup";
            this.SignUpbtn.UseVisualStyleBackColor = false;
            // 
            // Fsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.PassWordSU);
            this.Controls.Add(this.UserNameSU);
            this.Controls.Add(this.SignUp);
            this.Name = "Fsignup";
            this.Text = "Sign up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Label UserNameSU;
        private System.Windows.Forms.Label PassWordSU;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SignUpbtn;
    }
}