
namespace WindowsFormsApp1
{
    partial class addRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Room_Type_label = new System.Windows.Forms.Label();
            this.comboBoxRT = new System.Windows.Forms.ComboBox();
            this.comboBoxLuxury = new System.Windows.Forms.ComboBox();
            this.Luxurylabel = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.comboBoxMP = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PoolType = new System.Windows.Forms.Label();
            this.roomService = new System.Windows.Forms.Label();
            this.RoomS = new System.Windows.Forms.CheckBox();
            this.PoolCombo = new System.Windows.Forms.ComboBox();
            this.Movielabel = new System.Windows.Forms.Label();
            this.Chef = new System.Windows.Forms.Label();
            this.checkBoxMovie = new System.Windows.Forms.CheckBox();
            this.checkBoxChef = new System.Windows.Forms.CheckBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.Costlable = new System.Windows.Forms.Label();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.ViewLabel = new System.Windows.Forms.Label();
            this.HottubLabel = new System.Windows.Forms.Label();
            this.HottubCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add room form:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Room_Type_label
            // 
            this.Room_Type_label.AutoSize = true;
            this.Room_Type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_Type_label.Location = new System.Drawing.Point(3, 127);
            this.Room_Type_label.Name = "Room_Type_label";
            this.Room_Type_label.Size = new System.Drawing.Size(135, 29);
            this.Room_Type_label.TabIndex = 2;
            this.Room_Type_label.Text = "Room type:";
            this.Room_Type_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRT
            // 
            this.comboBoxRT.FormattingEnabled = true;
            this.comboBoxRT.Items.AddRange(new object[] {
            "Regular",
            "Luxury"});
            this.comboBoxRT.Location = new System.Drawing.Point(249, 127);
            this.comboBoxRT.Name = "comboBoxRT";
            this.comboBoxRT.Size = new System.Drawing.Size(145, 28);
            this.comboBoxRT.TabIndex = 3;
            this.comboBoxRT.SelectedIndexChanged += new System.EventHandler(this.comboBoxRT_SelectedIndexChanged);
            // 
            // comboBoxLuxury
            // 
            this.comboBoxLuxury.FormattingEnabled = true;
            this.comboBoxLuxury.Items.AddRange(new object[] {
            "Suite",
            "Penthouse"});
            this.comboBoxLuxury.Location = new System.Drawing.Point(249, 248);
            this.comboBoxLuxury.Name = "comboBoxLuxury";
            this.comboBoxLuxury.Size = new System.Drawing.Size(145, 28);
            this.comboBoxLuxury.TabIndex = 4;
            this.comboBoxLuxury.SelectedIndexChanged += new System.EventHandler(this.comboBoxLuxury_SelectedIndexChanged);
            // 
            // Luxurylabel
            // 
            this.Luxurylabel.AutoSize = true;
            this.Luxurylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luxurylabel.Location = new System.Drawing.Point(1, 244);
            this.Luxurylabel.Name = "Luxurylabel";
            this.Luxurylabel.Size = new System.Drawing.Size(88, 29);
            this.Luxurylabel.TabIndex = 5;
            this.Luxurylabel.Text = "Luxury:";
            this.Luxurylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Luxurylabel.Click += new System.EventHandler(this.Luxurylabel_Click);
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMP.Location = new System.Drawing.Point(1, 188);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(147, 29);
            this.labelMP.TabIndex = 6;
            this.labelMP.Text = "Max People:";
            this.labelMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMP
            // 
            this.comboBoxMP.FormattingEnabled = true;
            this.comboBoxMP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxMP.Location = new System.Drawing.Point(249, 188);
            this.comboBoxMP.Name = "comboBoxMP";
            this.comboBoxMP.Size = new System.Drawing.Size(145, 28);
            this.comboBoxMP.TabIndex = 8;
            this.comboBoxMP.SelectedIndexChanged += new System.EventHandler(this.comboBoxMP_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PoolType
            // 
            this.PoolType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoolType.Location = new System.Drawing.Point(-16, 302);
            this.PoolType.Name = "PoolType";
            this.PoolType.Size = new System.Drawing.Size(164, 40);
            this.PoolType.TabIndex = 9;
            this.PoolType.Text = "Pool Type:";
            this.PoolType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PoolType.Click += new System.EventHandler(this.PoolType_Click);
            // 
            // roomService
            // 
            this.roomService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomService.Location = new System.Drawing.Point(0, 355);
            this.roomService.Name = "roomService";
            this.roomService.Size = new System.Drawing.Size(174, 46);
            this.roomService.TabIndex = 10;
            this.roomService.Text = "Room service:";
            this.roomService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomS
            // 
            this.RoomS.AutoSize = true;
            this.RoomS.Location = new System.Drawing.Point(326, 372);
            this.RoomS.Name = "RoomS";
            this.RoomS.Size = new System.Drawing.Size(22, 21);
            this.RoomS.TabIndex = 11;
            this.RoomS.UseVisualStyleBackColor = true;
            this.RoomS.CheckedChanged += new System.EventHandler(this.RoomS_CheckedChanged);
            // 
            // PoolCombo
            // 
            this.PoolCombo.FormattingEnabled = true;
            this.PoolCombo.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.PoolCombo.Location = new System.Drawing.Point(249, 308);
            this.PoolCombo.Name = "PoolCombo";
            this.PoolCombo.Size = new System.Drawing.Size(145, 28);
            this.PoolCombo.TabIndex = 12;
            this.PoolCombo.SelectedIndexChanged += new System.EventHandler(this.PoolCombo_SelectedIndexChanged);
            // 
            // Movielabel
            // 
            this.Movielabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movielabel.Location = new System.Drawing.Point(-8, 412);
            this.Movielabel.Name = "Movielabel";
            this.Movielabel.Size = new System.Drawing.Size(182, 28);
            this.Movielabel.TabIndex = 13;
            this.Movielabel.Text = "Movie theater:";
            this.Movielabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chef
            // 
            this.Chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chef.Location = new System.Drawing.Point(1, 405);
            this.Chef.Name = "Chef";
            this.Chef.Size = new System.Drawing.Size(135, 42);
            this.Chef.TabIndex = 14;
            this.Chef.Text = "Chef meal:";
            this.Chef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMovie
            // 
            this.checkBoxMovie.AutoSize = true;
            this.checkBoxMovie.Location = new System.Drawing.Point(326, 424);
            this.checkBoxMovie.Name = "checkBoxMovie";
            this.checkBoxMovie.Size = new System.Drawing.Size(22, 21);
            this.checkBoxMovie.TabIndex = 15;
            this.checkBoxMovie.UseVisualStyleBackColor = true;
            this.checkBoxMovie.CheckedChanged += new System.EventHandler(this.checkBoxMovie_CheckedChanged);
            // 
            // checkBoxChef
            // 
            this.checkBoxChef.AutoSize = true;
            this.checkBoxChef.Location = new System.Drawing.Point(326, 424);
            this.checkBoxChef.Name = "checkBoxChef";
            this.checkBoxChef.Size = new System.Drawing.Size(22, 21);
            this.checkBoxChef.TabIndex = 16;
            this.checkBoxChef.UseVisualStyleBackColor = true;
            this.checkBoxChef.CheckedChanged += new System.EventHandler(this.checkBoxChef_CheckedChanged);
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalPrice.Location = new System.Drawing.Point(6, 533);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(100, 23);
            this.TotalPrice.TabIndex = 17;
            this.TotalPrice.Text = "Total Cost:";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Costlable
            // 
            this.Costlable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Costlable.Location = new System.Drawing.Point(131, 533);
            this.Costlable.Name = "Costlable";
            this.Costlable.Size = new System.Drawing.Size(100, 23);
            this.Costlable.TabIndex = 18;
            this.Costlable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Costlable.Click += new System.EventHandler(this.Costlable_Click);
            // 
            // comboBoxView
            // 
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "Ocean view",
            "Pool view"});
            this.comboBoxView.Location = new System.Drawing.Point(249, 251);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(145, 28);
            this.comboBoxView.TabIndex = 20;
            // 
            // ViewLabel
            // 
            this.ViewLabel.AutoSize = true;
            this.ViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLabel.Location = new System.Drawing.Point(3, 247);
            this.ViewLabel.Name = "ViewLabel";
            this.ViewLabel.Size = new System.Drawing.Size(123, 29);
            this.ViewLabel.TabIndex = 19;
            this.ViewLabel.Text = "View type:";
            this.ViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HottubLabel
            // 
            this.HottubLabel.AutoSize = true;
            this.HottubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HottubLabel.Location = new System.Drawing.Point(5, 308);
            this.HottubLabel.Name = "HottubLabel";
            this.HottubLabel.Size = new System.Drawing.Size(95, 29);
            this.HottubLabel.TabIndex = 21;
            this.HottubLabel.Text = "Hot tub:";
            this.HottubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HottubLabel.Click += new System.EventHandler(this.HottubLabel_Click);
            // 
            // HottubCheckBox
            // 
            this.HottubCheckBox.AutoSize = true;
            this.HottubCheckBox.Location = new System.Drawing.Point(326, 316);
            this.HottubCheckBox.Name = "HottubCheckBox";
            this.HottubCheckBox.Size = new System.Drawing.Size(22, 21);
            this.HottubCheckBox.TabIndex = 23;
            this.HottubCheckBox.UseVisualStyleBackColor = true;
            this.HottubCheckBox.CheckedChanged += new System.EventHandler(this.HottubCheckBox_CheckedChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmButton.Location = new System.Drawing.Point(401, 526);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(116, 36);
            this.ConfirmButton.TabIndex = 24;
            this.ConfirmButton.Text = "Confirm room";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // addRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.checkBoxChef);
            this.Controls.Add(this.checkBoxMovie);
            this.Controls.Add(this.Chef);
            this.Controls.Add(this.Movielabel);
            this.Controls.Add(this.PoolCombo);
            this.Controls.Add(this.RoomS);
            this.Controls.Add(this.roomService);
            this.Controls.Add(this.PoolType);
            this.Controls.Add(this.Luxurylabel);
            this.Controls.Add(this.comboBoxLuxury);
            this.Controls.Add(this.HottubCheckBox);
            this.Controls.Add(this.HottubLabel);
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.ViewLabel);
            this.Controls.Add(this.Costlable);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.comboBoxMP);
            this.Controls.Add(this.labelMP);
            this.Controls.Add(this.comboBoxRT);
            this.Controls.Add(this.Room_Type_label);
            this.Controls.Add(this.label1);
            this.Name = "addRoom";
            this.Size = new System.Drawing.Size(520, 565);
            this.Load += new System.EventHandler(this.addRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Room_Type_label;
        private System.Windows.Forms.ComboBox comboBoxRT;
        private System.Windows.Forms.ComboBox comboBoxLuxury;
        private System.Windows.Forms.Label Luxurylabel;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.ComboBox comboBoxMP;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label PoolType;
        private System.Windows.Forms.Label roomService;
        private System.Windows.Forms.CheckBox RoomS;
        private System.Windows.Forms.ComboBox PoolCombo;
        private System.Windows.Forms.Label Movielabel;
        private System.Windows.Forms.Label Chef;
        private System.Windows.Forms.CheckBox checkBoxMovie;
        private System.Windows.Forms.CheckBox checkBoxChef;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label Costlable;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.Label ViewLabel;
        private System.Windows.Forms.Label HottubLabel;
        private System.Windows.Forms.CheckBox HottubCheckBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
