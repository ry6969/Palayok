namespace Palayok.UI
{
    partial class RecipeSelectionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeSelectionScreen));
            Recipe1Btn = new Button();
            Recipe2Btn = new Button();
            Recipe3Btn = new Button();
            Recipe4Btn = new Button();
            Recipe5Btn = new Button();
            Recipe6Btn = new Button();
            ViewIngredientsBtn = new Button();
            CookBtn = new Button();
            ChosenLabel = new Label();
            pictureBox1 = new PictureBox();
            universalBackBtn1 = new UniversalBackBtn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pictureBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Recipe1Btn
            // 
            Recipe1Btn.Image = Properties.Resources.Adobo;
            Recipe1Btn.Location = new Point(121, 173);
            Recipe1Btn.Name = "Recipe1Btn";
            Recipe1Btn.Size = new Size(198, 98);
            Recipe1Btn.TabIndex = 1;
            Recipe1Btn.UseVisualStyleBackColor = true;
            // 
            // Recipe2Btn
            // 
            Recipe2Btn.Image = Properties.Resources.Tinola;
            Recipe2Btn.Location = new Point(375, 173);
            Recipe2Btn.Name = "Recipe2Btn";
            Recipe2Btn.Size = new Size(203, 98);
            Recipe2Btn.TabIndex = 2;
            Recipe2Btn.UseVisualStyleBackColor = true;
            // 
            // Recipe3Btn
            // 
            Recipe3Btn.FlatAppearance.BorderSize = 0;
            Recipe3Btn.Image = Properties.Resources.TortangTalong;
            Recipe3Btn.Location = new Point(641, 173);
            Recipe3Btn.Name = "Recipe3Btn";
            Recipe3Btn.Size = new Size(198, 98);
            Recipe3Btn.TabIndex = 3;
            Recipe3Btn.UseVisualStyleBackColor = true;
            // 
            // Recipe4Btn
            // 
            Recipe4Btn.Image = Properties.Resources.PaksiwnaBangus;
            Recipe4Btn.Location = new Point(116, 309);
            Recipe4Btn.Name = "Recipe4Btn";
            Recipe4Btn.Size = new Size(203, 98);
            Recipe4Btn.TabIndex = 4;
            Recipe4Btn.UseVisualStyleBackColor = true;
            // 
            // Recipe5Btn
            // 
            Recipe5Btn.Image = Properties.Resources.PorkMonggo;
            Recipe5Btn.Location = new Point(375, 309);
            Recipe5Btn.Name = "Recipe5Btn";
            Recipe5Btn.Size = new Size(203, 98);
            Recipe5Btn.TabIndex = 5;
            Recipe5Btn.UseVisualStyleBackColor = true;
            // 
            // Recipe6Btn
            // 
            Recipe6Btn.Image = Properties.Resources.NilagangBaka;
            Recipe6Btn.Location = new Point(636, 309);
            Recipe6Btn.Name = "Recipe6Btn";
            Recipe6Btn.Size = new Size(203, 98);
            Recipe6Btn.TabIndex = 6;
            Recipe6Btn.UseVisualStyleBackColor = true;
            // 
            // ViewIngredientsBtn
            // 
            ViewIngredientsBtn.Image = Properties.Resources.View;
            ViewIngredientsBtn.Location = new Point(285, 459);
            ViewIngredientsBtn.Name = "ViewIngredientsBtn";
            ViewIngredientsBtn.Size = new Size(148, 71);
            ViewIngredientsBtn.TabIndex = 8;
            ViewIngredientsBtn.UseVisualStyleBackColor = true;
            ViewIngredientsBtn.Click += ViewIngredientsBtn_Click;
            // 
            // CookBtn
            // 
            CookBtn.Image = Properties.Resources.Cook;
            CookBtn.Location = new Point(499, 459);
            CookBtn.Name = "CookBtn";
            CookBtn.Size = new Size(148, 71);
            CookBtn.TabIndex = 9;
            CookBtn.UseVisualStyleBackColor = true;
            CookBtn.Click += CookBtn_Click;
            // 
            // ChosenLabel
            // 
            ChosenLabel.BackColor = Color.Transparent;
            ChosenLabel.Font = new Font("Pixelify Sans", 32F);
            ChosenLabel.ForeColor = SystemColors.Control;
            ChosenLabel.Location = new Point(584, 24);
            ChosenLabel.Name = "ChosenLabel";
            ChosenLabel.Size = new Size(342, 84);
            ChosenLabel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(ChosenLabel);
            pictureBox1.Controls.Add(universalBackBtn1);
            pictureBox1.Controls.Add(CookBtn);
            pictureBox1.Controls.Add(ViewIngredientsBtn);
            pictureBox1.Controls.Add(Recipe6Btn);
            pictureBox1.Controls.Add(Recipe5Btn);
            pictureBox1.Controls.Add(Recipe4Btn);
            pictureBox1.Controls.Add(Recipe3Btn);
            pictureBox1.Controls.Add(Recipe2Btn);
            pictureBox1.Controls.Add(Recipe1Btn);
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
            universalBackBtn1.TabIndex = 10;
            universalBackBtn1.Load += universalBackBtn1_Load;
            // 
            // RecipeSelectionScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Name = "RecipeSelectionScreen";
            Size = new Size(960, 576);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pictureBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Recipe1Btn;
        private Button Recipe2Btn;
        private Button Recipe3Btn;
        private Button Recipe4Btn;
        private Button Recipe5Btn;
        private Button Recipe6Btn;
        private Button ViewIngredientsBtn;
        private Button CookBtn;
        private Label ChosenLabel;
        private PictureBox pictureBox1;
        private UniversalBackBtn universalBackBtn1;
    }
}
