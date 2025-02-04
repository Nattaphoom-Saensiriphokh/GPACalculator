using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<double> gpaList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // รับค่าจาก TextBox
            if (double.TryParse(textBox1.Text, out double gpa) && gpa >= 0.0 && gpa <= 4.0)
            {
                gpaList.Add(gpa); // เพิ่มค่า GPA ลงใน List
                UpdateGPAInfo();  // อัปเดตค่าบนหน้าจอ
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("กรุณากรอกค่า GPA ระหว่าง 0.0 - 4.0", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateGPAInfo()
        {
            if (gpaList.Count > 0)
            {
                double avgGPA = gpaList.Average(); // ค่าเฉลี่ย GPA
                double maxGPA = gpaList.Max();     // ค่า GPA สูงสุด
                double minGPA = gpaList.Min();     // ค่า GPA ต่ำสุด
                int totalStudents = gpaList.Count; // จำนวนคนที่ป้อน GPA

                
                textBox2.Text = avgGPA.ToString("F2");     // GPA เฉลี่ย
                textBox3.Text = totalStudents.ToString();  // จำนวนคนที่ป้อน GPA
                textBox4.Text = maxGPA.ToString("F2");     // คะแนนสูงสุด
                textBox5.Text = minGPA.ToString("F2");     // คะแนนต่ำสุด
            }
            else
            {
                // ถ้ายังไม่มีข้อมูล ให้เคลียร์ช่อง TextBox
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

    }
}
