namespace AirportOOP
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
            this.DepartureComboBox = new System.Windows.Forms.ComboBox();
            this.DestinantionComboBox = new System.Windows.Forms.ComboBox();
            this.returnComboBox = new System.Windows.Forms.ComboBox();
            this.EconomyCheckBox = new System.Windows.Forms.CheckBox();
            this.BusinessCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstClassCheckBox = new System.Windows.Forms.CheckBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.AllDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartureComboBox
            // 
            this.DepartureComboBox.FormattingEnabled = true;
            this.DepartureComboBox.Location = new System.Drawing.Point(391, 63);
            this.DepartureComboBox.Name = "DepartureComboBox";
            this.DepartureComboBox.Size = new System.Drawing.Size(375, 28);
            this.DepartureComboBox.TabIndex = 0;
            this.DepartureComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartureComboBox_SelectedIndexChanged);
            // 
            // DestinantionComboBox
            // 
            this.DestinantionComboBox.FormattingEnabled = true;
            this.DestinantionComboBox.Location = new System.Drawing.Point(391, 129);
            this.DestinantionComboBox.Name = "DestinantionComboBox";
            this.DestinantionComboBox.Size = new System.Drawing.Size(375, 28);
            this.DestinantionComboBox.TabIndex = 1;
            this.DestinantionComboBox.SelectedIndexChanged += new System.EventHandler(this.DestinantionComboBox_SelectedIndexChanged);
            // 
            // returnComboBox
            // 
            this.returnComboBox.FormattingEnabled = true;
            this.returnComboBox.Location = new System.Drawing.Point(391, 209);
            this.returnComboBox.Name = "returnComboBox";
            this.returnComboBox.Size = new System.Drawing.Size(375, 28);
            this.returnComboBox.TabIndex = 2;
            this.returnComboBox.SelectedIndexChanged += new System.EventHandler(this.returnComboBox_SelectedIndexChanged);
            // 
            // EconomyCheckBox
            // 
            this.EconomyCheckBox.AutoSize = true;
            this.EconomyCheckBox.Location = new System.Drawing.Point(310, 355);
            this.EconomyCheckBox.Name = "EconomyCheckBox";
            this.EconomyCheckBox.Size = new System.Drawing.Size(101, 24);
            this.EconomyCheckBox.TabIndex = 3;
            this.EconomyCheckBox.Text = "Economy";
            this.EconomyCheckBox.UseVisualStyleBackColor = true;
            this.EconomyCheckBox.CheckedChanged += new System.EventHandler(this.EconomyCheckBox_CheckedChanged);
            // 
            // BusinessCheckBox
            // 
            this.BusinessCheckBox.AutoSize = true;
            this.BusinessCheckBox.Location = new System.Drawing.Point(469, 355);
            this.BusinessCheckBox.Name = "BusinessCheckBox";
            this.BusinessCheckBox.Size = new System.Drawing.Size(113, 24);
            this.BusinessCheckBox.TabIndex = 4;
            this.BusinessCheckBox.Text = "checkBox2";
            this.BusinessCheckBox.UseVisualStyleBackColor = true;
            this.BusinessCheckBox.CheckedChanged += new System.EventHandler(this.BusinessCheckBox_CheckedChanged);
            // 
            // FirstClassCheckBox
            // 
            this.FirstClassCheckBox.AutoSize = true;
            this.FirstClassCheckBox.Location = new System.Drawing.Point(631, 355);
            this.FirstClassCheckBox.Name = "FirstClassCheckBox";
            this.FirstClassCheckBox.Size = new System.Drawing.Size(113, 24);
            this.FirstClassCheckBox.TabIndex = 5;
            this.FirstClassCheckBox.Text = "checkBox3";
            this.FirstClassCheckBox.UseVisualStyleBackColor = true;
            this.FirstClassCheckBox.CheckedChanged += new System.EventHandler(this.FirstClassCheckBox_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(678, 438);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(216, 87);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "button1";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AllDataBtn
            // 
            this.AllDataBtn.Location = new System.Drawing.Point(63, 480);
            this.AllDataBtn.Name = "AllDataBtn";
            this.AllDataBtn.Size = new System.Drawing.Size(186, 45);
            this.AllDataBtn.TabIndex = 7;
            this.AllDataBtn.Text = "button1";
            this.AllDataBtn.UseVisualStyleBackColor = true;
            this.AllDataBtn.Click += new System.EventHandler(this.AllDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 622);
            this.Controls.Add(this.AllDataBtn);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FirstClassCheckBox);
            this.Controls.Add(this.BusinessCheckBox);
            this.Controls.Add(this.EconomyCheckBox);
            this.Controls.Add(this.returnComboBox);
            this.Controls.Add(this.DestinantionComboBox);
            this.Controls.Add(this.DepartureComboBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DestinationComboBox;
        private System.Windows.Forms.ComboBox DepartureComboBox;
        private System.Windows.Forms.ComboBox DestinantionComboBox;
        private System.Windows.Forms.ComboBox returnComboBox;
        private System.Windows.Forms.CheckBox EconomyCheckBox;
        private System.Windows.Forms.CheckBox BusinessCheckBox;
        private System.Windows.Forms.CheckBox FirstClassCheckBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button AllDataBtn;
    }
}

