namespace RoomBooking.WinFormsUI
{
    partial class frmReservationEdit
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txbGuestName = new System.Windows.Forms.TextBox();
            this.lblGuestLastName = new System.Windows.Forms.Label();
            this.txbGuestLastName = new System.Windows.Forms.TextBox();
            this.lblTCIdNo = new System.Windows.Forms.Label();
            this.txbTCIdNo = new System.Windows.Forms.TextBox();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.dteDateIn = new DevExpress.XtraEditors.DateEdit();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.dteDateOut = new DevExpress.XtraEditors.DateEdit();
            this.btnReservationAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRoomSelect = new System.Windows.Forms.Label();
            this.dgwEmptyRooms = new System.Windows.Forms.DataGridView();
            this.btnUsableRooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateIn.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateOut.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmptyRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.Location = new System.Drawing.Point(381, 46);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(96, 20);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Müşteri Adı :";
            // 
            // txbGuestName
            // 
            this.txbGuestName.Location = new System.Drawing.Point(508, 46);
            this.txbGuestName.Name = "txbGuestName";
            this.txbGuestName.Size = new System.Drawing.Size(127, 20);
            this.txbGuestName.TabIndex = 1;
            // 
            // lblGuestLastName
            // 
            this.lblGuestLastName.AutoSize = true;
            this.lblGuestLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestLastName.Location = new System.Drawing.Point(381, 83);
            this.lblGuestLastName.Name = "lblGuestLastName";
            this.lblGuestLastName.Size = new System.Drawing.Size(121, 20);
            this.lblGuestLastName.TabIndex = 0;
            this.lblGuestLastName.Text = "Müşteri Soyadı :";
            // 
            // txbGuestLastName
            // 
            this.txbGuestLastName.Location = new System.Drawing.Point(508, 83);
            this.txbGuestLastName.Name = "txbGuestLastName";
            this.txbGuestLastName.Size = new System.Drawing.Size(127, 20);
            this.txbGuestLastName.TabIndex = 2;
            // 
            // lblTCIdNo
            // 
            this.lblTCIdNo.AutoSize = true;
            this.lblTCIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCIdNo.Location = new System.Drawing.Point(381, 7);
            this.lblTCIdNo.Name = "lblTCIdNo";
            this.lblTCIdNo.Size = new System.Drawing.Size(105, 20);
            this.lblTCIdNo.TabIndex = 0;
            this.lblTCIdNo.Text = "TC Kimlik No :";
            // 
            // txbTCIdNo
            // 
            this.txbTCIdNo.Location = new System.Drawing.Point(508, 7);
            this.txbTCIdNo.Name = "txbTCIdNo";
            this.txbTCIdNo.Size = new System.Drawing.Size(127, 20);
            this.txbTCIdNo.TabIndex = 0;
            this.txbTCIdNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTCIdNo_KeyPress);
            this.txbTCIdNo.Leave += new System.EventHandler(this.txbTCIdNo_Leave);
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIn.Location = new System.Drawing.Point(12, 9);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(91, 20);
            this.lblDateIn.TabIndex = 0;
            this.lblDateIn.Text = "Giriş Tarihi :";
            // 
            // dteDateIn
            // 
            this.dteDateIn.EditValue = null;
            this.dteDateIn.Location = new System.Drawing.Point(139, 9);
            this.dteDateIn.Name = "dteDateIn";
            this.dteDateIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateIn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateIn.Size = new System.Drawing.Size(127, 20);
            this.dteDateIn.TabIndex = 3;
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOut.Location = new System.Drawing.Point(12, 48);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(92, 20);
            this.lblDateOut.TabIndex = 0;
            this.lblDateOut.Text = "Çıkış Tarihi :";
            // 
            // dteDateOut
            // 
            this.dteDateOut.EditValue = null;
            this.dteDateOut.Location = new System.Drawing.Point(139, 48);
            this.dteDateOut.Name = "dteDateOut";
            this.dteDateOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateOut.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDateOut.Size = new System.Drawing.Size(127, 20);
            this.dteDateOut.TabIndex = 4;
            // 
            // btnReservationAdd
            // 
            this.btnReservationAdd.Location = new System.Drawing.Point(538, 146);
            this.btnReservationAdd.Name = "btnReservationAdd";
            this.btnReservationAdd.Size = new System.Drawing.Size(97, 57);
            this.btnReservationAdd.TabIndex = 3;
            this.btnReservationAdd.Text = "Kaydet";
            this.btnReservationAdd.UseVisualStyleBackColor = true;
            this.btnReservationAdd.Click += new System.EventHandler(this.btnReservationAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 183);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 0;
            // 
            // lblRoomSelect
            // 
            this.lblRoomSelect.AutoSize = true;
            this.lblRoomSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomSelect.Location = new System.Drawing.Point(12, 85);
            this.lblRoomSelect.Name = "lblRoomSelect";
            this.lblRoomSelect.Size = new System.Drawing.Size(98, 20);
            this.lblRoomSelect.TabIndex = 0;
            this.lblRoomSelect.Text = "Oda Seçimi :";
            // 
            // dgwEmptyRooms
            // 
            this.dgwEmptyRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmptyRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmptyRooms.Location = new System.Drawing.Point(12, 108);
            this.dgwEmptyRooms.Name = "dgwEmptyRooms";
            this.dgwEmptyRooms.RowHeadersVisible = false;
            this.dgwEmptyRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEmptyRooms.Size = new System.Drawing.Size(349, 228);
            this.dgwEmptyRooms.TabIndex = 5;
            // 
            // btnUsableRooms
            // 
            this.btnUsableRooms.Location = new System.Drawing.Point(274, 9);
            this.btnUsableRooms.Name = "btnUsableRooms";
            this.btnUsableRooms.Size = new System.Drawing.Size(87, 59);
            this.btnUsableRooms.TabIndex = 6;
            this.btnUsableRooms.Text = "Uygun Odaları Göster";
            this.btnUsableRooms.UseVisualStyleBackColor = true;
            this.btnUsableRooms.Click += new System.EventHandler(this.btnUsableRooms_Click);
            // 
            // frmReservationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 357);
            this.Controls.Add(this.btnUsableRooms);
            this.Controls.Add(this.dgwEmptyRooms);
            this.Controls.Add(this.btnReservationAdd);
            this.Controls.Add(this.txbTCIdNo);
            this.Controls.Add(this.txbGuestLastName);
            this.Controls.Add(this.txbGuestName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRoomSelect);
            this.Controls.Add(this.lblDateOut);
            this.Controls.Add(this.lblDateIn);
            this.Controls.Add(this.lblTCIdNo);
            this.Controls.Add(this.lblGuestLastName);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.dteDateOut);
            this.Controls.Add(this.dteDateIn);
            this.Name = "frmReservationEdit";
            this.Text = "Rezervasyon Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.dteDateIn.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateOut.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDateOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmptyRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txbGuestName;
        private System.Windows.Forms.Label lblGuestLastName;
        private System.Windows.Forms.TextBox txbGuestLastName;
        private System.Windows.Forms.Label lblTCIdNo;
        private System.Windows.Forms.TextBox txbTCIdNo;
        private System.Windows.Forms.Label lblDateIn;
        private DevExpress.XtraEditors.DateEdit dteDateIn;
        private System.Windows.Forms.Label lblDateOut;
        private DevExpress.XtraEditors.DateEdit dteDateOut;
        private System.Windows.Forms.Button btnReservationAdd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRoomSelect;
        private System.Windows.Forms.DataGridView dgwEmptyRooms;
        private System.Windows.Forms.Button btnUsableRooms;
    }
}