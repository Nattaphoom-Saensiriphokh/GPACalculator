# Grade Calculator (WinForms)

## 📝 รายละเอียดโปรแกรม
โปรแกรมคำนวณเกรดโดยรับคะแนนจากผู้ใช้ และแสดง **คะแนนสูงสุด, คะแนนต่ำสุด, GPA, และจำนวนคน**  
ใช้ภาษา **C# (WinForms)** และออกแบบโครงสร้างโดยใช้ **Class Diagram**  

## 📌 Class Diagram
```mermaid
classDiagram
    class Form1 {
        - double[] scores
        + Form1()
        + void button1_Click(object sender, EventArgs e)
    }
    
    class GradeCalculator {
        + double MaxScore(double[] scores)
        + double MinScore(double[] scores)
        + double CalculateGPA(double[] scores)
    }

    Form1 --> GradeCalculator : ใช้งาน
