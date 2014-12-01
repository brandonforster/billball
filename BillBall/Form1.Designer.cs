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
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.sbmtBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.sbmtBtn2 = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(16, 102);
            this.dataBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(793, 413);
            this.dataBox.TabIndex = 0;
            this.dataBox.Text = "";
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(291, 14);
            this.inputBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(248, 22);
            this.inputBox1.TabIndex = 1;
            // 
            // sbmtBtn1
            // 
            this.sbmtBtn1.Location = new System.Drawing.Point(603, 11);
            this.sbmtBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.sbmtBtn1.Name = "sbmtBtn1";
            this.sbmtBtn1.Size = new System.Drawing.Size(100, 28);
            this.sbmtBtn1.TabIndex = 2;
            this.sbmtBtn1.Text = "Submit";
            this.sbmtBtn1.UseVisualStyleBackColor = true;
            this.sbmtBtn1.Click += new System.EventHandler(this.sbmtBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Term to Search";
            // 
            // clearBtn1
            // 
            this.clearBtn1.Location = new System.Drawing.Point(711, 11);
            this.clearBtn1.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.Size = new System.Drawing.Size(100, 28);
            this.clearBtn1.TabIndex = 4;
            this.clearBtn1.Text = "Clear";
            this.clearBtn1.UseVisualStyleBackColor = true;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Term to Search";
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(291, 56);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(248, 22);
            this.inputBox2.TabIndex = 6;
            // 
            // sbmtBtn2
            // 
            this.sbmtBtn2.Location = new System.Drawing.Point(603, 53);
            this.sbmtBtn2.Margin = new System.Windows.Forms.Padding(4);
            this.sbmtBtn2.Name = "sbmtBtn2";
            this.sbmtBtn2.Size = new System.Drawing.Size(100, 28);
            this.sbmtBtn2.TabIndex = 7;
            this.sbmtBtn2.Text = "Submit";
            this.sbmtBtn2.UseVisualStyleBackColor = true;
            this.sbmtBtn2.Click += new System.EventHandler(this.sbmtBtn2_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(42, 17);
            this.player1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(84, 20);
            this.player1Label.TabIndex = 8;
            this.player1Label.Text = "Player 1:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(42, 56);
            this.player2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(84, 20);
            this.player2Label.TabIndex = 9;
            this.player2Label.Text = "Player 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 530);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.sbmtBtn2);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearBtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbmtBtn1);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.dataBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bill Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dataBox;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.Button sbmtBtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.Button sbmtBtn2;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;

    }
}

