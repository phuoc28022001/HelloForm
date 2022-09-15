// F7 để chế độ code
// Shift + F7 để chế độ design

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloForm
{
    public partial class Form1 : Form
    {
        ErrorProvider error; 
        public Form1()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _soThuNhat = txtSoThuNhat.Text;
                var _soThuHai = txtSoThuHai.Text;
                error.Clear();

                if(String.IsNullOrEmpty(_soThuNhat))
                {
                    error.SetError(txtSoThuNhat, "Vui lòng nhập số thứ nhất");
                    return;
                }

                if (String.IsNullOrEmpty(_soThuHai))
                {
                    error.SetError(txtSoThuNhat, "Vui lòng nhập số thứ hai");
                    return;
                }


                var soThuNhat = Convert.ToDouble(_soThuNhat);
                var soThuHai = Convert.ToDouble(_soThuHai);

                double ketQua = soThuNhat + soThuHai;

                if(rdbLabel.Checked)
                {
                    lbKetQua.Text = ketQua.ToString("N2");
                }
                else
                {
                    MessageBox.Show($"Kết quả: {ketQua:N2}");
                }

                
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập không đúng. Vui lòng xem lại");
            }
            catch(OverflowException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập quá lớn. Vui lòng xem lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khum biết");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rdbLabel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
