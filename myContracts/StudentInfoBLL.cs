using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myContracts
{
    class StudentInfoBLL
    {
        //XML文件路径
        private static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
        ///<summary>
        ///创建学生XML文档
        ///</summary>
        public static void CreateStudentXml()
        {
            if (!Directory.Exists("xml"))
            {
                Directory.CreateDirectory("xml");
            }
            //创建XML文档
            XDocument studentDoc = new XDocument();
            //创建声明对象
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf- 8", "yes");
            //指定XML声明对象
            studentDoc.Declaration = xDeclaration;
            //创建studentstore节点
            XElement xElement = new XElement("studentcontract");
            //保存文件
            studentDoc.Add(xElement);
            studentDoc.Save(_basePath);
        }
            ///<summary>
            ///增加学生信息
            ///</summary>
            public static bool AddStudentInfo(StudentInfo param)
            {
                XElement xml = XElement.Load(_basePath);
                //创建student节点
                XElement studentXml = new XElement("student");
                //添加属性
                studentXml.Add(new XAttribute("studentid", param.StudentId));
            //添加子节点
                //studentXml.Add(new XElement("studentid", param.StudentId));
                studentXml.Add(new XElement("name", param.Name));
                studentXml.Add(new XElement("sex", param.Sex));
                studentXml.Add(new XElement("age", param.Age.ToString()));
                studentXml.Add(new XElement("birthdate", param.BirthDate.ToString("yyyy-MM-dd")));
                studentXml.Add(new XElement("phone", param.Phone));
                studentXml.Add(new XElement("homeaddress", param.HomeAddress));
                studentXml.Add(new XElement("email", param.Email));
                studentXml.Add(new XElement("profession", param.Profession));
                xml.Add(studentXml);
                //保存
                xml.Save(_basePath);
                return true;
            }
        ///<summary>
        ///修改学生信息
        /// </summary>
        public static bool UpdateStudentInfo(StudentInfo param)
        {
            bool result = false;
            if (param.StudentId != null)
            {
                //根据StudentId找到要修改的学生XML
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student")
                                       where db.Attribute("studentid").Value == param.StudentId
                                       select db).Single();
                //修改属性
               
                   // studentXml.SetAttributeValue("studentid", param.StudentId);
                    studentXml.SetElementValue("name", param.Name);
                    studentXml.SetElementValue("sex", param.Sex);
                    studentXml.SetElementValue("age", param.Age.ToString());
                    studentXml.SetElementValue("birthdate", param.BirthDate.ToString("yyyy-MM-dd"));
                    studentXml.SetElementValue("phone", param.Phone);
                    studentXml.SetElementValue("homeaddress", param.HomeAddress);
                    studentXml.SetElementValue("email", param.Email);
                    studentXml.SetElementValue("profession", param.Profession);
                    //保存
                    xml.Save(_basePath);
                    result = true;
                
            }
            return result;
        }
            ///<summary>
            ///删除学生信息
            /// </summary>
            public static bool  DeleteStudentInfo(string studentid)
            {
                bool result = false;
                if( (studentid != null))
                {
                    XElement xml = XElement.Load(_basePath);
                    XElement studentXml = (from db in xml.Descendants("student")
                                          where db.Attribute("studentid").Value ==studentid
                                          select db).Single();
                    studentXml.Remove();
                xml.Save(_basePath);
                result = true;
                }
            return result;
            }
            ///<summary>
            ///查询全部学生列表
            /// </summary>
            public static List<StudentInfo> GetAllStudentInfo()
            {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            //默认查询所有学生
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId =student.Attribute("studentid").Value,
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex= student.Element("sex").Value,
                               BirthDate=DateTime.Parse(student.Element("birthdate").Value),
                               Phone =student.Element("phone").Value,
                               HomeAddress =student.Element("homeaddress").Value,
                               Email=student.Element("email").Value,
                               Profession=student.Element("profession").Value
                           }).ToList();
            return studentList;       
            }
        /// <summary>
        /// 根据学号查询信息
        /// </summary>
        public static StudentInfo GetStudentInfo(string studentid)
        {
            StudentInfo studentinfo = new StudentInfo();
            XElement xml = XElement.Load(_basePath);
            studentinfo = (from student in xml.Descendants("student")
                           where student.Attribute("studentid").Value == studentid
                           select new StudentInfo
                           {
                               StudentId = student.Attribute("studentid").Value,
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).Single();
            return studentinfo;
        }
        ///<summary>
        ///获取列表
        /// </summary>
        /// <param name="param">参数条件 </param>
        /// <returns>学生列表</returns>
        public static List<StudentInfo>GetStudentInfoList(StudentInfo param)
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            if(param.StudentId!=null)
            {
                studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value==param.StudentId);
            }
            else if(!String.IsNullOrEmpty(param.Name))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);
            }
            //扩展新加
            else if(!String.IsNullOrEmpty(param.Profession))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession);
            }
            else if(!String.IsNullOrEmpty(param.HomeAddress))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("homeaddress").Value == param.HomeAddress);
            }
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = student.Attribute("studentid").Value,
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }
    }
}
