using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxSpace.SelectedIndex = 0;
        }

        List<SpaceObjects> Space = new List<SpaceObjects>();

        private void dataGridAndAllListsUpdate()
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Выберите объект");
            dataGridView1.Rows.Clear();
            ClearTextBoxes();
            for (int i = 0; i < Space.Count; i++)
                dataGridView1.Rows.Add(Space[i].Name, Space[i].Age,  Space[i].Location.Distance, Space[i].Location.Redshift);
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxDiameter.Clear();
            textBoxShine.Clear();
            textBoxDistance.Clear();
            textBoxRedshift.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBoxSpace.SelectedIndex = 0;
        }

        private static SpaceObjects getSpaceTypeByString(string spaceChosen, string name, Location location, int age, int diameter, double shine, string firstParam, string secondParam)
        {
            if (spaceChosen.Equals("Галактика"))
                return new Galaxy(name, location, age, diameter, shine, firstParam, Convert.ToInt32(secondParam));
            else if (spaceChosen.Equals("Не уточнено"))
                return new SpaceObjects(name, location, age, diameter, shine);
            else if (spaceChosen.Equals("Туманность"))
                return new Nebula(name, location, age, diameter, shine, firstParam, secondParam);
            else if (spaceChosen.Equals("Звездное скопление"))
                return new StarCluster(name, location, age, diameter, shine, firstParam);
            else if (spaceChosen.Equals("Черная дыра"))
                return new BlackHole(name, location, age, diameter, shine, Convert.ToInt32(firstParam));
            else if (spaceChosen.Equals("Квазар"))
                return new Quasar(name, location, age, diameter, shine, Convert.ToInt32(firstParam), Convert.ToInt32(secondParam));
            else
                throw new Exception(spaceChosen + " не существует в списке объектов космоса!");
        }

        private bool inputtedValues()
        {
            if (textBoxName.Text == "" || textBoxAge.Text == "" || textBoxDiameter.Text == "" || textBoxDistance.Text == "" || textBoxRedshift.Text == "" || textBoxShine.Text == "")
                return false;
            else
                return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (inputtedValues())
            {
                Location currLoc;
                currLoc = new Location(Convert.ToDouble(textBoxDistance.Text), Convert.ToDouble(textBoxRedshift.Text));

                string FirstParam;
                try
                {
                    FirstParam = textBox1.Text;
                }
                catch
                {
                    FirstParam = "";
                }

                string SecondParam;
                try
                {
                    SecondParam = textBox2.Text;
                }
                catch
                {
                    SecondParam = "";
                }
                SpaceObjects space = getSpaceTypeByString(comboBoxSpace.Text.ToString(), textBoxName.Text, currLoc, Convert.ToInt32(textBoxAge.Text), Convert.ToInt32(textBoxDiameter.Text), Convert.ToDouble(textBoxShine.Text), FirstParam, SecondParam);
                Space.Add(space);
                dataGridAndAllListsUpdate();

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить объект " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value + "?", "Удаление объекта", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Space.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                    MessageBox.Show("Объект удалён!");
                }
                dataGridAndAllListsUpdate();
            }
            catch
            {
                MessageBox.Show("Выберите Объект!");
            }
        }

        private void buttonClearInfo_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dataGridAdd()
        {
            dataGridViewType.Rows.Clear();
            if (comboBoxSpace.SelectedIndex == 0)
            {
                
            }
            else if (comboBoxSpace.SelectedIndex == 1)
            {
                dataGridViewType.Rows.Add("Спиральная галактика");
                dataGridViewType.Rows.Add("Эллиптическая галактика");
                dataGridViewType.Rows.Add("Неправильная галактика");
                dataGridViewType.Rows.Add("Пекулярная галактика");
                dataGridViewType.Visible = true;
                textBox1.Text = dataGridViewType.CurrentRow.Cells[0].Value.ToString();
            }
            else if (comboBoxSpace.SelectedIndex == 2)
            {
                dataGridViewType.Rows.Add("Светлая туманность");
                dataGridViewType.Rows.Add("Эмиссионная туманность");
                dataGridViewType.Rows.Add("Отражательная туманность");
                dataGridViewType.Rows.Add("Остаток сверхновой");
                dataGridViewType.Rows.Add("Планетарная туманность");
                dataGridViewType.Rows.Add("Тёмная туманность");
                dataGridViewType.Visible = true;
                textBox1.Text = dataGridViewType.CurrentRow.Cells[0].Value.ToString();
            }
            else if (comboBoxSpace.SelectedIndex == 3)
            {
                dataGridViewType.Rows.Add("Рассеянное звёздное скопление");
                dataGridViewType.Rows.Add("Тёмная туманность");
                dataGridViewType.Visible = true;
                textBox1.Text = dataGridViewType.CurrentRow.Cells[0].Value.ToString();
            }
        }
        private void comboBoxSpace_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.ReadOnly = false;
            labelF.Visible = false;
            labelS.Visible = false;
            dataGridViewType.Visible = false;     

