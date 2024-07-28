
namespace WindowsFormsApp1
{
    partial class mainMenu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAvailableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Log_Out_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SelectPanel = new System.Windows.Forms.Panel();
            this.OrderButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.NewRoombutton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Costlable = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectRoomButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AllowUserToAddRows = false;
            this.dataGridViewRooms.AllowUserToDeleteRows = false;
            this.dataGridViewRooms.AutoGenerateColumns = false;
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.maxPeopleDataGridViewTextBoxColumn,
            this.isAvailableDataGridViewCheckBoxColumn});
            this.dataGridViewRooms.DataSource = this.roomBindingSource1;
            this.dataGridViewRooms.Location = new System.Drawing.Point(501, 82);
            this.dataGridViewRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRooms.MultiSelect = false;
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 62;
            this.dataGridViewRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRooms.Size = new System.Drawing.Size(816, 305);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellContentClick);
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "roomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room number";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Price";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // maxPeopleDataGridViewTextBoxColumn
            // 
            this.maxPeopleDataGridViewTextBoxColumn.DataPropertyName = "maxPeople";
            this.maxPeopleDataGridViewTextBoxColumn.HeaderText = "Maximum people";
            this.maxPeopleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxPeopleDataGridViewTextBoxColumn.Name = "maxPeopleDataGridViewTextBoxColumn";
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            this.isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "isAvailable";
            this.isAvailableDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.isAvailableDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            // 
            // roomBindingSource1
            // 
            this.roomBindingSource1.DataSource = typeof(WindowsFormsApp1.Room);
            // 
            // Log_Out_Button
            // 
            this.Log_Out_Button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Log_Out_Button.Location = new System.Drawing.Point(219, 888);
            this.Log_Out_Button.Name = "Log_Out_Button";
            this.Log_Out_Button.Size = new System.Drawing.Size(100, 37);
            this.Log_Out_Button.TabIndex = 5;
            this.Log_Out_Button.Text = "Log Out";
            this.Log_Out_Button.UseVisualStyleBackColor = true;
            this.Log_Out_Button.Click += new System.EventHandler(this.Log_Out_Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(828, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "All rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SidePanel.Controls.Add(this.SelectPanel);
            this.SidePanel.Controls.Add(this.OrderButton);
            this.SidePanel.Controls.Add(this.LoginButton);
            this.SidePanel.Controls.Add(this.ShowButton);
            this.SidePanel.Controls.Add(this.NewRoombutton);
            this.SidePanel.Controls.Add(this.RemoveButton);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(213, 938);
            this.SidePanel.TabIndex = 14;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // SelectPanel
            // 
            this.SelectPanel.BackColor = System.Drawing.Color.Tan;
            this.SelectPanel.Location = new System.Drawing.Point(0, 82);
            this.SelectPanel.Name = "SelectPanel";
            this.SelectPanel.Size = new System.Drawing.Size(10, 57);
            this.SelectPanel.TabIndex = 17;
            this.SelectPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectPanel_Paint);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OrderButton.Location = new System.Drawing.Point(0, 612);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(213, 57);
            this.OrderButton.TabIndex = 9;
            this.OrderButton.Text = "Order room";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Location = new System.Drawing.Point(0, 789);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(213, 57);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ShowButton.Location = new System.Drawing.Point(0, 82);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(213, 57);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Show rooms";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click_1);
            // 
            // NewRoombutton
            // 
            this.NewRoombutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.NewRoombutton.FlatAppearance.BorderSize = 0;
            this.NewRoombutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRoombutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRoombutton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NewRoombutton.Location = new System.Drawing.Point(-4, 258);
            this.NewRoombutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewRoombutton.Name = "NewRoombutton";
            this.NewRoombutton.Size = new System.Drawing.Size(213, 57);
            this.NewRoombutton.TabIndex = 6;
            this.NewRoombutton.Text = "Add room";
            this.NewRoombutton.UseVisualStyleBackColor = false;
            this.NewRoombutton.Click += new System.EventHandler(this.NewRoombutton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RemoveButton.Location = new System.Drawing.Point(-4, 435);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(213, 57);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove room";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(213, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1387, 9);
            this.TopPanel.TabIndex = 15;
            // 
            // Costlable
            // 
            this.Costlable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Costlable.Location = new System.Drawing.Point(914, 894);
            this.Costlable.Name = "Costlable";
            this.Costlable.Size = new System.Drawing.Size(100, 23);
            this.Costlable.TabIndex = 21;
            this.Costlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Costlable.Click += new System.EventHandler(this.Costlable_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalPrice.Location = new System.Drawing.Point(788, 894);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(100, 23);
            this.TotalPrice.TabIndex = 20;
            this.TotalPrice.Text = "Total Cost:";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TotalPrice.Click += new System.EventHandler(this.TotalPrice_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close_97px;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.Location = new System.Drawing.Point(1557, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(44, 46);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Hotel_Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(286, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SelectRoomButton
            // 
            this.SelectRoomButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SelectRoomButton.Location = new System.Drawing.Point(1054, 888);
            this.SelectRoomButton.Name = "SelectRoomButton";
            this.SelectRoomButton.Size = new System.Drawing.Size(136, 37);
            this.SelectRoomButton.TabIndex = 22;
            this.SelectRoomButton.Text = "Select Room";
            this.SelectRoomButton.UseVisualStyleBackColor = true;
            this.SelectRoomButton.Click += new System.EventHandler(this.SelectRoomButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(213, 515);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1388, 365);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(788, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 51);
            this.label1.TabIndex = 24;
            this.label1.Text = "More about room:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 889);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.BackColor = System.Drawing.Color.White;
            this.pictureBoxRoom.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.IC_Maldives_Desktop;
            this.pictureBoxRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRoom.Location = new System.Drawing.Point(1104, 538);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(484, 318);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoom.TabIndex = 26;
            this.pictureBoxRoom.TabStop = false;
            this.pictureBoxRoom.Click += new System.EventHandler(this.pictureBoxRoom_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(WindowsFormsApp1.Room);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.My_project;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 938);
            this.Controls.Add(this.pictureBoxRoom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectRoomButton);
            this.Controls.Add(this.Costlable);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Log_Out_Button);
            this.Controls.Add(this.dataGridViewRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource1)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button Log_Out_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button NewRoombutton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel SelectPanel;
        private System.Windows.Forms.Label Costlable;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button SelectRoomButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
    }
}