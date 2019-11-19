namespace TestScoreLookupandUpdateZafar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisplayFinalAndMidtermBtn = new System.Windows.Forms.Button();
            this.FinalDisplayLabel = new System.Windows.Forms.Label();
            this.MidtermDisplayLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentNumComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplaySelectedBtn = new System.Windows.Forms.Button();
            this.FindFinalScoreRadioButton = new System.Windows.Forms.RadioButton();
            this.FindMidtermRadioButton = new System.Windows.Forms.RadioButton();
            this.AverageFinalRadioButton = new System.Windows.Forms.RadioButton();
            this.AverageMidtermRadioButton = new System.Windows.Forms.RadioButton();
            this.AverageAllTestsRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateMidtermTextbox = new System.Windows.Forms.TextBox();
            this.UpdateFinalTextbox = new System.Windows.Forms.TextBox();
            this.UpdateMidtermBtn = new System.Windows.Forms.Button();
            this.UpdateFinalBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayFinalAndMidtermBtn);
            this.groupBox1.Controls.Add(this.FinalDisplayLabel);
            this.groupBox1.Controls.Add(this.MidtermDisplayLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 124);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Selected Student\'s Scores";
            // 
            // DisplayFinalAndMidtermBtn
            // 
            this.DisplayFinalAndMidtermBtn.Location = new System.Drawing.Point(89, 95);
            this.DisplayFinalAndMidtermBtn.Name = "DisplayFinalAndMidtermBtn";
            this.DisplayFinalAndMidtermBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayFinalAndMidtermBtn.TabIndex = 4;
            this.DisplayFinalAndMidtermBtn.Text = "Display";
            this.DisplayFinalAndMidtermBtn.UseVisualStyleBackColor = true;
            this.DisplayFinalAndMidtermBtn.Click += new System.EventHandler(this.DisplayFinalAndMidtermBtn_Click);
            // 
            // FinalDisplayLabel
            // 
            this.FinalDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FinalDisplayLabel.Location = new System.Drawing.Point(151, 54);
            this.FinalDisplayLabel.Name = "FinalDisplayLabel";
            this.FinalDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.FinalDisplayLabel.TabIndex = 3;
            // 
            // MidtermDisplayLabel
            // 
            this.MidtermDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MidtermDisplayLabel.Location = new System.Drawing.Point(6, 54);
            this.MidtermDisplayLabel.Name = "MidtermDisplayLabel";
            this.MidtermDisplayLabel.Size = new System.Drawing.Size(100, 23);
            this.MidtermDisplayLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Midterm";
            // 
            // StudentNumComboBox
            // 
            this.StudentNumComboBox.FormattingEnabled = true;
            this.StudentNumComboBox.Location = new System.Drawing.Point(392, 14);
            this.StudentNumComboBox.Name = "StudentNumComboBox";
            this.StudentNumComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentNumComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Student Number:";
            // 
            // DisplaySelectedBtn
            // 
            this.DisplaySelectedBtn.Location = new System.Drawing.Point(99, 96);
            this.DisplaySelectedBtn.Name = "DisplaySelectedBtn";
            this.DisplaySelectedBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplaySelectedBtn.TabIndex = 15;
            this.DisplaySelectedBtn.Text = "Display";
            this.DisplaySelectedBtn.UseVisualStyleBackColor = true;
            this.DisplaySelectedBtn.Click += new System.EventHandler(this.DisplaySelectedBtn_Click);
            // 
            // FindFinalScoreRadioButton
            // 
            this.FindFinalScoreRadioButton.AutoSize = true;
            this.FindFinalScoreRadioButton.Location = new System.Drawing.Point(10, 65);
            this.FindFinalScoreRadioButton.Name = "FindFinalScoreRadioButton";
            this.FindFinalScoreRadioButton.Size = new System.Drawing.Size(101, 17);
            this.FindFinalScoreRadioButton.TabIndex = 14;
            this.FindFinalScoreRadioButton.TabStop = true;
            this.FindFinalScoreRadioButton.Text = "Find Final Score";
            this.FindFinalScoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // FindMidtermRadioButton
            // 
            this.FindMidtermRadioButton.AutoSize = true;
            this.FindMidtermRadioButton.Location = new System.Drawing.Point(155, 37);
            this.FindMidtermRadioButton.Name = "FindMidtermRadioButton";
            this.FindMidtermRadioButton.Size = new System.Drawing.Size(113, 17);
            this.FindMidtermRadioButton.TabIndex = 13;
            this.FindMidtermRadioButton.TabStop = true;
            this.FindMidtermRadioButton.Text = "Find midterm score";
            this.FindMidtermRadioButton.UseVisualStyleBackColor = true;
            // 
            // AverageFinalRadioButton
            // 
            this.AverageFinalRadioButton.AutoSize = true;
            this.AverageFinalRadioButton.Location = new System.Drawing.Point(155, 14);
            this.AverageFinalRadioButton.Name = "AverageFinalRadioButton";
            this.AverageFinalRadioButton.Size = new System.Drawing.Size(107, 17);
            this.AverageFinalRadioButton.TabIndex = 12;
            this.AverageFinalRadioButton.TabStop = true;
            this.AverageFinalRadioButton.Text = "Average of Finals";
            this.AverageFinalRadioButton.UseVisualStyleBackColor = true;
            // 
            // AverageMidtermRadioButton
            // 
            this.AverageMidtermRadioButton.AutoSize = true;
            this.AverageMidtermRadioButton.Location = new System.Drawing.Point(10, 37);
            this.AverageMidtermRadioButton.Name = "AverageMidtermRadioButton";
            this.AverageMidtermRadioButton.Size = new System.Drawing.Size(124, 17);
            this.AverageMidtermRadioButton.TabIndex = 11;
            this.AverageMidtermRadioButton.TabStop = true;
            this.AverageMidtermRadioButton.Text = "Average Of Midterms";
            this.AverageMidtermRadioButton.UseVisualStyleBackColor = true;
            // 
            // AverageAllTestsRadioButton
            // 
            this.AverageAllTestsRadioButton.AutoSize = true;
            this.AverageAllTestsRadioButton.Location = new System.Drawing.Point(10, 14);
            this.AverageAllTestsRadioButton.Name = "AverageAllTestsRadioButton";
            this.AverageAllTestsRadioButton.Size = new System.Drawing.Size(115, 17);
            this.AverageAllTestsRadioButton.TabIndex = 10;
            this.AverageAllTestsRadioButton.TabStop = true;
            this.AverageAllTestsRadioButton.Text = "Average of all tests";
            this.AverageAllTestsRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Midterm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Final";
            // 
            // UpdateMidtermTextbox
            // 
            this.UpdateMidtermTextbox.Location = new System.Drawing.Point(6, 56);
            this.UpdateMidtermTextbox.Name = "UpdateMidtermTextbox";
            this.UpdateMidtermTextbox.Size = new System.Drawing.Size(100, 20);
            this.UpdateMidtermTextbox.TabIndex = 2;
            // 
            // UpdateFinalTextbox
            // 
            this.UpdateFinalTextbox.Location = new System.Drawing.Point(151, 56);
            this.UpdateFinalTextbox.Name = "UpdateFinalTextbox";
            this.UpdateFinalTextbox.Size = new System.Drawing.Size(100, 20);
            this.UpdateFinalTextbox.TabIndex = 3;
            // 
            // UpdateMidtermBtn
            // 
            this.UpdateMidtermBtn.Location = new System.Drawing.Point(6, 82);
            this.UpdateMidtermBtn.Name = "UpdateMidtermBtn";
            this.UpdateMidtermBtn.Size = new System.Drawing.Size(101, 23);
            this.UpdateMidtermBtn.TabIndex = 4;
            this.UpdateMidtermBtn.Text = "Update Midterm";
            this.UpdateMidtermBtn.UseVisualStyleBackColor = true;
            this.UpdateMidtermBtn.Click += new System.EventHandler(this.UpdateMidtermBtn_Click);
            // 
            // UpdateFinalBtn
            // 
            this.UpdateFinalBtn.Location = new System.Drawing.Point(151, 82);
            this.UpdateFinalBtn.Name = "UpdateFinalBtn";
            this.UpdateFinalBtn.Size = new System.Drawing.Size(100, 23);
            this.UpdateFinalBtn.TabIndex = 5;
            this.UpdateFinalBtn.Text = "Update Final";
            this.UpdateFinalBtn.UseVisualStyleBackColor = true;
            this.UpdateFinalBtn.Click += new System.EventHandler(this.UpdateFinalBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateFinalBtn);
            this.groupBox2.Controls.Add(this.UpdateMidtermBtn);
            this.groupBox2.Controls.Add(this.UpdateFinalTextbox);
            this.groupBox2.Controls.Add(this.UpdateMidtermTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Selected Student\'s Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 387);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StudentNumComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplaySelectedBtn);
            this.Controls.Add(this.FindFinalScoreRadioButton);
            this.Controls.Add(this.FindMidtermRadioButton);
            this.Controls.Add(this.AverageFinalRadioButton);
            this.Controls.Add(this.AverageMidtermRadioButton);
            this.Controls.Add(this.AverageAllTestsRadioButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisplayFinalAndMidtermBtn;
        private System.Windows.Forms.Label FinalDisplayLabel;
        private System.Windows.Forms.Label MidtermDisplayLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StudentNumComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisplaySelectedBtn;
        private System.Windows.Forms.RadioButton FindFinalScoreRadioButton;
        private System.Windows.Forms.RadioButton FindMidtermRadioButton;
        private System.Windows.Forms.RadioButton AverageFinalRadioButton;
        private System.Windows.Forms.RadioButton AverageMidtermRadioButton;
        private System.Windows.Forms.RadioButton AverageAllTestsRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UpdateMidtermTextbox;
        private System.Windows.Forms.TextBox UpdateFinalTextbox;
        private System.Windows.Forms.Button UpdateMidtermBtn;
        private System.Windows.Forms.Button UpdateFinalBtn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

