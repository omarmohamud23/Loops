namespace Loops
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDowhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.trknum = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trknum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(32, 52);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(97, 23);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDowhile
            // 
            this.btnDowhile.Location = new System.Drawing.Point(173, 52);
            this.btnDowhile.Name = "btnDowhile";
            this.btnDowhile.Size = new System.Drawing.Size(95, 23);
            this.btnDowhile.TabIndex = 1;
            this.btnDowhile.Text = "Do while loop";
            this.btnDowhile.UseVisualStyleBackColor = true;
            this.btnDowhile.Click += new System.EventHandler(this.btnDowhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(311, 52);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 2;
            this.btnFor.Text = "For loop";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // trknum
            // 
            this.trknum.Location = new System.Drawing.Point(266, 156);
            this.trknum.Name = "trknum";
            this.trknum.Size = new System.Drawing.Size(104, 45);
            this.trknum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.trknum);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDowhile);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trknum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDowhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.TrackBar trknum;
    }
}

