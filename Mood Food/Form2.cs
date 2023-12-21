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
        private FoodManager foodmanage;
        List<Meal> meal_list_Form2 = new List<Meal>();
        int count = 0;
        public Form2(FoodManager foodmg)
        {
            InitializeComponent();
            foodmanage = foodmg;
            meal_list_Form2 = foodmg.Meal_list;
            labelFood.Text = meal_list_Form2[count].Food;
        }



        private void buttonAddMood_Click(object sender, EventArgs e)
        {
            Mood mood_form2 = new Mood();
            mood_form2.Rate = Convert.ToInt32(numericUpDownRate.Value);
            //prom =2 => You are sad maybe u should eat some "pasta"
            int rate = 0;
            rate += mood_form2.Rate ;
            int prom= rate/ meal_list_Form2.Count;
            set_mood(mood_form2);

            numericUpDownRate.Value = 1;
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

            }

        }
        private void recomendation()
        {

        }
    }
}
