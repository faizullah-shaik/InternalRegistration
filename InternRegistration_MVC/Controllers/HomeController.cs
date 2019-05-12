using InternRegistration_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternRegistration_MVC.Controllers
{
    public class HomeController : Controller
    {
        string connection_string = ConfigurationManager.ConnectionStrings["InternsConnectionstring"].ConnectionString;
       // string filename="a";
        public ActionResult Index()
        {
            return View();
        }
       
[HttpPost]

        public ActionResult Index(Class1 details)
        {
            if (!ModelState.IsValid)
            {
                return View(details);
            }

            using (SqlConnection connection = new SqlConnection(connection_string))

                {
                
                    //connection.Open();
                    //string a = details.EmpId;

                    //SqlCommand CommandProfessional = new SqlCommand("PRODATA", connection);
                    //cmd.Connection = connection;
                    ////  cmd.CommandText = "insert into Professional_table(EmpId) values("+a+")";
                    //cmd.CommandText = "insert into ProfessionalTable(FirstName,LastName,EmpId,EmailId,CollegeName,Specialization,Gender,SkillSet) values('aa','bb,9999,'hii@com','rrr','CSE','Male','C')";
                    //cmd.CommandType = CommandType.Text;
                    //int i = cmd.ExecuteNonQuery();

                    //string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                    //if (filename == null)
                    //{
                    //    MessageBox.Show("Please select a valid image.");
                    //}



                    //else if (txtFirstName.Text == "" || txtEmpId.Text == "" || txtEmailId.Text == "")
                    //    MessageBox.Show("please fill the mandatory fields");


                    //else if ((!(Regex.Match(txtContact.Text, @"^(\+?[0-9]{10})$").Success)))
                    //{
                    //    MessageBox.Show("Please enter Valid Mobile Number format");
                    //    txtContact.Text = "";
                    //}
                    //else if ((!string.IsNullOrWhiteSpace(txtEmailId.Text)) && (!(Regex.Match(txtEmailId.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").Success)))
                    //{


                    //    MessageBox.Show("Please enter valid mail id ");

                    //}
                    ////else if ((!(Regex.Match(txtContact.Text, @"^[a-zA-Z0-9]+[a-zA-Z0-9._]*@)$").Success)))
                    ////{

                    ////        MessageBox.Show("Please enter valid mail id ");

                    ////}
                    //else
                    //{
                    //    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    //    System.IO.File.Copy(openFileDialog1.FileName, path + "\\Image\\" + filename);
               
                SqlCommand CommandProfessional = new SqlCommand("PRODATA", connection);
                // SqlCommand CommandPersonal = new SqlCommand("PERSONALDATA", connection);
                CommandProfessional.CommandType = CommandType.StoredProcedure;
                // CommandPersonal.CommandType = CommandType.StoredProcedure;
                CommandProfessional.Parameters.AddWithValue("@FirstName", details.FirstName.Trim());
                CommandProfessional.Parameters.AddWithValue("@LastName", details.LastName.Trim());
                CommandProfessional.Parameters.AddWithValue("@EmpId", details.EmpId.Trim());
                CommandProfessional.Parameters.AddWithValue("@EmailId", details.EmailId.Trim());
                CommandProfessional.Parameters.AddWithValue("@CollegeName", details.CollegeName.Trim());
               
                   // cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@Items", item);

                CommandProfessional.Parameters.AddWithValue("@Specialization", details.Specialization.Trim()); 
                CommandProfessional.Parameters.AddWithValue("@Gender", details.Gender.Trim());
                string selected_skillset="";

                foreach (var item in details.SkillSet)
                {
                    selected_skillset += item + ";";
                    
                }
                CommandProfessional.Parameters.AddWithValue("@SkillSet", selected_skillset);

                CommandProfessional.Parameters.AddWithValue("@Address1", details.Address1.Trim());
                CommandProfessional.Parameters.AddWithValue("@Address2", details.Address2.Trim());
                CommandProfessional.Parameters.AddWithValue("@City_Town", details.City_Town.Trim());
                CommandProfessional.Parameters.AddWithValue("@State", details.State.Trim());
                CommandProfessional.Parameters.AddWithValue("@Contact", details.Contact.Trim());
                CommandProfessional.Parameters.AddWithValue("@PinCode", details.PinCode.Trim());
                CommandProfessional.Parameters.AddWithValue("@Photo", details.Photo.Trim());
                connection.Open();

                CommandProfessional.ExecuteNonQuery();
              //  return RedirectToAction("Index");
                ViewBag.Message="Registration is successful";
                //clear();
            
            }
            return View();
        }
        //private void btnBrowseFile_Click(object sender, EventArgs e)
        //{
        //    {
        //        //To where your opendialog box get starting location. My initial directory location is desktop.
        //        openFileDialog1.InitialDirectory = "C://Desktop";
        //        //Your opendialog box title name.
        //        openFileDialog1.Title = "Select image to be upload.";
        //        //which type image format you want to upload in database. just add them.
        //        openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        //        //FilterIndex property represents the index of the filter currently selected in the file dialog box.
        //        openFileDialog1.FilterIndex = 1;
        //        try
        //        {
        //            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //            {
        //                if (openFileDialog1.CheckFileExists)
        //                {
        //                    string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
        //                    lblPath.Text = path;
        //                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        //                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //                }
        //            }
        //            else
        //            {
        //                //MessageBox.Show("Please Upload image.");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            //it will give if file is already exits..
        //            //MessageBox.Show(ex.Message);
        //    }

        //    }
        //}


    }
}