
namespace bestaurantstandalone
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
            this.res_comboBox1 = new System.Windows.Forms.ComboBox();
            this.res_label = new System.Windows.Forms.Label();
            this.res_load_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // res_comboBox1
            // 
            this.res_comboBox1.FormattingEnabled = true;
            this.res_comboBox1.Location = new System.Drawing.Point(68, 52);
            this.res_comboBox1.Name = "res_comboBox1";
            this.res_comboBox1.Size = new System.Drawing.Size(168, 21);
            this.res_comboBox1.TabIndex = 0;
            // 
            // res_label
            // 
            this.res_label.AutoSize = true;
            this.res_label.Location = new System.Drawing.Point(13, 52);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(49, 13);
            this.res_label.TabIndex = 1;
            this.res_label.Text = "Venues: ";
            // 
            // res_load_button1
            // 
            this.res_load_button1.Location = new System.Drawing.Point(255, 52);
            this.res_load_button1.Name = "res_load_button1";
            this.res_load_button1.Size = new System.Drawing.Size(75, 23);
            this.res_load_button1.TabIndex = 2;
            this.res_load_button1.Text = "Load";
            this.res_load_button1.UseVisualStyleBackColor = true;
            this.res_load_button1.Click += new System.EventHandler(this.res_load_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 129);
            this.Controls.Add(this.res_load_button1);
            this.Controls.Add(this.res_label);
            this.Controls.Add(this.res_comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox res_comboBox1;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.Button res_load_button1;
    }
}

