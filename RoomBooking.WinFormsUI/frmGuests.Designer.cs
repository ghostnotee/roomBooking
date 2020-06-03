namespace RoomBooking.WinFormsUI
{
    partial class frmGuests
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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.btnGuestAdd = new System.Windows.Forms.Button();
            this.btnGuestUpdate = new System.Windows.Forms.Button();
            this.btnGuestDelete = new System.Windows.Forms.Button();
            this.btnGuestReservations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvGuests.Location = new System.Drawing.Point(0, 0);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersVisible = false;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(639, 450);
            this.dgvGuests.TabIndex = 6;
            // 
            // btnGuestAdd
            // 
            this.btnGuestAdd.Location = new System.Drawing.Point(677, 12);
            this.btnGuestAdd.Name = "btnGuestAdd";
            this.btnGuestAdd.Size = new System.Drawing.Size(111, 23);
            this.btnGuestAdd.TabIndex = 7;
            this.btnGuestAdd.Text = "Müşteri Ekle";
            this.btnGuestAdd.UseVisualStyleBackColor = true;
            this.btnGuestAdd.Click += new System.EventHandler(this.btnGuestAdd_Click);
            // 
            // btnGuestUpdate
            // 
            this.btnGuestUpdate.Location = new System.Drawing.Point(677, 70);
            this.btnGuestUpdate.Name = "btnGuestUpdate";
            this.btnGuestUpdate.Size = new System.Drawing.Size(111, 23);
            this.btnGuestUpdate.TabIndex = 8;
            this.btnGuestUpdate.Text = "Müşteri Düzenle";
            this.btnGuestUpdate.UseVisualStyleBackColor = true;
            this.btnGuestUpdate.Click += new System.EventHandler(this.btnGuestUpdate_Click);
            // 
            // btnGuestDelete
            // 
            this.btnGuestDelete.Location = new System.Drawing.Point(677, 128);
            this.btnGuestDelete.Name = "btnGuestDelete";
            this.btnGuestDelete.Size = new System.Drawing.Size(111, 23);
            this.btnGuestDelete.TabIndex = 9;
            this.btnGuestDelete.Text = "Müşteri Sil";
            this.btnGuestDelete.UseVisualStyleBackColor = true;
            this.btnGuestDelete.Click += new System.EventHandler(this.btnGuestDelete_Click);
            // 
            // btnGuestReservations
            // 
            this.btnGuestReservations.Location = new System.Drawing.Point(677, 214);
            this.btnGuestReservations.Name = "btnGuestReservations";
            this.btnGuestReservations.Size = new System.Drawing.Size(111, 75);
            this.btnGuestReservations.TabIndex = 10;
            this.btnGuestReservations.Text = "Rezervasyonları Görüntüler";
            this.btnGuestReservations.UseVisualStyleBackColor = true;
            this.btnGuestReservations.Click += new System.EventHandler(this.btnGuestReservations_Click);
            // 
            // frmGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuestReservations);
            this.Controls.Add(this.btnGuestDelete);
            this.Controls.Add(this.btnGuestUpdate);
            this.Controls.Add(this.btnGuestAdd);
            this.Controls.Add(this.dgvGuests);
            this.Name = "frmGuests";
            this.Text = "frmGuests";
            this.Load += new System.EventHandler(this.frmGuests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnGuestAdd;
        private System.Windows.Forms.Button btnGuestUpdate;
        private System.Windows.Forms.Button btnGuestDelete;
        private System.Windows.Forms.Button btnGuestReservations;
    }
}