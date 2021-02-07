using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214.Assignment1.App.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        public bool IsUpdate { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //    if (IsUpdate)
            //    {
            //        //get student id out of session
            //        if (Session["StudentID"] != null)
            //        {
            //            //need to convert the object in session to an int
            //            var id = Convert.ToInt32(Session["StudentID"]);

            //            //get the Authentication object from the manager
            //            var auth = AuthenticationManager.Find(id);

            //            //set the state of the form
            //            if (auth != null)
            //            {
            //                uxFirstName.Text = auth.Student.FirstName;
            //                uxLastName.Text = auth.Student.LastName;
            //                uxCity.Text = auth.Student.City;
            //                uxUsername.Text = auth.Username;
            //                uxPassword.Text = auth.Password;
            //            }
            //        }
            //    }
            //}

            //protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
            //{
            //    if (IsUpdate)
            //    {
            //        //updating the record
            //        //get student id out of session
            //        if (Session["StudentID"] != null)
            //        {
            //            var id = Convert.ToInt32(Session["StudentID"]);
            //            //get the Authentication object from the manager
            //            var auth = AuthenticationManager.Find(id);
            //            auth.Student.FirstName = uxFirstName.Text;
            //            auth.Student.LastName = uxLastName.Text;
            //            auth.Student.City = uxCity.Text;
            //            auth.Username = uxUsername.Text;
            //            auth.Password = uxPassword.Text;
            //            //pass auth to the manager for updating
            //            AuthenticationManager.Update(auth);

            //            //remove from auth ticket, clear session and redirect
            //            FormsAuthentication.SignOut();
            //            Session.Clear();
            //            Response.Redirect("~/Login");
            //        }
            //    }
            //    else
            //    {
            //        //inserting the record
            //        var auth = new Authentication
            //        {
            //            Username = uxUsername.Text,
            //            Password = uxPassword.Text,
            //            Student = new Student
            //            {
            //                FirstName = uxFirstName.Text,
            //                LastName = uxLastName.Text,
            //                City = uxCity.Text
            //            }
            //        };
            //        //pass the auth object to the manager for inserting
            //        AuthenticationManager.Add(auth);

            //        Response.Redirect("~/Login");
            //    }
        }
    }
}