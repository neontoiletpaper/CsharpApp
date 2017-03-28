namespace WindowsFormsApp2
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
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.pickupRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.dineinRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.outputLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.couponTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.verifyLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(6, 38);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(59, 17);
            this.onionCheckBox.TabIndex = 0;
            this.onionCheckBox.Text = "Onions";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.onionCheckBox_CheckedChanged);
            // 
            // pepperCheckBox
            // 
            this.pepperCheckBox.AutoSize = true;
            this.pepperCheckBox.Location = new System.Drawing.Point(6, 62);
            this.pepperCheckBox.Name = "pepperCheckBox";
            this.pepperCheckBox.Size = new System.Drawing.Size(97, 17);
            this.pepperCheckBox.TabIndex = 1;
            this.pepperCheckBox.Text = "Green Peppers";
            this.pepperCheckBox.UseVisualStyleBackColor = true;
            this.pepperCheckBox.CheckedChanged += new System.EventHandler(this.pepperCheckBox_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(6, 86);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 2;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.pepperoniCheckBox_CheckedChanged);
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(6, 110);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(68, 17);
            this.sausageCheckBox.TabIndex = 3;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.sausageCheckBox_CheckedChanged);
            // 
            // pickupRadioButton
            // 
            this.pickupRadioButton.AutoSize = true;
            this.pickupRadioButton.Location = new System.Drawing.Point(25, 38);
            this.pickupRadioButton.Name = "pickupRadioButton";
            this.pickupRadioButton.Size = new System.Drawing.Size(63, 17);
            this.pickupRadioButton.TabIndex = 7;
            this.pickupRadioButton.Text = "Pick-Up";
            this.pickupRadioButton.UseVisualStyleBackColor = true;
            // 
            // deliveryRadioButton
            // 
            this.deliveryRadioButton.AutoSize = true;
            this.deliveryRadioButton.Checked = true;
            this.deliveryRadioButton.Location = new System.Drawing.Point(25, 62);
            this.deliveryRadioButton.Name = "deliveryRadioButton";
            this.deliveryRadioButton.Size = new System.Drawing.Size(63, 17);
            this.deliveryRadioButton.TabIndex = 8;
            this.deliveryRadioButton.TabStop = true;
            this.deliveryRadioButton.Text = "Delivery";
            this.deliveryRadioButton.UseVisualStyleBackColor = true;
            this.deliveryRadioButton.CheckedChanged += new System.EventHandler(this.deliveryRadioButton_CheckedChanged);
            // 
            // dineinRadioButton
            // 
            this.dineinRadioButton.AutoSize = true;
            this.dineinRadioButton.Location = new System.Drawing.Point(25, 86);
            this.dineinRadioButton.Name = "dineinRadioButton";
            this.dineinRadioButton.Size = new System.Drawing.Size(59, 17);
            this.dineinRadioButton.TabIndex = 9;
            this.dineinRadioButton.Text = "Dine In";
            this.dineinRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(35, 30);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallRadioButton.TabIndex = 11;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Checked = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(126, 30);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 12;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(215, 30);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeRadioButton.TabIndex = 13;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.largeRadioButton_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(198, 415);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(56, 24);
            this.outputLabel.TabIndex = 14;
            this.outputLabel.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pizza Order Form";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pickupRadioButton);
            this.groupBox1.Controls.Add(this.deliveryRadioButton);
            this.groupBox1.Controls.Add(this.dineinRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(202, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 136);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dining Options";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.smallRadioButton);
            this.groupBox2.Controls.Add(this.mediumRadioButton);
            this.groupBox2.Controls.Add(this.largeRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 53);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.onionCheckBox);
            this.groupBox3.Controls.Add(this.pepperCheckBox);
            this.groupBox3.Controls.Add(this.pepperoniCheckBox);
            this.groupBox3.Controls.Add(this.sausageCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(21, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 136);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // couponTextBox
            // 
            this.couponTextBox.Location = new System.Drawing.Point(202, 348);
            this.couponTextBox.Name = "couponTextBox";
            this.couponTextBox.Size = new System.Drawing.Size(74, 20);
            this.couponTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Coupon Code";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(282, 346);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(42, 23);
            this.btnVerify.TabIndex = 21;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // verifyLabel
            // 
            this.verifyLabel.AutoSize = true;
            this.verifyLabel.Location = new System.Drawing.Point(199, 371);
            this.verifyLabel.Name = "verifyLabel";
            this.verifyLabel.Size = new System.Drawing.Size(65, 13);
            this.verifyLabel.TabIndex = 22;
            this.verifyLabel.Text = "Approved??";
            this.verifyLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 483);
            this.Controls.Add(this.verifyLabel);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.couponTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox pepperCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.RadioButton pickupRadioButton;
        private System.Windows.Forms.RadioButton deliveryRadioButton;
        private System.Windows.Forms.RadioButton dineinRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox couponTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label verifyLabel;
    }
}

