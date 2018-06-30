using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySQLLibrary;

namespace Övning_30
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Kollar om man besökt där tidigare. Om inte, så ladda all data från databasen
            {
                foreach (var p in SQL.ReadDatabase())
                {
                    ListBoxContacts.Items.Add($"{p.FirstName} {p.LastName}");
                }
            }
        }

        protected void ListBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // För att den ska funka måste man slå på postback för att möjliggöra att ASP.NET kan bygga om hemsidan varje gång man ex byter index
            if (ListBoxContacts.SelectedIndex >= 0) //måste kolla så att det finns något selekterat i listan
            {
                Person p = SQL.ReadDatabase()[ListBoxContacts.SelectedIndex];

                TextBoxFirstname.Text = p.FirstName;
                TextBoxLastname.Text = p.LastName;
                TextBoxSSN.Text = p.SSN;
            }
        }

        // Add
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            ListBoxContacts.Items.Add($"{TextBoxFirstname.Text} {TextBoxLastname.Text}");

            SQL.AddContact(TextBoxFirstname.Text, TextBoxLastname.Text, TextBoxSSN.Text);

            TextBoxFirstname.Text = "";
            TextBoxLastname.Text = "";
            TextBoxSSN.Text = "";
        }
         
        // Remove
        protected void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex >= 0)
            {
                Person p = SQL.ReadDatabase()[ListBoxContacts.SelectedIndex];

                SQL.DeleteContact(p.SSN);

                ListBoxContacts.Items.RemoveAt(ListBoxContacts.SelectedIndex);

                TextBoxFirstname.Text = "";
                TextBoxLastname.Text = "";
                TextBoxSSN.Text = "";
            }
        }

        // Update
        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (ListBoxContacts.SelectedIndex >= 0)
            {
                Person p = SQL.ReadDatabase()[ListBoxContacts.SelectedIndex];

                p.FirstName = TextBoxFirstname.Text;
                p.LastName = TextBoxLastname.Text;
                p.SSN = TextBoxSSN.Text;

                //Update
                SQL.UpdateContact(p);
                ListBoxContacts.Items[ListBoxContacts.SelectedIndex].Text = $"{TextBoxFirstname.Text} {TextBoxLastname.Text}";

                //ListBoxContacts

                TextBoxFirstname.Text = "";
                TextBoxLastname.Text = "";
                TextBoxSSN.Text = "";


                //if (Req["cid"] != null) // Page.Request[] förkortas till Req[]
                //{

                //}
            }
        }
    }
}