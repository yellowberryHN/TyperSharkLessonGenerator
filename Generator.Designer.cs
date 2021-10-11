
namespace TyperSharkLessonGenerator
{
    partial class Generator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textInput = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.lessonSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minAccuracyChk = new System.Windows.Forms.CheckBox();
            this.minAccuracyBox = new System.Windows.Forms.NumericUpDown();
            this.minWpmChk = new System.Windows.Forms.CheckBox();
            this.minWpmBox = new System.Windows.Forms.NumericUpDown();
            this.maxErrorsChk = new System.Windows.Forms.CheckBox();
            this.maxErrorsBox = new System.Windows.Forms.NumericUpDown();
            this.lessonTimeChk = new System.Windows.Forms.CheckBox();
            this.lessonTimeBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minAccuracyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWpmBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxErrorsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonTimeBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(6, 22);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInput.Size = new System.Drawing.Size(388, 389);
            this.textInput.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(100, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Enabled = false;
            this.loadBtn.Location = new System.Drawing.Point(6, 22);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(88, 23);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // lessonSelect
            // 
            this.lessonSelect.FormattingEnabled = true;
            this.lessonSelect.Items.AddRange(new object[] {
            "Typing Test",
            "Lesson 1",
            "Lesson 2",
            "Lesson 3",
            "Lesson 4",
            "Lesson 5",
            "Lesson 6",
            "Lesson 7",
            "Lesson 8",
            "Lesson 9",
            "Lesson 10",
            "Lesson 11",
            "Lesson 12",
            "Lesson 13",
            "Lesson 14",
            "Lesson 15",
            "Lesson 16",
            "Lesson 17",
            "Lesson 18"});
            this.lessonSelect.Location = new System.Drawing.Point(6, 82);
            this.lessonSelect.Name = "lessonSelect";
            this.lessonSelect.Size = new System.Drawing.Size(182, 23);
            this.lessonSelect.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 417);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minAccuracyChk);
            this.groupBox2.Controls.Add(this.minAccuracyBox);
            this.groupBox2.Controls.Add(this.minWpmChk);
            this.groupBox2.Controls.Add(this.minWpmBox);
            this.groupBox2.Controls.Add(this.maxErrorsChk);
            this.groupBox2.Controls.Add(this.maxErrorsBox);
            this.groupBox2.Controls.Add(this.lessonTimeChk);
            this.groupBox2.Controls.Add(this.lessonTimeBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.loadBtn);
            this.groupBox2.Controls.Add(this.saveBtn);
            this.groupBox2.Controls.Add(this.lessonSelect);
            this.groupBox2.Location = new System.Drawing.Point(418, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // minAccuracyChk
            // 
            this.minAccuracyChk.AutoSize = true;
            this.minAccuracyChk.Location = new System.Drawing.Point(6, 187);
            this.minAccuracyChk.Name = "minAccuracyChk";
            this.minAccuracyChk.Size = new System.Drawing.Size(120, 19);
            this.minAccuracyChk.TabIndex = 12;
            this.minAccuracyChk.Text = "Min Accuracy (%)";
            this.minAccuracyChk.UseVisualStyleBackColor = true;
            this.minAccuracyChk.CheckedChanged += new System.EventHandler(this.minAccuracyChk_CheckedChanged);
            // 
            // minAccuracyBox
            // 
            this.minAccuracyBox.Enabled = false;
            this.minAccuracyBox.Location = new System.Drawing.Point(143, 186);
            this.minAccuracyBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minAccuracyBox.Name = "minAccuracyBox";
            this.minAccuracyBox.Size = new System.Drawing.Size(45, 23);
            this.minAccuracyBox.TabIndex = 11;
            this.minAccuracyBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minWpmChk
            // 
            this.minWpmChk.AutoSize = true;
            this.minWpmChk.Location = new System.Drawing.Point(6, 162);
            this.minWpmChk.Name = "minWpmChk";
            this.minWpmChk.Size = new System.Drawing.Size(79, 19);
            this.minWpmChk.TabIndex = 10;
            this.minWpmChk.Text = "Min WPM";
            this.minWpmChk.UseVisualStyleBackColor = true;
            this.minWpmChk.CheckedChanged += new System.EventHandler(this.minWpmChk_CheckedChanged);
            // 
            // minWpmBox
            // 
            this.minWpmBox.Enabled = false;
            this.minWpmBox.Location = new System.Drawing.Point(143, 161);
            this.minWpmBox.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.minWpmBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minWpmBox.Name = "minWpmBox";
            this.minWpmBox.Size = new System.Drawing.Size(45, 23);
            this.minWpmBox.TabIndex = 9;
            this.minWpmBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxErrorsChk
            // 
            this.maxErrorsChk.AutoSize = true;
            this.maxErrorsChk.Location = new System.Drawing.Point(6, 137);
            this.maxErrorsChk.Name = "maxErrorsChk";
            this.maxErrorsChk.Size = new System.Drawing.Size(82, 19);
            this.maxErrorsChk.TabIndex = 8;
            this.maxErrorsChk.Text = "Max Errors";
            this.maxErrorsChk.UseVisualStyleBackColor = true;
            this.maxErrorsChk.CheckedChanged += new System.EventHandler(this.maxErrorsChk_CheckedChanged);
            // 
            // maxErrorsBox
            // 
            this.maxErrorsBox.Enabled = false;
            this.maxErrorsBox.Location = new System.Drawing.Point(143, 136);
            this.maxErrorsBox.Name = "maxErrorsBox";
            this.maxErrorsBox.Size = new System.Drawing.Size(45, 23);
            this.maxErrorsBox.TabIndex = 7;
            this.maxErrorsBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lessonTimeChk
            // 
            this.lessonTimeChk.AutoSize = true;
            this.lessonTimeChk.Location = new System.Drawing.Point(6, 112);
            this.lessonTimeChk.Name = "lessonTimeChk";
            this.lessonTimeChk.Size = new System.Drawing.Size(91, 19);
            this.lessonTimeChk.TabIndex = 6;
            this.lessonTimeChk.Text = "Lesson Time";
            this.lessonTimeChk.UseVisualStyleBackColor = true;
            this.lessonTimeChk.CheckedChanged += new System.EventHandler(this.lessonTimeChk_CheckedChanged);
            // 
            // lessonTimeBox
            // 
            this.lessonTimeBox.Enabled = false;
            this.lessonTimeBox.Location = new System.Drawing.Point(143, 111);
            this.lessonTimeBox.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.lessonTimeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lessonTimeBox.Name = "lessonTimeBox";
            this.lessonTimeBox.Size = new System.Drawing.Size(45, 23);
            this.lessonTimeBox.TabIndex = 5;
            this.lessonTimeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lesson:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descInput);
            this.groupBox3.Location = new System.Drawing.Point(418, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 194);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(6, 22);
            this.descInput.Multiline = true;
            this.descInput.Name = "descInput";
            this.descInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descInput.Size = new System.Drawing.Size(182, 166);
            this.descInput.TabIndex = 0;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Generator";
            this.Text = "Typer Shark Lesson Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minAccuracyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWpmBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxErrorsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonTimeBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ComboBox lessonSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox lessonTimeChk;
        private System.Windows.Forms.NumericUpDown lessonTimeBox;
        private System.Windows.Forms.CheckBox maxErrorsChk;
        private System.Windows.Forms.NumericUpDown maxErrorsBox;
        private System.Windows.Forms.CheckBox minWpmChk;
        private System.Windows.Forms.NumericUpDown minWpmBox;
        private System.Windows.Forms.CheckBox minAccuracyChk;
        private System.Windows.Forms.NumericUpDown minAccuracyBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox descInput;
    }
}

