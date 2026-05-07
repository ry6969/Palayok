namespace Palayok.UI
{
    partial class UniversalBackBtn
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
            BackBtn = new Button();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BackBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Image = Properties.Resources.Back;
            BackBtn.Location = new Point(0, 0);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(66, 66);
            BackBtn.TabIndex = 9;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // UniversalBackBtn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(BackBtn);
            Name = "UniversalBackBtn";
            Size = new Size(66, 66);
            ResumeLayout(false);
        }

        #endregion

        private Button BackBtn;
    }
}
