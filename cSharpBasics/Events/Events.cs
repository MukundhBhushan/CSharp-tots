using System;

namespace cSharpBasic
{
    class Program
    {
        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.show("Mouse Entered");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String firstname = txtFirstName.text; //text box1 lable name
            String lastname = txtLastName.text; //text box 2 lable name
            string fullname = firstname + lastname;
            txtResult.text = fullname;// txtresult is text box 3 lable
        }
    }
    
    

}

