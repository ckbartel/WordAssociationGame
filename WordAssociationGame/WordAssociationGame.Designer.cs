namespace WordAssociationGame
{
    partial class WordAssociationGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxLoadData = new Button();
            uxOpenFileDialog = new OpenFileDialog();
            uxRevealLetter = new Button();
            uxGuessBox = new TextBox();
            uxGuess = new Button();
            uxGuessResult = new Label();
            uxGuesses = new ListBox();
            uxHint = new TextBox();
            SuspendLayout();
            // 
            // uxLoadData
            // 
            uxLoadData.Location = new Point(12, 12);
            uxLoadData.Name = "uxLoadData";
            uxLoadData.Size = new Size(132, 34);
            uxLoadData.TabIndex = 0;
            uxLoadData.Text = "Load Data";
            uxLoadData.UseVisualStyleBackColor = true;
            uxLoadData.Click += LoadDataClick;
            // 
            // uxRevealLetter
            // 
            uxRevealLetter.Location = new Point(252, 263);
            uxRevealLetter.Name = "uxRevealLetter";
            uxRevealLetter.Size = new Size(141, 34);
            uxRevealLetter.TabIndex = 1;
            uxRevealLetter.Text = "Reveal Letter";
            uxRevealLetter.UseVisualStyleBackColor = true;
            uxRevealLetter.Click += RevealLetterClick;
            // 
            // uxGuessBox
            // 
            uxGuessBox.Location = new Point(135, 203);
            uxGuessBox.Name = "uxGuessBox";
            uxGuessBox.Size = new Size(229, 31);
            uxGuessBox.TabIndex = 2;
            uxGuessBox.KeyDown += OnEnter;
            // 
            // uxGuess
            // 
            uxGuess.Location = new Point(105, 263);
            uxGuess.Name = "uxGuess";
            uxGuess.Size = new Size(141, 34);
            uxGuess.TabIndex = 3;
            uxGuess.Text = "Guess";
            uxGuess.UseVisualStyleBackColor = true;
            uxGuess.Click += GuessClick;
            // 
            // uxGuessResult
            // 
            uxGuessResult.AutoSize = true;
            uxGuessResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uxGuessResult.Location = new Point(158, 89);
            uxGuessResult.Name = "uxGuessResult";
            uxGuessResult.Size = new Size(195, 32);
            uxGuessResult.TabIndex = 4;
            uxGuessResult.Text = "Guess The Word!";
            uxGuessResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uxGuesses
            // 
            uxGuesses.FormattingEnabled = true;
            uxGuesses.ItemHeight = 25;
            uxGuesses.Location = new Point(515, 24);
            uxGuesses.Name = "uxGuesses";
            uxGuesses.Size = new Size(249, 404);
            uxGuesses.TabIndex = 5;
            // 
            // uxHint
            // 
            uxHint.BackColor = SystemColors.Control;
            uxHint.BorderStyle = BorderStyle.None;
            uxHint.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uxHint.Location = new Point(105, 141);
            uxHint.Name = "uxHint";
            uxHint.Size = new Size(304, 38);
            uxHint.TabIndex = 8;
            uxHint.TextAlign = HorizontalAlignment.Center;
            // 
            // WordAssociationGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uxHint);
            Controls.Add(uxGuesses);
            Controls.Add(uxGuessResult);
            Controls.Add(uxGuess);
            Controls.Add(uxGuessBox);
            Controls.Add(uxRevealLetter);
            Controls.Add(uxLoadData);
            Name = "WordAssociationGame";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxLoadData;
        private OpenFileDialog uxOpenFileDialog;
        private Button uxRevealLetter;
        private TextBox uxGuessBox;
        private Button uxGuess;
        private Label uxGuessResult;
        private ListBox uxGuesses;
        private TextBox uxHint;
    }
}
