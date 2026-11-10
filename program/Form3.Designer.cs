namespace program
{
    partial class Form3
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
            lblBicycle = new Label();
            lblStart = new Label();
            txtStart = new TextBox();
            lblEnd = new Label();
            txtEnd = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnLogout = new Button();
            SuspendLayout();
            lblBicycle.AutoSize = true;
            lblBicycle.Location = new Point(306, 75);
            lblBicycle.Name = "lblBicycle";
            lblBicycle.Size = new Size(117, 25);
            lblBicycle.TabIndex = 1;
            lblBicycle.Text = "Bicycle Rental";
            lblBicycle.Click += lblBicycle_Click;
            lblStart.AutoSize = true;
            lblStart.Location = new Point(108, 175);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(163, 25);
            lblStart.TabIndex = 2;
            lblStart.Text = "Enter starting hour:";
            txtStart.Location = new Point(372, 172);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(207, 31);
            txtStart.TabIndex = 3;
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(108, 242);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(158, 25);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "Enter ending hour:";
            txtEnd.Location = new Point(372, 236);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(207, 31);
            txtEnd.TabIndex = 3;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(108, 301);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 25);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total cost:";
            txtTotal.Location = new Point(372, 301);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(207, 31);
            txtTotal.TabIndex = 3;
            btnCalculate.BackColor = Color.DarkOrange;
            btnCalculate.Location = new Point(174, 380);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            btnLogout.BackColor = Color.Red;
            btnLogout.Location = new Point(406, 380);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(lblTotal);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(lblBicycle);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBicycle;
        private Label lblStart;
        private TextBox txtStart;
        private Label lblEnd;
        private TextBox txtEnd;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnLogout;
    }
}