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
    public partial class Payment : UserControl
    {
        public Room SelectedRoom { get; set; }
        private mainMenu main_menu_ref = null;
        public bool ConfirmButtonClicked { get; internal set; }
        public Payment()
        {
            InitializeComponent();
        }
        public void set_main_menu_ref(mainMenu main_ref)
        {
            this.main_menu_ref = main_ref;
        }
        public Payment(Room OrderedRoom)
        {
            InitializeComponent();
        }
        public void ClearPayment()
        {
            this.textBoxName.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxID.Text = "";
            this.textBoxCard.Text = "";
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearPayment();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string info = "";
            ConfirmButtonClicked = true;
            if(textBoxCard.Text != "" && textBoxID.Text != "" && textBoxName.Text != "" & textBoxPhone.Text != "")
            {
                string confirmationMessage = ($"Are you sure you want to order room number {this.SelectedRoom.roomNumber} at the total price of {this.SelectedRoom.cost} NIS?");
                DialogResult result = MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.main_menu_ref.isPaymentOpen = false;
                    this.SelectedRoom.isAvailable = false;
                    this.main_menu_ref.refreshDataGrid();
                    MessageBox.Show("Room ordered successfully!");
                    info = $"\n\nThis room is taken by " + textBoxName.Text.ToString() + "\nID number: " + textBoxID.Text.ToString() + "\nPhone number: " + textBoxPhone.Text.ToString();
                    this.SelectedRoom.roominfo = info;
                    this.SelectedRoom = null;
                    this.main_menu_ref.refreshDataGrid();
                }
                else
                {
                    ClearPayment();
                }
                this.Visible = false;
                ClearPayment();
            }
            else
            {
                MessageBox.Show("One or more fields missing.");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearPayment();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClearPayment();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


