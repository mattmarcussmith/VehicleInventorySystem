namespace matthewsmith_c968
{
    partial class ModifyPartForm
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
            this.sourceLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelPartButton = new System.Windows.Forms.Button();
            this.savePartButton = new System.Windows.Forms.Button();
            this.sourceInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.partPrice = new System.Windows.Forms.TextBox();
            this.inventoryInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.partIDInput = new System.Windows.Forms.TextBox();
            this.outSourced_radio = new System.Windows.Forms.RadioButton();
            this.inHouse_radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(168, 518);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(120, 25);
            this.sourceLabel.TabIndex = 36;
            this.sourceLabel.Text = "Machine ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID";
            // 
            // cancelPartButton
            // 
            this.cancelPartButton.Location = new System.Drawing.Point(677, 595);
            this.cancelPartButton.Name = "cancelPartButton";
            this.cancelPartButton.Size = new System.Drawing.Size(114, 48);
            this.cancelPartButton.TabIndex = 29;
            this.cancelPartButton.Text = "Cancel";
            this.cancelPartButton.UseVisualStyleBackColor = true;
            this.cancelPartButton.Click += new System.EventHandler(this.CancelModifyPart);
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(536, 595);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(125, 48);
            this.savePartButton.TabIndex = 28;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // sourceInput
            // 
            this.sourceInput.Location = new System.Drawing.Point(365, 512);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(192, 31);
            this.sourceInput.TabIndex = 27;
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(607, 444);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(100, 31);
            this.minInput.TabIndex = 26;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(365, 444);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(141, 31);
            this.maxInput.TabIndex = 25;
            // 
            // partPrice
            // 
            this.partPrice.Location = new System.Drawing.Point(365, 381);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(296, 31);
            this.partPrice.TabIndex = 24;
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(365, 334);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(296, 31);
            this.inventoryInput.TabIndex = 23;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(365, 282);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(296, 31);
            this.nameInput.TabIndex = 22;
            // 
            // partIDInput
            // 
            this.partIDInput.Location = new System.Drawing.Point(365, 231);
            this.partIDInput.Name = "partIDInput";
            this.partIDInput.ReadOnly = true;
            this.partIDInput.Size = new System.Drawing.Size(296, 31);
            this.partIDInput.TabIndex = 21;
            // 
            // outSourced_radio
            // 
            this.outSourced_radio.AutoSize = true;
            this.outSourced_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.outSourced_radio.Location = new System.Drawing.Point(567, 118);
            this.outSourced_radio.Name = "outSourced_radio";
            this.outSourced_radio.Size = new System.Drawing.Size(169, 33);
            this.outSourced_radio.TabIndex = 20;
            this.outSourced_radio.TabStop = true;
            this.outSourced_radio.Text = "Outsourced";
            this.outSourced_radio.UseVisualStyleBackColor = true;
            this.outSourced_radio.CheckedChanged += new System.EventHandler(this.OutSourced_Change);
            // 
            // inHouse_radio
            // 
            this.inHouse_radio.AutoSize = true;
            this.inHouse_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.inHouse_radio.Location = new System.Drawing.Point(365, 118);
            this.inHouse_radio.Name = "inHouse_radio";
            this.inHouse_radio.Size = new System.Drawing.Size(141, 33);
            this.inHouse_radio.TabIndex = 19;
            this.inHouse_radio.TabStop = true;
            this.inHouse_radio.Text = "In-House";
            this.inHouse_radio.UseVisualStyleBackColor = true;
            this.inHouse_radio.CheckedChanged += new System.EventHandler(this.InHouse_Change);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 1017);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelPartButton);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.sourceInput);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.partIDInput);
            this.Controls.Add(this.outSourced_radio);
            this.Controls.Add(this.inHouse_radio);
            this.Name = "ModifyPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelPartButton;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.TextBox sourceInput;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.TextBox inventoryInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox partIDInput;
        private System.Windows.Forms.RadioButton outSourced_radio;
        private System.Windows.Forms.RadioButton inHouse_radio;
    }
}