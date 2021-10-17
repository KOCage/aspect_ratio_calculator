
namespace aspect_ratio_calculator
{
    partial class View
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
            this.ARButton = new System.Windows.Forms.Button();
            this.WDButton = new System.Windows.Forms.Button();
            this.IDButton = new System.Windows.Forms.Button();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.comboBoxUnit1 = new System.Windows.Forms.ComboBox();
            this.comboBoxUnit2 = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.layoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ARButton
            // 
            this.ARButton.AccessibleDescription = "Button to switch to AR Calculation";
            this.ARButton.AccessibleName = "AR-button";
            this.ARButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ARButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ARButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(204)))));
            this.ARButton.Location = new System.Drawing.Point(28, 12);
            this.ARButton.Name = "ARButton";
            this.ARButton.Size = new System.Drawing.Size(150, 50);
            this.ARButton.TabIndex = 0;
            this.ARButton.Text = "Aspect Ratio";
            this.ARButton.UseVisualStyleBackColor = false;
            this.ARButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickAspectRatioButton);
            // 
            // WDButton
            // 
            this.WDButton.AccessibleDescription = "Button to switch to WD Calculation";
            this.WDButton.AccessibleName = "WD-button";
            this.WDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(204)))));
            this.WDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WDButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WDButton.ForeColor = System.Drawing.Color.Black;
            this.WDButton.Location = new System.Drawing.Point(184, 12);
            this.WDButton.Name = "WDButton";
            this.WDButton.Size = new System.Drawing.Size(150, 50);
            this.WDButton.TabIndex = 1;
            this.WDButton.Text = "Wire Diameter";
            this.WDButton.UseVisualStyleBackColor = false;
            this.WDButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickWireDiameterButton);
            // 
            // IDButton
            // 
            this.IDButton.AccessibleDescription = "Button to switch to ID Calculation";
            this.IDButton.AccessibleName = "ID-button";
            this.IDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(204)))));
            this.IDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDButton.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDButton.ForeColor = System.Drawing.Color.Black;
            this.IDButton.Location = new System.Drawing.Point(340, 12);
            this.IDButton.Name = "IDButton";
            this.IDButton.Size = new System.Drawing.Size(150, 50);
            this.IDButton.TabIndex = 2;
            this.IDButton.Text = "Inner Diameter";
            this.IDButton.UseVisualStyleBackColor = false;
            this.IDButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickInnerDiameterButton);
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(160, 94);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(125, 27);
            this.textBoxInput1.TabIndex = 3;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(160, 139);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(125, 27);
            this.textBoxInput2.TabIndex = 4;
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.labelInput1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInput1.ForeColor = System.Drawing.Color.Black;
            this.labelInput1.Location = new System.Drawing.Point(12, 97);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(133, 24);
            this.labelInput1.TabIndex = 6;
            this.labelInput1.Text = "Wire Diameter";
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.labelInput2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInput2.ForeColor = System.Drawing.Color.Black;
            this.labelInput2.Location = new System.Drawing.Point(12, 142);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(139, 24);
            this.labelInput2.TabIndex = 7;
            this.labelInput2.Text = "Inner Diameter";
            // 
            // CalculateButton
            // 
            this.CalculateButton.AccessibleDescription = "Button to perform calculation";
            this.CalculateButton.AccessibleName = "Calculate-button";
            this.CalculateButton.BackColor = System.Drawing.Color.Black;
            this.CalculateButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(204)))));
            this.CalculateButton.Location = new System.Drawing.Point(12, 189);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(150, 50);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickCalculateButton);
            // 
            // comboBoxUnit1
            // 
            this.comboBoxUnit1.FormattingEnabled = true;
            this.comboBoxUnit1.Items.AddRange(new object[] {
            "SWG",
            "AWG",
            "Inches",
            "MM"});
            this.comboBoxUnit1.Location = new System.Drawing.Point(301, 93);
            this.comboBoxUnit1.Name = "comboBoxUnit1";
            this.comboBoxUnit1.Size = new System.Drawing.Size(136, 28);
            this.comboBoxUnit1.TabIndex = 10;
            // 
            // comboBoxUnit2
            // 
            this.comboBoxUnit2.FormattingEnabled = true;
            this.comboBoxUnit2.Items.AddRange(new object[] {
            "Fraction Inches",
            "Decimal Inches",
            "MM"});
            this.comboBoxUnit2.Location = new System.Drawing.Point(301, 138);
            this.comboBoxUnit2.Name = "comboBoxUnit2";
            this.comboBoxUnit2.Size = new System.Drawing.Size(136, 28);
            this.comboBoxUnit2.TabIndex = 11;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResult.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelResult.Location = new System.Drawing.Point(189, 203);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 12;
            // 
            // layoutButton
            // 
            this.layoutButton.AccessibleDescription = "Button to swap between layouts";
            this.layoutButton.AccessibleName = "Layout-Button";
            this.layoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layoutButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.layoutButton.ForeColor = System.Drawing.Color.Black;
            this.layoutButton.Location = new System.Drawing.Point(514, 12);
            this.layoutButton.Name = "layoutButton";
            this.layoutButton.Size = new System.Drawing.Size(33, 50);
            this.layoutButton.TabIndex = 13;
            this.layoutButton.Text = "L";
            this.layoutButton.UseVisualStyleBackColor = true;
            this.layoutButton.Click += new System.EventHandler(this.clickSwitchLayout);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(571, 276);
            this.Controls.Add(this.layoutButton);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxUnit2);
            this.Controls.Add(this.comboBoxUnit1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.labelInput2);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.IDButton);
            this.Controls.Add(this.WDButton);
            this.Controls.Add(this.ARButton);
            this.Name = "View";
            this.Text = "Aspect Ratio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ARButton;
        private System.Windows.Forms.Button WDButton;
        private System.Windows.Forms.Button IDButton;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ComboBox comboBoxUnit1;
        private System.Windows.Forms.ComboBox comboBoxUnit2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button layoutButton;
    }
}

