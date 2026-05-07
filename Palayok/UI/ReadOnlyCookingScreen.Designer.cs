namespace Palayok.UI
{
    partial class ReadOnlyCookingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadOnlyCookingScreen));
            pictureBox1 = new PictureBox();
            universalBackBtn1 = new UniversalBackBtn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pictureBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Controls.Add(universalBackBtn1);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 576);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // universalBackBtn1
            // 
            universalBackBtn1.BackColor = Color.Transparent;
            universalBackBtn1.Location = new Point(25, 132);
            universalBackBtn1.Name = "universalBackBtn1";
            universalBackBtn1.Size = new Size(66, 66);
            universalBackBtn1.TabIndex = 2;
            // 
            // ReadOnlyCookingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Name = "ReadOnlyCookingScreen";
            Size = new Size(960, 576);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pictureBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private UniversalBackBtn universalBackBtn1;
    }
}
