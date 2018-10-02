using System;

namespace taiga
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
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.pictureBox2 = new System.Windows.Forms.PictureBox();
        	this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// textBox1
        	// 
        	this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
        	this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.textBox1.ForeColor = System.Drawing.Color.Crimson;
        	this.textBox1.Location = new System.Drawing.Point(10, 405);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(421, 33);
        	this.textBox1.TabIndex = 0;
        	this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
        	// 
        	// textBox2
        	// 
        	this.textBox2.BackColor = System.Drawing.Color.DarkSlateGray;
        	this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
        	this.textBox2.Font = new System.Drawing.Font("Consolas", 12F);
        	this.textBox2.ForeColor = System.Drawing.Color.Yellow;
        	this.textBox2.Location = new System.Drawing.Point(10, 7);
        	this.textBox2.Multiline = true;
        	this.textBox2.Name = "textBox2";
        	this.textBox2.ReadOnly = true;
        	this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.textBox2.Size = new System.Drawing.Size(421, 392);
        	this.textBox2.TabIndex = 4;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(437, 0);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(320, 600);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox1.TabIndex = 5;
        	this.pictureBox1.TabStop = false;
        	// 
        	// pictureBox2
        	// 
        	this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
        	this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
        	this.pictureBox2.Location = new System.Drawing.Point(437, 405);
        	this.pictureBox2.Name = "pictureBox2";
        	this.pictureBox2.Size = new System.Drawing.Size(34, 33);
        	this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox2.TabIndex = 6;
        	this.pictureBox2.TabStop = false;
        	this.toolTip1.SetToolTip(this.pictureBox2, "Dúvidas? Digite o comando \'-h\' ou \'-i\'.");
        	// 
        	// toolTip1
        	// 
        	this.toolTip1.AutomaticDelay = 0;
        	this.toolTip1.IsBalloon = true;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.Black;
        	this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.ClientSize = new System.Drawing.Size(756, 450);
        	this.Controls.Add(this.pictureBox2);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.pictureBox1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "Form1";
        	this.Opacity = 0.95D;
        	this.Padding = new System.Windows.Forms.Padding(20);
        	this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "taiga.exe";
        	this.TransparencyKey = System.Drawing.Color.Red;
        	this.Load += new System.EventHandler(this.Form1_Load);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

