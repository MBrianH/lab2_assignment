namespace program
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnexit = new Button();
            btnlogin = new Button();
            btndisplay = new Button();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lblusername = new Label();
            lblpassword = new Label();
            SuspendLayout();
            btnexit.BackColor = Color.Red;
            btnexit.Location = new Point(538, 305);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 0;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            btnlogin.BackColor = Color.Orange;
            btnlogin.Location = new Point(316, 305);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 34);
            btnlogin.TabIndex = 1;
            btnlogin.Text = "login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            btndisplay.BackColor = Color.Gold;
            btndisplay.Location = new Point(83, 305);
            btndisplay.Name = "btndisplay";
            btndisplay.Size = new Size(112, 34);
            btndisplay.TabIndex = 2;
            btndisplay.Text = "display";
            btndisplay.UseVisualStyleBackColor = false;
            btndisplay.Click += btndisplay_Click;
            txtusername.Location = new Point(332, 107);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(252, 31);
            txtusername.TabIndex = 3;
            txtpassword.Location = new Point(332, 172);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(252, 31);
            txtpassword.TabIndex = 4;
            lblusername.AutoSize = true;
            lblusername.Location = new Point(83, 113);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(89, 25);
            lblusername.TabIndex = 5;
            lblusername.Text = "username";
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(83, 178);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(89, 25);
            lblpassword.TabIndex = 6;
            lblpassword.Text = "password";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(btndisplay);
            Controls.Add(btnlogin);
            Controls.Add(btnexit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Button btnlogin;
        private Button btndisplay;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblusername;
        private Label lblpassword;
    }
}
