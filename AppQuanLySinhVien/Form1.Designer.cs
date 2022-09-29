namespace AppQuanLySinhVien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLopHoc = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinhVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienViewModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp học:";
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.FormattingEnabled = true;
            this.cbbLopHoc.Location = new System.Drawing.Point(90, 13);
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Size = new System.Drawing.Size(121, 28);
            this.cbbLopHoc.TabIndex = 1;
            this.cbbLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbbLopHoc_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVienDataGridViewTextBoxColumn,
            this.hoDemDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.iDLopHocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinhVienViewModelBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // sinhVienViewModelBindingSource
            // 
            this.sinhVienViewModelBindingSource.DataSource = typeof(AppQuanLySinhVien.ViewModel.SinhVienViewModel);
            // 
            // sinhVienViewModelBindingSource1
            // 
            this.sinhVienViewModelBindingSource1.DataSource = typeof(AppQuanLySinhVien.ViewModel.SinhVienViewModel);
            // 
            // sinhVienViewModelBindingSource2
            // 
            this.sinhVienViewModelBindingSource2.DataSource = typeof(AppQuanLySinhVien.ViewModel.SinhVienViewModel);
            // 
            // maSinhVienDataGridViewTextBoxColumn
            // 
            this.maSinhVienDataGridViewTextBoxColumn.DataPropertyName = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.HeaderText = "MaSinhVien";
            this.maSinhVienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maSinhVienDataGridViewTextBoxColumn.Name = "maSinhVienDataGridViewTextBoxColumn";
            this.maSinhVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoDemDataGridViewTextBoxColumn
            // 
            this.hoDemDataGridViewTextBoxColumn.DataPropertyName = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.HeaderText = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoDemDataGridViewTextBoxColumn.Name = "hoDemDataGridViewTextBoxColumn";
            this.hoDemDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            this.queQuanDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDLopHocDataGridViewTextBoxColumn
            // 
            this.iDLopHocDataGridViewTextBoxColumn.DataPropertyName = "IDLopHoc";
            this.iDLopHocDataGridViewTextBoxColumn.HeaderText = "IDLopHoc";
            this.iDLopHocDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDLopHocDataGridViewTextBoxColumn.Name = "iDLopHocDataGridViewTextBoxColumn";
            this.iDLopHocDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbbLopHoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLopHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource2;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource1;
    }
}

