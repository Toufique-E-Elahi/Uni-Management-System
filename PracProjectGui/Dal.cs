using System;
using System.Collections;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace PracProjectGui
{
    public class Dal
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        

        public Dal()
        {
            server = "localhost";
            database = "unimanagementprojectcsharp";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        
        private void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        //Close connection
        private void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        //Update statement
        /*public void Update(Operation op)
        {
            string query = "UPDATE operation SET result="+op.result+ " WHERE id=" + op.id;

            //Open connection
            this.OpenConnection();
            
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = connection;

            //Execute query
            cmd.ExecuteNonQuery();

            //close connection
            this.CloseConnection();
            
        }
        public System.Collections.ArrayList getAllOperations()
        {
            //connect to DB
            //get all operations and package them and return to the caller
            string query = "SELECT * FROM operation";

            //Create a list to store the result
            ArrayList list = new ArrayList();
            this.OpenConnection();
            //Open connection
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                Operation op = new Operation();
                op.id = (int)dataReader["id"];
                op.num1 = (int)dataReader["first_nmbr"];
                op.num2 = (int)dataReader["second_nmbr"];
                op.op = dataReader["op"].ToString();
                list.Add(op);
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;
        }*/
        public User CheckPass(string id, string Passwd)
        {
            string query = "SELECT * FROM Login WHERE UserId='" + id + "' and Passwd='" + Passwd + "'";
            User u = new User();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u.status = (uint)dr["status"];
                    u.uId = id;
                }
                else
                {
                    u.error = "User does not exist";
                }
                return u;
            }
            catch(Exception e)
            {
                u.error = e.Message;
                return u;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string InsertTeacherDB(string id, string name, string add, string mail, string degree )
        {
            String query = "INSERT INTO teacher VALUES ('" + id + "','" + name + "','" + degree + "', '" + mail + "' ,'"+add+"');";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Done";

            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string InsertStudentDB(string id, string name, string add, string mail, string sem)
        {
            String query = "INSERT INTO student VALUES ('" + id + "','" + name + "','" + add + "', '" + mail + "' ,'" + sem + "');";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Done";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Student LoadStd(string id)
        {
            string query = "SELECT * FROM student WHERE StdId='" + id + "'";
            Student s = new Student();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    s.SName = dr["stdName"].ToString();
                    s.SAddress=dr["Address"].ToString();
                    s.sEmail=dr["Email"].ToString();
                    s.SAdmit=dr["Admission_Sem"].ToString();
                    dr.Close();
                }
                else
                {
                    s.Error = "Student does not exist";
                }
                return s;
            }
            catch (Exception e)
            {
                s.Error = e.Message;
                return s;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public Teacher LoadTeacherDB(string id)
        {
            string query = "SELECT * FROM teacher WHERE tId='" + id + "'";
            Teacher t = new Teacher();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    t.tName = dr["tName"].ToString();
                    t.tAddress = dr["tAddress"].ToString();
                    t.tEmail = dr["tEmail"].ToString();
                    t.tDegree = dr["tDegree"].ToString();
                    dr.Close();

                }
                else
                {
                    t.error = "Teacher does not exist";
                }
                
                return t;
            }
            catch (Exception e)
            {
                t.error = e.Message;
                return t;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string UpdateStudentDB(string id, string name, string add, string mail, string sem)
        {
            String query = "UPDATE student SET stdName='" + name + "', 	Address = '" + add+ "',Email = '" + mail + "', Admission_Sem='"+sem+"' WHERE stdId='" + id + "'";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Updated";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string UpdateTeacherDB(string id, string name, string add, string mail, string deg)
        {
            String query = "UPDATE teacher SET tName='" + name + "', 	tAddress = '" + add + "',tEmail = '" + mail + "', tDegree='" + deg + "' WHERE tId='" + id + "'";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Updated";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string DeleteTeacherDB(string id)
        {
            String query = "DELETE FROM teacher WHERE tId='" + id + "';";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Deleted";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string DeleteStudentDB(string id)
        {
            String query = "DELETE FROM student WHERE StdId='" + id + "';";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Deleted";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string InsertUserDB(string id, string pass,int type)
        {
            String query = "INSERT INTO login VALUES ('" + id + "','" + pass + "','" + type + "');";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "User Creation Completed";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string DeleteUserDB(string id)
        {
            String query = "DELETE FROM login WHERE UserId='" + id + "';";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Deleted";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public User CheckUser(string id)
        {
            string query = "SELECT * FROM Login WHERE UserId='" + id + "'";
            User u = new User();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //u.status = (uint)dr["status"];
                    //u.uId = id;
                }
                else
                {
                    u.error = "User does not exist";
                }
                return u;
            }
            catch (Exception e)
            {
                u.error = e.Message;
                return u;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public List<String> loadTComboDB()
        {
            string query = "SELECT * FROM teacher ";
            List<String> teachers = new List<String>();
            try
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string s = dr["tName"].ToString();
                    
                    
                    teachers.Add(s);
                }
                dr.Close();
                return teachers;
            }
            catch (Exception ex)
            {
                teachers.Add(ex.Message);
                return teachers;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string InsertCourseDB(string name, string cred)
        {
            String query = "INSERT INTO course(CName, Credit)  VALUES ('" + name + "' ,'" + cred + "');";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Done";

            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string UpdateCourseDB(string name, string cred,string i)
        {
            
            String id= "SELECT * FROM course where CName='" + i + "'";
            Course c = new Course();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(id, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c.cId = dr["CId"].ToString();
                    dr.Close();
                }
                else
                {
                    c.error = "Course does not exist";
                }
                
            }
            catch (Exception e)
            {
                c.error = e.Message;
                
            }
            finally
            {
                this.CloseConnection();
            }

            String query = "UPDATE course SET CName='" + name + "',Credit = '" + cred + "' WHERE CId='" + c.cId + "'";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Updated";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Course LoadCourseDB(string name)
        {
            string query = "SELECT * FROM course WHERE CName='" + name + "'";
            Course c = new Course();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c.cName = dr["CName"].ToString();
                    c.credit = dr["Credit"].ToString();
                    dr.Close();
                }
                else
                {
                    c.error = "Course does not exist";
                }

                return c;
            }
            catch (Exception e)
            {
                c.error = e.Message;
                return c;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string DeleteCourseDB(string name)
        {
            String query = "DELETE FROM course WHERE CName='" + name + "';";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Deleted";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<String> loadCComboDB()
        {
            string query = "SELECT * FROM course ";
            List<String> Courses = new List<String>();
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string s = dr["CName"].ToString();
                    Courses.Add(s);
                }
                dr.Close();
                return Courses;
            }
            catch (Exception ex)
            {
                Courses.Add(ex.Message);
                return Courses;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string AssignCourseDB(string cname, string tname, string yr, string sem)
        {
            String query = "INSERT INTO course_assign(cName, tName, year, sem)  VALUES ('" + cname + "' ,'" + tname + "', '" + yr + "', '" + sem + "');";
            try
            {
                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;
                //Execute query
                cmd.ExecuteNonQuery();
                return "Done";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string UpdatePassDB(string id, string pass)
        {
            String query = "UPDATE login SET Passwd='" + pass + "' WHERE UserId='" + id + "'";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Updated";

            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Student> loadStdListDB()
        {
            string query = "SELECT * FROM student ";
            Student st = new Student();
            List<Student> students = new List<Student>();
            try
            {
                this.OpenConnection();
                //DataTable table = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                //dr.Fill(table);
                while (dr.Read())
                {
                    Student s = new Student();
                    s.SId = dr["stdId"].ToString();
                    s.SName= dr["stdName"].ToString();
                    s.sEmail= dr["Email"].ToString();
                    students.Add(s);
                }
                dr.Close();
                return students;
            }
            catch (Exception ex)
            {
                st.Error = ex.Message;
                students.Add(st);
                return students;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Course_Assign> getAllCaDB()
        {
            string query = "SELECT * FROM course_assign";
            Course_Assign c = new Course_Assign();
            List<Course_Assign> CAlst = new List<Course_Assign>();
            try
            {
                this.OpenConnection();
                //DataTable table = new DataTable();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                //dr.Fill(table);
                while (dr.Read())
                {
                    Course_Assign ca = new Course_Assign();
                    ca.CaId = dr["caId"].ToString();
                    ca.CName = dr["cName"].ToString();
                    ca.TName = dr["tName"].ToString();
                    ca.Year = dr["year"].ToString();
                    ca.Sem = dr["sem"].ToString();
                    CAlst.Add(ca);
                }
                dr.Close();
                return CAlst;
            }
            catch (Exception ex)
            {
                c.Error = ex.Message;
                CAlst.Add(c);
                return CAlst;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public string DeleteCADB(string id)
        {
            String query = "DELETE FROM course_assign WHERE caId='" + id + "';";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Deleted";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Course_Assign> LoadCADB(string cnm, string yr, string tnm)
        {
            string query = "";
            List<Course_Assign> CAlst = new List<Course_Assign>();
            if(!String.IsNullOrEmpty(cnm) && !String.IsNullOrEmpty(tnm))
            {
                return CAlst;
            }
            if (!String.IsNullOrEmpty(cnm) && !String.IsNullOrEmpty(yr))
            {
                return CAlst;
            }
            if (!String.IsNullOrEmpty(tnm) && !String.IsNullOrEmpty(yr))
            {
                return CAlst;
            }
            else if(!String.IsNullOrEmpty(cnm))
            {
                query = "SELECT * FROM course_assign WHERE cName='" + cnm + "'";
            }
            else if(!String.IsNullOrEmpty(yr))
            {
                query = "SELECT * FROM course_assign WHERE year='" + yr + "'";
            }
            else if (!String.IsNullOrEmpty(tnm))
            {
                query = "SELECT * FROM course_assign WHERE tName='" + tnm + "'";
            }
            else
            {
                return CAlst;
            }
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Course_Assign ca = new Course_Assign();
                    ca.CaId = dr["caId"].ToString();
                    ca.CName = dr["cName"].ToString();
                    ca.TName = dr["tName"].ToString();
                    ca.Year = dr["year"].ToString();
                    ca.Sem = dr["sem"].ToString();
                    CAlst.Add(ca);
                }
                dr.Close();
                return CAlst;
            }
            catch (Exception e)
            {
                return CAlst;
            }
            finally
            {
                this.CloseConnection();
            }

        }
        public string UpdateCADB(string cnm, string tnm, string yr,string sem,string id)
        {
            String query = "UPDATE course_assign SET cName='" + cnm + "',tName = '" + tnm + "',year = '" + yr + "',sem = '" + sem + "' WHERE caId='" + id + "'";
            try
            {

                this.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();
                return "Updated";

            }
            catch (Exception e)
            {
                return e.Message;

            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}