using Personnel.Data;
using System.Windows.Forms;

namespace Personnel
{
    static public class Utility
    {
        // Initialize Manager Combo
        public static ComboBox InitManagers(ComboBox cboManager, int? managerID = null)
        {
            Employee employee = new Employee();

            // Bind Manager Dropdown
            cboManager.DataSource = null;
            cboManager.DataSource = employee.GetManagers();
            cboManager.DisplayMember = "DisplayName";
            cboManager.ValueMember = "EmployeeID";
            cboManager.SelectedValue = managerID ?? -1;

            return cboManager;
        }       
    }
}
