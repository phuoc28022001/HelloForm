using AppQuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSLopHoc();
            NapDSSinhVien();
        }

        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbbLopHoc.SelectedItem as LopHocViewModel;
            }
        }

        void NapDSLopHoc()
        {
            var ls = new LopHocViewModel();
            cbbLopHoc.DataSource = ls.GetList();
            cbbLopHoc.DisplayMember = "TenLop";
        }

        void NapDSSinhVien()
        {
            if(selectedLopHoc != null)
            {
                var ls = new SinhVienViewModel().GetList(selectedLopHoc.ID);
                dataGridView1.DataSource = ls;
            }
            
        }


        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDSSinhVien();
        }
    }
}
