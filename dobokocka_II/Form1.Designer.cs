namespace dobokocka_II
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
            this.buttonPlayer1Roll = new System.Windows.Forms.Button();
            this.buttonPlayer2Roll = new System.Windows.Forms.Button();
            this.labelPlayer1Roll = new System.Windows.Forms.Label();
            this.labelPlayer2Roll = new System.Windows.Forms.Label();
            this.labelRoundWinner = new System.Windows.Forms.Label();
            this.labelGameResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlayer1Roll
            // 
            this.buttonPlayer1Roll.Location = new System.Drawing.Point(30, 24);
            this.buttonPlayer1Roll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlayer1Roll.Name = "buttonPlayer1Roll";
            this.buttonPlayer1Roll.Size = new System.Drawing.Size(100, 40);
            this.buttonPlayer1Roll.TabIndex = 0;
            this.buttonPlayer1Roll.Text = "Player 2 Roll";
            this.buttonPlayer1Roll.UseVisualStyleBackColor = true;
            this.buttonPlayer1Roll.Click += new System.EventHandler(this.buttonPlayer1Roll_Click);
            // 
            // buttonPlayer2Roll
            // 
            this.buttonPlayer2Roll.Location = new System.Drawing.Point(150, 24);
            this.buttonPlayer2Roll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlayer2Roll.Name = "buttonPlayer2Roll";
            this.buttonPlayer2Roll.Size = new System.Drawing.Size(100, 40);
            this.buttonPlayer2Roll.TabIndex = 1;
            this.buttonPlayer2Roll.Text = "Player 2 Roll";
            this.buttonPlayer2Roll.UseVisualStyleBackColor = true;
            this.buttonPlayer2Roll.Click += new System.EventHandler(this.buttonPlayer1Roll_Click);
            // 
            // labelPlayer1Roll
            // 
            this.labelPlayer1Roll.AutoSize = true;
            this.labelPlayer1Roll.Location = new System.Drawing.Point(30, 80);
            this.labelPlayer1Roll.Name = "labelPlayer1Roll";
            this.labelPlayer1Roll.Size = new System.Drawing.Size(59, 16);
            this.labelPlayer1Roll.TabIndex = 2;
            this.labelPlayer1Roll.Text = "Player 1:";
            // 
            // labelPlayer2Roll
            // 
            this.labelPlayer2Roll.AutoSize = true;
            this.labelPlayer2Roll.Location = new System.Drawing.Point(150, 80);
            this.labelPlayer2Roll.Name = "labelPlayer2Roll";
            this.labelPlayer2Roll.Size = new System.Drawing.Size(59, 16);
            this.labelPlayer2Roll.TabIndex = 3;
            this.labelPlayer2Roll.Text = "Player 2:";
            // 
            // labelRoundWinner
            // 
            this.labelRoundWinner.AutoSize = true;
            this.labelRoundWinner.Location = new System.Drawing.Point(30, 120);
            this.labelRoundWinner.Name = "labelRoundWinner";
            this.labelRoundWinner.Size = new System.Drawing.Size(91, 16);
            this.labelRoundWinner.TabIndex = 4;
            this.labelRoundWinner.Text = "Round winner:";
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.Location = new System.Drawing.Point(30, 160);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(92, 16);
            this.labelGameResult.TabIndex = 5;
            this.labelGameResult.Text = "Player 1 Wins:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.labelGameResult);
            this.Controls.Add(this.labelRoundWinner);
            this.Controls.Add(this.labelPlayer2Roll);
            this.Controls.Add(this.labelPlayer1Roll);
            this.Controls.Add(this.buttonPlayer2Roll);
            this.Controls.Add(this.buttonPlayer1Roll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayer1Roll;
        private System.Windows.Forms.Button buttonPlayer2Roll;
        private System.Windows.Forms.Label labelPlayer1Roll;
        private System.Windows.Forms.Label labelPlayer2Roll;
        private System.Windows.Forms.Label labelRoundWinner;
        private System.Windows.Forms.Label labelGameResult;
    }
}
