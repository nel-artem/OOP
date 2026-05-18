namespace lab18
{
    partial class lab18
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonProdBetween = new System.Windows.Forms.Button();
            this.arraySizeInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_find_max_index = new System.Windows.Forms.Button();
            this.gen_array_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.arraySizeY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arraySizeX = new System.Windows.Forms.NumericUpDown();
            this.buttonGenMatrix = new System.Windows.Forms.Button();
            this.buttonGeomMean = new System.Windows.Forms.Button();
            this.buttonDiff = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeInput)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeX)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 120);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonTransform);
            this.tabPage1.Controls.Add(this.buttonProdBetween);
            this.tabPage1.Controls.Add(this.arraySizeInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button_find_max_index);
            this.tabPage1.Controls.Add(this.gen_array_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 94);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(525, 45);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(167, 42);
            this.buttonTransform.TabIndex = 6;
            this.buttonTransform.Text = "Transform array";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonProdBetween
            // 
            this.buttonProdBetween.Location = new System.Drawing.Point(352, 45);
            this.buttonProdBetween.Name = "buttonProdBetween";
            this.buttonProdBetween.Size = new System.Drawing.Size(167, 42);
            this.buttonProdBetween.TabIndex = 5;
            this.buttonProdBetween.Text = "Product between zeros";
            this.buttonProdBetween.UseVisualStyleBackColor = true;
            this.buttonProdBetween.Click += new System.EventHandler(this.buttonProdBetween_Click);
            // 
            // arraySizeInput
            // 
            this.arraySizeInput.Location = new System.Drawing.Point(6, 19);
            this.arraySizeInput.Name = "arraySizeInput";
            this.arraySizeInput.Size = new System.Drawing.Size(167, 20);
            this.arraySizeInput.TabIndex = 4;
            this.arraySizeInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Array size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_find_max_index
            // 
            this.button_find_max_index.Location = new System.Drawing.Point(179, 45);
            this.button_find_max_index.Name = "button_find_max_index";
            this.button_find_max_index.Size = new System.Drawing.Size(167, 42);
            this.button_find_max_index.TabIndex = 1;
            this.button_find_max_index.Text = "Find max index";
            this.button_find_max_index.UseVisualStyleBackColor = true;
            this.button_find_max_index.Click += new System.EventHandler(this.button_find_max_index_Click);
            // 
            // gen_array_button
            // 
            this.gen_array_button.Location = new System.Drawing.Point(6, 45);
            this.gen_array_button.Name = "gen_array_button";
            this.gen_array_button.Size = new System.Drawing.Size(167, 42);
            this.gen_array_button.TabIndex = 0;
            this.gen_array_button.Text = "Generate new array";
            this.gen_array_button.UseVisualStyleBackColor = true;
            this.gen_array_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDiff);
            this.tabPage2.Controls.Add(this.buttonGeomMean);
            this.tabPage2.Controls.Add(this.buttonGenMatrix);
            this.tabPage2.Controls.Add(this.arraySizeY);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.arraySizeX);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 94);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // arraySizeY
            // 
            this.arraySizeY.Location = new System.Drawing.Point(132, 19);
            this.arraySizeY.Name = "arraySizeY";
            this.arraySizeY.Size = new System.Drawing.Size(120, 20);
            this.arraySizeY.TabIndex = 8;
            this.arraySizeY.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Array size y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Array size x:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // arraySizeX
            // 
            this.arraySizeX.Location = new System.Drawing.Point(6, 19);
            this.arraySizeX.Name = "arraySizeX";
            this.arraySizeX.Size = new System.Drawing.Size(120, 20);
            this.arraySizeX.TabIndex = 5;
            this.arraySizeX.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // buttonGenMatrix
            // 
            this.buttonGenMatrix.Location = new System.Drawing.Point(6, 45);
            this.buttonGenMatrix.Name = "buttonGenMatrix";
            this.buttonGenMatrix.Size = new System.Drawing.Size(167, 42);
            this.buttonGenMatrix.TabIndex = 9;
            this.buttonGenMatrix.Text = "Generate new matrix";
            this.buttonGenMatrix.UseVisualStyleBackColor = true;
            this.buttonGenMatrix.Click += new System.EventHandler(this.buttonGenMatrix_Click);
            // 
            // buttonGeomMean
            // 
            this.buttonGeomMean.Location = new System.Drawing.Point(352, 45);
            this.buttonGeomMean.Name = "buttonGeomMean";
            this.buttonGeomMean.Size = new System.Drawing.Size(167, 42);
            this.buttonGeomMean.TabIndex = 10;
            this.buttonGeomMean.Text = "Find geometric mean";
            this.buttonGeomMean.UseVisualStyleBackColor = true;
            this.buttonGeomMean.Click += new System.EventHandler(this.buttonGeomMean_Click);
            // 
            // buttonDiff
            // 
            this.buttonDiff.Location = new System.Drawing.Point(179, 45);
            this.buttonDiff.Name = "buttonDiff";
            this.buttonDiff.Size = new System.Drawing.Size(167, 42);
            this.buttonDiff.TabIndex = 11;
            this.buttonDiff.Text = "Difference between two elements";
            this.buttonDiff.UseVisualStyleBackColor = true;
            this.buttonDiff.Click += new System.EventHandler(this.buttonDiff_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Console";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consoleTextBox.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextBox.ForeColor = System.Drawing.Color.Yellow;
            this.consoleTextBox.Location = new System.Drawing.Point(16, 151);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(697, 363);
            this.consoleTextBox.TabIndex = 2;
            this.consoleTextBox.Text = "";
            this.consoleTextBox.TextChanged += new System.EventHandler(this.consoleBox_TextChanged);
            // 
            // lab18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(727, 526);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "lab18";
            this.Text = "Lab 18 Var 16";
            this.Load += new System.EventHandler(this.lab18_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeInput)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button gen_array_button;
        private System.Windows.Forms.Button button_find_max_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown arraySizeInput;
        private System.Windows.Forms.Button buttonProdBetween;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown arraySizeX;
        private System.Windows.Forms.NumericUpDown arraySizeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGenMatrix;
        private System.Windows.Forms.Button buttonDiff;
        private System.Windows.Forms.Button buttonGeomMean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox consoleTextBox;
    }
}