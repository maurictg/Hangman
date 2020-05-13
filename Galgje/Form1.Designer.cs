namespace Galgje
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
            this.components = new System.ComponentModel.Container();
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.pbGalgje = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.lblTimespan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lbStats = new System.Windows.Forms.ListBox();
            this.cbUseKey = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalgje)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLetters
            // 
            this.pnlLetters.Location = new System.Drawing.Point(0, 0);
            this.pnlLetters.Name = "pnlLetters";
            this.pnlLetters.Size = new System.Drawing.Size(1340, 71);
            this.pnlLetters.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(2, 74);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(205, 159);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "10";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.Aqua;
            this.lblWord.Location = new System.Drawing.Point(2, 299);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(870, 106);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ";
            // 
            // pbGalgje
            // 
            this.pbGalgje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pbGalgje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGalgje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGalgje.Location = new System.Drawing.Point(911, 84);
            this.pbGalgje.Name = "pbGalgje";
            this.pbGalgje.Size = new System.Drawing.Size(400, 700);
            this.pbGalgje.TabIndex = 2;
            this.pbGalgje.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore.Location = new System.Drawing.Point(663, 655);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(175, 81);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(700, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 767);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(114, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: loading...";
            // 
            // btnHint
            // 
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.Location = new System.Drawing.Point(770, 86);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(122, 58);
            this.btnHint.TabIndex = 7;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.BtnHint_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(770, 150);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 58);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ticker
            // 
            this.ticker.Interval = 50;
            this.ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // lblTimespan
            // 
            this.lblTimespan.AutoSize = true;
            this.lblTimespan.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimespan.ForeColor = System.Drawing.Color.Silver;
            this.lblTimespan.Location = new System.Drawing.Point(624, 521);
            this.lblTimespan.Name = "lblTimespan";
            this.lblTimespan.Size = new System.Drawing.Size(248, 54);
            this.lblTimespan.TabIndex = 13;
            this.lblTimespan.Text = "00:00:00.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(700, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 49);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(534, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 15;
            this.label1.Text = "Win  /   Lose";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.Lime;
            this.lblWin.Location = new System.Drawing.Point(529, 137);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(70, 81);
            this.lblWin.TabIndex = 16;
            this.lblWin.Text = "0";
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.Red;
            this.lblLose.Location = new System.Drawing.Point(663, 137);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(70, 81);
            this.lblLose.TabIndex = 17;
            this.lblLose.Text = "0";
            // 
            // lbStats
            // 
            this.lbStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lbStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbStats.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStats.ForeColor = System.Drawing.Color.White;
            this.lbStats.FormattingEnabled = true;
            this.lbStats.ItemHeight = 37;
            this.lbStats.Location = new System.Drawing.Point(12, 431);
            this.lbStats.Name = "lbStats";
            this.lbStats.Size = new System.Drawing.Size(587, 296);
            this.lbStats.TabIndex = 18;
            // 
            // cbUseKey
            // 
            this.cbUseKey.AutoSize = true;
            this.cbUseKey.Checked = true;
            this.cbUseKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseKey.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUseKey.ForeColor = System.Drawing.Color.White;
            this.cbUseKey.Location = new System.Drawing.Point(20, 728);
            this.cbUseKey.Name = "cbUseKey";
            this.cbUseKey.Size = new System.Drawing.Size(182, 36);
            this.cbUseKey.TabIndex = 19;
            this.cbUseKey.Text = "Use keyboard";
            this.cbUseKey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1342, 796);
            this.Controls.Add(this.cbUseKey);
            this.Controls.Add(this.lblTimespan);
            this.Controls.Add(this.lbStats);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.pbGalgje);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.pnlLetters);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Galgje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGalgje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLetters;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pbGalgje;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.Label lblTimespan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.ListBox lbStats;
        private System.Windows.Forms.CheckBox cbUseKey;
    }
}

