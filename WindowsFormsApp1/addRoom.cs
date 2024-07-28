using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addRoom : UserControl
    {
        private mainMenu _main_form = null;
        private double cost = 0;
        public BindingList<Room> GetRooms()
        {
            return _main_form.GetAllRooms();
        }        
        public addRoom(mainMenu main_form)
        {
            InitializeComponent();
            this._main_form = main_form;
            this.HottubCheckBox.Visible = false;
            this.HottubLabel.Visible = false;
            this.comboBoxLuxury.Visible = false;
            this.ViewLabel.Visible = false;
            this.comboBoxView.Visible = false;
            this.Luxurylabel.Visible = false;
            this.roomService.Visible = false;
            this.RoomS.Visible = false;
            this.PoolType.Visible = false;
            this.PoolCombo.Visible = false;
            this.checkBoxMovie.Visible = false;
            this.Movielabel.Visible = false;
            this.checkBoxChef.Visible = false;
            this.Chef.Visible = false;
        }

        private void addRoom_Load(object sender, EventArgs e)
        {

        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Room newRoom = null;
            switch (this.comboBoxRT.Text)
            {
                case "Regular":
                      Regular regularRoom = new Regular(double.Parse(this.Costlable.Text), int.Parse(this.comboBoxMP.Text), this.comboBoxView.Text, this.HottubCheckBox.Checked /*== true*/);
                    newRoom = regularRoom;
                    break;
                case "Luxury":
                    if (this.comboBoxLuxury.Text == "Suite")
                    {
                        Suite suiteRoom = new Suite(double.Parse(this.Costlable.Text), int.Parse(this.comboBoxMP.Text), this.PoolCombo.Text, this.RoomS.Checked, this.checkBoxChef.Checked);
                        newRoom = suiteRoom;
                    }
                    else if (this.comboBoxLuxury.Text == "Penthouse")
                    {
                        Penthouse penthouseRoom = new Penthouse(double.Parse(this.Costlable.Text), int.Parse(this.comboBoxMP.Text), this.PoolCombo.Text, this.RoomS.Checked, this.checkBoxMovie.Checked);
                        newRoom = penthouseRoom;
                    }
                    break;
                default:
                    MessageBox.Show("Invalid room type selected.");
                    break;
            }
            this._main_form.GetAllRooms().Add(newRoom);
            this._main_form.refreshDataGrid();
            Clear();
            this.Hide();
            MessageBox.Show("Added successfully !");
        }
        public void Clear()
        {//Edit
            this.comboBoxRT.SelectedIndex = -1;
            this.comboBoxMP.SelectedIndex = -1;
            this.comboBoxLuxury.SelectedIndex = -1;
            this.comboBoxView.SelectedIndex = -1;
            this.PoolCombo.SelectedIndex = -1;
            this.HottubCheckBox.Checked = false;
            this.HottubCheckBox.Visible = false;
            this.HottubLabel.Visible = false;
            this.comboBoxView.Visible = false;
            this.ViewLabel.Visible = false;
            this.RoomS.Checked = false;
            this.checkBoxMovie.Checked = false;
            this.checkBoxChef.Checked = false;
            this.comboBoxLuxury.Visible = false;
            this.Luxurylabel.Visible = false;
            this.roomService.Visible = false;
            this.RoomS.Visible = false;
            this.PoolType.Visible = false;
            this.PoolCombo.Visible = false;
            this.checkBoxMovie.Visible = false;
            this.Movielabel.Visible = false;
            this.checkBoxChef.Visible = false;
            this.Chef.Visible = false;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLuxury_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCost();
            if (this.comboBoxLuxury.Text == "Suite")
            {
                this.comboBoxView.SelectedIndex = -1;
                this.PoolCombo.SelectedIndex = -1;
                this.checkBoxChef.Visible = true;
                this.Chef.Visible = true;
                this.Movielabel.Visible = false;
                this.checkBoxMovie.Visible = false;
                this.cost = 800;
            }
            else if (this.comboBoxLuxury.Text == "Penthouse")
            {
                this.comboBoxView.SelectedIndex = -1;
                this.PoolCombo.SelectedIndex = -1;
                this.Movielabel.Visible = true;
                this.checkBoxMovie.Visible = true;
                this.checkBoxChef.Visible = false;
                this.Chef.Visible = false;
                this.cost = 700;
            }
        }

        private void comboBoxRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxRT.Text == "Luxury")
            {
                this.comboBoxMP.SelectedIndex = -1;
                this.comboBoxLuxury.SelectedIndex = -1;
                this.comboBoxView.SelectedIndex = -1;
                this.PoolCombo.SelectedIndex = -1;
                this.HottubCheckBox.Checked = false;
                this.HottubCheckBox.Visible = false;
                this.HottubLabel.Visible = false;
                this.comboBoxView.Visible = false;
                this.ViewLabel.Visible = false;
                this.Luxurylabel.Visible = true;
                this.comboBoxLuxury.Visible = true;
                this.roomService.Visible = true;
                this.RoomS.Visible = true;
                this.PoolType.Visible = true;
                this.PoolCombo.Visible = true;
                this.Costlable.Text = cost.ToString();
            }
            else if (this.comboBoxRT.Text == "Regular")
            {
                this.comboBoxMP.SelectedIndex = -1;
                this.comboBoxLuxury.SelectedIndex = -1;
                this.comboBoxView.SelectedIndex = -1;
                this.PoolCombo.SelectedIndex = -1;
                this.HottubCheckBox.Visible = true;
                this.HottubLabel.Visible = true;
                this.comboBoxView.Visible = true;
                this.ViewLabel.Visible = true;
                this.Luxurylabel.Visible = false;
                this.comboBoxLuxury.Visible = false;
                this.roomService.Visible = false;
                this.RoomS.Visible = false;
                this.PoolType.Visible = false;
                this.PoolCombo.Visible = false;
                this.checkBoxChef.Visible = false;
                this.Chef.Visible = false;
                this.Movielabel.Visible = false;
                this.checkBoxMovie.Visible = false;
                this.cost = 200;
                this.Costlable.Text = cost.ToString();
            }
        }

        private void comboBoxMP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PoolType_Click(object sender, EventArgs e)
        {

        }

        private void PoolCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }
        private void UpdateCost()
        {
            cost = 0;

            if (this.comboBoxRT.Text == "Regular")
            {
                cost = 200;
            }
            else if (this.comboBoxRT.Text == "Luxury")
            {
                if (this.comboBoxLuxury.Text == "Suite")
                {
                    cost = 800;
                }
                else if (this.comboBoxLuxury.Text == "Penthouse")
                {
                    cost = 700;
                }
            }

            if (this.PoolCombo.Text == "Small")
            {
                cost += 1000;
            }
            else if (this.PoolCombo.Text == "Medium")
            {
                cost += 1100;
            }
            else if (this.PoolCombo.Text == "Big")
            {
                cost += 1200;
            }

            if (this.RoomS.Checked)
            {
                cost += 100;
            }

            if (this.checkBoxMovie.Checked)
            {
                cost += 1400;
            }

            if (this.checkBoxChef.Checked)
            {
                cost += 1500;
            }

            this.Costlable.Text = cost.ToString();
        }







        private void RoomS_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void checkBoxMovie_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void checkBoxChef_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }
        private void Costlable_Click(object sender, EventArgs e)
        {

        }
        private void Luxurylabel_Click(object sender, EventArgs e)
        {

        }
        private void HottubLabel_Click(object sender, EventArgs e)
        {

        }
        private void HottubCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

