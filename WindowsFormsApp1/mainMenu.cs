using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Login;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class mainMenu : Form
    {
        private BindingList<Room> allRooms = new BindingList<Room>();
        private BindingList<Room> availableRooms = new BindingList<Room>();
        private Login login_form2 = null;
        private bool flagIsOpen = false;
        private bool isOrderOpen = false;
        public bool isPaymentOpen = false;
        private bool is_add_open = false;
        private addRoom addRoom1 = null;
        public bool PaymentForm_ConfirmButtonClicked { get; private set; }
        public void SaveListToFile(BindingList<Room> myList, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, myList);
            }
        }
        public string RoomInfo { get; set; }
        private void LoadListFromFile(string fileName)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    allRooms = (BindingList<Room>)binaryFormatter.Deserialize(fileStream);
                    if(allRooms != null)
                    {
                        dataGridViewRooms.DataSource = allRooms; // Rebind the data grid view
                        Room.set_generator(this.GetAllRooms().Count + 1);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"File not found: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public BindingList<Room> GetAllRooms()
        {
            return allRooms;
        }
        public BindingList<Room> GetAvailableRooms()
        {
            return availableRooms;
        }
        public void addRoom(Room newRoom)
        {
            allRooms.Add(newRoom);
            dataGridViewRooms.DataSource = allRooms;
        }
        public void updateAvailableRooms(Room newRoom)
        {
            availableRooms.Add(newRoom);
        }
        private Room is_selected = null;

        public mainMenu()
        {
            InitializeComponent();
            login_form2 = new Login();
            login_form2.Hide();
            SelectPanel.Height = LoginButton.Height;
            SelectPanel.Top = LoginButton.Top;
            this.login_form2.set_is_logged(false);
            dataGridViewRooms.DataSource = GetAllRooms();
            addRoom1 = new addRoom(this);
            this.Controls.Add(addRoom1);
            this.addRoom1.Visible = false;
            this.addRoom1.Location = new System.Drawing.Point(334, 50);
            this.addRoom1.Size = new System.Drawing.Size(770, 680);
            Payment payment1 = new Payment();
            payment1.Visible = false;
            this.Controls.Add(payment1);
            this.addRoom1.TabIndex = 7;
            OrderStatus();
            dataGridViewRooms.SelectionChanged += DataGridViewRooms_SelectionChanged;
            this.richTextBox1.Hide();
            this.label1.Hide();
            this.pictureBoxRoom.Hide();
        }

        public DataGridView get_grid()
        {
            return this.dataGridViewRooms;
        }
        private void DataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            ShowRoomPrice();
            if (this.dataGridViewRooms.SelectedRows.Count > 0)
            {
                this.is_selected = this.allRooms[this.dataGridViewRooms.SelectedRows[0].Index];
                this.richTextBox1.Text = this.is_selected.info().ToString();
                if (this.is_selected.roominfo != null)
                {
                    this.richTextBox1.AppendText(this.is_selected.roominfo);
                }
            }

            if (this.is_selected.GetType().Name.ToString() == "Suite")
            {
                pictureBoxRoom.Image = Properties.Resources.IC_Maldives_Desktop;
            }
            else if (this.is_selected.GetType().Name.ToString() == "Penthouse")
            {
                pictureBoxRoom.Image = Properties.Resources.Movie_Room;
            }
            else
                pictureBoxRoom.Image = Properties.Resources.Regular_Room;

        }
        private void mainMenu_Load(object sender, EventArgs e)
        {
            this.dataGridViewRooms.DataSource = this.allRooms;
            this.dataGridViewRooms.Hide();
            this.LoadListFromFile("myData.bin");
        }
        public void refreshDataGrid()
        {
            this.dataGridViewRooms.DataSource = null;
            this.dataGridViewRooms.DataSource = allRooms;
        }
        private void Log_Out_Button_Click(object sender, EventArgs e)
        {
            if (this.login_form2.get_is_logged() == false)
            {
                MessageBox.Show("You are not logged in.");
            }
            else
            {
                this.login_form2.set_is_logged(false);
                MessageBox.Show("Logged out successfully !");
            }
        }
            private void button1_Click_1(object sender, EventArgs e)
        {
            this.refreshDataGrid();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Any edit will be saved.");
            this.SaveListToFile(this.allRooms, "myData.bin");
            this.Close();
        }
        private void NewRoombutton_Click(object sender, EventArgs e)
        {
            this.dataGridViewRooms.Hide();
            if (this.login_form2.get_is_logged() == false)
                MessageBox.Show("Can't access without login");
            else
            {
                SelectPanel.Height = NewRoombutton.Height;
                SelectPanel.Top = NewRoombutton.Top;
                if (this.is_add_open == false)
                {
                    this.addRoom1.Visible = true;
                    this.is_add_open = true;
                }
                else
                {
                    this.addRoom1.Visible = false;
                    this.is_add_open = false;
                }
            }
        }

        private void ShowButton_Click_1(object sender, EventArgs e)
        {
            this.SelectRoomButton.Hide();
            this.Costlable.Hide();
            this.TotalPrice.Hide();
            if (this.login_form2.get_is_logged() == false)
                MessageBox.Show("Can't access without login");
            else
            {
                this.addRoom1.Hide();
                this.dataGridViewRooms.Hide();
                SelectPanel.Height = ShowButton.Height;
                SelectPanel.Top = ShowButton.Top;
                if (this.flagIsOpen == false)
                {
                    this.addRoom1.Hide();
                    this.login_form2.Hide();
                    this.dataGridViewRooms.DataSource = GetAllRooms();
                    this.dataGridViewRooms.Show();
                    flagIsOpen = true;
                    this.dataGridViewRooms.Columns[3].Visible = true;
                    this.richTextBox1.Show();
                    this.pictureBoxRoom.Show();
                }
                else
                {
                    this.dataGridViewRooms.Hide();
                    flagIsOpen = false;
                    this.richTextBox1.Hide();
                    this.pictureBoxRoom.Hide();
                }
            }
            if (this.flagIsOpen)
            {
                if (this.is_selected.isAvailable)//deletes order info if room available again
                {
                    this.is_selected.roominfo = "";
                    refreshDataGrid();
                }
                this.richTextBox1.Show();
                this.label1.Show();
            }
            else
            {
                this.richTextBox1.Hide();
                this.label1.Hide();
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = RemoveButton.Height;
            SelectPanel.Top = RemoveButton.Top;
            if(this.dataGridViewRooms.SelectedRows.Count > 0)
            {
                if (this.login_form2.get_is_logged() == true && flagIsOpen == true)
                {
                    if (this.is_selected != null)
                    {
                        this.allRooms.Remove(this.is_selected);
                        this.refreshDataGrid();
                    }
                    else
                        MessageBox.Show("Please select a room.");
                }
                else
                {
                    if (this.login_form2.get_is_logged() == false)
                        MessageBox.Show("Can't access without login");
                    else
                        MessageBox.Show("Please use the rooms list in the show rooms button");

                }
            }
            else
            {
                MessageBox.Show("No rooms left in the hotel.");
            }
        }
        public void OrderStatus()
        {
            if (isOrderOpen == false)
            {
                Costlable.Hide();
                SelectRoomButton.Hide();
                TotalPrice.Hide();
            }
            else
            {
                Costlable.Show();
                SelectRoomButton.Show();
                TotalPrice.Show();
            }
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            SelectPanel.Height = OrderButton.Height;
            SelectPanel.Top = OrderButton.Top;
            if (!isOrderOpen)
            {
                this.SelectRoomButton.Show();
                this.Costlable.Show();
                this.TotalPrice.Show();
                this.pictureBoxRoom.Show();
                List<Room> availableRoomsList = new List<Room>();

                foreach (Room room in allRooms)
                {
                    if (room.isAvailable)
                    {
                        availableRoomsList.Add(room);
                    }
                }
                dataGridViewRooms.DataSource = availableRoomsList;
                dataGridViewRooms.Columns[3].Visible = false;

                dataGridViewRooms.Show();
                this.richTextBox1.Show();
                this.label1.Show();
                isOrderOpen = true;
                OrderStatus();
                // Select the first row if there are available rooms
                if (dataGridViewRooms.Rows.Count > 0)
                {
                    dataGridViewRooms.Rows[0].Selected = true;
                    ShowRoomPrice();
                }
            }
            else
            {
                this.SelectRoomButton.Hide();
                this.Costlable.Hide();
                this.TotalPrice.Hide();
                this.label1.Hide();
                this.richTextBox1.Hide();
                this.pictureBoxRoom.Hide();
                dataGridViewRooms.Hide();
                isOrderOpen = false;
                TotalPrice.Text = string.Empty;
                SelectRoomButton.Enabled = false;
                OrderStatus();
            }           
        }

        public void ShowRoomPrice()
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                Room selectedRoom = dataGridViewRooms.SelectedRows[0].DataBoundItem as Room;
                if (selectedRoom != null)
                {
                    Costlable.Text = selectedRoom.cost.ToString();
                    TotalPrice.Text = ("Total price:");
                    SelectRoomButton.Enabled = true;
                }
            }
            else
            {
                TotalPrice.Text = string.Empty;
                Costlable.Text = string.Empty;
                SelectRoomButton.Enabled = false;
            }
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool is_login_open = false;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(this.is_login_open == true)
            {
                this.login_form2.Hide();
                this.is_login_open = false;
            }
            else
            {
                if (this.login_form2.get_is_logged() == true)
                {
                    MessageBox.Show("You are already logged in.");
                }
                else
                {
                    this.is_login_open = true;
                    this.login_form2.Show();
                }
            }
        }

        private void SelectPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataGridViewRooms.SelectedRows.Count > 0)
            {
                this.is_selected = this.allRooms[this.dataGridViewRooms.SelectedRows[0].Index];
            }
        }

        private void TotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void Costlable_Click(object sender, EventArgs e)
        {

        }

        private void SelectRoomButton_Click(object sender, EventArgs e)
        {           
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                Room selectedRoom = dataGridViewRooms.SelectedRows[0].DataBoundItem as Room;
                if (selectedRoom != null)
                {
                    Payment payment1 = this.Controls.OfType<Payment>().FirstOrDefault(); 
                    payment1.set_main_menu_ref(this);
                    if (payment1 == null)
                    {
                        this.isPaymentOpen = true;
                        payment1.Location = new System.Drawing.Point(334, 50);
                        payment1.Size = new System.Drawing.Size(770, 680);
                        this.Controls.Add(payment1);
                    }
    
                    // Set the selected room in the Payment user control
                    payment1.SelectedRoom = selectedRoom;
                    payment1.Visible = true;
                    payment1.BringToFront();
                    isOrderOpen = true;
                }
                else
                {
                    MessageBox.Show("Invalid room chosen.");
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SaveListToFile(this.allRooms, "myData.bin");
            MessageBox.Show("Saved!");
        }

        private void pictureBoxRoom_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

