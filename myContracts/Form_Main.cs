using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myContracts
{
    public partial class Form_Main : Form
    {
        void initContracts()
        {
            //如果存在Students.xml，查询所有学生信息，如果不存在，则创建该文件后再查询
            if (File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml"))
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            else
            {
                StudentInfoBLL.CreateStudentXml();
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            //初始化数据表格dataGridView1的列标题
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生性别";
            dataGridView1.Columns[3].HeaderText = "学生年龄";
            dataGridView1.Columns[4].HeaderText = "出生日期";
            dataGridView1.Columns[5].HeaderText = "手机号码";
            dataGridView1.Columns[6].HeaderText = "家庭住址";
            dataGridView1.Columns[7].HeaderText = "电子邮箱";
            dataGridView1.Columns[8].HeaderText = "专　　业";
        }
        public Form_Main()
        {
            InitializeComponent();
            initContracts();
        }

        private void toolStrip_add_Click(object sender, EventArgs e)
        {
            //打开添加窗体
            Form_Add formadd = new Form_Add();
            formadd.ShowDialog();
            //添加删除或编辑后仍是当前选中节点的数据
            if (treeView1.SelectedNode != null)
            {
                StudentInfo Rchose = new StudentInfo();

                switch (treeView1.SelectedNode.Tag.ToString())
                {
                    //通过调用search中现有的方法完成
                    case "0": dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo(); break;
                    case "1":
                        Rchose.Profession = treeView1.SelectedNode.Text;
                        dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(Rchose);
                        break;
                        //使用Tag标志区别选中的标签类别，可以再次扩展，这里不做了，用Tag意义不大
                }
            }
            else
                initContracts();
        }

        private void toolStrip_edit_Click(object sender, EventArgs e)
        {
            //打开编辑
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string selectrow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Form_Edit formedit = new Form_Edit();
                formedit.studentid_edit = selectrow;
                formedit.ShowDialog();
                if (treeView1.SelectedNode != null)
                {
                    StudentInfo Rchose = new StudentInfo();

                    switch (treeView1.SelectedNode.Tag.ToString())
                    {
                        //通过调用search中现有的方法完成
                        case "0": dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo(); break;
                        case "1":
                            Rchose.Profession = treeView1.SelectedNode.Text;
                            dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(Rchose);
                            break;
                            //使用Tag标志区别选中的标签类别，可以再次扩展，这里不做了，用Tag意义不大
                    }
                }
                else
                    initContracts();
            }
            else
                MessageBox.Show("请选中一行后再点击编辑按钮");
        }

        private void toolStrip_delete_Click(object sender, EventArgs e)
        {
            //删除信息
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("确定要删除此学生信息？", "确认信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    string selectrow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    if (StudentInfoBLL.DeleteStudentInfo(selectrow))
                    {
                        MessageBox.Show("删除学生信息成功！");
                        if (treeView1.SelectedNode != null)
                        {
                            StudentInfo Rchose = new StudentInfo();

                            switch (treeView1.SelectedNode.Tag.ToString())
                            {
                                //通过调用search中现有的方法完成
                                case "0": dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo(); break;
                                case "1":
                                    Rchose.Profession = treeView1.SelectedNode.Text;
                                    dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(Rchose);
                                    break;
                                    //使用Tag标志区别选中的标签类别，可以再次扩展，这里不做了，用Tag意义不大
                            }
                        }
                        else
                            initContracts();
                    }

                    else
                    {
                        MessageBox.Show("删除学生信息失败，请检查是否选中学生信息！");
                        if (treeView1.SelectedNode != null)
                        {
                            StudentInfo Rchose = new StudentInfo();

                            switch (treeView1.SelectedNode.Tag.ToString())
                            {
                                //通过调用search中现有的方法完成
                                case "0": dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo(); break;
                                case "1":
                                    Rchose.Profession = treeView1.SelectedNode.Text;
                                    dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(Rchose);
                                    break;
                                    //使用Tag标志区别选中的标签类别，可以再次扩展，这里不做了，用Tag意义不大
                            }
                        }
                        else
                            initContracts();
                    }
                }
                else
                {
                    MessageBox.Show("请选中一行后再点击删除按钮！");
                }
            }
        }

        private void toolStrip_search_Click(object sender, EventArgs e)
        {
            //打开查询
            Form_Search formsearch = new Form_Search();
            formsearch.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StudentInfo Rchose = new StudentInfo();

            switch (e.Node.Tag.ToString())
            {
                //通过调用search中现有的方法完成
                case "0": dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo(); break;
                case "1": Rchose.Profession = treeView1.SelectedNode.Text;
                               dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(Rchose);
                                break;
                
                //使用Tag标志区别选中的标签类别，可以再次扩展，这里不做了，用Tag意义不大
            }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();//提示用户选择保存文件
            savefile.InitialDirectory = @"C:\Documents and Settings\Administrator\桌面";//打开文件的初始目录
            savefile.Filter = "xmlbak文件(*.xmlbak)|";
            savefile.FileName = "备份文件-" +
                System.DateTime.Now.ToString("yyyyMMddHHmmss");
            savefile.DefaultExt = ".xmlbak";//文件后缀
            DialogResult dr = savefile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String filePath = savefile.FileName.ToString();
                try
                {
                    string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
                    File.Copy(path, filePath, true);
                    MessageBox.Show("备份成功！", "成功", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("未知异常！", "异常", MessageBoxButtons.OK);
                }
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = @"C:\Documents and Settings\Administrator\桌面";//打开文件的初始目录
            openfile.Filter = "xmlbak文件(*.xmlbak)|";
            openfile.DefaultExt = ".xmlbak";
            DialogResult dr1 = openfile.ShowDialog();
            if (dr1 == DialogResult.OK)
            {
                String filePath = openfile.FileName.ToString();
                try
                {
                    //获取用户选择文件的后缀名 
                    string extension = Path.GetExtension(openfile.FileName);
                    if (extension != ".xmlbak")
                        MessageBox.Show("请选择.xmlbak后缀的文件");
                    else
                    {
                        if (!(File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml")))
                            StudentInfoBLL.CreateStudentXml();
                        string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
                        File.Copy(filePath, path, true);
                        MessageBox.Show("恢复成功！", "成功", MessageBoxButtons.OK);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("未知异常！", "异常", MessageBoxButtons.OK);
                }
            }
        }

        
    }
    }
