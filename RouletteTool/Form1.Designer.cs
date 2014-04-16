namespace RouletteTool
{
    partial class frmMain
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
            this.btnWin = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.cbStrategy = new System.Windows.Forms.ComboBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtStrategy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWin
            // 
            this.btnWin.BackColor = System.Drawing.Color.Lime;
            this.btnWin.Location = new System.Drawing.Point(387, 34);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(75, 23);
            this.btnWin.TabIndex = 0;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = false;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnLose
            // 
            this.btnLose.BackColor = System.Drawing.Color.Red;
            this.btnLose.Location = new System.Drawing.Point(387, 72);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(75, 23);
            this.btnLose.TabIndex = 1;
            this.btnLose.Text = "Lose";
            this.btnLose.UseVisualStyleBackColor = false;
            // 
            // cbStrategy
            // 
            this.cbStrategy.FormattingEnabled = true;
            this.cbStrategy.Location = new System.Drawing.Point(70, 34);
            this.cbStrategy.Name = "cbStrategy";
            this.cbStrategy.Size = new System.Drawing.Size(233, 21);
            this.cbStrategy.TabIndex = 2;
            this.cbStrategy.Text = "Strategy Selector";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(387, 297);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(70, 61);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(233, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtStrategy
            // 
            this.txtStrategy.Cursor = System.Windows.Forms.Cursors.No;
            this.txtStrategy.Enabled = false;
            this.txtStrategy.Location = new System.Drawing.Point(70, 90);
            this.txtStrategy.Name = "txtStrategy";
            this.txtStrategy.Size = new System.Drawing.Size(233, 20);
            this.txtStrategy.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RouletteTool.Properties.Resources.roulette_wallpapers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(509, 332);
            this.Controls.Add(this.txtStrategy);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.cbStrategy);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmMain";
            this.Text = "Roulette Strategy Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.ComboBox cbStrategy;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtStrategy;
    }
}