//            checkBoxSwear.Visible = false;
            if (comboBoxSpace.SelectedIndex == 0)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                labelF.Visible = false;
                labelS.Visible = false;
            }
            else if (comboBoxSpace.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox1.ReadOnly = true;
                labelF.Visible = true;
                labelS.Visible = true;
                labelF.Text = "Тип:";
                labelS.Text = "Масса (M⨀):";
            }
            else if (comboBoxSpace.SelectedIndex == 2)
            {
                textBox1.ReadOnly = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                labelF.Visible = true;
                labelS.Visible = true;
                labelF.Text = "Тип:";
                labelS.Text = "Состав (хим. элементы):";
            }
            else if (comboBoxSpace.SelectedIndex == 3)
            {
                textBox1.ReadOnly = true;
                textBox1.Visible = true;
                labelF.Visible = true;
                labelF.Text = "Тип:";   
            }
            else if (comboBoxSpace.SelectedIndex == 4)
            {
                textBox1.Visible = true;
                labelF.Visible = true;
                labelF.Text = "Масса (M⨀):";
            }
            else
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                labelF.Visible = true;
                labelS.Visible = true;
                //                checkBoxSwear.Visible = true;
                labelF.Text = "Масса (M⨀):";
                labelS.Text = "Длина джета (св. лет):";
            }
            dataGridAdd();
        }

        private void dataGridViewType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridViewType.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputtedValues())
                {
                    //name, location, age, diameter, shine

                    Space[dataGridView1.SelectedCells[0].RowIndex].Name = textBoxName.Text;
                    Space[dataGridView1.SelectedCells[0].RowIndex].Location.Distance = Convert.ToDouble(textBoxDistance.Text);
                    Space[dataGridView1.SelectedCells[0].RowIndex].Location.Redshift = Convert.ToDouble(textBoxRedshift.Text);
                    Space[dataGridView1.SelectedCells[0].RowIndex].Age = Convert.ToInt32(textBoxAge.Text);
                    Space[dataGridView1.SelectedCells[0].RowIndex].Diameter = Convert.ToInt32(textBoxDiameter.Text);
                    Space[dataGridView1.SelectedCells[0].RowIndex].Shine = Convert.ToDouble(textBoxShine.Text);

                    comboBoxSpace.SelectedIndex = 0;
                    if (Space[dataGridView1.SelectedCells[0].RowIndex] is Galaxy)
                    {
                        comboBoxSpace.SelectedIndex = 1;
                        Galaxy curr = Space[dataGridView1.SelectedCells[0].RowIndex] as Galaxy;
                        curr.Type = textBox1.Text;
                        curr.Weight = Convert.ToInt32(textBox2.Text);
                        Space[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Space[dataGridView1.SelectedCells[0].RowIndex] is Nebula)
                    {
                        comboBoxSpace.SelectedIndex = 2;
                        Nebula curr = Space[dataGridView1.SelectedCells[0].RowIndex] as Nebula;
                        curr.Type = textBox1.Text;
                        curr.Composition = textBox2.Text;
                        Space[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Space[dataGridView1.SelectedCells[0].RowIndex] is StarCluster)
                    {
                        comboBoxSpace.SelectedIndex = 3;
                        StarCluster curr = Space[dataGridView1.SelectedCells[0].RowIndex] as StarCluster;
                        curr.Type = textBox1.Text;
                        Space[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Space[dataGridView1.SelectedCells[0].RowIndex] is Quasar)
                    {
                        comboBoxSpace.SelectedIndex = 5;
                        Quasar currQuasar = Space[dataGridView1.SelectedCells[0].RowIndex] as Quasar;
                        currQuasar.Weight = Convert.ToInt32(textBox1.Text);
                        currQuasar.LengthJet = Convert.ToInt32(textBox2.Text);
                        Space[dataGridView1.SelectedCells[0].RowIndex] = currQuasar;
                    }
                    else if (Space[dataGridView1.SelectedCells[0].RowIndex] is BlackHole)
                    {
                        comboBoxSpace.SelectedIndex = 4;
                        BlackHole curr = Space[dataGridView1.SelectedCells[0].RowIndex] as BlackHole;
                        curr.Weight = Convert.ToInt32(textBox1.Text);
                        Space[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    dataGridAndAllListsUpdate();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Выберите объект!");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FillTextBoxes()
        {
            textBoxName.Text = Space[dataGridView1.SelectedCells[0].RowIndex].Name;
            textBoxAge.Text = Convert.ToString(Space[dataGridView1.SelectedCells[0].RowIndex].Age);
            textBoxDiameter.Text = Convert.ToString(Space[dataGridView1.SelectedCells[0].RowIndex].Diameter);
            textBoxShine.Text = Convert.ToString(Space[dataGridView1.SelectedCells[0].RowIndex].Shine);
            textBoxDistance.Text = Convert.ToString(Space[dataGridView1.SelectedCells[0].RowIndex].Location.Distance);
            textBoxRedshift.Text = Convert.ToString(Space[dataGridView1.SelectedCells[0].RowIndex].Location.Redshift);

            comboBoxSpace.SelectedIndex = 0;
            if (Space[dataGridView1.SelectedCells[0].RowIndex] is Galaxy)
            {
                comboBoxSpace.SelectedIndex = 1;
                Galaxy curr = Space[dataGridView1.SelectedCells[0].RowIndex] as Galaxy;
                textBox1.Text = curr.Type;
                textBox2.Text = curr.Weight.ToString();
            }
            else if (Space[dataGridView1.SelectedCells[0].RowIndex] is Nebula)
            {
                comboBoxSpace.SelectedIndex = 2;
                Nebula curr = Space[dataGridView1.SelectedCells[0].RowIndex] as Nebula;

                textBox2.Text = curr.Composition;
            }
            else if (Space[dataGridView1.SelectedCells[0].RowIndex] is StarCluster)
            {
                comboBoxSpace.SelectedIndex = 3;
                StarCluster curr = Space[dataGridView1.SelectedCells[0].RowIndex] as StarCluster;
                textBox1.Text = curr.Type;
            }
            else if (Space[dataGridView1.SelectedCells[0].RowIndex] is Quasar)
            {
                comboBoxSpace.SelectedIndex = 5;
                Quasar currQuasar = Space[dataGridView1.SelectedCells[0].RowIndex] as Quasar;
                textBox1.Text = currQuasar.Weight.ToString();
                textBox2.Text = currQuasar.LengthJet.ToString();
            }
            else if (Space[dataGridView1.SelectedCells[0].RowIndex] is BlackHole)
            {
                comboBoxSpace.SelectedIndex = 4;
                BlackHole curr = Space[dataGridView1.SelectedCells[0].RowIndex] as BlackHole;
                textBox1.Text = curr.Weight.ToString();
            }
        }

        private void ShowDiameterShine()
        {
            listBoxInfo.Items.Add($"Диаметр: { Space[dataGridView1.SelectedCells[0].RowIndex].Diameter} св. лет");
            listBoxInfo.Items.Add($"Светимость: { Space[dataGridView1.SelectedCells[0].RowIndex].Shine} L⨀");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            listBoxInfo.Items.Clear();
            FillTextBoxes();
            try
            {
                listBoxInfo.Items.Add($"{ Space[dataGridView1.SelectedCells[0].RowIndex].Name}");
                
                if (Space[dataGridView1.SelectedCells[0].RowIndex] is Galaxy)
                {
                    Galaxy curr = Space[dataGridView1.SelectedCells[0].RowIndex] as Galaxy;
                    listBoxInfo.Items.Add("Объект: Галактика");
                    ShowDiameterShine();
                    listBoxInfo.Items.Add($"Тип: { curr.Type}");
                    listBoxInfo.Items.Add($"Масса: { curr.Weight} M⨀");
                }
                else if (Space[dataGridView1.SelectedCells[0].RowIndex] is Nebula)
                {
                    Nebula curr = Space[dataGridView1.SelectedCells[0].RowIndex] as Nebula;
                    listBoxInfo.Items.Add("Объект: Туманность");
                    ShowDiameterShine();
                    listBoxInfo.Items.Add($"Тип: { curr.Type}");
                    listBoxInfo.Items.Add($"Состав: { curr.Composition}");
                }
                else if (Space[dataGridView1.SelectedCells[0].RowIndex] is StarCluster)
                {
                    StarCluster curr = Space[dataGridView1.SelectedCells[0].RowIndex] as StarCluster;
                    listBoxInfo.Items.Add("Объект: Туманность");
                    ShowDiameterShine();
                    listBoxInfo.Items.Add($"Тип: { curr.Type}");

                }
                else if (Space[dataGridView1.SelectedCells[0].RowIndex] is Quasar)
                {
                    Quasar currQuasar = Space[dataGridView1.SelectedCells[0].RowIndex] as Quasar;
                    listBoxInfo.Items.Add("Объект: Квазар");
                    ShowDiameterShine();
                    listBoxInfo.Items.Add($"Масса: { currQuasar.Weight} M⨀");
                    listBoxInfo.Items.Add($"Длина джета: { currQuasar.LengthJet} св. лет");

                }
                else if (Space[dataGridView1.SelectedCells[0].RowIndex] is BlackHole)
                {
                    BlackHole curr = Space[dataGridView1.SelectedCells[0].RowIndex] as BlackHole;
                    listBoxInfo.Items.Add("Объект: Черная дыра");
                    ShowDiameterShine();
                    listBoxInfo.Items.Add($"Масса: { curr.Weight} M⨀");
                }
                else
                {
                    listBoxInfo.Items.Add("Объект: Дальний обьект космоса");
                }

            }
            catch
            {
                MessageBox.Show("Выберите объект!");
            }
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
