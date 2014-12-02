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
            this.dataBox = new System.Windows.Forms.RichTextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sbmtBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.srcLabel = new System.Windows.Forms.Label();
            this.srcWordLabel = new System.Windows.Forms.Label();
            this.srcValLabel = new System.Windows.Forms.Label();
            this.srcWorthLabel = new System.Windows.Forms.Label();
            this.srcPointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(12, 176);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(311, 216);
            this.dataBox.TabIndex = 0;
            this.dataBox.Text = "";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(102, 39);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(348, 20);
            this.inputBox.TabIndex = 1;
            // 
            // sbmtBtn
            // 
            this.sbmtBtn.Location = new System.Drawing.Point(456, 36);
            this.sbmtBtn.Name = "sbmtBtn";
            this.sbmtBtn.Size = new System.Drawing.Size(75, 23);
            this.sbmtBtn.TabIndex = 2;
            this.sbmtBtn.Text = "Submit";
            this.sbmtBtn.UseVisualStyleBackColor = true;
            this.sbmtBtn.Click += new System.EventHandler(this.sbmtBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(16, 41);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(80, 13);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Enter Your Play";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(537, 36);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // srcLabel
            // 
            this.srcLabel.AutoSize = true;
            this.srcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcLabel.Location = new System.Drawing.Point(12, 19);
            this.srcLabel.Name = "srcLabel";
            this.srcLabel.Size = new System.Drawing.Size(80, 17);
            this.srcLabel.TabIndex = 5;
            this.srcLabel.Text = "Your Word:";
            this.srcLabel.Click += new System.EventHandler(this.srcLabel_Click);
            // 
            // srcWordLabel
            // 
            this.srcWordLabel.AutoSize = true;
            this.srcWordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcWordLabel.Location = new System.Drawing.Point(98, 17);
            this.srcWordLabel.Name = "srcWordLabel";
            this.srcWordLabel.Size = new System.Drawing.Size(54, 19);
            this.srcWordLabel.TabIndex = 6;
            this.srcWordLabel.Text = "Word!";
            // 
            // srcValLabel
            // 
            this.srcValLabel.AutoSize = true;
            this.srcValLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcValLabel.Location = new System.Drawing.Point(342, 17);
            this.srcValLabel.Name = "srcValLabel";
            this.srcValLabel.Size = new System.Drawing.Size(74, 19);
            this.srcValLabel.TabIndex = 8;
            this.srcValLabel.Text = "Number!";
            // 
            // srcWorthLabel
            // 
            this.srcWorthLabel.AutoSize = true;
            this.srcWorthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcWorthLabel.Location = new System.Drawing.Point(215, 19);
            this.srcWorthLabel.Name = "srcWorthLabel";
            this.srcWorthLabel.Size = new System.Drawing.Size(121, 17);
            this.srcWorthLabel.TabIndex = 7;
            this.srcWorthLabel.Text = "This word is worth";
            // 
            // srcPointsLabel
            // 
            this.srcPointsLabel.AutoSize = true;
            this.srcPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.srcPointsLabel.Location = new System.Drawing.Point(433, 19);
            this.srcPointsLabel.Name = "srcPointsLabel";
            this.srcPointsLabel.Size = new System.Drawing.Size(49, 17);
            this.srcPointsLabel.TabIndex = 9;
            this.srcPointsLabel.Text = "points!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 431);
            this.Controls.Add(this.srcPointsLabel);
            this.Controls.Add(this.srcValLabel);
            this.Controls.Add(this.srcWorthLabel);
            this.Controls.Add(this.srcWordLabel);
            this.Controls.Add(this.srcLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.sbmtBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.dataBox);
            this.Name = "Form1";
            this.Text = "Bill Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dataBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sbmtBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label srcLabel;
        private System.Windows.Forms.Label srcWordLabel;
        private System.Windows.Forms.Label srcValLabel;
        private System.Windows.Forms.Label srcWorthLabel;
        private System.Windows.Forms.Label srcPointsLabel;

    }
}

