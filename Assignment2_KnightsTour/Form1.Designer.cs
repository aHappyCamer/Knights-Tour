namespace Assignment2_KnightsTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numOfRunsLbl = new System.Windows.Forms.Label();
            this.columnLbl = new System.Windows.Forms.Label();
            this.rowLbl = new System.Windows.Forms.Label();
            this.runsTb = new System.Windows.Forms.TextBox();
            this.strategyLbl = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.strategyLb = new System.Windows.Forms.ListBox();
            this.rowCb = new System.Windows.Forms.ComboBox();
            this.columnCb = new System.Windows.Forms.ComboBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.stdDevLbl = new System.Windows.Forms.Label();
            this.avgLbl = new System.Windows.Forms.Label();
            this.stdDevOut = new System.Windows.Forms.TextBox();
            this.avgOut = new System.Windows.Forms.TextBox();
            this.txtPrintOutput = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phuong\'s Knight\'s Tour";
            // 
            // numOfRunsLbl
            // 
            this.numOfRunsLbl.AutoSize = true;
            this.numOfRunsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRunsLbl.Location = new System.Drawing.Point(728, 190);
            this.numOfRunsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfRunsLbl.Name = "numOfRunsLbl";
            this.numOfRunsLbl.Size = new System.Drawing.Size(129, 20);
            this.numOfRunsLbl.TabIndex = 12;
            this.numOfRunsLbl.Text = "Number of Runs:";
            // 
            // columnLbl
            // 
            this.columnLbl.AutoSize = true;
            this.columnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnLbl.Location = new System.Drawing.Point(728, 141);
            this.columnLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.columnLbl.Name = "columnLbl";
            this.columnLbl.Size = new System.Drawing.Size(67, 20);
            this.columnLbl.TabIndex = 11;
            this.columnLbl.Text = "Column:";
            // 
            // rowLbl
            // 
            this.rowLbl.AutoSize = true;
            this.rowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLbl.Location = new System.Drawing.Point(728, 93);
            this.rowLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rowLbl.Name = "rowLbl";
            this.rowLbl.Size = new System.Drawing.Size(45, 20);
            this.rowLbl.TabIndex = 10;
            this.rowLbl.Text = "Row:";
            // 
            // runsTb
            // 
            this.runsTb.Location = new System.Drawing.Point(874, 187);
            this.runsTb.Margin = new System.Windows.Forms.Padding(4);
            this.runsTb.Name = "runsTb";
            this.runsTb.Size = new System.Drawing.Size(51, 23);
            this.runsTb.TabIndex = 9;
            // 
            // strategyLbl
            // 
            this.strategyLbl.AutoSize = true;
            this.strategyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategyLbl.Location = new System.Drawing.Point(728, 233);
            this.strategyLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.strategyLbl.Name = "strategyLbl";
            this.strategyLbl.Size = new System.Drawing.Size(122, 20);
            this.strategyLbl.TabIndex = 14;
            this.strategyLbl.Text = "Select Strategy:";
            // 
            // playBtn
            // 
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(732, 335);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(195, 28);
            this.playBtn.TabIndex = 17;
            this.playBtn.Text = "Play!";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // strategyLb
            // 
            this.strategyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategyLb.FormattingEnabled = true;
            this.strategyLb.ItemHeight = 18;
            this.strategyLb.Items.AddRange(new object[] {
            "Non-Intelligent",
            "Accessibility Heuristic"});
            this.strategyLb.Location = new System.Drawing.Point(732, 253);
            this.strategyLb.Margin = new System.Windows.Forms.Padding(4);
            this.strategyLb.Name = "strategyLb";
            this.strategyLb.Size = new System.Drawing.Size(193, 40);
            this.strategyLb.TabIndex = 18;
            // 
            // rowCb
            // 
            this.rowCb.FormattingEnabled = true;
            this.rowCb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.rowCb.Location = new System.Drawing.Point(874, 93);
            this.rowCb.Margin = new System.Windows.Forms.Padding(4);
            this.rowCb.Name = "rowCb";
            this.rowCb.Size = new System.Drawing.Size(51, 24);
            this.rowCb.TabIndex = 19;
            // 
            // columnCb
            // 
            this.columnCb.FormattingEnabled = true;
            this.columnCb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.columnCb.Location = new System.Drawing.Point(874, 137);
            this.columnCb.Margin = new System.Windows.Forms.Padding(4);
            this.columnCb.Name = "columnCb";
            this.columnCb.Size = new System.Drawing.Size(51, 24);
            this.columnCb.TabIndex = 20;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(76, 93);
            this.txtResults.Margin = new System.Windows.Forms.Padding(4);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(528, 297);
            this.txtResults.TabIndex = 21;
            this.txtResults.Text = resources.GetString("txtResults.Text");
            // 
            // stdDevLbl
            // 
            this.stdDevLbl.AutoSize = true;
            this.stdDevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdDevLbl.Location = new System.Drawing.Point(665, 491);
            this.stdDevLbl.Name = "stdDevLbl";
            this.stdDevLbl.Size = new System.Drawing.Size(149, 20);
            this.stdDevLbl.TabIndex = 22;
            this.stdDevLbl.Text = "Standard Deviation:";
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLbl.Location = new System.Drawing.Point(665, 444);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(72, 20);
            this.avgLbl.TabIndex = 23;
            this.avgLbl.Text = "Average:";
            // 
            // stdDevOut
            // 
            this.stdDevOut.Location = new System.Drawing.Point(837, 488);
            this.stdDevOut.Name = "stdDevOut";
            this.stdDevOut.ReadOnly = true;
            this.stdDevOut.Size = new System.Drawing.Size(100, 23);
            this.stdDevOut.TabIndex = 24;
            // 
            // avgOut
            // 
            this.avgOut.Location = new System.Drawing.Point(837, 438);
            this.avgOut.Name = "avgOut";
            this.avgOut.ReadOnly = true;
            this.avgOut.Size = new System.Drawing.Size(100, 23);
            this.avgOut.TabIndex = 25;
            // 
            // txtPrintOutput
            // 
            this.txtPrintOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrintOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrintOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintOutput.Location = new System.Drawing.Point(73, 438);
            this.txtPrintOutput.Multiline = true;
            this.txtPrintOutput.Name = "txtPrintOutput";
            this.txtPrintOutput.ReadOnly = true;
            this.txtPrintOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrintOutput.Size = new System.Drawing.Size(531, 112);
            this.txtPrintOutput.TabIndex = 26;
            this.txtPrintOutput.Text = "Outputs can be found in the debug folder with the\r\nfilename as:\r\nPhuongCamNonInte" +
    "lligentMethod.txt\r\nPhuongCamHueristicMethod.txt\r\n\r\n";
            this.txtPrintOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(73, 72);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(90, 17);
            this.resultLbl.TabIndex = 27;
            this.resultLbl.Text = "Grid Results:";
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(73, 419);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(55, 17);
            this.outputLbl.TabIndex = 28;
            this.outputLbl.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 592);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.txtPrintOutput);
            this.Controls.Add(this.avgOut);
            this.Controls.Add(this.stdDevOut);
            this.Controls.Add(this.avgLbl);
            this.Controls.Add(this.stdDevLbl);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.columnCb);
            this.Controls.Add(this.rowCb);
            this.Controls.Add(this.strategyLb);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.strategyLbl);
            this.Controls.Add(this.numOfRunsLbl);
            this.Controls.Add(this.columnLbl);
            this.Controls.Add(this.rowLbl);
            this.Controls.Add(this.runsTb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numOfRunsLbl;
        private System.Windows.Forms.Label columnLbl;
        private System.Windows.Forms.Label rowLbl;
        private System.Windows.Forms.TextBox runsTb;
        private System.Windows.Forms.Label strategyLbl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ListBox strategyLb;
        private System.Windows.Forms.ComboBox rowCb;
        private System.Windows.Forms.ComboBox columnCb;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label stdDevLbl;
        private System.Windows.Forms.Label avgLbl;
        private System.Windows.Forms.TextBox stdDevOut;
        private System.Windows.Forms.TextBox avgOut;
        private System.Windows.Forms.TextBox txtPrintOutput;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label outputLbl;
    }
}

