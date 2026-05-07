namespace Palayok.UI
{
    partial class InteractiveCookingScreen
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
            pictureBox2 = new PictureBox();
            NextBtn = new Button();
            universalBackBtn1 = new UniversalBackBtn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pictureBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 576);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Controls.Add(NextBtn);
            pictureBox2.Controls.Add(universalBackBtn1);
            pictureBox2.Image = Properties.Resources.adobo1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(960, 576);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.Transparent;
            NextBtn.FlatAppearance.BorderSize = 0;
            NextBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            NextBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Image = Properties.Resources.LetsGo;
            NextBtn.Location = new Point(600, 453);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(155, 75);
            NextBtn.TabIndex = 10;
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // universalBackBtn1
            // 
            universalBackBtn1.BackColor = Color.Transparent;
            universalBackBtn1.Location = new Point(25, 130);
            universalBackBtn1.Name = "universalBackBtn1";
            universalBackBtn1.Size = new Size(66, 66);
            universalBackBtn1.TabIndex = 2;
            // 
            // InteractiveCookingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "InteractiveCookingScreen";
            Size = new Size(960, 576);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pictureBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button NextBtn;
        private UniversalBackBtn universalBackBtn1;
    }
}
