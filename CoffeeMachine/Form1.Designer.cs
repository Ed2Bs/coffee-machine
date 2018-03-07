namespace CoffeeMachine
{
    partial class Form1
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
            this.makeButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sugarCheckBox = new System.Windows.Forms.CheckBox();
            this.milkCheckBox = new System.Windows.Forms.CheckBox();
            this.beveragesCombo = new System.Windows.Forms.ComboBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(262, 57);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(75, 23);
            this.makeButton.TabIndex = 0;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(226, 257);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(111, 23);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "Usage Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose beverage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sugarCheckBox);
            this.groupBox1.Controls.Add(this.milkCheckBox);
            this.groupBox1.Controls.Add(this.beveragesCombo);
            this.groupBox1.Controls.Add(this.makeButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 132);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee machine";
            // 
            // sugarCheckBox
            // 
            this.sugarCheckBox.AutoSize = true;
            this.sugarCheckBox.Location = new System.Drawing.Point(72, 99);
            this.sugarCheckBox.Name = "sugarCheckBox";
            this.sugarCheckBox.Size = new System.Drawing.Size(54, 17);
            this.sugarCheckBox.TabIndex = 9;
            this.sugarCheckBox.Text = "Sugar";
            this.sugarCheckBox.UseVisualStyleBackColor = true;
            // 
            // milkCheckBox
            // 
            this.milkCheckBox.AutoSize = true;
            this.milkCheckBox.Location = new System.Drawing.Point(21, 99);
            this.milkCheckBox.Name = "milkCheckBox";
            this.milkCheckBox.Size = new System.Drawing.Size(45, 17);
            this.milkCheckBox.TabIndex = 8;
            this.milkCheckBox.Text = "Milk";
            this.milkCheckBox.UseVisualStyleBackColor = true;
            // 
            // beveragesCombo
            // 
            this.beveragesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beveragesCombo.FormattingEnabled = true;
            this.beveragesCombo.Location = new System.Drawing.Point(21, 57);
            this.beveragesCombo.Name = "beveragesCombo";
            this.beveragesCombo.Size = new System.Drawing.Size(210, 21);
            this.beveragesCombo.TabIndex = 7;
            this.beveragesCombo.SelectionChangeCommitted += new System.EventHandler(this.beveragesCombo_SelectionChangeCommitted);
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(21, 34);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.ReadOnly = true;
            this.statusBox.Size = new System.Drawing.Size(316, 200);
            this.statusBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusBox);
            this.groupBox2.Controls.Add(this.reportButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 296);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Coffee Machine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.CheckBox sugarCheckBox;
        private System.Windows.Forms.CheckBox milkCheckBox;
        private System.Windows.Forms.ComboBox beveragesCombo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

