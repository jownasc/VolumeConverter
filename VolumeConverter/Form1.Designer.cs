namespace VolumeConverter
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
            this.convertClLitreLabel = new System.Windows.Forms.Label();
            this.litreTextbox = new System.Windows.Forms.TextBox();
            this.clTextbox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertClLitreLabel
            // 
            this.convertClLitreLabel.AutoSize = true;
            this.convertClLitreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertClLitreLabel.Location = new System.Drawing.Point(12, 25);
            this.convertClLitreLabel.Name = "convertClLitreLabel";
            this.convertClLitreLabel.Size = new System.Drawing.Size(320, 31);
            this.convertClLitreLabel.TabIndex = 0;
            this.convertClLitreLabel.Text = "Converter CL para Litro";
            this.convertClLitreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // litreTextbox
            // 
            this.litreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreTextbox.Location = new System.Drawing.Point(43, 126);
            this.litreTextbox.Multiline = true;
            this.litreTextbox.Name = "litreTextbox";
            this.litreTextbox.Size = new System.Drawing.Size(172, 36);
            this.litreTextbox.TabIndex = 1;
            this.litreTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clTextbox
            // 
            this.clTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTextbox.Location = new System.Drawing.Point(43, 72);
            this.clTextbox.Multiline = true;
            this.clTextbox.Name = "clTextbox";
            this.clTextbox.Size = new System.Drawing.Size(172, 36);
            this.clTextbox.TabIndex = 2;
            this.clTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.ForestGreen;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(43, 187);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(112, 49);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.ForestGreen;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(183, 187);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(114, 49);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLabel.Location = new System.Drawing.Point(239, 83);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(41, 25);
            this.clLabel.TabIndex = 5;
            this.clLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreLabel.Location = new System.Drawing.Point(221, 137);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(59, 25);
            this.litreLabel.TabIndex = 6;
            this.litreLabel.Text = "Litro";
            this.litreLabel.Click += new System.EventHandler(this.literLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(337, 262);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clTextbox);
            this.Controls.Add(this.litreTextbox);
            this.Controls.Add(this.convertClLitreLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Convert CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertClLitreLabel;
        private System.Windows.Forms.TextBox litreTextbox;
        private System.Windows.Forms.TextBox clTextbox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label litreLabel;
    }
}

