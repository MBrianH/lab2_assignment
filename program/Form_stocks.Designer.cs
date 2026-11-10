namespace program
{
    partial class Form_stocks
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
            btnLogout = new Button();
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkOrange;
            btnLogout.Location = new Point(519, 129);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnlogout_Click;
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = Color.Red;
            btnBicycle.Location = new Point(96, 129);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(112, 34);
            btnBicycle.TabIndex = 1;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.BackColor = Color.PeachPuff;
            btnMushroom.Location = new Point(301, 129);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(112, 34);
            btnMushroom.TabIndex = 2;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // Form_stocks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Controls.Add(btnLogout);
            Name = "Form_stocks";
            Text = "Form_stocks";
            Load += Form_stocks_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}