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
            this.fromMinutesTimePicker = new System.Windows.Forms.NumericUpDown();
            this.toHoursTimePicker = new System.Windows.Forms.NumericUpDown();
            this.toMinutesTimePicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fromHoursTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMinutesTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHoursTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMinutesTimePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(66, 334);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(150, 38);
            this.readyButton.TabIndex = 2;
            this.readyButton.Text = "Готово";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.SendDataBtn);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(42, 67);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.userNameTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(104, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(41, 130);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(130, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(90, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Введите имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(80, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Выберите день";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(130, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "от";
            // 
            // fromHoursTimePicker
            // 
            this.fromHoursTimePicker.Location = new System.Drawing.Point(66, 203);
            this.fromHoursTimePicker.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.fromHoursTimePicker.Name = "fromHoursTimePicker";
            this.fromHoursTimePicker.Size = new System.Drawing.Size(58, 20);
            this.fromHoursTimePicker.TabIndex = 22;
            // 
            // fromMinutesTimePicker
            // 
            this.fromMinutesTimePicker.Location = new System.Drawing.Point(158, 203);
            this.fromMinutesTimePicker.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.fromMinutesTimePicker.Name = "fromMinutesTimePicker";
            this.fromMinutesTimePicker.Size = new System.Drawing.Size(58, 20);
            this.fromMinutesTimePicker.TabIndex = 23;
            // 
            // toHoursTimePicker
            // 
            this.toHoursTimePicker.Location = new System.Drawing.Point(66, 249);
            this.toHoursTimePicker.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.toHoursTimePicker.Name = "toHoursTimePicker";
            this.toHoursTimePicker.Size = new System.Drawing.Size(58, 20);
            this.toHoursTimePicker.TabIndex = 24;
            // 
            // toMinutesTimePicker
            // 
            this.toMinutesTimePicker.Location = new System.Drawing.Point(158, 249);
            this.toMinutesTimePicker.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.toMinutesTimePicker.Name = "toMinutesTimePicker";
            this.toMinutesTimePicker.Size = new System.Drawing.Size(58, 20);
            this.toMinutesTimePicker.TabIndex = 25;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 409);
            this.Controls.Add(this.toMinutesTimePicker);
            this.Controls.Add(this.toHoursTimePicker);
            this.Controls.Add(this.fromMinutesTimePicker);
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
            this.Name = "UserForm";
            this.Text = "Комната пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.fromHoursTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMinutesTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHoursTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMinutesTimePicker)).EndInit();
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
        private System.Windows.Forms.NumericUpDown fromMinutesTimePicker;
        private System.Windows.Forms.NumericUpDown toHoursTimePicker;
        private System.Windows.Forms.NumericUpDown toMinutesTimePicker;
    }
}