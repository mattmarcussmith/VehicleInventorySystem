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
            this.sourceLabel.Location = new System.Drawing.Point(112, 332);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(74, 16);
            this.sourceLabel.TabIndex = 36;
            this.sourceLabel.Text = "Machine ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID";
            // 
            // cancelPartButton
            // 
            this.cancelPartButton.Location = new System.Drawing.Point(451, 381);
            this.cancelPartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelPartButton.Name = "cancelPartButton";
            this.cancelPartButton.Size = new System.Drawing.Size(76, 31);
            this.cancelPartButton.TabIndex = 29;
            this.cancelPartButton.Text = "Cancel";
            this.cancelPartButton.UseVisualStyleBackColor = true;
            this.cancelPartButton.Click += new System.EventHandler(this.CancelModifyPart);
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(357, 381);
            this.savePartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(83, 31);
            this.savePartButton.TabIndex = 28;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // sourceInput
            // 
            this.sourceInput.Location = new System.Drawing.Point(243, 328);
            this.sourceInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(129, 22);
            this.sourceInput.TabIndex = 27;
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(405, 284);
            this.minInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(68, 22);
            this.minInput.TabIndex = 26;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(243, 284);
            this.maxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(95, 22);
            this.maxInput.TabIndex = 25;
            // 
            // partPrice
            // 
            this.partPrice.Location = new System.Drawing.Point(243, 244);
            this.partPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(199, 22);
            this.partPrice.TabIndex = 24;
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(243, 214);
            this.inventoryInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(199, 22);
            this.inventoryInput.TabIndex = 23;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(243, 180);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(199, 22);
            this.nameInput.TabIndex = 22;
            // 
            // partIDInput
            // 
            this.partIDInput.Location = new System.Drawing.Point(243, 148);
            this.partIDInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partIDInput.Name = "partIDInput";
            this.partIDInput.ReadOnly = true;
            this.partIDInput.Size = new System.Drawing.Size(199, 22);
            this.partIDInput.TabIndex = 21;
            // 
            // outSourced_radio
            // 
            this.outSourced_radio.AutoSize = true;
            this.outSourced_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.outSourced_radio.Location = new System.Drawing.Point(378, 76);
            this.outSourced_radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outSourced_radio.Name = "outSourced_radio";
            this.outSourced_radio.Size = new System.Drawing.Size(107, 22);
            this.outSourced_radio.TabIndex = 20;
            this.outSourced_radio.Text = "Outsourced";
            this.outSourced_radio.UseVisualStyleBackColor = true;
            this.outSourced_radio.CheckedChanged += new System.EventHandler(this.OutSourced_Change);
            // 
            // inHouse_radio
            // 
            this.inHouse_radio.AutoSize = true;
            this.inHouse_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.inHouse_radio.Location = new System.Drawing.Point(243, 76);
            this.inHouse_radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inHouse_radio.Name = "inHouse_radio";
            this.inHouse_radio.Size = new System.Drawing.Size(89, 22);
            this.inHouse_radio.TabIndex = 19;
            this.inHouse_radio.Text = "In-House";
            this.inHouse_radio.UseVisualStyleBackColor = true;
            this.inHouse_radio.CheckedChanged += new System.EventHandler(this.InHouse_Change);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 651);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.TextBox inventoryInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox partIDInput;
        public System.Windows.Forms.RadioButton inHouse_radio;
        public System.Windows.Forms.RadioButton outSourced_radio;
        public System.Windows.Forms.TextBox sourceInput;
    }
}