namespace TicTacToe
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
            this.TopLeft = new System.Windows.Forms.Button();
            this.MiddleLeft = new System.Windows.Forms.Button();
            this.BottomLeft = new System.Windows.Forms.Button();
            this.TopMiddle = new System.Windows.Forms.Button();
            this.Middle = new System.Windows.Forms.Button();
            this.BottomMiddle = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            this.MiddleRight = new System.Windows.Forms.Button();
            this.BottomRight = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.XWins = new System.Windows.Forms.Label();
            this.OWins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopLeft
            // 
            this.TopLeft.Location = new System.Drawing.Point(272, 60);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(189, 149);
            this.TopLeft.TabIndex = 0;
            this.TopLeft.UseVisualStyleBackColor = true;
            this.TopLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.Location = new System.Drawing.Point(272, 233);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(189, 149);
            this.MiddleLeft.TabIndex = 1;
            this.MiddleLeft.UseVisualStyleBackColor = true;
            this.MiddleLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // BottomLeft
            // 
            this.BottomLeft.Location = new System.Drawing.Point(272, 403);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(189, 149);
            this.BottomLeft.TabIndex = 3;
            this.BottomLeft.UseVisualStyleBackColor = true;
            this.BottomLeft.Click += new System.EventHandler(this.buttonClick);
            // 
            // TopMiddle
            // 
            this.TopMiddle.Location = new System.Drawing.Point(482, 60);
            this.TopMiddle.Name = "TopMiddle";
            this.TopMiddle.Size = new System.Drawing.Size(189, 149);
            this.TopMiddle.TabIndex = 2;
            this.TopMiddle.UseVisualStyleBackColor = true;
            this.TopMiddle.Click += new System.EventHandler(this.buttonClick);
            // 
            // Middle
            // 
            this.Middle.Location = new System.Drawing.Point(482, 233);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(189, 149);
            this.Middle.TabIndex = 4;
            this.Middle.UseVisualStyleBackColor = true;
            this.Middle.Click += new System.EventHandler(this.buttonClick);
            // 
            // BottomMiddle
            // 
            this.BottomMiddle.Location = new System.Drawing.Point(482, 403);
            this.BottomMiddle.Name = "BottomMiddle";
            this.BottomMiddle.Size = new System.Drawing.Size(189, 149);
            this.BottomMiddle.TabIndex = 5;
            this.BottomMiddle.UseVisualStyleBackColor = true;
            this.BottomMiddle.Click += new System.EventHandler(this.buttonClick);
            // 
            // TopRight
            // 
            this.TopRight.Location = new System.Drawing.Point(689, 60);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(189, 149);
            this.TopRight.TabIndex = 6;
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // MiddleRight
            // 
            this.MiddleRight.Location = new System.Drawing.Point(689, 233);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(189, 149);
            this.MiddleRight.TabIndex = 7;
            this.MiddleRight.UseVisualStyleBackColor = true;
            this.MiddleRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // BottomRight
            // 
            this.BottomRight.Location = new System.Drawing.Point(689, 403);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(189, 149);
            this.BottomRight.TabIndex = 8;
            this.BottomRight.UseVisualStyleBackColor = true;
            this.BottomRight.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(272, 656);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(189, 53);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(482, 656);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(189, 53);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(878, 656);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(189, 53);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // XWins
            // 
            this.XWins.AutoSize = true;
            this.XWins.Location = new System.Drawing.Point(884, 122);
            this.XWins.Name = "XWins";
            this.XWins.Size = new System.Drawing.Size(64, 25);
            this.XWins.TabIndex = 12;
            this.XWins.Text = "label1";
            // 
            // OWins
            // 
            this.OWins.AutoSize = true;
            this.OWins.Location = new System.Drawing.Point(884, 295);
            this.OWins.Name = "OWins";
            this.OWins.Size = new System.Drawing.Size(64, 25);
            this.OWins.TabIndex = 13;
            this.OWins.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.AutoSize = true;
            this.Draws.Location = new System.Drawing.Point(884, 465);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(64, 25);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1004);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.OWins);
            this.Controls.Add(this.XWins);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.BottomMiddle);
            this.Controls.Add(this.Middle);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.TopMiddle);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.TopLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button MiddleLeft;
        private System.Windows.Forms.Button BottomLeft;
        private System.Windows.Forms.Button TopMiddle;
        private System.Windows.Forms.Button Middle;
        private System.Windows.Forms.Button BottomMiddle;
        private System.Windows.Forms.Button TopRight;
        private System.Windows.Forms.Button MiddleRight;
        private System.Windows.Forms.Button BottomRight;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label XWins;
        private System.Windows.Forms.Label OWins;
        private System.Windows.Forms.Label Draws;
    }
}

