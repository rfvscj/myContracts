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
    public partial class Form_Edit : Form
    {

        public string studentid_edit = null;
        public void initControl()
        {
            //查询信息并显示编辑前信息
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            if(studentinfo!=null)
            {
                txt_studentid.Text = studentinfo.StudentId;
                txt_name.Text = studentinfo.Name;
                if(studentinfo.Sex=="男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                else
                {
                    rb_man.Checked = false;
                    rb_woman.Checked = true;
                }
                txt_age.Text = studentinfo.Age.ToString();
                dt_birthdate.Text = studentinfo.BirthDate.ToString();
                txt_phone.Text = studentinfo.Phone;
                txt_email.Text = studentinfo.Email;
                txt_homeaddress.Text = studentinfo.HomeAddress;
                txt_profession.Text = studentinfo.Profession;
            }
        }
        public Form_Edit()
        {
            InitializeComponent();
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            initControl();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try { 
                //更新学生编辑信息
                StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
                //studentinfo.StudentId = Int32.Parse(txt_studengid.Text);
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
            if (StudentInfoBLL.UpdateStudentInfo(studentinfo))
            {
                MessageBox.Show("修改学生信息成功！");
            }
                }catch (Exception)
                {
                    if (String.IsNullOrEmpty(txt_age.Text))
                        MessageBox.Show("年龄输入不能为空!");
                    else
                    MessageBox.Show("请不要修改学生编号！","错误", MessageBoxButtons.OK);
                }
            }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_studengid_TextChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_studentid_Click(object sender, EventArgs e)
        {

        }
    }
}
