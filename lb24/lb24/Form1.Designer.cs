namespace lb24
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.buttonStart3 = new System.Windows.Forms.Button();
            this.buttonStartAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(534, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonStart1
            // 
            this.buttonStart1.Location = new System.Drawing.Point(12, 295);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(254, 29);
            this.buttonStart1.TabIndex = 3;
            this.buttonStart1.Text = "Запустити 1";
            this.buttonStart1.UseVisualStyleBackColor = true;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 251);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(274, 38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(254, 251);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(534, 38);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(254, 251);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // buttonStart2
            // 
            this.buttonStart2.Location = new System.Drawing.Point(274, 295);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(254, 29);
            this.buttonStart2.TabIndex = 3;
            this.buttonStart2.Text = "Запустити 2";
            this.buttonStart2.UseVisualStyleBackColor = true;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click_1);
            // 
            // buttonStart3
            // 
            this.buttonStart3.Location = new System.Drawing.Point(534, 295);
            this.buttonStart3.Name = "buttonStart3";
            this.buttonStart3.Size = new System.Drawing.Size(254, 29);
            this.buttonStart3.TabIndex = 3;
            this.buttonStart3.Text = "Запустити 3";
            this.buttonStart3.UseVisualStyleBackColor = true;
            this.buttonStart3.Click += new System.EventHandler(this.buttonStart3_Click_1);
            // 
            // buttonStartAll
            // 
            this.buttonStartAll.Location = new System.Drawing.Point(12, 330);
            this.buttonStartAll.Name = "buttonStartAll";
            this.buttonStartAll.Size = new System.Drawing.Size(776, 29);
            this.buttonStartAll.TabIndex = 7;
            this.buttonStartAll.Text = "Запустити всі потоки";
            this.buttonStartAll.UseVisualStyleBackColor = true;
            this.buttonStartAll.Click += new System.EventHandler(this.buttonStartAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.buttonStartAll);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonStart3);
            this.Controls.Add(this.buttonStart2);
            this.Controls.Add(this.buttonStart1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "lab24 var16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.Button buttonStart3;
        private System.Windows.Forms.Button buttonStartAll;
    }
}

