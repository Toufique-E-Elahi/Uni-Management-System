using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracProjectGui
{
    class BizLogic
    {
        private Dal dl = new Dal();
        //private MainWindow Mw = new MainWindow();
        public User CheckLogin(string id, string password)
        {
            User user = dl.CheckPass(id, password);
            return user;
        }
        public string InsertTeacher(string id, string name, string add, string mail, string degree)
        {
            string  s=dl.InsertTeacherDB(id,name,add,mail,degree);
            return s;
        }
        public string InsertStudent(string id, string name, string add, string mail, string degree)
        {
            string s = dl.InsertStudentDB(id, name, add, mail, degree);
            return s;
        }
        public Student LoadStudent(string id)
        {
            Student s = dl.LoadStd(id);
            return s;
        }
        public Teacher LoadTeacher(string id)
        {
            Teacher t = dl.LoadTeacherDB(id);
            return t;
        }
        public string UpdateStudent(string id, string name, string add, string mail, string sem)
        {
            string s = dl.UpdateStudentDB(id, name, add, mail, sem);
            return s;
        }
        public string UpdateTeacher(string id, string name, string add, string mail, string deg)
        {
            string s = dl.UpdateTeacherDB(id, name, add, mail, deg);
            return s;
        }
        public string DeleteTeacher(string id)
        {
            string s = dl.DeleteTeacherDB(id);
            return s;
        }
        public string DeleteStudent(string id)
        {
            string s = dl.DeleteStudentDB(id);
            return s;
        }
        public string InsertUser(string id, string pass, string usertype)
        {
            int t = 0;
            if (!String.IsNullOrEmpty(usertype))
            {
                if(usertype.Equals("ADMIN"))
                {
                    t = 0;
                }
                else
                {
                    t = 1;
                }
            }
            else
            {
                return "Choose User Type";
            }
            string s = dl.InsertUserDB(id,pass,t);
            return s;
        }
        public string DeleteUser(string id)
        {
            User u = dl.CheckUser(id);
            if (string.IsNullOrEmpty(u.error))
            {
                string s = dl.DeleteUserDB(id);
                return s;
            }
            else
            {
                return "User Not Found";
            }
        }
        public List<String> loadTCombo()
        {
            List<String> s=dl.loadTComboDB();
            return s;
        }
        public string InsertCourse(string name, string cred)
        {
            string s = dl.InsertCourseDB(name,cred);
            return s;
        }
        public string UpdateCourse(string name, string cred, string i)
        {
            string s = dl.UpdateCourseDB(name, cred,i);
            return s;
        }
        public Course LoadCourse(string name)
        {
            Course c = dl.LoadCourseDB(name);
            return c;
        }
        public string DeleteCourse(string name)
        {
            string s = dl.DeleteCourseDB(name);
            return s;
        }
        public List<String> loadCCombo()
        {
            List<String> s = dl.loadCComboDB();
            return s;
        }
        public string AssignCourse(string cname, string tname, string yr, string sem)
        {
            string s = dl.AssignCourseDB(cname, tname, yr, sem);
            return s;
        }
        public string UpdatePass(string id, string pass)
        {
            string s = dl.UpdatePassDB(id, pass);
            return s;
        }
        public List<Student> loadStdList()
        {
            List<Student>  s = dl.loadStdListDB();
            return s;
        }
        public List<Course_Assign> getAllCA()
        {
            List<Course_Assign> ca = dl.getAllCaDB();
            return ca;
        }
        public string DeleteCA(string id)
        {
            string s = dl.DeleteCADB(id);
            return s;
        }
        public List<Course_Assign> LoadCA(string cnm, string yr, string tnm)
        {
            List<Course_Assign> ca = dl.LoadCADB(cnm, yr, tnm);
            return ca;
        }
        public string UpdateCA(string cnm, string tnm, string yr, string sem, string id)
        {
            string s = dl.UpdateCADB(cnm, tnm, yr, sem, id);
            return s;
        }

    }
}
