namespace GuessNumApp {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.playerAnsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guessNumButton = new System.Windows.Forms.Button();
            this.ansListTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerAnsTextBox
            // 
            this.playerAnsTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.playerAnsTextBox.Location = new System.Drawing.Point(66, 33);
            this.playerAnsTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.playerAnsTextBox.MaxLength = 4;
            this.playerAnsTextBox.Name = "playerAnsTextBox";
            this.playerAnsTextBox.Size = new System.Drawing.Size(164, 35);
            this.playerAnsTextBox.TabIndex = 0;
            this.playerAnsTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playerAnsTextBox_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "開始新遊戲(&N)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // guessNumButton
            // 
            this.guessNumButton.Location = new System.Drawing.Point(285, 33);
            this.guessNumButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.guessNumButton.Name = "guessNumButton";
            this.guessNumButton.Size = new System.Drawing.Size(177, 35);
            this.guessNumButton.TabIndex = 2;
            this.guessNumButton.Text = "猜數字(&A)";
            this.guessNumButton.UseVisualStyleBackColor = true;
            this.guessNumButton.Click += new System.EventHandler(this.guessNumButton_Click);
            // 
            // ansListTextBox
            // 
            this.ansListTextBox.Location = new System.Drawing.Point(66, 91);
            this.ansListTextBox.Multiline = true;
            this.ansListTextBox.Name = "ansListTextBox";
            this.ansListTextBox.ReadOnly = true;
            this.ansListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ansListTextBox.Size = new System.Drawing.Size(164, 255);
            this.ansListTextBox.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 311);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "關閉(&C)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ansListTextBox);
            this.Controls.Add(this.guessNumButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerAnsTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.GuessNumForm_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerAnsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button guessNumButton;
        private System.Windows.Forms.TextBox ansListTextBox;
        private System.Windows.Forms.Button button3;
    }
}

