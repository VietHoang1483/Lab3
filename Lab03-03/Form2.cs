using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form2 : Form
    {
        public event EventHandler<StudentEventArgs> StudentAdded;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtScore.Text) || cboFacul.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtScore.Text, out double diemTB))
            {
                MessageBox.Show("Điểm trung bình phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(diemTB<0 || diemTB > 10)
            {
                MessageBox.Show("Thang điểm trung bình chỉ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = new Student
            {
                MaSo = txtID.Text,
                Ten = txtName.Text,
                Khoa = cboFacul.SelectedItem.ToString(),
                DiemTB = diemTB
            };

            // Kích hoạt sự kiện StudentAdded
            StudentAdded?.Invoke(this, new StudentEventArgs { Student = student });
            this.Close();
            
        }
    }
    public class StudentEventArgs : EventArgs
    {
        public Student Student { get; set; }
    }
}
