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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MealSelectRT;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(960, 576);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Adobo;
            button1.Location = new Point(121, 173);
            button1.Name = "button1";
            button1.Size = new Size(198, 98);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Tinola;
            button2.Location = new Point(375, 173);
            button2.Name = "button2";
            button2.Size = new Size(203, 98);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.TortangTalong;
            button3.Location = new Point(641, 173);
            button3.Name = "button3";
            button3.Size = new Size(198, 98);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.PaksiwnaBangus;
            button4.Location = new Point(116, 309);
            button4.Name = "button4";
            button4.Size = new Size(203, 98);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.PorkMonggo;
            button5.Location = new Point(375, 309);
            button5.Name = "button5";
            button5.Size = new Size(203, 98);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.NilagangBaka;
            button6.Location = new Point(636, 309);
            button6.Name = "button6";
            button6.Size = new Size(203, 98);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Image = Properties.Resources.View;
            button8.Location = new Point(285, 459);
            button8.Name = "button8";
            button8.Size = new Size(148, 71);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Image = Properties.Resources.Cook;
            button9.Location = new Point(499, 459);
            button9.Name = "button9";
            button9.Size = new Size(148, 71);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.Back;
            button7.Location = new Point(26, 135);
            button7.Name = "button7";
            button7.Size = new Size(66, 66);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            // 
            // RecipeSelectionScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "RecipeSelectionScreen";
            Size = new Size(960, 576);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button7;
    }
}
