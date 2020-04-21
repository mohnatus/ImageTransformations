namespace ImageTransformationsApp
{
    partial class ImageTransformationsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AngleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HorizStretchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VertStretchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FlipHorizontalCheckBox = new System.Windows.Forms.CheckBox();
            this.FlipVerticalCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GreenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BlueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ExecutionTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizStretchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertStretchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(70, 23);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(532, 20);
            this.FileTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(608, 22);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(180, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rotation Angle (Degrees):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horizontal Stretch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vertical Stretch:";
            // 
            // AngleNumericUpDown
            // 
            this.AngleNumericUpDown.Location = new System.Drawing.Point(148, 56);
            this.AngleNumericUpDown.Name = "AngleNumericUpDown";
            this.AngleNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.AngleNumericUpDown.TabIndex = 4;
            // 
            // HorizStretchNumericUpDown
            // 
            this.HorizStretchNumericUpDown.Location = new System.Drawing.Point(147, 82);
            this.HorizStretchNumericUpDown.Name = "HorizStretchNumericUpDown";
            this.HorizStretchNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.HorizStretchNumericUpDown.TabIndex = 4;
            // 
            // VertStretchNumericUpDown
            // 
            this.VertStretchNumericUpDown.Location = new System.Drawing.Point(147, 108);
            this.VertStretchNumericUpDown.Name = "VertStretchNumericUpDown";
            this.VertStretchNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.VertStretchNumericUpDown.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "(-360 - 360)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "(-100 - 100)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "(-100 - 100)";
            // 
            // FlipHorizontalCheckBox
            // 
            this.FlipHorizontalCheckBox.AutoSize = true;
            this.FlipHorizontalCheckBox.Location = new System.Drawing.Point(64, 138);
            this.FlipHorizontalCheckBox.Name = "FlipHorizontalCheckBox";
            this.FlipHorizontalCheckBox.Size = new System.Drawing.Size(99, 17);
            this.FlipHorizontalCheckBox.TabIndex = 6;
            this.FlipHorizontalCheckBox.Text = "Flip Horizontally";
            this.FlipHorizontalCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlipVerticalCheckBox
            // 
            this.FlipVerticalCheckBox.AutoSize = true;
            this.FlipVerticalCheckBox.Location = new System.Drawing.Point(169, 138);
            this.FlipVerticalCheckBox.Name = "FlipVerticalCheckBox";
            this.FlipVerticalCheckBox.Size = new System.Drawing.Size(87, 17);
            this.FlipVerticalCheckBox.TabIndex = 6;
            this.FlipVerticalCheckBox.Text = "Flip Vertically";
            this.FlipVerticalCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Alpha:";
            // 
            // AlphaNumericUpDown
            // 
            this.AlphaNumericUpDown.Location = new System.Drawing.Point(451, 56);
            this.AlphaNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.AlphaNumericUpDown.Name = "AlphaNumericUpDown";
            this.AlphaNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.AlphaNumericUpDown.TabIndex = 4;
            this.AlphaNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "(0 - 200)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Red:";
            // 
            // RedNumericUpDown
            // 
            this.RedNumericUpDown.Location = new System.Drawing.Point(451, 82);
            this.RedNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.RedNumericUpDown.Name = "RedNumericUpDown";
            this.RedNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.RedNumericUpDown.TabIndex = 4;
            this.RedNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "(0 - 200)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Green:";
            // 
            // GreenNumericUpDown
            // 
            this.GreenNumericUpDown.Location = new System.Drawing.Point(451, 108);
            this.GreenNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.GreenNumericUpDown.Name = "GreenNumericUpDown";
            this.GreenNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.GreenNumericUpDown.TabIndex = 4;
            this.GreenNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(520, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "(0 - 200)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Blue:";
            // 
            // BlueNumericUpDown
            // 
            this.BlueNumericUpDown.Location = new System.Drawing.Point(451, 135);
            this.BlueNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.BlueNumericUpDown.Name = "BlueNumericUpDown";
            this.BlueNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.BlueNumericUpDown.TabIndex = 4;
            this.BlueNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "(0 - 200)";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(608, 128);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(180, 23);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(15, 172);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(773, 346);
            this.ImagePictureBox.TabIndex = 8;
            this.ImagePictureBox.TabStop = false;
            // 
            // ExecutionTimeLabel
            // 
            this.ExecutionTimeLabel.AutoSize = true;
            this.ExecutionTimeLabel.Location = new System.Drawing.Point(15, 525);
            this.ExecutionTimeLabel.Name = "ExecutionTimeLabel";
            this.ExecutionTimeLabel.Size = new System.Drawing.Size(115, 13);
            this.ExecutionTimeLabel.TabIndex = 9;
            this.ExecutionTimeLabel.Text = "Total execution time is ";
            // 
            // ImageTransformationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.ExecutionTimeLabel);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FlipVerticalCheckBox);
            this.Controls.Add(this.FlipHorizontalCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BlueNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GreenNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RedNumericUpDown);
            this.Controls.Add(this.VertStretchNumericUpDown);
            this.Controls.Add(this.AlphaNumericUpDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HorizStretchNumericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AngleNumericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ImageTransformationsForm";
            this.Text = "Image Transformations";
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizStretchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VertStretchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AngleNumericUpDown;
        private System.Windows.Forms.NumericUpDown HorizStretchNumericUpDown;
        private System.Windows.Forms.NumericUpDown VertStretchNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox FlipHorizontalCheckBox;
        private System.Windows.Forms.CheckBox FlipVerticalCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown AlphaNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown RedNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown GreenNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown BlueNumericUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label ExecutionTimeLabel;
    }
}

