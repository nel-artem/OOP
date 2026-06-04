namespace lab19
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
            this.checkButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.correctCodeButton = new System.Windows.Forms.Button();
            this.incorrectCodeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(401, 13);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(226, 35);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 16);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Location = new System.Drawing.Point(401, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 289);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(13, 13);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(382, 425);
            this.codeBox.TabIndex = 4;
            this.codeBox.Text = "";
            // 
            // correctCodeButton
            // 
            this.correctCodeButton.Location = new System.Drawing.Point(9, 19);
            this.correctCodeButton.Name = "correctCodeButton";
            this.correctCodeButton.Size = new System.Drawing.Size(211, 25);
            this.correctCodeButton.TabIndex = 5;
            this.correctCodeButton.Text = "Correct Code";
            this.correctCodeButton.UseVisualStyleBackColor = true;
            this.correctCodeButton.Click += new System.EventHandler(this.correctCodeButton_Click);
            // 
            // incorrectCodeButton
            // 
            this.incorrectCodeButton.Location = new System.Drawing.Point(9, 50);
            this.incorrectCodeButton.Name = "incorrectCodeButton";
            this.incorrectCodeButton.Size = new System.Drawing.Size(211, 25);
            this.incorrectCodeButton.TabIndex = 6;
            this.incorrectCodeButton.Text = "Incorrect Code";
            this.incorrectCodeButton.UseVisualStyleBackColor = true;
            this.incorrectCodeButton.Click += new System.EventHandler(this.incorrectCodeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.correctCodeButton);
            this.groupBox2.Controls.Add(this.incorrectCodeButton);
            this.groupBox2.Location = new System.Drawing.Point(401, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing Templates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 19 Var 16 - testing java bracket syntaxt";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.Button correctCodeButton;
        private System.Windows.Forms.Button incorrectCodeButton;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

