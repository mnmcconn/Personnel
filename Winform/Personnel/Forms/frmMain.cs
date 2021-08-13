using Personnel.Data;
using System;
using System.Windows.Forms;

namespace Personnel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            grdEmployee.AutoGenerateColumns = false;            

            // Bind Manager Combo
            cboManager = Utility.InitManagers(cboManager);

            CenterToScreen();
        }
                
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            // Create and show form to add an employee
            using (var frm = new frmAdd((int?)cboManager.SelectedValue))
            {
                frm.ShowDialog();
                
                // Rebind after employee is added
                cboManager = Utility.InitManagers(cboManager, (int?)cboManager.SelectedValue);
            }            
        }
       
        private void cboManager_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadEmployees();
        }


        private void loadEmployees()
        {
            grdEmployee.DataSource = null;

            // If a Manager is selected, bind list of employees for selected manager 
            if (cboManager.SelectedIndex > -1)
            {
                BindingSource source = new BindingSource();
                Employee employee = (Employee)cboManager.SelectedItem;
                source.DataSource = employee.GetEmployees(employee.EmployeeID);
                grdEmployee.DataSource = source;
            }
        }
    }
}
