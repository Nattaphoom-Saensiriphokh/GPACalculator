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
            // �Ѻ��Ҩҡ TextBox
            if (double.TryParse(textBox1.Text, out double gpa) && gpa >= 0.0 && gpa <= 4.0)
            {
                gpaList.Add(gpa); // ������� GPA ŧ� List
                UpdateGPAInfo();  // �ѻവ��Һ�˹�Ҩ�
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("��سҡ�͡��� GPA �����ҧ 0.0 - 4.0", "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateGPAInfo()
        {
            if (gpaList.Count > 0)
            {
                double avgGPA = gpaList.Average(); // �������� GPA
                double maxGPA = gpaList.Max();     // ��� GPA �٧�ش
                double minGPA = gpaList.Min();     // ��� GPA ����ش
                int totalStudents = gpaList.Count; // �ӹǹ������͹ GPA

                
                textBox2.Text = avgGPA.ToString("F2");     // GPA �����
                textBox3.Text = totalStudents.ToString();  // �ӹǹ������͹ GPA
                textBox4.Text = maxGPA.ToString("F2");     // ��ṹ�٧�ش
                textBox5.Text = minGPA.ToString("F2");     // ��ṹ����ش
            }
            else
            {
                // ����ѧ����բ����� ����������ͧ TextBox
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

    }
}
