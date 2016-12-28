namespace VLC
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuImageButton9 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton10 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton11 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.header.Controls.Add(this.bunifuImageButton11);
            this.header.Controls.Add(this.bunifuImageButton10);
            this.header.Controls.Add(this.bunifuImageButton9);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(794, 43);
            this.header.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.footer.Controls.Add(this.bunifuSlider1);
            this.footer.Controls.Add(this.bunifuImageButton8);
            this.footer.Controls.Add(this.bunifuImageButton7);
            this.footer.Controls.Add(this.bunifuImageButton6);
            this.footer.Controls.Add(this.bunifuImageButton5);
            this.footer.Controls.Add(this.bunifuCustomLabel3);
            this.footer.Controls.Add(this.bunifuCustomLabel2);
            this.footer.Controls.Add(this.bunifuImageButton4);
            this.footer.Controls.Add(this.bunifuImageButton3);
            this.footer.Controls.Add(this.bunifuImageButton2);
            this.footer.Controls.Add(this.bunifuImageButton1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 452);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(794, 150);
            this.footer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.bunifuProgressBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 409);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(132, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Lecteur Media Player";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(101, 36);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 0;
            this.bunifuProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 399);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(794, 10);
            this.bunifuProgressBar1.TabIndex = 0;
            this.bunifuProgressBar1.Value = 30;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(44, 49);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(51, 44);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(178, 49);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(51, 44);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(235, 49);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(51, 44);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 3;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(33, 20);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "0:00";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(754, 7);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(37, 20);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "-0:00";
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(367, 58);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(29, 29);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 6;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(402, 58);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(29, 29);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 7;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(437, 58);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(29, 29);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 8;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(617, 66);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(24, 19);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 9;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuImageButton8.Zoom = 10;
            this.bunifuImageButton8.Click += new System.EventHandler(this.bunifuImageButton8_Click);
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 5;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(657, 62);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(100, 30);
            this.bunifuSlider1.TabIndex = 10;
            this.bunifuSlider1.Value = 20;
            // 
            // bunifuImageButton9
            // 
            this.bunifuImageButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton9.Image")));
            this.bunifuImageButton9.ImageActive = null;
            this.bunifuImageButton9.Location = new System.Drawing.Point(753, 7);
            this.bunifuImageButton9.Name = "bunifuImageButton9";
            this.bunifuImageButton9.Size = new System.Drawing.Size(29, 29);
            this.bunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton9.TabIndex = 11;
            this.bunifuImageButton9.TabStop = false;
            this.bunifuImageButton9.Zoom = 10;
            this.bunifuImageButton9.Click += new System.EventHandler(this.bunifuImageButton9_Click);
            // 
            // bunifuImageButton10
            // 
            this.bunifuImageButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton10.Image")));
            this.bunifuImageButton10.ImageActive = null;
            this.bunifuImageButton10.Location = new System.Drawing.Point(718, 7);
            this.bunifuImageButton10.Name = "bunifuImageButton10";
            this.bunifuImageButton10.Size = new System.Drawing.Size(29, 29);
            this.bunifuImageButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton10.TabIndex = 12;
            this.bunifuImageButton10.TabStop = false;
            this.bunifuImageButton10.Zoom = 10;
            // 
            // bunifuImageButton11
            // 
            this.bunifuImageButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuImageButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton11.Image")));
            this.bunifuImageButton11.ImageActive = null;
            this.bunifuImageButton11.Location = new System.Drawing.Point(683, 7);
            this.bunifuImageButton11.Name = "bunifuImageButton11";
            this.bunifuImageButton11.Size = new System.Drawing.Size(29, 29);
            this.bunifuImageButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton11.TabIndex = 13;
            this.bunifuImageButton11.TabStop = false;
            this.bunifuImageButton11.Zoom = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(794, 399);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton9;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton10;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton11;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

