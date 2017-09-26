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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listView1.Location = new System.Drawing.Point(14, 448);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1001, 170);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(12, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run GA";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(102, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(97, 23);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Default Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Custom Config";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxConfig
            // 
            this.pictureBoxConfig.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxConfig.Image = global::IA_TP.UI.Properties.Resources.Terrain3;
            this.pictureBoxConfig.Location = new System.Drawing.Point(13, 42);
            this.pictureBoxConfig.Name = "pictureBoxConfig";
            this.pictureBoxConfig.Size = new System.Drawing.Size(1000, 400);
            this.pictureBoxConfig.TabIndex = 3;
            this.pictureBoxConfig.TabStop = false;
            this.pictureBoxConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxConfig_MouseClick);
            
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxConfig);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "UTN - IA - TP - Genetic Algorithm";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.PictureBox pictureBoxConfig;
        private System.Windows.Forms.Button button1;
    }
}

