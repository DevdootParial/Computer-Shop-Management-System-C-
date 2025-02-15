﻿namespace Computer_Shop_Management_System
{
    partial class UserControlBills
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
            this.dgvbills = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbills)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbills
            // 
            this.dgvbills.AllowUserToAddRows = false;
            this.dgvbills.AllowUserToDeleteRows = false;
            this.dgvbills.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dgvbills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvbills.GridColor = System.Drawing.Color.MediumPurple;
            this.dgvbills.Location = new System.Drawing.Point(0, 97);
            this.dgvbills.Name = "dgvbills";
            this.dgvbills.ReadOnly = true;
            this.dgvbills.RowHeadersWidth = 51;
            this.dgvbills.RowTemplate.Height = 24;
            this.dgvbills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbills.Size = new System.Drawing.Size(973, 472);
            this.dgvbills.TabIndex = 35;
            this.dgvbills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbills_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkOrchid;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(607, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Search";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAutoSearch.Location = new System.Drawing.Point(269, 43);
            this.txtAutoSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(303, 22);
            this.txtAutoSearch.TabIndex = 45;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "BILL  LIST";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(370, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "**(Search by Name)**";
            // 
            // UserControlBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAutoSearch);
            this.Controls.Add(this.dgvbills);
            this.Name = "UserControlBills";
            this.Size = new System.Drawing.Size(973, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbills;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
    }
}
