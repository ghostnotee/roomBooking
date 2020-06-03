namespace RoomBooking.WinFormsUI
{
    partial class frmRoomEdit
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
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.dgvEditAllRooms = new System.Windows.Forms.DataGridView();
            this.btnRoomUpdate = new System.Windows.Forms.Button();
            this.btnRoomDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAllRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Location = new System.Drawing.Point(490, 29);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(102, 49);
            this.btnRoomAdd.TabIndex = 0;
            this.btnRoomAdd.Text = "Oda Ekle";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.btnRoomAdd_Click);
            // 
            // dgvEditAllRooms
            // 
            this.dgvEditAllRooms.AllowUserToAddRows = false;
            this.dgvEditAllRooms.AllowUserToDeleteRows = false;
            this.dgvEditAllRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditAllRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditAllRooms.Location = new System.Drawing.Point(12, 29);
            this.dgvEditAllRooms.MultiSelect = false;
            this.dgvEditAllRooms.Name = "dgvEditAllRooms";
            this.dgvEditAllRooms.ReadOnly = true;
            this.dgvEditAllRooms.RowHeadersVisible = false;
            this.dgvEditAllRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditAllRooms.Size = new System.Drawing.Size(460, 185);
            this.dgvEditAllRooms.TabIndex = 1;
            this.dgvEditAllRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEditAllRooms_CellClick);
            // 
            // btnRoomUpdate
            // 
            this.btnRoomUpdate.Location = new System.Drawing.Point(490, 97);
            this.btnRoomUpdate.Name = "btnRoomUpdate";
            this.btnRoomUpdate.Size = new System.Drawing.Size(102, 49);
            this.btnRoomUpdate.TabIndex = 0;
            this.btnRoomUpdate.Text = "Oda Güncelle";
            this.btnRoomUpdate.UseVisualStyleBackColor = true;
            this.btnRoomUpdate.Click += new System.EventHandler(this.btnRoomUpdate_Click);
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Location = new System.Drawing.Point(490, 165);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Size = new System.Drawing.Size(102, 49);
            this.btnRoomDelete.TabIndex = 0;
            this.btnRoomDelete.Text = "Odayı Sil";
            this.btnRoomDelete.UseVisualStyleBackColor = true;
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Düzenlenecek Odayı Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Oda Özellikleri :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oda Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Adı :";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(12, 270);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(100, 20);
            this.txtRoomType.TabIndex = 7;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(207, 270);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNumber.TabIndex = 7;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(372, 270);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Oda Tipi :";
            // 
            // frmRoomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 308);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEditAllRooms);
            this.Controls.Add(this.btnRoomDelete);
            this.Controls.Add(this.btnRoomUpdate);
            this.Controls.Add(this.btnRoomAdd);
            this.Name = "frmRoomEdit";
            this.Text = "frmRoomEdit";
            this.Load += new System.EventHandler(this.frmRoomEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAllRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.DataGridView dgvEditAllRooms;
        private System.Windows.Forms.Button btnRoomUpdate;
        private System.Windows.Forms.Button btnRoomDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label5;
    }
}