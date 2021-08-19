namespace Simulation_Lab15
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelChi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.textBoxVariance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCurrentIteration = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 91);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iterations (N):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time (T):";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(432, 19);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(148, 20);
            this.textBoxIterations.TabIndex = 4;
            this.textBoxIterations.Text = "4";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(432, 52);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(148, 20);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.Text = "60";
            // 
            // labelChi
            // 
            this.labelChi.Location = new System.Drawing.Point(363, 149);
            this.labelChi.Name = "labelChi";
            this.labelChi.Size = new System.Drawing.Size(217, 42);
            this.labelChi.TabIndex = 6;
            this.labelChi.Text = "Chi-squared:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Variance:";
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(432, 85);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(148, 20);
            this.textBoxAverage.TabIndex = 9;
            // 
            // textBoxVariance
            // 
            this.textBoxVariance.Location = new System.Drawing.Point(432, 118);
            this.textBoxVariance.Name = "textBoxVariance";
            this.textBoxVariance.ReadOnly = true;
            this.textBoxVariance.Size = new System.Drawing.Size(148, 20);
            this.textBoxVariance.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCurrentIteration
            // 
            this.labelCurrentIteration.AutoSize = true;
            this.labelCurrentIteration.Location = new System.Drawing.Point(9, 179);
            this.labelCurrentIteration.Name = "labelCurrentIteration";
            this.labelCurrentIteration.Size = new System.Drawing.Size(85, 13);
            this.labelCurrentIteration.TabIndex = 12;
            this.labelCurrentIteration.Text = "Current Iteration:";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(144, 179);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(70, 13);
            this.labelCurrentTime.TabIndex = 13;
            this.labelCurrentTime.Text = "Current Time:";
            // 
            // labelWeather
            // 
            this.labelWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWeather.Location = new System.Drawing.Point(9, 149);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(346, 23);
            this.labelWeather.TabIndex = 14;
            this.labelWeather.Text = "Weather for next hour: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 209);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.labelCurrentIteration);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxVariance);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChi);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TextBox textBoxVariance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCurrentIteration;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelWeather;
    }
}

