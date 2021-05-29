
namespace WindowsFormsApp1
{
    partial class s27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s27));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSalah = new System.Windows.Forms.Button();
            this.btnBenar = new System.Windows.Forms.Button();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1225, 75);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 27);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "Stop Timer";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1130, 75);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 27);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Start Timer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSalah
            // 
            this.btnSalah.Location = new System.Drawing.Point(704, 629);
            this.btnSalah.Name = "btnSalah";
            this.btnSalah.Size = new System.Drawing.Size(102, 45);
            this.btnSalah.TabIndex = 25;
            this.btnSalah.Text = "Salah";
            this.btnSalah.UseVisualStyleBackColor = true;
            this.btnSalah.Click += new System.EventHandler(this.btnSalah_Click);
            // 
            // btnBenar
            // 
            this.btnBenar.Location = new System.Drawing.Point(264, 629);
            this.btnBenar.Name = "btnBenar";
            this.btnBenar.Size = new System.Drawing.Size(102, 45);
            this.btnBenar.TabIndex = 24;
            this.btnBenar.Text = "Benar";
            this.btnBenar.UseVisualStyleBackColor = true;
            this.btnBenar.Click += new System.EventHandler(this.btnBenar_Click);
            // 
            // tbTimer
            // 
            this.tbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimer.Location = new System.Drawing.Point(1130, 24);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 38);
            this.tbTimer.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1127, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nomor Tim";
            // 
            // TeamNumber
            // 
            this.TeamNumber.Location = new System.Drawing.Point(1130, 142);
            this.TeamNumber.Name = "TeamNumber";
            this.TeamNumber.ReadOnly = true;
            this.TeamNumber.Size = new System.Drawing.Size(101, 20);
            this.TeamNumber.TabIndex = 29;
            // 
            // s27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSalah);
            this.Controls.Add(this.btnBenar);
            this.Controls.Add(this.tbTimer);
            this.Name = "s27";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s27";
            this.Load += new System.EventHandler(this.s27_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSalah;
        private System.Windows.Forms.Button btnBenar;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeamNumber;
    }
}