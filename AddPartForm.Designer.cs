namespace matthewsmith_c968
{
    partial class AddPartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inHouse_radio = new System.Windows.Forms.RadioButton();
            this.outSourced_radio = new System.Windows.Forms.RadioButton();
            this.partID = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.inventoryInput = new System.Windows.Forms.TextBox();
            this.partPriceInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.sourceInput = new System.Windows.Forms.TextBox();
            this.savePartButton = new System.Windows.Forms.Button();
            this.cancelPartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inHouse_radio
            // 
            this.inHouse_radio.AutoSize = true;
            this.inHouse_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.inHouse_radio.Location = new System.Drawing.Point(390, 62);
            this.inHouse_radio.Name = "inHouse_radio";
            this.inHouse_radio.Size = new System.Drawing.Size(141, 33);
            this.inHouse_radio.TabIndex = 1;
            this.inHouse_radio.TabStop = true;
            this.inHouse_radio.Text = "In-House";
            this.inHouse_radio.UseVisualStyleBackColor = true;
            this.inHouse_radio.CheckedChanged += new System.EventHandler(this.InHouse_Change);
            // 
            // outSourced_radio
            // 
            this.outSourced_radio.AutoSize = true;
            this.outSourced_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F);
            this.outSourced_radio.Location = new System.Drawing.Point(592, 62);
            this.outSourced_radio.Name = "outSourced_radio";
            this.outSourced_radio.Size = new System.Drawing.Size(169, 33);
            this.outSourced_radio.TabIndex = 2;
            this.outSourced_radio.TabStop = true;
            this.outSourced_radio.Text = "Outsourced";
            this.outSourced_radio.UseVisualStyleBackColor = true;
            this.outSourced_radio.CheckedChanged += new System.EventHandler(this.OutSourced_Change);
            // 
            // partID
            // 
            this.partID.Location = new System.Drawing.Point(390, 175);
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Size = new System.Drawing.Size(296, 31);
            this.partID.TabIndex = 3;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nameInput.Location = new System.Drawing.Point(390, 226);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(296, 31);
            this.nameInput.TabIndex = 4;
            // 
            // inventoryInput
            // 
            this.inventoryInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.inventoryInput.Location = new System.Drawing.Point(390, 278);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(296, 31);
            this.inventoryInput.TabIndex = 5;
            // 
            // partPriceInput
            // 
            this.partPriceInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.partPriceInput.Location = new System.Drawing.Point(390, 325);
            this.partPriceInput.Name = "partPriceInput";
            this.partPriceInput.Size = new System.Drawing.Size(296, 31);
            this.partPriceInput.TabIndex = 6;
            // 
            // maxInput
            // 
            this.maxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.maxInput.Location = new System.Drawing.Point(390, 388);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(141, 31);
            this.maxInput.TabIndex = 7;
            // 
            // minInput
            // 
            this.minInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.minInput.Location = new System.Drawing.Point(632, 388);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(100, 31);
            this.minInput.TabIndex = 8;
            // 
            // sourceInput
            // 
            this.sourceInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sourceInput.Location = new System.Drawing.Point(390, 456);
            this.sourceInput.Name = "sourceInput";
            this.sourceInput.Size = new System.Drawing.Size(192, 31);
            this.sourceInput.TabIndex = 9;
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(561, 539);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(125, 48);
            this.savePartButton.TabIndex = 10;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // cancelPartButton
            // 
            this.cancelPartButton.Location = new System.Drawing.Point(702, 539);
            this.cancelPartButton.Name = "cancelPartButton";
            this.cancelPartButton.Size = new System.Drawing.Size(114, 48);
            this.cancelPartButton.TabIndex = 11;
            this.cancelPartButton.Text = "Cancel";
            this.cancelPartButton.UseVisualStyleBackColor = true;
            this.cancelPartButton.Click += new System.EventHandler(this.CancelAddPart);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Min";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(228, 462);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(120, 25);
            this.sourceLabel.TabIndex = 18;
            this.sourceLabel.Text = "Machine ID";
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 1139);
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
            this.Controls.Add(this.partPriceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.outSourced_radio);
            this.Controls.Add(this.inHouse_radio);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouse_radio;
        private System.Windows.Forms.RadioButton outSourced_radio;
        private System.Windows.Forms.TextBox partID;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox inventoryInput;
        private System.Windows.Forms.TextBox partPriceInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.TextBox sourceInput;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button cancelPartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sourceLabel;
    }
}