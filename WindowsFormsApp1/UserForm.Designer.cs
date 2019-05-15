namespace WindowsFormsApp1
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.readyButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fromHoursTimePicker = new System.Windows.Forms.NumericUpDown();
            this.toHoursTimePicker = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fromHoursTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHoursTimePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // readyButton
            // 
            resources.ApplyResources(this.readyButton, "readyButton");
            this.readyButton.Name = "readyButton";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.SendDataBtn);
            // 
            // userNameTextBox
            // 
            resources.ApplyResources(this.userNameTextBox, "userNameTextBox");
            this.userNameTextBox.Name = "userNameTextBox";
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // fromHoursTimePicker
            // 
            resources.ApplyResources(this.fromHoursTimePicker, "fromHoursTimePicker");
            this.fromHoursTimePicker.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.fromHoursTimePicker.Name = "fromHoursTimePicker";
            // 
            // toHoursTimePicker
            // 
            resources.ApplyResources(this.toHoursTimePicker, "toHoursTimePicker");
            this.toHoursTimePicker.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.toHoursTimePicker.Name = "toHoursTimePicker";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toHoursTimePicker);
            this.Controls.Add(this.fromHoursTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.readyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.fromHoursTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHoursTimePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown fromHoursTimePicker;
        private System.Windows.Forms.NumericUpDown toHoursTimePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}