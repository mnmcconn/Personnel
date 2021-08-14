using Personnel.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;

namespace Personnel
{
    public partial class frmAdd : Form
    {

        private int? _managerID;

        public frmAdd(int? managerID)
        {
            InitializeComponent();
            
            _managerID = managerID;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            // Bind Manager Combo - set to same manager as parent form.
            cboManager = Utility.InitManagers(cboManager, _managerID);

            // Bind Role Listbox
            Role role = new Role();
            lstRoles.DataSource = null;
            lstRoles.DataSource = role.GetRoles();
            lstRoles.DisplayMember = "Description";
            lstRoles.ValueMember = "RoleID";
            lstRoles.SelectedIndex = -1;
          
            CenterToParent();
        }
        
        private void cmdSave_Click(object sender, EventArgs e)
        {
            // If form is invalid, abort save process
            if (!Valid())
            {
                return;
            }          

            try
            {
                using (PersonnelEntities db = new PersonnelEntities())
                {
                    // Create employee object
                    Employee employee = new Employee
                    {
                        ManagerID = _managerID,
                        EmployeeCode = txtEmployeeID.Text,
                        LastName = txtLastName.Text,
                        FirstName = txtFirstName.Text,
                        CreatedOn = DateTime.UtcNow
                    };

                    // Add selected roles
                    foreach (Role r in lstRoles.SelectedItems)
                    {
                        employee.Roles.Add(r);
                        db.Entry(r).State = EntityState.Unchanged;
                    }

                    // Save employee
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving Employee: {String.Concat(ex.Message, Environment.NewLine, ex.InnerException?.Message)}");
            }

            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private bool Valid()
        {
            List<string> errors = new List<string>();

            if (lstRoles.SelectedIndices.Count == 0)
            {
                errors.Add("At least one role is required.");
            }
            if (txtFirstName.TextLength == 0)
            {
                errors.Add("First Name is required.");
            }
            if (txtLastName.TextLength == 0)
            {
                errors.Add("Last Name is required.");
            }
            if (txtEmployeeID.TextLength == 0)
            {
                errors.Add("Employee ID is required.");
            }
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors));
                return false;
            }
            return true;
        }
    }
}
