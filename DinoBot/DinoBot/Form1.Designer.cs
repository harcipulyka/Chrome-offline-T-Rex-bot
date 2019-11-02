namespace DinoBot
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
            this.ss = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.DelayScreen = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ss)).BeginInit();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(12, 12);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(550, 125);
            this.ss.TabIndex = 0;
            this.ss.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.ForeColor = System.Drawing.Color.IndianRed;
            this.start.Location = new System.Drawing.Point(571, 12);
            this.start.Margin = new System.Windows.Forms.Padding(0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(86, 42);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // DelayScreen
            // 
            this.DelayScreen.AutoSize = true;
            this.DelayScreen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DelayScreen.Location = new System.Drawing.Point(572, 98);
            this.DelayScreen.Name = "DelayScreen";
            this.DelayScreen.Size = new System.Drawing.Size(52, 18);
            this.DelayScreen.TabIndex = 6;
            this.DelayScreen.Text = "Delay";
            this.DelayScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Black;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop.ForeColor = System.Drawing.Color.IndianRed;
            this.stop.Location = new System.Drawing.Point(571, 54);
            this.stop.Margin = new System.Windows.Forms.Padding(0);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(86, 42);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(669, 150);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.DelayScreen);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ss);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DinoBot";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ss;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label DelayScreen;
        private System.Windows.Forms.Button stop;
    }
}

