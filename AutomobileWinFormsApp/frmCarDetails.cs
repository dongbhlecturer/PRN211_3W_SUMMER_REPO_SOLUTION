using AutomobileLibrary.Repository;
using AutomobileLibrary.BusinessObjects;

namespace AutomobileWinFormsApp
{
    public partial class frmCarDetails : Form
    {

        private frmManagementCar frmCar;
        private Action action;
     
        /*Su dung API de connect db*/
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Car CarInfo { get; set; }


        public frmCarDetails()
        {
            CarRepository = new CarRepository();
            InitializeComponent();
        }

        public frmCarDetails(ICarRepository carRepository, bool insertOrUpdate, Action action)
            
        {
            this.action = action;
            CarRepository = carRepository;
            InsertOrUpdate = insertOrUpdate;
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            //1. load toan bo Manufacturer vao combobox
            cboManu.Items.AddRange(CarRepository.GetAllManufacturers());
            cboManu.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate is true)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName.ToString();
                mskPrice.Text = CarInfo.Price.ToString();
                mskYear.Text=CarInfo.ReleaseYear.ToString();    
                cboManu.Text = CarInfo.Manufacturer.ToString();
            }
        }

        private void cboSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = new(); //C#9.0
                c.CarID=int.Parse(txtCarID.Text); //convert string to int
                c.CarName=txtCarName.Text;
                c.Manufacturer = cboManu.Text;
                c.Price = decimal.Parse(mskPrice.Text);
                c.ReleaseYear = int.Parse(mskYear.Text);
                if (!InsertOrUpdate)
                {
                    CarRepository.AddCar(c);
                    //Phai load lai dgv
                    action.Invoke();
                    //hide form add/reset
                }
                else
                {
                    CarRepository.UpdateCar(c);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
