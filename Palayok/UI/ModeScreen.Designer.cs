namespace Palayok.UI
{
    partial class ModeScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeScreen));
            pictureBox1 = new PictureBox();
            universalBackBtn1 = new UniversalBackBtn();
            ROMode = new PictureBox();
            RTCMode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ROMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RTCMode).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Controls.Add(universalBackBtn1);
            pictureBox1.Controls.Add(ROMode);
            pictureBox1.Controls.Add(RTCMode);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 576);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // universalBackBtn1
            // 
            universalBackBtn1.BackColor = Color.Transparent;
            universalBackBtn1.Location = new Point(25, 132);
            universalBackBtn1.Name = "universalBackBtn1";
            universalBackBtn1.Size = new Size(66, 66);
            universalBackBtn1.TabIndex = 11;
            // 
            // ROMode
            // 
            ROMode.Image = Properties.Resources.ReadOnly;
            ROMode.Location = new Point(528, 152);
            ROMode.Name = "ROMode";
            ROMode.Size = new Size(290, 350);
            ROMode.TabIndex = 10;
            ROMode.TabStop = false;
            ROMode.Click += ROMode_Click;
            // 
            // RTCMode
            // 
            RTCMode.Image = Properties.Resources.RealTime;
            RTCMode.Location = new Point(144, 152);
            RTCMode.Name = "RTCMode";
            RTCMode.Size = new Size(290, 350);
            RTCMode.TabIndex = 9;
            RTCMode.TabStop = false;
            RTCMode.Click += RTCMode_Click;
            // 
            // ModeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Name = "ModeScreen";
            Size = new Size(960, 576);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pictureBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ROMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)RTCMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox RTCMode;
        private PictureBox ROMode;
        private UniversalBackBtn universalBackBtn1;
    }
}
