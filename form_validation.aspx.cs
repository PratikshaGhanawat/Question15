using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quuestion15
{
    public partial class form_validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate the input when the submit button is clicked

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "Please fill in all required fields.";
                return;
            }

            // Validate email format using RegularExpressionValidator
            if (!IsValidEmail(txtEmail.Text))
            {
                lblMessage.Text = "Please enter a valid email address.";
                return;
            }

            // Validate password strength
            if (!IsValidPassword(txtPassword.Text))
            {
                lblMessage.Text = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit.";
                return;
            }

            // Validate whether the terms and conditions checkbox is checked
            if (!chkTerms.Checked)
            {
                lblMessage.Text = "Please accept the terms and conditions.";
                return;
            }

            // If all validations pass, you can proceed with further actions
            // For example, you might save the data to a database or perform other business logic

            lblMessage.Text = "Validation successful. Proceed with further actions.";
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Helper method to validate password strength
        private bool IsValidPassword(string password)
        {
            // Customize the password strength requirements as needed
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);
        }

        // Custom validator for checking if the checkbox is checked
        protected void CustomValidator_Terms(object source, ServerValidateEventArgs args)
        {
            args.IsValid = chkTerms.Checked;
        }
    }
}
    
