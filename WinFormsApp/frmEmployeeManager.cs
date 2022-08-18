using DataAccess.Entities;
using DataAccess.BusinessLogic;
namespace WinFormsApp;

public partial class frmEmployeeManager : Form
{
    private EmployeeManager employeeManager;
    public frmEmployeeManager()
    {
        employeeManager = new EmployeeManager();
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void cboType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        /*1. tập hợp các value của Employee từ form*/
        int employeeID;
        string  employeeName, employeeType, phone;
        bool gender;

        /*Goi ham validation all data from the form*/
        employeeID = int.Parse(txtEmployeeID.Text); //convert string to int
        employeeName = txtEmployeeName.Text;
        employeeType = cboType.Text;
        phone = mskPhone.Text;
        gender = radMale.Checked ? true : false;
        /*2. validation các value*/
        //Tu check
        Employee emp= new Employee(employeeID, employeeName, phone,
            gender, employeeType);

        /*3. gọi tới lớp EmployeeManager bên DataAccess assembly*/
        employeeManager.AddEmployee(emp);
        List<Employee> emps = employeeManager.GetAllEmployee();
        this.dgvEmployees.DataSource = null;
        this.dgvEmployees.DataSource = emps;

        MessageBox.Show("Employee has been added...");
    }

    private void frmEmployeeManager_Load(object sender, EventArgs e)
    {
        //default data for dgv
        List<Employee> employees = employeeManager.GetAllEmployee();
        this.dgvEmployees.DataSource = employees;
    }
    /**/
}
