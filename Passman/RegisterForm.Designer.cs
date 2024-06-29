namespace Passman
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btnRegister = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(35, 168);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(270, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 101);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(61, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(61, 66);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 27);
            txtUsername.TabIndex = 5;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 232);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegisterForm";
            Text = "Passman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}
