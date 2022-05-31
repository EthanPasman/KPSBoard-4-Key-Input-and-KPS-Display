namespace Kpsboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.key1But = new System.Windows.Forms.Button();
            this.key2But = new System.Windows.Forms.Button();
            this.key3But = new System.Windows.Forms.Button();
            this.key4But = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kpsLbl = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // key1But
            // 
            this.key1But.BackColor = System.Drawing.Color.White;
            this.key1But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key1But.Font = new System.Drawing.Font("Helvetica", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.key1But.Location = new System.Drawing.Point(16, 14);
            this.key1But.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.key1But.Name = "key1But";
            this.key1But.Size = new System.Drawing.Size(100, 87);
            this.key1But.TabIndex = 0;
            this.key1But.Text = "K1";
            this.key1But.UseVisualStyleBackColor = false;
            this.key1But.Click += new System.EventHandler(this.key1But_Click);
            // 
            // key2But
            // 
            this.key2But.BackColor = System.Drawing.Color.White;
            this.key2But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key2But.Font = new System.Drawing.Font("Helvetica", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.key2But.Location = new System.Drawing.Point(124, 14);
            this.key2But.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.key2But.Name = "key2But";
            this.key2But.Size = new System.Drawing.Size(100, 87);
            this.key2But.TabIndex = 1;
            this.key2But.Text = "K2";
            this.key2But.UseVisualStyleBackColor = false;
            this.key2But.Click += new System.EventHandler(this.key2But_Click);
            // 
            // key3But
            // 
            this.key3But.BackColor = System.Drawing.Color.White;
            this.key3But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key3But.Font = new System.Drawing.Font("Helvetica", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.key3But.Location = new System.Drawing.Point(232, 14);
            this.key3But.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.key3But.Name = "key3But";
            this.key3But.Size = new System.Drawing.Size(100, 87);
            this.key3But.TabIndex = 2;
            this.key3But.Text = "K3";
            this.key3But.UseVisualStyleBackColor = false;
            this.key3But.Click += new System.EventHandler(this.key3But_Click);
            // 
            // key4But
            // 
            this.key4But.BackColor = System.Drawing.Color.White;
            this.key4But.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.key4But.Font = new System.Drawing.Font("Helvetica", 14.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.key4But.Location = new System.Drawing.Point(340, 14);
            this.key4But.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.key4But.Name = "key4But";
            this.key4But.Size = new System.Drawing.Size(100, 87);
            this.key4But.TabIndex = 3;
            this.key4But.Text = "K4";
            this.key4But.UseVisualStyleBackColor = false;
            this.key4But.Click += new System.EventHandler(this.key4But_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.totLbl);
            this.panel1.Controls.Add(this.maxLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kpsLbl);
            this.panel1.Location = new System.Drawing.Point(448, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 87);
            this.panel1.TabIndex = 4;
            // 
            // totLbl
            // 
            this.totLbl.AutoSize = true;
            this.totLbl.Location = new System.Drawing.Point(47, 65);
            this.totLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totLbl.Name = "totLbl";
            this.totLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totLbl.Size = new System.Drawing.Size(14, 15);
            this.totLbl.TabIndex = 5;
            this.totLbl.Text = "0";
            this.totLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(47, 50);
            this.maxLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(14, 15);
            this.maxLbl.TabIndex = 4;
            this.maxLbl.Text = "0";
            this.maxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "KPS";
            // 
            // kpsLbl
            // 
            this.kpsLbl.AutoSize = true;
            this.kpsLbl.ForeColor = System.Drawing.Color.Black;
            this.kpsLbl.Location = new System.Drawing.Point(47, 35);
            this.kpsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kpsLbl.Name = "kpsLbl";
            this.kpsLbl.Size = new System.Drawing.Size(14, 15);
            this.kpsLbl.TabIndex = 0;
            this.kpsLbl.Text = "0";
            this.kpsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(564, 118);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.key4But);
            this.Controls.Add(this.key3But);
            this.Controls.Add(this.key2But);
            this.Controls.Add(this.key1But);
            this.Font = new System.Drawing.Font("Helvetica", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KpsBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button key1But;
        private System.Windows.Forms.Button key2But;
        private System.Windows.Forms.Button key3But;
        private System.Windows.Forms.Button key4But;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kpsLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totLbl;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label12;
    }
}

