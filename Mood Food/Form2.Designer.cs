namespace Mood_Food
{
    partial class Form2
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
            Rate = new Label();
            numericUpDownRate = new NumericUpDown();
            buttonAddFood = new Button();
            label2 = new Label();
            labelFood = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRate).BeginInit();
            SuspendLayout();
            // 
            // Rate
            // 
            Rate.AutoSize = true;
            Rate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Rate.Location = new Point(249, 156);
            Rate.Name = "Rate";
            Rate.Size = new Size(51, 28);
            Rate.TabIndex = 14;
            Rate.Text = "Rate";
            // 
            // numericUpDownRate
            // 
            numericUpDownRate.Location = new Point(345, 157);
            numericUpDownRate.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRate.Name = "numericUpDownRate";
            numericUpDownRate.Size = new Size(150, 27);
            numericUpDownRate.TabIndex = 13;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddFood.Location = new Point(283, 264);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(158, 41);
            buttonAddFood.TabIndex = 15;
            buttonAddFood.Text = "Rate Food";
            buttonAddFood.UseVisualStyleBackColor = true;
            buttonAddFood.Click += buttonAddMood_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 19;
            label2.Text = "Food";
            // 
            // labelFood
            // 
            labelFood.AutoSize = true;
            labelFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFood.Location = new Point(345, 71);
            labelFood.Name = "labelFood";
            labelFood.Size = new Size(65, 28);
            labelFood.TabIndex = 20;
            labelFood.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 187);
            label1.Name = "label1";
            label1.Size = new Size(98, 12);
            label1.TabIndex = 21;
            label1.Text = "*Rate each food item";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelFood);
            Controls.Add(label2);
            Controls.Add(buttonAddFood);
            Controls.Add(Rate);
            Controls.Add(numericUpDownRate);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Rate;
        private NumericUpDown numericUpDownRate;
        private Button buttonAddFood;
        private Label label2;
        private Label labelFood;
        private Label label1;
    }
}