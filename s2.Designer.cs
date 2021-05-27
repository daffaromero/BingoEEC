
namespace WindowsFormsApp1
{
    partial class s2
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSalah = new System.Windows.Forms.Button();
            this.btnBenar = new System.Windows.Forms.Button();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(417, 128);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 27);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop Timer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(322, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 27);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start Timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSalah
            // 
            this.btnSalah.Location = new System.Drawing.Point(417, 282);
            this.btnSalah.Name = "btnSalah";
            this.btnSalah.Size = new System.Drawing.Size(102, 45);
            this.btnSalah.TabIndex = 7;
            this.btnSalah.Text = "Salah";
            this.btnSalah.UseVisualStyleBackColor = true;
            this.btnSalah.Click += new System.EventHandler(this.btnSalah_Click);
            // 
            // btnBenar
            // 
            this.btnBenar.Location = new System.Drawing.Point(189, 282);
            this.btnBenar.Name = "btnBenar";
            this.btnBenar.Size = new System.Drawing.Size(102, 45);
            this.btnBenar.TabIndex = 6;
            this.btnBenar.Text = "Benar";
            this.btnBenar.UseVisualStyleBackColor = true;
            this.btnBenar.Click += new System.EventHandler(this.btnBenar_Click);
            // 
            // tbTimer
            // 
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimer.Location = new System.Drawing.Point(322, 77);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 38);
            this.tbTimer.TabIndex = 5;
            // 
            // s2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSalah);
            this.Controls.Add(this.btnBenar);
            this.Controls.Add(this.tbTimer);
            this.Name = "s2";
            this.Text = "s2";
            this.Load += new System.EventHandler(this.s2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSalah;
        private System.Windows.Forms.Button btnBenar;
        private System.Windows.Forms.TextBox tbTimer;
    }
}