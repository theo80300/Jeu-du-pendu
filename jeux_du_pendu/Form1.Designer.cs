
using System;

namespace jeux_du_pendu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.Location = new System.Drawing.Point(12, 131);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(435, 133);
            this.btnOnePlayer.TabIndex = 0;
            this.btnOnePlayer.Text = "Solo";
            this.btnOnePlayer.UseVisualStyleBackColor = true;
            this.btnOnePlayer.Click += new System.EventHandler(this.Solo_Click);
            // 
            // label1

            // 
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jeu du pendu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnePlayer);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Solo_Click(object sender, EventArgs e)
        {
            Form2 game = new Form2();
            this.Visible = false;
            game.ShowDialog();
            this.Visible = true;
        }




        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Label label1;
    }
}

