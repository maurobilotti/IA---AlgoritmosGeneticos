namespace IA_TP.UI
{
    partial class CustomConfig
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
            this.btnNewCity = new System.Windows.Forms.Button();
            this.gridCities = new System.Windows.Forms.DataGridView();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numFiberChannelKms = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTVPrice = new System.Windows.Forms.NumericUpDown();
            this.numInternetPrice = new System.Windows.Forms.NumericUpDown();
            this.numPhonePrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveCity = new System.Windows.Forms.Button();
            this.btnEditCity = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numFiberChannelCost = new System.Windows.Forms.NumericUpDown();
            this.numPenalty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiberChannelKms)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTVPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInternetPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhonePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiberChannelCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenalty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCity
            // 
            this.btnNewCity.BackColor = System.Drawing.Color.Orange;
            this.btnNewCity.Location = new System.Drawing.Point(18, 135);
            this.btnNewCity.Name = "btnNewCity";
            this.btnNewCity.Size = new System.Drawing.Size(118, 23);
            this.btnNewCity.TabIndex = 0;
            this.btnNewCity.Text = "Add New City";
            this.btnNewCity.UseVisualStyleBackColor = false;
            this.btnNewCity.Click += new System.EventHandler(this.btnNewCity_Click);
            // 
            // gridCities
            // 
            this.gridCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCities.Location = new System.Drawing.Point(17, 162);
            this.gridCities.Name = "gridCities";
            this.gridCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCities.Size = new System.Drawing.Size(665, 251);
            this.gridCities.TabIndex = 1;
            this.gridCities.SelectionChanged += new System.EventHandler(this.gridCities_SelectionChanged);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveConfig.Location = new System.Drawing.Point(273, 465);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 2;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(354, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(141, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "WARNING: At least three cities are needed";
            // 
            // numFiberChannelKms
            // 
            this.numFiberChannelKms.Location = new System.Drawing.Point(117, 14);
            this.numFiberChannelKms.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFiberChannelKms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFiberChannelKms.Name = "numFiberChannelKms";
            this.numFiberChannelKms.Size = new System.Drawing.Size(70, 20);
            this.numFiberChannelKms.TabIndex = 5;
            this.numFiberChannelKms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fiber Channel (KM)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.numTVPrice);
            this.panel1.Controls.Add(this.numInternetPrice);
            this.panel1.Controls.Add(this.numPhonePrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 77);
            this.panel1.TabIndex = 7;
            // 
            // numTVPrice
            // 
            this.numTVPrice.Location = new System.Drawing.Point(497, 34);
            this.numTVPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTVPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTVPrice.Name = "numTVPrice";
            this.numTVPrice.Size = new System.Drawing.Size(70, 20);
            this.numTVPrice.TabIndex = 10;
            this.numTVPrice.ThousandsSeparator = true;
            this.numTVPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numInternetPrice
            // 
            this.numInternetPrice.Location = new System.Drawing.Point(309, 34);
            this.numInternetPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numInternetPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInternetPrice.Name = "numInternetPrice";
            this.numInternetPrice.Size = new System.Drawing.Size(70, 20);
            this.numInternetPrice.TabIndex = 9;
            this.numInternetPrice.ThousandsSeparator = true;
            this.numInternetPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPhonePrice
            // 
            this.numPhonePrice.Location = new System.Drawing.Point(100, 34);
            this.numPhonePrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPhonePrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPhonePrice.Name = "numPhonePrice";
            this.numPhonePrice.Size = new System.Drawing.Size(70, 20);
            this.numPhonePrice.TabIndex = 8;
            this.numPhonePrice.ThousandsSeparator = true;
            this.numPhonePrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "TV ($) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Internet ($) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone ($) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Catalogue";
            // 
            // btnRemoveCity
            // 
            this.btnRemoveCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveCity.Location = new System.Drawing.Point(604, 422);
            this.btnRemoveCity.Name = "btnRemoveCity";
            this.btnRemoveCity.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCity.TabIndex = 8;
            this.btnRemoveCity.Text = "Remove";
            this.btnRemoveCity.UseVisualStyleBackColor = false;
            // 
            // btnEditCity
            // 
            this.btnEditCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnEditCity.Location = new System.Drawing.Point(523, 422);
            this.btnEditCity.Name = "btnEditCity";
            this.btnEditCity.Size = new System.Drawing.Size(75, 23);
            this.btnEditCity.TabIndex = 9;
            this.btnEditCity.Text = "Edit";
            this.btnEditCity.UseVisualStyleBackColor = false;
            this.btnEditCity.Click += new System.EventHandler(this.btnEditCity_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(17, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 326);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fiber Channel Cost ($/KM)";
            // 
            // numFiberChannelCost
            // 
            this.numFiberChannelCost.Location = new System.Drawing.Point(334, 14);
            this.numFiberChannelCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFiberChannelCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFiberChannelCost.Name = "numFiberChannelCost";
            this.numFiberChannelCost.Size = new System.Drawing.Size(62, 20);
            this.numFiberChannelCost.TabIndex = 11;
            this.numFiberChannelCost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numPenalty
            // 
            this.numPenalty.Location = new System.Drawing.Point(514, 14);
            this.numPenalty.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numPenalty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenalty.Name = "numPenalty";
            this.numPenalty.Size = new System.Drawing.Size(70, 20);
            this.numPenalty.TabIndex = 13;
            this.numPenalty.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Penalty (%)";
            // 
            // CustomConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 496);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numPenalty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numFiberChannelCost);
            this.Controls.Add(this.btnEditCity);
            this.Controls.Add(this.btnRemoveCity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numFiberChannelKms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.gridCities);
            this.Controls.Add(this.btnNewCity);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Config";
            this.Load += new System.EventHandler(this.CustomConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiberChannelKms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTVPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInternetPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhonePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiberChannelCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCity;
        private System.Windows.Forms.DataGridView gridCities;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numFiberChannelKms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTVPrice;
        private System.Windows.Forms.NumericUpDown numInternetPrice;
        private System.Windows.Forms.NumericUpDown numPhonePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveCity;
        private System.Windows.Forms.Button btnEditCity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numFiberChannelCost;
        private System.Windows.Forms.NumericUpDown numPenalty;
        private System.Windows.Forms.Label label8;
    }
}