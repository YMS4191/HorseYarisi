namespace AtYarisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.btnYarisiStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1635, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1635, 10);
            this.label2.TabIndex = 1;
            // 
            // pc3
            // 
            this.pc3.Image = global::AtYarisi.Properties.Resources.horse5;
            this.pc3.Location = new System.Drawing.Point(0, 624);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(281, 156);
            this.pc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc3.TabIndex = 4;
            this.pc3.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.Image = global::AtYarisi.Properties.Resources.horse3;
            this.pc2.Location = new System.Drawing.Point(0, 418);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(281, 156);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc2.TabIndex = 3;
            this.pc2.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.Image = global::AtYarisi.Properties.Resources.horse1;
            this.pc1.Location = new System.Drawing.Point(0, 212);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(281, 156);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 2;
            this.pc1.TabStop = false;
            // 
            // btnYarisiStart
            // 
            this.btnYarisiStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYarisiStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYarisiStart.ForeColor = System.Drawing.Color.White;
            this.btnYarisiStart.Location = new System.Drawing.Point(1417, 12);
            this.btnYarisiStart.Name = "btnYarisiStart";
            this.btnYarisiStart.Size = new System.Drawing.Size(377, 56);
            this.btnYarisiStart.TabIndex = 5;
            this.btnYarisiStart.Text = "Yarışı Başlat";
            this.btnYarisiStart.UseVisualStyleBackColor = true;
            this.btnYarisiStart.Click += new System.EventHandler(this.btnYarisiStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1806, 794);
            this.Controls.Add(this.btnYarisiStart);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.Button btnYarisiStart;
        private System.Windows.Forms.Timer timer1;
    }
}

