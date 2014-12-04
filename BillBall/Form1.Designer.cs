namespace BillBall
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sbmtBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.srcLabel = new System.Windows.Forms.Label();
            this.srcWordLabel = new System.Windows.Forms.Label();
            this.srcValLabel = new System.Windows.Forms.Label();
            this.srcWorthLabel = new System.Windows.Forms.Label();
            this.srcPointsLabel = new System.Windows.Forms.Label();
            this.searchWorthLabel = new System.Windows.Forms.Label();
            this.searchValLabel = new System.Windows.Forms.Label();
            this.searchPointsLabel = new System.Windows.Forms.Label();
            this.frameLabel = new System.Windows.Forms.Label();
            this.frameValLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreValLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(224, 72);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(176, 22);
            this.inputBox.TabIndex = 1;
            // 
            // sbmtBtn
            // 
            this.sbmtBtn.Location = new System.Drawing.Point(423, 69);
            this.sbmtBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sbmtBtn.Name = "sbmtBtn";
            this.sbmtBtn.Size = new System.Drawing.Size(100, 28);
            this.sbmtBtn.TabIndex = 2;
            this.sbmtBtn.Text = "Submit";
            this.sbmtBtn.UseVisualStyleBackColor = true;
            this.sbmtBtn.Click += new System.EventHandler(this.sbmtBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.Navy;
            this.searchLabel.Location = new System.Drawing.Point(13, 67);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(181, 28);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Enter Your Play";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(531, 69);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // srcLabel
            // 
            this.srcLabel.AutoSize = true;
            this.srcLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcLabel.ForeColor = System.Drawing.Color.Navy;
            this.srcLabel.Location = new System.Drawing.Point(13, 21);
            this.srcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcLabel.Name = "srcLabel";
            this.srcLabel.Size = new System.Drawing.Size(135, 28);
            this.srcLabel.TabIndex = 5;
            this.srcLabel.Text = "Your Word:";
            this.srcLabel.Click += new System.EventHandler(this.srcLabel_Click);
            // 
            // srcWordLabel
            // 
            this.srcWordLabel.AutoSize = true;
            this.srcWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcWordLabel.Location = new System.Drawing.Point(156, 19);
            this.srcWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcWordLabel.Name = "srcWordLabel";
            this.srcWordLabel.Size = new System.Drawing.Size(77, 29);
            this.srcWordLabel.TabIndex = 6;
            this.srcWordLabel.Text = "Word!";
            // 
            // srcValLabel
            // 
            this.srcValLabel.AutoSize = true;
            this.srcValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcValLabel.Location = new System.Drawing.Point(524, 19);
            this.srcValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcValLabel.Name = "srcValLabel";
            this.srcValLabel.Size = new System.Drawing.Size(106, 29);
            this.srcValLabel.TabIndex = 8;
            this.srcValLabel.Text = "Number!";
            // 
            // srcWorthLabel
            // 
            this.srcWorthLabel.AutoSize = true;
            this.srcWorthLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcWorthLabel.ForeColor = System.Drawing.Color.Navy;
            this.srcWorthLabel.Location = new System.Drawing.Point(301, 21);
            this.srcWorthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcWorthLabel.Name = "srcWorthLabel";
            this.srcWorthLabel.Size = new System.Drawing.Size(215, 28);
            this.srcWorthLabel.TabIndex = 7;
            this.srcWorthLabel.Text = "This word is worth";
            // 
            // srcPointsLabel
            // 
            this.srcPointsLabel.AutoSize = true;
            this.srcPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcPointsLabel.Location = new System.Drawing.Point(676, 19);
            this.srcPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.srcPointsLabel.Name = "srcPointsLabel";
            this.srcPointsLabel.Size = new System.Drawing.Size(84, 29);
            this.srcPointsLabel.TabIndex = 9;
            this.srcPointsLabel.Text = "points!";
            // 
            // searchWorthLabel
            // 
            this.searchWorthLabel.AutoSize = true;
            this.searchWorthLabel.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWorthLabel.ForeColor = System.Drawing.Color.Navy;
            this.searchWorthLabel.Location = new System.Drawing.Point(13, 112);
            this.searchWorthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchWorthLabel.Name = "searchWorthLabel";
            this.searchWorthLabel.Size = new System.Drawing.Size(207, 28);
            this.searchWorthLabel.TabIndex = 10;
            this.searchWorthLabel.Text = "Your play is worth";
            // 
            // searchValLabel
            // 
            this.searchValLabel.AutoSize = true;
            this.searchValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchValLabel.Location = new System.Drawing.Point(239, 110);
            this.searchValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchValLabel.Name = "searchValLabel";
            this.searchValLabel.Size = new System.Drawing.Size(19, 29);
            this.searchValLabel.TabIndex = 11;
            this.searchValLabel.Text = " ";
            // 
            // searchPointsLabel
            // 
            this.searchPointsLabel.AutoSize = true;
            this.searchPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPointsLabel.Location = new System.Drawing.Point(346, 110);
            this.searchPointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchPointsLabel.Name = "searchPointsLabel";
            this.searchPointsLabel.Size = new System.Drawing.Size(84, 29);
            this.searchPointsLabel.TabIndex = 12;
            this.searchPointsLabel.Text = "points!";
            // 
            // frameLabel
            // 
            this.frameLabel.AutoSize = true;
            this.frameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameLabel.Location = new System.Drawing.Point(211, 186);
            this.frameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frameLabel.Name = "frameLabel";
            this.frameLabel.Size = new System.Drawing.Size(80, 25);
            this.frameLabel.TabIndex = 13;
            this.frameLabel.Text = "Frame:";
            // 
            // frameValLabel
            // 
            this.frameValLabel.AutoSize = true;
            this.frameValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameValLabel.Location = new System.Drawing.Point(291, 186);
            this.frameValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frameValLabel.Name = "frameValLabel";
            this.frameValLabel.Size = new System.Drawing.Size(0, 25);
            this.frameValLabel.TabIndex = 14;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(338, 186);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(212, 25);
            this.scoreLabel.TabIndex = 15;
            this.scoreLabel.Text = "Total Bowling Score:";
            // 
            // scoreValLabel
            // 
            this.scoreValLabel.AutoSize = true;
            this.scoreValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreValLabel.Location = new System.Drawing.Point(558, 186);
            this.scoreValLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreValLabel.Name = "scoreValLabel";
            this.scoreValLabel.Size = new System.Drawing.Size(18, 25);
            this.scoreValLabel.TabIndex = 16;
            this.scoreValLabel.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(239, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreValLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.frameValLabel);
            this.Controls.Add(this.frameLabel);
            this.Controls.Add(this.searchPointsLabel);
            this.Controls.Add(this.searchValLabel);
            this.Controls.Add(this.searchWorthLabel);
            this.Controls.Add(this.srcPointsLabel);
            this.Controls.Add(this.srcValLabel);
            this.Controls.Add(this.srcWorthLabel);
            this.Controls.Add(this.srcWordLabel);
            this.Controls.Add(this.srcLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.sbmtBtn);
            this.Controls.Add(this.inputBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bill Ball";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sbmtBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label srcLabel;
        private System.Windows.Forms.Label srcWordLabel;
        private System.Windows.Forms.Label srcValLabel;
        private System.Windows.Forms.Label srcWorthLabel;
        private System.Windows.Forms.Label srcPointsLabel;
        private System.Windows.Forms.Label searchWorthLabel;
        private System.Windows.Forms.Label searchValLabel;
        private System.Windows.Forms.Label searchPointsLabel;
        private System.Windows.Forms.Label frameLabel;
        private System.Windows.Forms.Label frameValLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreValLabel;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

