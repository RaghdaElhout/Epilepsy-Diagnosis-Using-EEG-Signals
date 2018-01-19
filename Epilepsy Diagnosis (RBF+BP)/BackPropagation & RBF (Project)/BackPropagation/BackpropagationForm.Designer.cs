namespace BackPropagation
{
    partial class BackpropagationForm
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
            this.input_features_grid = new System.Windows.Forms.DataGridView();
            this.Input_Features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSE_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Hidden = new System.Windows.Forms.Button();
            this.BackP = new System.Windows.Forms.Button();
            this.Hyper = new System.Windows.Forms.RadioButton();
            this.Sigmoid_radio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Confusion_txt = new System.Windows.Forms.TextBox();
            this.Classify = new System.Windows.Forms.Button();
            this.class_txt = new System.Windows.Forms.TextBox();
            this.AccuracyText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.epocsCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eta = new System.Windows.Forms.TextBox();
            this.Hidden = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bias = new System.Windows.Forms.CheckBox();
            this.cross_check = new System.Windows.Forms.CheckBox();
            this.MSE_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_features_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hidden)).BeginInit();
            this.SuspendLayout();
            // 
            // input_features_grid
            // 
            this.input_features_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.input_features_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Input_Features});
            this.input_features_grid.Location = new System.Drawing.Point(12, 12);
            this.input_features_grid.Name = "input_features_grid";
            this.input_features_grid.Size = new System.Drawing.Size(145, 395);
            this.input_features_grid.TabIndex = 58;
            this.input_features_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Input_Features
            // 
            this.Input_Features.HeaderText = "Input Features";
            this.Input_Features.Name = "Input_Features";
            // 
            // MSE_txt
            // 
            this.MSE_txt.Location = new System.Drawing.Point(386, 82);
            this.MSE_txt.Name = "MSE_txt";
            this.MSE_txt.Size = new System.Drawing.Size(100, 20);
            this.MSE_txt.TabIndex = 55;
            this.MSE_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "MSE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Add_Hidden
            // 
            this.Add_Hidden.Location = new System.Drawing.Point(160, 328);
            this.Add_Hidden.Name = "Add_Hidden";
            this.Add_Hidden.Size = new System.Drawing.Size(145, 23);
            this.Add_Hidden.TabIndex = 53;
            this.Add_Hidden.Text = "Add Hidden Layers";
            this.Add_Hidden.UseVisualStyleBackColor = true;
            this.Add_Hidden.Click += new System.EventHandler(this.Add_Hidden_Click);
            // 
            // BackP
            // 
            this.BackP.Location = new System.Drawing.Point(398, 292);
            this.BackP.Name = "BackP";
            this.BackP.Size = new System.Drawing.Size(120, 23);
            this.BackP.TabIndex = 52;
            this.BackP.Text = "Backpropagation";
            this.BackP.UseVisualStyleBackColor = true;
            this.BackP.Click += new System.EventHandler(this.BackP_Click);
            // 
            // Hyper
            // 
            this.Hyper.AutoSize = true;
            this.Hyper.Location = new System.Drawing.Point(448, 116);
            this.Hyper.Name = "Hyper";
            this.Hyper.Size = new System.Drawing.Size(75, 17);
            this.Hyper.TabIndex = 51;
            this.Hyper.Text = "Hyperbolic";
            this.Hyper.UseVisualStyleBackColor = true;
            // 
            // Sigmoid_radio
            // 
            this.Sigmoid_radio.AutoSize = true;
            this.Sigmoid_radio.Location = new System.Drawing.Point(381, 116);
            this.Sigmoid_radio.Name = "Sigmoid_radio";
            this.Sigmoid_radio.Size = new System.Drawing.Size(61, 17);
            this.Sigmoid_radio.TabIndex = 50;
            this.Sigmoid_radio.Text = "Sigmoid";
            this.Sigmoid_radio.UseVisualStyleBackColor = true;
            this.Sigmoid_radio.CheckedChanged += new System.EventHandler(this.Sigmoid_radio_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Confusion Matrix";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Confusion_txt
            // 
            this.Confusion_txt.Location = new System.Drawing.Point(371, 210);
            this.Confusion_txt.Multiline = true;
            this.Confusion_txt.Name = "Confusion_txt";
            this.Confusion_txt.Size = new System.Drawing.Size(171, 62);
            this.Confusion_txt.TabIndex = 48;
            this.Confusion_txt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Classify
            // 
            this.Classify.Location = new System.Drawing.Point(63, 428);
            this.Classify.Name = "Classify";
            this.Classify.Size = new System.Drawing.Size(75, 23);
            this.Classify.TabIndex = 47;
            this.Classify.Text = "Classify";
            this.Classify.UseVisualStyleBackColor = true;
            this.Classify.Click += new System.EventHandler(this.Classify_Click);
            // 
            // class_txt
            // 
            this.class_txt.Location = new System.Drawing.Point(12, 466);
            this.class_txt.Name = "class_txt";
            this.class_txt.Size = new System.Drawing.Size(210, 20);
            this.class_txt.TabIndex = 46;
            this.class_txt.TextChanged += new System.EventHandler(this.class_txt_TextChanged);
            // 
            // AccuracyText
            // 
            this.AccuracyText.Location = new System.Drawing.Point(406, 143);
            this.AccuracyText.Name = "AccuracyText";
            this.AccuracyText.Size = new System.Drawing.Size(100, 20);
            this.AccuracyText.TabIndex = 45;
            this.AccuracyText.TextChanged += new System.EventHandler(this.AccuracyText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Class";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Accuracy";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "No epocs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // epocsCount
            // 
            this.epocsCount.Location = new System.Drawing.Point(386, 56);
            this.epocsCount.Name = "epocsCount";
            this.epocsCount.Size = new System.Drawing.Size(100, 20);
            this.epocsCount.TabIndex = 41;
            this.epocsCount.Text = "500";
            this.epocsCount.TextChanged += new System.EventHandler(this.epocsCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Learning Rate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eta
            // 
            this.eta.Location = new System.Drawing.Point(408, 29);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(100, 20);
            this.eta.TabIndex = 39;
            this.eta.Text = "0.1";
            this.eta.TextChanged += new System.EventHandler(this.eta_TextChanged);
            // 
            // Hidden
            // 
            this.Hidden.AllowUserToDeleteRows = false;
            this.Hidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hidden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1});
            this.Hidden.Location = new System.Drawing.Point(160, 12);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(145, 310);
            this.Hidden.TabIndex = 38;
            this.Hidden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hidden_CellContentClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "Neourns per Layers";
            this.col1.Name = "col1";
            // 
            // Bias
            // 
            this.Bias.AutoSize = true;
            this.Bias.Location = new System.Drawing.Point(330, 117);
            this.Bias.Name = "Bias";
            this.Bias.Size = new System.Drawing.Size(45, 17);
            this.Bias.TabIndex = 37;
            this.Bias.Text = "Bias";
            this.Bias.UseVisualStyleBackColor = true;
            this.Bias.CheckedChanged += new System.EventHandler(this.Bias_CheckedChanged);
            // 
            // cross_check
            // 
            this.cross_check.AutoSize = true;
            this.cross_check.Location = new System.Drawing.Point(501, 57);
            this.cross_check.Name = "cross_check";
            this.cross_check.Size = new System.Drawing.Size(102, 17);
            this.cross_check.TabIndex = 59;
            this.cross_check.Text = "Cross Validation";
            this.cross_check.UseVisualStyleBackColor = true;
            this.cross_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MSE_check
            // 
            this.MSE_check.AutoSize = true;
            this.MSE_check.Location = new System.Drawing.Point(501, 84);
            this.MSE_check.Name = "MSE_check";
            this.MSE_check.Size = new System.Drawing.Size(45, 17);
            this.MSE_check.TabIndex = 60;
            this.MSE_check.Text = "USE";
            this.MSE_check.UseVisualStyleBackColor = true;
            this.MSE_check.CheckedChanged += new System.EventHandler(this.MSE_check_CheckedChanged);
            // 
            // BackpropagationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 510);
            this.Controls.Add(this.MSE_check);
            this.Controls.Add(this.cross_check);
            this.Controls.Add(this.input_features_grid);
            this.Controls.Add(this.MSE_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Hidden);
            this.Controls.Add(this.BackP);
            this.Controls.Add(this.Hyper);
            this.Controls.Add(this.Sigmoid_radio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Confusion_txt);
            this.Controls.Add(this.Classify);
            this.Controls.Add(this.class_txt);
            this.Controls.Add(this.AccuracyText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.epocsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eta);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.Bias);
            this.Name = "BackpropagationForm";
            this.Text = "Backpropagation";
            this.Load += new System.EventHandler(this.BackpropagationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_features_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView input_features_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input_Features;
        private System.Windows.Forms.TextBox MSE_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Hidden;
        private System.Windows.Forms.Button BackP;
        private System.Windows.Forms.RadioButton Hyper;
        private System.Windows.Forms.RadioButton Sigmoid_radio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Confusion_txt;
        private System.Windows.Forms.Button Classify;
        private System.Windows.Forms.TextBox class_txt;
        private System.Windows.Forms.TextBox AccuracyText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epocsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eta;
        private System.Windows.Forms.DataGridView Hidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.CheckBox Bias;
        private System.Windows.Forms.CheckBox cross_check;
        private System.Windows.Forms.CheckBox MSE_check;
    }
}