using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food
{
    public partial class Form2 : Form
    {
        private Form1 form1data;
        List<Meal> meal_list_Form2 = new List<Meal>();
        Dictionary<Meal, Mood> meal_Mood_dict = new Dictionary<Meal, Mood>();
        int count = 0;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            form1data = form1;
            meal_list_Form2 = form1data.getMealForm1();
            labelFood.Text = meal_list_Form2[count].Food;
        }



        private void buttonAddMood_Click(object sender, EventArgs e)
        {
            Mood mood_form2 = new Mood();
            mood_form2.Rate = Convert.ToInt32(numericUpDownRate.Value);
            set_mood(mood_form2);

            numericUpDownRate.Value = 0;
            count++;
            if (meal_list_Form2.Count > count)
            {
                labelFood.Text = meal_list_Form2[count].Food;
            }
            else
            {
                buttonAddFood.Enabled = false;
                recomendation();
            }

        }
        /*
        private void nextFood(int i)
        {
            if (textBoxFood.Text == null)
            {
                textBoxFood.Text = meal_list_Form2[0].Food;
            }
            else
            {
                textBoxFood.Text = meal_list_Form2[i].Food;
            }
               
        

            foreach (var mel_list in meal_list_Form2)
            {
                textBoxFood.Text = mel_list.Food;
                numericUpDownRate.Value = 0;
                Mood mood_form2 = new Mood();
                mood_form2.Rate = Convert.ToInt32(numericUpDownRate.Value);
                set_mood(mood_form2);

                meal_Mood_dict[mel_list] = mood_form2;
            }
        }
        */
        private void set_mood(Mood mood2)
        {
            switch (mood2.Rate)
            {
                case 0:
                    mood2.Moods = "Very Irritated";
                    break;
                case 1:
                    mood2.Moods = "Irritated";
                    break;
                case 2:
                    mood2.Moods = "Frustrated";
                    break;
                case 3:
                    mood2.Moods = "Very Anxious";
                    break;
                case 4:
                    mood2.Moods = "Anxious";
                    break;
                case 5:
                    mood2.Moods = "Neutral";
                    break;
                case 6:
                    mood2.Moods = "Relieved";
                    break;
                case 7:
                    mood2.Moods = "Calm";
                    break;
                case 8:
                    mood2.Moods = "Very Calm";
                    break;
                case 9:
                    mood2.Moods = "Happy";
                    break;
                case 10:
                    mood2.Moods = "Very Happy";
                    break;
            }

        }
        private void recomendation()
        {

        }
    }
}
