namespace SpeedReader
{
    partial class ReaderForm
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
            System.Windows.Forms.Panel panel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.wpmLabel = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.textBox = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            panel = new System.Windows.Forms.Panel();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(this.wpmLabel);
            panel.Controls.Add(this.speedBar);
            panel.Controls.Add(this.textBox);
            panel.Controls.Add(this.readButton);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 163);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(2156, 1248);
            panel.TabIndex = 3;
            // 
            // wpmLabel
            // 
            this.wpmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wpmLabel.Location = new System.Drawing.Point(1921, 1127);
            this.wpmLabel.Name = "wpmLabel";
            this.wpmLabel.Size = new System.Drawing.Size(223, 53);
            this.wpmLabel.TabIndex = 3;
            this.wpmLabel.Text = "WPM";
            this.wpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speedBar
            // 
            this.speedBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedBar.LargeChange = 100;
            this.speedBar.Location = new System.Drawing.Point(12, 1146);
            this.speedBar.Maximum = 900;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(1903, 90);
            this.speedBar.SmallChange = 10;
            this.speedBar.TabIndex = 1;
            this.speedBar.TabStop = false;
            this.speedBar.TickFrequency = 50;
            this.speedBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.speedBar.Value = 200;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Verdana", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 6);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(2132, 1118);
            this.textBox.TabIndex = 0;
            // 
            // readButton
            // 
            this.readButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.readButton.Location = new System.Drawing.Point(1979, 1183);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(165, 53);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.wordTextBox.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.Location = new System.Drawing.Point(0, 0);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.ReadOnly = true;
            this.wordTextBox.Size = new System.Drawing.Size(2156, 163);
            this.wordTextBox.TabIndex = 2;
            this.wordTextBox.TabStop = false;
            this.wordTextBox.Text = "word";
            this.wordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2156, 1411);
            this.Controls.Add(panel);
            this.Controls.Add(this.wordTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReaderForm";
            this.Text = "Speed Reader";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label wpmLabel;
    }
}

