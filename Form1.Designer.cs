namespace Gallery
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
            this.test = new System.Windows.Forms.PictureBox();
            this.d = new System.Windows.Forms.PictureBox();
            this.c = new System.Windows.Forms.PictureBox();
            this.b = new System.Windows.Forms.PictureBox();
            this.a = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Prevouis = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Image = global::Gallery.Properties.Resources.img5;
            this.test.Location = new System.Drawing.Point(757, 443);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(100, 50);
            this.test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.test.TabIndex = 2;
            this.test.TabStop = false;
            this.test.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // d
            // 
            this.d.Image = global::Gallery.Properties.Resources.img4;
            this.d.Location = new System.Drawing.Point(634, 443);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 50);
            this.d.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.d.TabIndex = 2;
            this.d.TabStop = false;
            this.d.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // c
            // 
            this.c.Image = global::Gallery.Properties.Resources.img3;
            this.c.Location = new System.Drawing.Point(506, 443);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 50);
            this.c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c.TabIndex = 2;
            this.c.TabStop = false;
            this.c.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // b
            // 
            this.b.Image = global::Gallery.Properties.Resources.img2;
            this.b.Location = new System.Drawing.Point(376, 443);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 50);
            this.b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b.TabIndex = 2;
            this.b.TabStop = false;
            this.b.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // a
            // 
            this.a.Image = global::Gallery.Properties.Resources.img1;
            this.a.Location = new System.Drawing.Point(251, 443);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 50);
            this.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.a.TabIndex = 2;
            this.a.TabStop = false;
            this.a.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(188, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(722, 344);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Prevouis
            // 
            this.Prevouis.Location = new System.Drawing.Point(350, 536);
            this.Prevouis.Name = "Prevouis";
            this.Prevouis.Size = new System.Drawing.Size(126, 41);
            this.Prevouis.TabIndex = 3;
            this.Prevouis.Text = "Prevouis";
            this.Prevouis.UseVisualStyleBackColor = true;
            this.Prevouis.Click += new System.EventHandler(this.Prevouis_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(482, 536);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(124, 41);
            this.Play.TabIndex = 3;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.button2_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(612, 536);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(130, 41);
            this.Next.TabIndex = 3;
            this.Next.Text = "next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(482, 536);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(124, 41);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 621);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prevouis);
            this.Controls.Add(this.test);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox b;
        private System.Windows.Forms.PictureBox c;
        private System.Windows.Forms.PictureBox test;
        private System.Windows.Forms.PictureBox d;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Prevouis;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Pause;
    }
}

