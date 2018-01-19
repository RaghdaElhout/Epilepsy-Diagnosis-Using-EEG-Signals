namespace BackPropagation
{
    partial class RBF_Form
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
            this.Add_Hidden = new System.Windows.Forms.Button();
            this.Classify = new System.Windows.Forms.Button();
            this.class_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MSE_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RBF_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Confusion_txt = new System.Windows.Forms.TextBox();
            this.AccuracyText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.epocsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eta = new System.Windows.Forms.TextBox();
            this.Bias = new System.Windows.Forms.CheckBox();
            this.Input_Features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.k_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Hidden
            // 
            this.Add_Hidden.Location = new System.Drawing.Point(175, 92);
            this.Add_Hidden.Name = "Add_Hidden";
            this.Add_Hidden.Size = new System.Drawing.Size(135, 30);
            this.Add_Hidden.TabIndex = 63;
            this.Add_Hidden.Text = "Add Hidden Neurons";
            this.Add_Hidden.UseVisualStyleBackColor = true;
            this.Add_Hidden.Click += new System.EventHandler(this.Add_Hidden_Click);
            // 
            // Classify
            // 
            this.Classify.Location = new System.Drawing.Point(46, 427);
            this.Classify.Name = "Classify";
            this.Classify.Size = new System.Drawing.Size(75, 23);
            this.Classify.TabIndex = 62;
            this.Classify.Text = "Classify";
            this.Classify.UseVisualStyleBackColor = true;
            // 
            // class_txt
            // 
            this.class_txt.Location = new System.Drawing.Point(33, 466);
            this.class_txt.Name = "class_txt";
            this.class_txt.Size = new System.Drawing.Size(104, 20);
            this.class_txt.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Class";
            // 
            // MSE_txtbox
            // 
            this.MSE_txtbox.Location = new System.Drawing.Point(407, 119);
            this.MSE_txtbox.Name = "MSE_txtbox";
            this.MSE_txtbox.Size = new System.Drawing.Size(100, 20);
            this.MSE_txtbox.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "MSE";
            // 
            // RBF_btn
            // 
            this.RBF_btn.Location = new System.Drawing.Point(404, 330);
            this.RBF_btn.Name = "RBF_btn";
            this.RBF_btn.Size = new System.Drawing.Size(120, 23);
            this.RBF_btn.TabIndex = 76;
            this.RBF_btn.Text = "RBF";
            this.RBF_btn.UseVisualStyleBackColor = true;
            this.RBF_btn.Click += new System.EventHandler(this.RBF_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Confusion Matrix";
            // 
            // Confusion_txt
            // 
            this.Confusion_txt.Location = new System.Drawing.Point(377, 248);
            this.Confusion_txt.Multiline = true;
            this.Confusion_txt.Name = "Confusion_txt";
            this.Confusion_txt.Size = new System.Drawing.Size(171, 62);
            this.Confusion_txt.TabIndex = 72;
            // 
            // AccuracyText
            // 
            this.AccuracyText.Location = new System.Drawing.Point(412, 181);
            this.AccuracyText.Name = "AccuracyText";
            this.AccuracyText.Size = new System.Drawing.Size(100, 20);
            this.AccuracyText.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Accuracy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "No epocs";
            // 
            // epocsCount
            // 
            this.epocsCount.Location = new System.Drawing.Point(407, 92);
            this.epocsCount.Name = "epocsCount";
            this.epocsCount.Size = new System.Drawing.Size(100, 20);
            this.epocsCount.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Learning Rate";
            // 
            // eta
            // 
            this.eta.Location = new System.Drawing.Point(414, 31);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(100, 20);
            this.eta.TabIndex = 66;
            // 
            // Bias
            // 
            this.Bias.AutoSize = true;
            this.Bias.Location = new System.Drawing.Point(336, 157);
            this.Bias.Name = "Bias";
            this.Bias.Size = new System.Drawing.Size(45, 17);
            this.Bias.TabIndex = 65;
            this.Bias.Text = "Bias";
            this.Bias.UseVisualStyleBackColor = true;
            // 
            // Input_Features
            // 
            this.Input_Features.HeaderText = "Input Features";
            this.Input_Features.Name = "Input_Features";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Input_Features});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(145, 395);
            this.dataGridView1.TabIndex = 64;
            // 
            // k_txtbox
            // 
            this.k_txtbox.Location = new System.Drawing.Point(188, 54);
            this.k_txtbox.Name = "k_txtbox";
            this.k_txtbox.Size = new System.Drawing.Size(100, 20);
            this.k_txtbox.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "K Value";
            // 
            // RBF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.k_txtbox);
            this.Controls.Add(this.MSE_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RBF_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Confusion_txt);
            this.Controls.Add(this.AccuracyText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.epocsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eta);
            this.Controls.Add(this.Bias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add_Hidden);
            this.Controls.Add(this.Classify);
            this.Controls.Add(this.class_txt);
            this.Controls.Add(this.label8);
            this.Name = "RBF_Form";
            this.Text = "RBF_Form";
            this.Load += new System.EventHandler(this.RBF_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_Hidden;
        private System.Windows.Forms.Button Classify;
        private System.Windows.Forms.TextBox class_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MSE_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RBF_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Confusion_txt;
        private System.Windows.Forms.TextBox AccuracyText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epocsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eta;
        private System.Windows.Forms.CheckBox Bias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input_Features;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox k_txtbox;
        private System.Windows.Forms.Label label3;
    }
}