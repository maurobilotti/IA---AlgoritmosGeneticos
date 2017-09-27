using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_TP.UI
{
    public partial class NewCity
    {
        private NumericUpDown numTVDemand;
        private NumericUpDown numInternetDemand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private NumericUpDown numPhoneDemand;
        private Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private NumericUpDown numLongitude;
        private System.Windows.Forms.Label label4;
        private NumericUpDown numLatitude;
        private Panel panel1;
        private System.Windows.Forms.Label label3;
        private TextBox txtCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private Button btnSaveCity;

        private void InitializeComponent()
        {
            this.numTVDemand = new System.Windows.Forms.NumericUpDown();
            this.numInternetDemand = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numPhoneDemand = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLongitude = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numLatitude = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTVDemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInternetDemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhoneDemand)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitude)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numTVDemand
            // 
            this.numTVDemand.Location = new System.Drawing.Point(367, 44);
            this.numTVDemand.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTVDemand.Name = "numTVDemand";
            this.numTVDemand.Size = new System.Drawing.Size(73, 20);
            this.numTVDemand.TabIndex = 10;
            this.numTVDemand.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numInternetDemand
            // 
            this.numInternetDemand.Location = new System.Drawing.Point(218, 44);
            this.numInternetDemand.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numInternetDemand.Name = "numInternetDemand";
            this.numInternetDemand.Size = new System.Drawing.Size(73, 20);
            this.numInternetDemand.TabIndex = 8;
            this.numInternetDemand.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Internet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phone";
            // 
            // numPhoneDemand
            // 
            this.numPhoneDemand.Location = new System.Drawing.Point(75, 44);
            this.numPhoneDemand.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPhoneDemand.Name = "numPhoneDemand";
            this.numPhoneDemand.Size = new System.Drawing.Size(73, 20);
            this.numPhoneDemand.TabIndex = 3;
            this.numPhoneDemand.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.numTVDemand);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numInternetDemand);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numPhoneDemand);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(40, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 76);
            this.panel2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(337, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "TV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Demand:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Longitude:";
            // 
            // numLongitude
            // 
            this.numLongitude.Location = new System.Drawing.Point(218, 44);
            this.numLongitude.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numLongitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLongitude.Name = "numLongitude";
            this.numLongitude.Size = new System.Drawing.Size(73, 20);
            this.numLongitude.TabIndex = 6;
            this.numLongitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Latitude:";
            // 
            // numLatitude
            // 
            this.numLatitude.Location = new System.Drawing.Point(75, 44);
            this.numLatitude.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLatitude.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLatitude.Name = "numLatitude";
            this.numLatitude.Size = new System.Drawing.Size(73, 20);
            this.numLatitude.TabIndex = 3;
            this.numLatitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numLongitude);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numLatitude);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(40, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 76);
            this.panel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(311, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "(Latitude <= 1000, Longitud <= 400)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location:";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(98, 49);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(189, 20);
            this.txtCityName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "City information:";
            // 
            // btnSaveCity
            // 
            this.btnSaveCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveCity.Location = new System.Drawing.Point(238, 278);
            this.btnSaveCity.Name = "btnSaveCity";
            this.btnSaveCity.Size = new System.Drawing.Size(93, 23);
            this.btnSaveCity.TabIndex = 14;
            this.btnSaveCity.Text = "Save";
            this.btnSaveCity.UseVisualStyleBackColor = false;
            this.btnSaveCity.Click += new System.EventHandler(this.btnSaveCity_Click);
            // 
            // NewCity
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(569, 313);
            this.Controls.Add(this.btnSaveCity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.NewCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTVDemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInternetDemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhoneDemand)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitude)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
