namespace IA_TP.UI
{
    partial class Main
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnDefaultConfig = new System.Windows.Forms.Button();
            this.btnCustomConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.pictureBoxConfig = new System.Windows.Forms.PictureBox();
            this.lstLogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(12, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run GA";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnDefaultConfig
            // 
            this.btnDefaultConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDefaultConfig.Location = new System.Drawing.Point(100, 12);
            this.btnDefaultConfig.Name = "btnDefaultConfig";
            this.btnDefaultConfig.Size = new System.Drawing.Size(97, 23);
            this.btnDefaultConfig.TabIndex = 2;
            this.btnDefaultConfig.Text = "Default Config";
            this.btnDefaultConfig.UseVisualStyleBackColor = false;
            this.btnDefaultConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnCustomConfig
            // 
            this.btnCustomConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomConfig.Location = new System.Drawing.Point(210, 11);
            this.btnCustomConfig.Name = "btnCustomConfig";
            this.btnCustomConfig.Size = new System.Drawing.Size(97, 23);
            this.btnCustomConfig.TabIndex = 4;
            this.btnCustomConfig.Text = "Custom Config";
            this.btnCustomConfig.UseVisualStyleBackColor = false;
            this.btnCustomConfig.Click += new System.EventHandler(this.btnCustomConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "click on each city to see its information";
            // 
            // btnRedraw
            // 
            this.btnRedraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRedraw.Location = new System.Drawing.Point(967, 12);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(97, 23);
            this.btnRedraw.TabIndex = 6;
            this.btnRedraw.Text = "Re-Draw";
            this.btnRedraw.UseVisualStyleBackColor = false;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // pictureBoxConfig
            // 
            this.pictureBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxConfig.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxConfig.Image = global::IA_TP.UI.Properties.Resources.Terrain3;
            this.pictureBoxConfig.Location = new System.Drawing.Point(13, 42);
            this.pictureBoxConfig.Name = "pictureBoxConfig";
            this.pictureBoxConfig.Size = new System.Drawing.Size(1051, 400);
            this.pictureBoxConfig.TabIndex = 3;
            this.pictureBoxConfig.TabStop = false;
            this.pictureBoxConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxConfig_MouseClick);
            // 
            // lstLogs
            // 
            this.lstLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstLogs.FormattingEnabled = true;
            this.lstLogs.Location = new System.Drawing.Point(12, 449);
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(1052, 173);
            this.lstLogs.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1076, 638);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomConfig);
            this.Controls.Add(this.pictureBoxConfig);
            this.Controls.Add(this.btnDefaultConfig);
            this.Controls.Add(this.btnRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN - IA - TP - Genetic Algorithm";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnDefaultConfig;
        private System.Windows.Forms.PictureBox pictureBoxConfig;
        private System.Windows.Forms.Button btnCustomConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.ListBox lstLogs;
    }
}

