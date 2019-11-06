namespace Slider
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
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trcSpeed = new System.Windows.Forms.TrackBar();
            this.trcRed = new System.Windows.Forms.TrackBar();
            this.trcBlue = new System.Windows.Forms.TrackBar();
            this.trcGreen = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "r1.jpg");
            this.imgList.Images.SetKeyName(1, "r2.jpg");
            this.imgList.Images.SetKeyName(2, "r3.jpg");
            this.imgList.Images.SetKeyName(3, "r4.jpg");
            this.imgList.Images.SetKeyName(4, "r5.jpg");
            this.imgList.Images.SetKeyName(5, "r6.jpg");
            this.imgList.Images.SetKeyName(6, "r7.jpg");
            this.imgList.Images.SetKeyName(7, "r8.jpg");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Slider.Properties.Resources.icons8_play_filled_50px;
            this.btnStart.Location = new System.Drawing.Point(175, 464);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(451, 65);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Slider.Properties.Resources.icons8_end_filled_50px;
            this.button4.Location = new System.Drawing.Point(713, 464);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 65);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Slider.Properties.Resources.icons8_fast_forward_26px;
            this.button3.Location = new System.Drawing.Point(632, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 65);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Slider.Properties.Resources.icons8_rewind_30px;
            this.button2.Location = new System.Drawing.Point(94, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 65);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Slider.Properties.Resources.icons8_bank_cards_48px_1;
            this.button1.Location = new System.Drawing.Point(13, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trcSpeed
            // 
            this.trcSpeed.Location = new System.Drawing.Point(13, 12);
            this.trcSpeed.Maximum = 1000;
            this.trcSpeed.Minimum = 100;
            this.trcSpeed.Name = "trcSpeed";
            this.trcSpeed.Size = new System.Drawing.Size(775, 45);
            this.trcSpeed.TabIndex = 3;
            this.trcSpeed.Value = 100;
            this.trcSpeed.Scroll += new System.EventHandler(this.trcSpeed_Scroll);
            // 
            // trcRed
            // 
            this.trcRed.Location = new System.Drawing.Point(13, 535);
            this.trcRed.Maximum = 255;
            this.trcRed.Minimum = 1;
            this.trcRed.Name = "trcRed";
            this.trcRed.Size = new System.Drawing.Size(775, 45);
            this.trcRed.TabIndex = 4;
            this.trcRed.Value = 1;
            this.trcRed.Scroll += new System.EventHandler(this.trcRed_Scroll);
            // 
            // trcBlue
            // 
            this.trcBlue.Location = new System.Drawing.Point(13, 586);
            this.trcBlue.Maximum = 255;
            this.trcBlue.Minimum = 1;
            this.trcBlue.Name = "trcBlue";
            this.trcBlue.Size = new System.Drawing.Size(775, 45);
            this.trcBlue.TabIndex = 5;
            this.trcBlue.Value = 1;
            this.trcBlue.Scroll += new System.EventHandler(this.trcRed_Scroll);
            // 
            // trcGreen
            // 
            this.trcGreen.Location = new System.Drawing.Point(13, 637);
            this.trcGreen.Maximum = 255;
            this.trcGreen.Minimum = 1;
            this.trcGreen.Name = "trcGreen";
            this.trcGreen.Size = new System.Drawing.Size(775, 45);
            this.trcGreen.TabIndex = 6;
            this.trcGreen.Value = 1;
            this.trcGreen.Scroll += new System.EventHandler(this.trcRed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 687);
            this.Controls.Add(this.trcGreen);
            this.Controls.Add(this.trcBlue);
            this.Controls.Add(this.trcRed);
            this.Controls.Add(this.trcSpeed);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trcSpeed;
        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcBlue;
        private System.Windows.Forms.TrackBar trcGreen;
    }
}

