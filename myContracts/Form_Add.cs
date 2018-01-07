using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myContracts
{
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            txt_age.Text = CalculateAgeCorrect(dt_birthdate.Value, DateTime.Now).ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try {
                StudentInfo studentinfo = new StudentInfo();
                studentinfo.StudentId = txt_studengid.Text;
                studentinfo.Name = txt_name.Text;
                if (rb_man.Checked)
                    studentinfo.Sex = "男";
                else if (rb_woman.Checked)
                    studentinfo.Sex = "女";
                studentinfo.Age = Int32.Parse(txt_age.Text);
                studentinfo.BirthDate = DateTime.Parse(dt_birthdate.Text);
                studentinfo.Phone = txt_phone.Text;
                studentinfo.Email = txt_email.Text;
                studentinfo.HomeAddress = txt_homeaddress.Text;
                studentinfo.Profession = txt_profession.Text;
                if (StudentInfoBLL.AddStudentInfo(studentinfo))
                {
                    MessageBox.Show("添加学生信息成功！");
                }
            }catch (Exception)
            {
                MessageBox.Show("有数据输入错误！", "错误", MessageBoxButtons.OK);
            }
            }
        

        private void btn_close_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }
        public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;
            return age;
        }
        private void dt_birthdate_ValueChanged(object sender, EventArgs e)
        {
                txt_age.Text = CalculateAgeCorrect(dt_birthdate.Value, DateTime.Now).ToString();
            
        }
    }
}
