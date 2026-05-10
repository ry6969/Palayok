namespace Palayok.UI
{
    partial class StartScreen
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
            pictureBox1 = new PictureBox();
            StartBtn = new Button();
            muteBtn1 = new MuteBtn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pictureBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Controls.Add(StartBtn);
            pictureBox1.Controls.Add(muteBtn1);
            pictureBox1.Image = Properties.Resources.Screen;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 576);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.Transparent;
            StartBtn.FlatAppearance.BorderSize = 0;
            StartBtn.FlatStyle = FlatStyle.Flat;
            StartBtn.Image = Properties.Resources.StartButton;
            StartBtn.Location = new Point(539, 330);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(349, 109);
            StartBtn.TabIndex = 1;
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // muteBtn1
            // 
            muteBtn1.Location = new Point(872, 136);
            muteBtn1.Name = "muteBtn1";
            muteBtn1.Size = new Size(66, 60);
            muteBtn1.TabIndex = 1;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Name = "StartScreen";
            Size = new Size(960, 576);
            Load += StartScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pictureBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button StartBtn;
        private MuteBtn muteBtn1;
    }
}
