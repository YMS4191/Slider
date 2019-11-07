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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
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
            // btnLast
            // 
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Image = global::Slider.Properties.Resources.icons8_end_filled_50px;
            this.btnLast.Location = new System.Drawing.Point(713, 464);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 65);
            this.btnLast.TabIndex = 1;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Slider.Properties.Resources.icons8_fast_forward_26px;
            this.btnNext.Location = new System.Drawing.Point(632, 464);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 65);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnForward
            // 
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = global::Slider.Properties.Resources.icons8_rewind_30px;
            this.btnForward.Location = new System.Drawing.Point(94, 464);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 65);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Image = global::Slider.Properties.Resources.icons8_bank_cards_48px_1;
            this.btnFirst.Location = new System.Drawing.Point(13, 464);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 65);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
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
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnFirst);
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
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trcSpeed;
        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcBlue;
        private System.Windows.Forms.TrackBar trcGreen;
    }
}

