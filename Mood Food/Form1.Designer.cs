namespace Mood_Food
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxMoods = new ComboBox();
            groupBox1 = new GroupBox();
            Rate = new Label();
            numericUpDownRate = new NumericUpDown();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label3 = new Label();
            comboBoxTypeofFood = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            buttonMood = new Button();
            buttonAddFood = new Button();
            numericUpDownPortionSize = new NumericUpDown();
            dateTimePickerTimeofDay = new DateTimePicker();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRate).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortionSize).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMoods
            // 
            comboBoxMoods.FormattingEnabled = true;
            comboBoxMoods.Items.AddRange(new object[] { "Angry", "Anxious", "Calm", "Depressed", "Embarrassed", "Excited", "Grumpy", "Happy", "Hurt", "Indifferent", "Irritated", "Paniccked", "Sad", "Worried" });
            comboBoxMoods.Location = new Point(215, 62);
            comboBoxMoods.Name = "comboBoxMoods";
            comboBoxMoods.Size = new Size(151, 28);
            comboBoxMoods.TabIndex = 0;
            comboBoxMoods.SelectedIndexChanged += comboBoxMoods_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rate);
            groupBox1.Controls.Add(numericUpDownRate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxMoods);
            groupBox1.Location = new Point(61, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 352);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Before Eating";
            // 
            // Rate
            // 
            Rate.AutoSize = true;
            Rate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Rate.Location = new Point(92, 156);
            Rate.Name = "Rate";
            Rate.Size = new Size(51, 28);
            Rate.TabIndex = 10;
            Rate.Text = "Rate";
            // 
            // numericUpDownRate
            // 
            numericUpDownRate.Location = new Point(215, 156);
            numericUpDownRate.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRate.Name = "numericUpDownRate";
            numericUpDownRate.Size = new Size(150, 27);
            numericUpDownRate.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(92, 58);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 8;
            label5.Text = "Mood";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(694, 535);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(686, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Before";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(686, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "After";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxTypeofFood);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(buttonMood);
            groupBox2.Controls.Add(buttonAddFood);
            groupBox2.Controls.Add(numericUpDownPortionSize);
            groupBox2.Controls.Add(dateTimePickerTimeofDay);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(91, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 352);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "After Eating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 128);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 8;
            label3.Text = "Portion size";
            // 
            // comboBoxTypeofFood
            // 
            comboBoxTypeofFood.FormattingEnabled = true;
            comboBoxTypeofFood.Items.AddRange(new object[] { "Fruits and Vegetables", "Meat", "Poultry, fish and/or eggs", "Dairy", "Nuts, seeds, beans and tofu", "Sugary Drinks and/or sweets", "High in fat and/or salt", "Starchy food(Potatoes, bread, rice, pasta, cereal)", "Alcohol" });
            comboBoxTypeofFood.Location = new Point(252, 55);
            comboBoxTypeofFood.Name = "comboBoxTypeofFood";
            comboBoxTypeofFood.Size = new Size(151, 28);
            comboBoxTypeofFood.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(316, 317);
            label1.Name = "label1";
            label1.Size = new Size(158, 12);
            label1.TabIndex = 6;
            label1.Text = "*Click after adding all the food had";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 210);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 9;
            label4.Text = "Time of day";
            // 
            // buttonMood
            // 
            buttonMood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMood.Location = new Point(316, 273);
            buttonMood.Name = "buttonMood";
            buttonMood.Size = new Size(158, 41);
            buttonMood.TabIndex = 5;
            buttonMood.Text = "Tell Mood";
            buttonMood.UseVisualStyleBackColor = true;
            // 
            // buttonAddFood
            // 
            buttonAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddFood.Location = new Point(89, 273);
            buttonAddFood.Name = "buttonAddFood";
            buttonAddFood.Size = new Size(158, 41);
            buttonAddFood.TabIndex = 4;
            buttonAddFood.Text = "Add Food";
            buttonAddFood.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPortionSize
            // 
            numericUpDownPortionSize.DecimalPlaces = 1;
            numericUpDownPortionSize.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPortionSize.Location = new Point(252, 130);
            numericUpDownPortionSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPortionSize.Name = "numericUpDownPortionSize";
            numericUpDownPortionSize.Size = new Size(150, 27);
            numericUpDownPortionSize.TabIndex = 2;
            // 
            // dateTimePickerTimeofDay
            // 
            dateTimePickerTimeofDay.CustomFormat = "\"hh:mm tt\"";
            dateTimePickerTimeofDay.Format = DateTimePickerFormat.Time;
            dateTimePickerTimeofDay.ImeMode = ImeMode.NoControl;
            dateTimePickerTimeofDay.Location = new Point(252, 212);
            dateTimePickerTimeofDay.Name = "dateTimePickerTimeofDay";
            dateTimePickerTimeofDay.ShowUpDown = true;
            dateTimePickerTimeofDay.Size = new Size(150, 27);
            dateTimePickerTimeofDay.TabIndex = 3;
            dateTimePickerTimeofDay.Value = new DateTime(2023, 11, 22, 9, 36, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 7;
            label2.Text = "Food type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 629);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Mood Food";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRate).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortionSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMoods;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownRate;
        private Label label5;
        private Label Rate;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox comboBoxTypeofFood;
        private Label label1;
        private Label label4;
        private Button buttonMood;
        private Button buttonAddFood;
        private NumericUpDown numericUpDownPortionSize;
        private DateTimePicker dateTimePickerTimeofDay;
        private Label label2;
    }
}