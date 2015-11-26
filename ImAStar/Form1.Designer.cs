namespace ImAStar
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
            this.components = new System.ComponentModel.Container();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.starButton = new System.Windows.Forms.Button();
            this.colourTimer = new System.Windows.Forms.Timer(this.components);
            this.colorLabel = new System.Windows.Forms.Label();
            this.color1Input = new System.Windows.Forms.TextBox();
            this.color2Input = new System.Windows.Forms.TextBox();
            this.color3Input = new System.Windows.Forms.TextBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.multipleStars = new System.Windows.Forms.RadioButton();
            this.oneStar = new System.Windows.Forms.RadioButton();
            this.starsBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.starsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(490, 160);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(490, 186);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(477, 212);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(510, 157);
            this.xInput.Multiline = true;
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(62, 20);
            this.xInput.TabIndex = 4;
            this.xInput.Text = "0";
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(510, 183);
            this.yInput.Multiline = true;
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(62, 20);
            this.yInput.TabIndex = 5;
            this.yInput.Text = "0";
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(510, 209);
            this.sizeInput.Multiline = true;
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(62, 20);
            this.sizeInput.TabIndex = 6;
            this.sizeInput.Text = "11";
            // 
            // starButton
            // 
            this.starButton.Location = new System.Drawing.Point(489, 364);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(90, 23);
            this.starButton.TabIndex = 7;
            this.starButton.Text = "Draw Star";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // colourTimer
            // 
            this.colourTimer.Enabled = true;
            this.colourTimer.Interval = 1000;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(507, 6);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(72, 26);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "ARGB Colors \r\n(0-255)";
            // 
            // color1Input
            // 
            this.color1Input.Location = new System.Drawing.Point(510, 35);
            this.color1Input.Multiline = true;
            this.color1Input.Name = "color1Input";
            this.color1Input.Size = new System.Drawing.Size(62, 20);
            this.color1Input.TabIndex = 9;
            this.color1Input.Text = "0";
            // 
            // color2Input
            // 
            this.color2Input.Location = new System.Drawing.Point(510, 61);
            this.color2Input.Multiline = true;
            this.color2Input.Name = "color2Input";
            this.color2Input.Size = new System.Drawing.Size(62, 20);
            this.color2Input.TabIndex = 10;
            this.color2Input.Text = "0";
            // 
            // color3Input
            // 
            this.color3Input.Location = new System.Drawing.Point(510, 87);
            this.color3Input.Multiline = true;
            this.color3Input.Name = "color3Input";
            this.color3Input.Size = new System.Drawing.Size(62, 20);
            this.color3Input.TabIndex = 11;
            this.color3Input.Text = "0";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(477, 38);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 13);
            this.redLabel.TabIndex = 12;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(468, 64);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(36, 13);
            this.greenLabel.TabIndex = 13;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(476, 90);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(28, 13);
            this.blueLabel.TabIndex = 14;
            this.blueLabel.Text = "Blue";
            // 
            // multipleStars
            // 
            this.multipleStars.Location = new System.Drawing.Point(6, 36);
            this.multipleStars.Name = "multipleStars";
            this.multipleStars.Size = new System.Drawing.Size(90, 20);
            this.multipleStars.TabIndex = 15;
            this.multipleStars.Text = "Two+ Stars";
            this.multipleStars.UseVisualStyleBackColor = true;
            // 
            // oneStar
            // 
            this.oneStar.Checked = true;
            this.oneStar.Location = new System.Drawing.Point(6, 10);
            this.oneStar.Name = "oneStar";
            this.oneStar.Size = new System.Drawing.Size(90, 20);
            this.oneStar.TabIndex = 16;
            this.oneStar.TabStop = true;
            this.oneStar.Text = "One Star";
            this.oneStar.UseVisualStyleBackColor = true;
            // 
            // starsBox
            // 
            this.starsBox.Controls.Add(this.oneStar);
            this.starsBox.Controls.Add(this.multipleStars);
            this.starsBox.Location = new System.Drawing.Point(480, 264);
            this.starsBox.Name = "starsBox";
            this.starsBox.Size = new System.Drawing.Size(99, 64);
            this.starsBox.TabIndex = 17;
            this.starsBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Position/Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.starsBox);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.color3Input);
            this.Controls.Add(this.color2Input);
            this.Controls.Add(this.color1Input);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.starButton);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.starsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.Timer colourTimer;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox color1Input;
        private System.Windows.Forms.TextBox color2Input;
        private System.Windows.Forms.TextBox color3Input;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.RadioButton multipleStars;
        private System.Windows.Forms.RadioButton oneStar;
        private System.Windows.Forms.GroupBox starsBox;
        private System.Windows.Forms.Label label1;
    }
}

