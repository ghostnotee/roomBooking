namespace RoomBooking.WinFormsUI
{
    partial class frmReservationsByGuest
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
            this.dgvReservationByGuest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationByGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservationByGuest
            // 
            this.dgvReservationByGuest.AllowUserToAddRows = false;
            this.dgvReservationByGuest.AllowUserToDeleteRows = false;
            this.dgvReservationByGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationByGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationByGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationByGuest.Location = new System.Drawing.Point(0, 0);
            this.dgvReservationByGuest.MultiSelect = false;
            this.dgvReservationByGuest.Name = "dgvReservationByGuest";
            this.dgvReservationByGuest.ReadOnly = true;
            this.dgvReservationByGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationByGuest.Size = new System.Drawing.Size(800, 450);
            this.dgvReservationByGuest.TabIndex = 0;
            // 
            // frmReservationByGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReservationByGuest);
            this.Name = "frmReservationByGuest";
            this.Text = "frmReservationByGuest";
            this.Load += new System.EventHandler(this.frmReservationByGuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationByGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservationByGuest;
    }
}