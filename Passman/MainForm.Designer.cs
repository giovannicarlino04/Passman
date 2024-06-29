namespace Passman
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lbAccounts = new ListBox();
            tbService = new TextBox();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbAccounts
            // 
            lbAccounts.FormattingEnabled = true;
            lbAccounts.Location = new Point(12, 33);
            lbAccounts.Name = "lbAccounts";
            lbAccounts.Size = new Size(336, 404);
            lbAccounts.TabIndex = 0;
            lbAccounts.SelectedIndexChanged += lbAccounts_SelectedIndexChanged;
            // 
            // tbService
            // 
            tbService.Location = new Point(386, 86);
            tbService.Name = "tbService";
            tbService.Size = new Size(402, 27);
            tbService.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(386, 143);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(402, 27);
            tbEmail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(386, 208);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(402, 27);
            tbPassword.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(414, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(593, 386);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(153, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 63);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 5;
            label1.Text = "Service:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 120);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 185);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(224, 26);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbService);
            Controls.Add(lbAccounts);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Passman";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAccounts;
        private TextBox tbService;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btnAdd;
        private Button btnRemove;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}
