namespace Mood_Food
{
    public partial class Form1 : Form
    {
        List<Meal> meal_list = new List<Meal>();
        public Form1()
        {
            InitializeComponent();

            buttonMood.Enabled = false;


        }

        private void buttonMood_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public List<Meal> getMealForm1()
        {
            return meal_list;
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {

            buttonMood.Enabled = true;
            Meal person_meal = new Meal();
            person_meal.Food = comboBoxTypeofFood.Text;
            person_meal.Rate = numericUpDownPortionSize.Value;
            person_meal.Time = dateTimePickerTimeofDay.Value.TimeOfDay;

            //MessageBox.Show(person_meal.Food + person_meal.Rate + person_meal.Time);

            meal_list.Add(person_meal);
            comboBoxTypeofFood.SelectedIndex = -1;
            numericUpDownPortionSize.Value = 0;
            dateTimePickerTimeofDay.Value = dateTimePickerTimeofDay.MinDate;
        }

        private void comboBoxMoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}