namespace IA_TP.UI
{
    partial class GeneticAlgorithmConfig
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
            this.numElitismPercentage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCrossoverProbability = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numMutationProbability = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numGenerationStop = new System.Windows.Forms.NumericUpDown();
            this.btnRunGA = new System.Windows.Forms.Button();
            this.numPopulation = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numChromosomeMaxLength = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numElitismPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerationStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChromosomeMaxLength)).BeginInit();
            this.SuspendLayout();
            // 
            // numElitismPercentage
            // 
            this.numElitismPercentage.Location = new System.Drawing.Point(143, 43);
            this.numElitismPercentage.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numElitismPercentage.Name = "numElitismPercentage";
            this.numElitismPercentage.Size = new System.Drawing.Size(120, 20);
            this.numElitismPercentage.TabIndex = 0;
            this.numElitismPercentage.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elitism Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crossover Probability";
            // 
            // numCrossoverProbability
            // 
            this.numCrossoverProbability.DecimalPlaces = 2;
            this.numCrossoverProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCrossoverProbability.Location = new System.Drawing.Point(143, 79);
            this.numCrossoverProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrossoverProbability.Name = "numCrossoverProbability";
            this.numCrossoverProbability.Size = new System.Drawing.Size(120, 20);
            this.numCrossoverProbability.TabIndex = 2;
            this.numCrossoverProbability.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mutation Probability";
            // 
            // numMutationProbability
            // 
            this.numMutationProbability.DecimalPlaces = 2;
            this.numMutationProbability.Location = new System.Drawing.Point(143, 114);
            this.numMutationProbability.Name = "numMutationProbability";
            this.numMutationProbability.Size = new System.Drawing.Size(120, 20);
            this.numMutationProbability.TabIndex = 4;
            this.numMutationProbability.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Generation expected";
            // 
            // numGenerationStop
            // 
            this.numGenerationStop.Location = new System.Drawing.Point(143, 153);
            this.numGenerationStop.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGenerationStop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGenerationStop.Name = "numGenerationStop";
            this.numGenerationStop.Size = new System.Drawing.Size(120, 20);
            this.numGenerationStop.TabIndex = 6;
            this.numGenerationStop.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnRunGA
            // 
            this.btnRunGA.BackColor = System.Drawing.Color.Lime;
            this.btnRunGA.Location = new System.Drawing.Point(128, 275);
            this.btnRunGA.Name = "btnRunGA";
            this.btnRunGA.Size = new System.Drawing.Size(75, 23);
            this.btnRunGA.TabIndex = 8;
            this.btnRunGA.Text = "RUN GA";
            this.btnRunGA.UseVisualStyleBackColor = false;
            this.btnRunGA.Click += new System.EventHandler(this.btnRunGA_Click);
            // 
            // numPopulation
            // 
            this.numPopulation.Location = new System.Drawing.Point(143, 188);
            this.numPopulation.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPopulation.Name = "numPopulation";
            this.numPopulation.Size = new System.Drawing.Size(120, 20);
            this.numPopulation.TabIndex = 9;
            this.numPopulation.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Population";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chromosome Max Length";
            // 
            // numChromosomeMaxLength
            // 
            this.numChromosomeMaxLength.Location = new System.Drawing.Point(143, 228);
            this.numChromosomeMaxLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numChromosomeMaxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChromosomeMaxLength.Name = "numChromosomeMaxLength";
            this.numChromosomeMaxLength.Size = new System.Drawing.Size(120, 20);
            this.numChromosomeMaxLength.TabIndex = 11;
            this.numChromosomeMaxLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GeneticAlgorithmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(330, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numChromosomeMaxLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numPopulation);
            this.Controls.Add(this.btnRunGA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numGenerationStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMutationProbability);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCrossoverProbability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numElitismPercentage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GeneticAlgorithmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Genetic Algorithm Config";
            ((System.ComponentModel.ISupportInitialize)(this.numElitismPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerationStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChromosomeMaxLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numElitismPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCrossoverProbability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMutationProbability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGenerationStop;
        private System.Windows.Forms.Button btnRunGA;
        private System.Windows.Forms.NumericUpDown numPopulation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numChromosomeMaxLength;
    }
}