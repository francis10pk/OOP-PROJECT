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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelAte = new Label();
            label6 = new Label();
            checkBoxAte = new CheckBox();
            buttonDislikes = new Button();
            checkedListBoxPreference = new CheckedListBox();
            comboBoxlistfood = new ComboBox();
            tabPageAfter = new TabPage();
            groupBox2 = new GroupBox();
            comboBoxFoodtype = new ComboBox();
            label3 = new Label();
            comboBoxTypeofFood = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            buttonMood = new Button();
            buttonAddFood = new Button();
            numericUpDownPortionSize = new NumericUpDown();
            dateTimePickerTimeofDay = new DateTimePicker();
            label2 = new Label();
            tabPageBefore = new TabPage();
            groupBox1 = new GroupBox();
            Rate = new Label();
            numericUpDownRate = new NumericUpDown();
            label5 = new Label();
            comboBoxMoods = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPageAfter.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortionSize).BeginInit();
            tabPageBefore.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRate).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageAfter);
            tabControl1.Controls.Add(tabPageBefore);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(951, 507);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelAte);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(checkBoxAte);
            tabPage1.Controls.Add(buttonDislikes);
            tabPage1.Controls.Add(checkedListBoxPreference);
            tabPage1.Controls.Add(comboBoxlistfood);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(943, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Preferences";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelAte
            // 
            labelAte.AutoSize = true;
            labelAte.Location = new Point(297, 379);
            labelAte.Name = "labelAte";
            labelAte.Size = new Size(0, 20);
            labelAte.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(297, 297);
            label6.Name = "label6";
            label6.Size = new Size(277, 20);
            label6.TabIndex = 5;
            label6.Text = "Answer after adding all your preferences";
            // 
            // checkBoxAte
            // 
            checkBoxAte.AutoSize = true;
            checkBoxAte.Location = new Point(368, 332);
            checkBoxAte.Name = "checkBoxAte";
            checkBoxAte.Size = new Size(115, 24);
            checkBoxAte.TabIndex = 4;
            checkBoxAte.Text = "Did You eat?";
            checkBoxAte.UseVisualStyleBackColor = true;
            checkBoxAte.CheckedChanged += checkBoxAte_CheckedChanged;
            // 
            // buttonDislikes
            // 
            buttonDislikes.Location = new Point(368, 185);
            buttonDislikes.Name = "buttonDislikes";
            buttonDislikes.Size = new Size(162, 52);
            buttonDislikes.TabIndex = 2;
            buttonDislikes.Text = "Disliked/Allergies";
            buttonDislikes.UseVisualStyleBackColor = true;
            buttonDislikes.Click += buttonDislikes_Click;
            // 
            // checkedListBoxPreference
            // 
            checkedListBoxPreference.FormattingEnabled = true;
            checkedListBoxPreference.Location = new Point(490, 59);
            checkedListBoxPreference.Name = "checkedListBoxPreference";
            checkedListBoxPreference.Size = new Size(150, 70);
            checkedListBoxPreference.TabIndex = 1;
            // 
            // comboBoxlistfood
            // 
            comboBoxlistfood.FormattingEnabled = true;
            comboBoxlistfood.Location = new Point(268, 80);
            comboBoxlistfood.Name = "comboBoxlistfood";
            comboBoxlistfood.Size = new Size(151, 28);
            comboBoxlistfood.TabIndex = 0;
            comboBoxlistfood.SelectedIndexChanged += comboBoxlistfood_SelectedIndexChanged;
            // 
            // tabPageAfter
            // 
            tabPageAfter.Controls.Add(groupBox2);
            tabPageAfter.Location = new Point(4, 29);
            tabPageAfter.Name = "tabPageAfter";
            tabPageAfter.Padding = new Padding(3);
            tabPageAfter.Size = new Size(943, 474);
            tabPageAfter.TabIndex = 1;
            tabPageAfter.Text = "After";
            tabPageAfter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxFoodtype);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBoxTypeofFood);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(buttonMood);
            groupBox2.Controls.Add(buttonAddFood);
            groupBox2.Controls.Add(numericUpDownPortionSize);
            groupBox2.Controls.Add(dateTimePickerTimeofDay);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(91, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(700, 391);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "After Eating";
            // 
            // comboBoxFoodtype
            // 
            comboBoxFoodtype.FormattingEnabled = true;
            comboBoxFoodtype.Location = new Point(402, 53);
            comboBoxFoodtype.Name = "comboBoxFoodtype";
            comboBoxFoodtype.Size = new Size(151, 28);
            comboBoxFoodtype.TabIndex = 11;
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
            comboBoxTypeofFood.Location = new Point(196, 55);
            comboBoxTypeofFood.Name = "comboBoxTypeofFood";
            comboBoxTypeofFood.Size = new Size(151, 28);
            comboBoxTypeofFood.TabIndex = 1;
            comboBoxTypeofFood.SelectedIndexChanged += comboBoxTypeofFood_SelectedIndexChanged;
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
            buttonMood.Click += buttonMood_Click;
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
            buttonAddFood.Click += buttonAddFood_Click;
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
            label2.Location = new Point(42, 53);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 7;
            label2.Text = "Food type";
            // 
            // tabPageBefore
            // 
            tabPageBefore.Controls.Add(groupBox1);
            tabPageBefore.Location = new Point(4, 29);
            tabPageBefore.Name = "tabPageBefore";
            tabPageBefore.Padding = new Padding(3);
            tabPageBefore.Size = new Size(943, 474);
            tabPageBefore.TabIndex = 2;
            tabPageBefore.Text = "Before";
            tabPageBefore.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Rate);
            groupBox1.Controls.Add(numericUpDownRate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxMoods);
            groupBox1.Location = new Point(116, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 352);
            groupBox1.TabIndex = 11;
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
            // comboBoxMoods
            // 
            comboBoxMoods.FormattingEnabled = true;
            comboBoxMoods.Items.AddRange(new object[] { "Angry", "Anxious", "Calm", "Depressed", "Embarrassed", "Excited", "Grumpy", "Happy", "Hurt", "Indifferent", "Irritated", "Paniccked", "Sad", "Worried" });
            comboBoxMoods.Location = new Point(215, 62);
            comboBoxMoods.Name = "comboBoxMoods";
            comboBoxMoods.Size = new Size(151, 28);
            comboBoxMoods.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 693);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Mood Food";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPageAfter.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPortionSize).EndInit();
            tabPageBefore.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRate).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPageAfter;
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
        private TabPage tabPageBefore;
        private GroupBox groupBox1;
        private Label Rate;
        private NumericUpDown numericUpDownRate;
        private Label label5;
        private ComboBox comboBoxMoods;
        private CheckedListBox checkedListBoxPreference;
        private ComboBox comboBoxlistfood;
        private Button buttonDislikes;
        private Label label6;
        private CheckBox checkBoxAte;
        private Label labelAte;
        private ComboBox comboBoxFoodtype;
    }
}