namespace WordPuzzle_Solver
{
    partial class WordPuzzleSolverForm
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
            this.lettersAvailable = new System.Windows.Forms.TextBox();
            this.numberOfLetters = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLetters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letters Available";
            // 
            // lettersAvailable
            // 
            this.lettersAvailable.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettersAvailable.Location = new System.Drawing.Point(146, 25);
            this.lettersAvailable.Name = "lettersAvailable";
            this.lettersAvailable.Size = new System.Drawing.Size(151, 26);
            this.lettersAvailable.TabIndex = 1;
            // 
            // numberOfLetters
            // 
            this.numberOfLetters.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfLetters.Location = new System.Drawing.Point(146, 57);
            this.numberOfLetters.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberOfLetters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfLetters.Name = "numberOfLetters";
            this.numberOfLetters.Size = new System.Drawing.Size(77, 26);
            this.numberOfLetters.TabIndex = 2;
            this.numberOfLetters.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Letters in Word";
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.Location = new System.Drawing.Point(15, 125);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(282, 134);
            this.wordsListBox.TabIndex = 4;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(15, 96);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(128, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate Word List";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // WordPuzzleSolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 279);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfLetters);
            this.Controls.Add(this.lettersAvailable);
            this.Controls.Add(this.label1);
            this.Name = "WordPuzzleSolverForm";
            this.Text = "Word Puzzle Solver";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfLetters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lettersAvailable;
        private System.Windows.Forms.NumericUpDown numberOfLetters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.Button generateButton;
    }
}

