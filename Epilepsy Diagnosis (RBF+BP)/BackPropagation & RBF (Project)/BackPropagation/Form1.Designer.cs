namespace BackPropagation
{
    partial class WELCOME
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
            this.Bp_form_btn = new System.Windows.Forms.Button();
            this.RBF_form_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bp_form_btn
            // 
            this.Bp_form_btn.Location = new System.Drawing.Point(43, 90);
            this.Bp_form_btn.Name = "Bp_form_btn";
            this.Bp_form_btn.Size = new System.Drawing.Size(190, 30);
            this.Bp_form_btn.TabIndex = 0;
            this.Bp_form_btn.Text = "Backpropagation Form";
            this.Bp_form_btn.UseVisualStyleBackColor = true;
            this.Bp_form_btn.Click += new System.EventHandler(this.Bp_form_btn_Click);
            // 
            // RBF_form_btn
            // 
            this.RBF_form_btn.Location = new System.Drawing.Point(43, 134);
            this.RBF_form_btn.Name = "RBF_form_btn";
            this.RBF_form_btn.Size = new System.Drawing.Size(190, 30);
            this.RBF_form_btn.TabIndex = 1;
            this.RBF_form_btn.Text = "RBF Form";
            this.RBF_form_btn.UseVisualStyleBackColor = true;
            this.RBF_form_btn.Click += new System.EventHandler(this.RBF_form_btn_Click);
            // 
            // WELCOME
            // 
            this.ClientSize = new System.Drawing.Size(283, 262);
            this.Controls.Add(this.RBF_form_btn);
            this.Controls.Add(this.Bp_form_btn);
            this.Name = "WELCOME";
            this.Load += new System.EventHandler(this.WELCOME_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Bias;
        private System.Windows.Forms.DataGridView Hidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.TextBox eta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox epocsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccuracyText;
        private System.Windows.Forms.TextBox class_txt;
        private System.Windows.Forms.Button Classify;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton Sigmoid_radio;
        private System.Windows.Forms.RadioButton Hyper;
        private System.Windows.Forms.Button BackP;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input_Features;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bp_btn;
        private System.Windows.Forms.Button RBF_btn;
        private System.Windows.Forms.Button Bp_form_btn;
        private System.Windows.Forms.Button RBF_form_btn;
    }
}

