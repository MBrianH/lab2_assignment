namespace program
{
    partial class Form5
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
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            btnLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(205, 133);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(334, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Does the mushroom have a convex cup?";
            btnYes.BackColor = Color.ForestGreen;
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(205, 207);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(112, 34);
            btnYes.TabIndex = 1;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            btnNo.BackColor = Color.Firebrick;
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(427, 207);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(112, 34);
            btnNo.TabIndex = 1;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            btnLogout.BackColor = Color.DarkOrange;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(309, 287);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 40);
            label1.Name = "label1";
            label1.Size = new Size(346, 38);
            label1.TabIndex = 2;
            label1.Text = "Mushroom Identification";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblQuestion);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Identification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Button btnLogout;
        private Label label1;
    }
}