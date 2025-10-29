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
            uxRevealWord = new Button();
            uxGuessBox = new TextBox();
            uxGuess = new Button();
            uxGuessResult = new Label();
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
            // uxRevealWord
            // 
            uxRevealWord.Location = new Point(382, 251);
            uxRevealWord.Name = "uxRevealWord";
            uxRevealWord.Size = new Size(141, 34);
            uxRevealWord.TabIndex = 1;
            uxRevealWord.Text = "Reveal Word";
            uxRevealWord.UseVisualStyleBackColor = true;
            uxRevealWord.Click += RevealWordClick;
            // 
            // uxGuessBox
            // 
            uxGuessBox.Location = new Point(264, 191);
            uxGuessBox.Name = "uxGuessBox";
            uxGuessBox.Size = new Size(229, 31);
            uxGuessBox.TabIndex = 2;
            // 
            // uxGuess
            // 
            uxGuess.Location = new Point(235, 251);
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
            uxGuessResult.Location = new Point(308, 128);
            uxGuessResult.Name = "uxGuessResult";
            uxGuessResult.Size = new Size(146, 25);
            uxGuessResult.TabIndex = 4;
            uxGuessResult.Text = "Guess The Word!";
            uxGuessResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WordAssociationGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uxGuessResult);
            Controls.Add(uxGuess);
            Controls.Add(uxGuessBox);
            Controls.Add(uxRevealWord);
            Controls.Add(uxLoadData);
            Name = "WordAssociationGame";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxLoadData;
        private OpenFileDialog uxOpenFileDialog;
        private Button uxRevealWord;
        private TextBox uxGuessBox;
        private Button uxGuess;
        private Label uxGuessResult;
    }
}
