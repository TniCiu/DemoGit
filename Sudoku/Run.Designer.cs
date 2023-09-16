namespace Sudoku
{
    partial class Run
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
            this.groupbox = new System.Windows.Forms.Panel();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupbox.AutoSize = true;
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(278, 74);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(538, 472);
            this.groupbox.TabIndex = 0;
            this.groupbox.Text = "Level";
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(826, 247);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(90, 24);
            this.Medium.TabIndex = 3;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(826, 121);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(104, 41);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Solve";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(822, 74);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(108, 41);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(826, 298);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(69, 24);
            this.Hard.TabIndex = 3;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(826, 505);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(142, 41);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Checked = true;
            this.Easy.Location = new System.Drawing.Point(826, 188);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(69, 24);
            this.Easy.TabIndex = 3;
            this.Easy.TabStop = true;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1136, 795);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.Medium);
            this.Name = "Run";
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel groupbox;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton Easy;
    }
}

