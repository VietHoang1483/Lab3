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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.tstxtFindname.TextChanged += new System.EventHandler(this.tstxtFindname_TextChanged);
        }
        
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void AddStudentToGrid(object sender, StudentEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSo"].Value?.ToString() == e.Student.MaSo)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int stt = dataGridView1.Rows.Count + 1;
            dataGridView1.Rows.Add(stt, e.Student.MaSo, e.Student.Ten, e.Student.Khoa, e.Student.DiemTB);
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
        private void tstxtFindname_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tstxtFindname.Text.ToLower();  

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu tên sinh viên chứa chuỗi tìm kiếm
                if (row.Cells["Ten"].Value != null && row.Cells["Ten"].Value.ToString().ToLower().Contains(searchTerm))
                {
                    // Hiển thị dòng nếu có kết quả tìm thấy
                    row.Visible = true;
                }
                else
                {
                    // Ẩn dòng 
                    row.Visible = false;
                }
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StudentAdded += AddStudentToGrid; // Đăng ký sự kiện
            form2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StudentAdded += AddStudentToGrid;
            form2.ShowDialog();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StudentAdded += AddStudentToGrid;
            form2.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void tstxtFindname_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
    public class Student
    {
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }
    }
}
