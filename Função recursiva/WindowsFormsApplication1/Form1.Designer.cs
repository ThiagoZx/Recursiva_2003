namespace WindowsFormsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Recursive = new System.Windows.Forms.Button();
            this.Interactive = new System.Windows.Forms.Button();
            this.Result_box = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Recursive
            // 
            this.Recursive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recursive.Location = new System.Drawing.Point(88, 130);
            this.Recursive.Name = "Recursive";
            this.Recursive.Size = new System.Drawing.Size(121, 50);
            this.Recursive.TabIndex = 1;
            this.Recursive.Text = "Recursivo";
            this.Recursive.UseVisualStyleBackColor = true;
            this.Recursive.Click += new System.EventHandler(this.Recursive_Click);
            // 
            // Interactive
            // 
            this.Interactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interactive.Location = new System.Drawing.Point(88, 74);
            this.Interactive.Name = "Interactive";
            this.Interactive.Size = new System.Drawing.Size(121, 50);
            this.Interactive.TabIndex = 2;
            this.Interactive.Text = "Interativo";
            this.Interactive.UseVisualStyleBackColor = true;
            this.Interactive.Click += new System.EventHandler(this.Interactive_Click);
            // 
            // Result_box
            // 
            this.Result_box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Result_box.Location = new System.Drawing.Point(12, 195);
            this.Result_box.Name = "Result_box";
            this.Result_box.Size = new System.Drawing.Size(277, 29);
            this.Result_box.TabIndex = 3;
            this.Result_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 233);
            this.Controls.Add(this.Result_box);
            this.Controls.Add(this.Interactive);
            this.Controls.Add(this.Recursive);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Recursive;
        private System.Windows.Forms.Button Interactive;
        private System.Windows.Forms.Label Result_box;
    }
}

