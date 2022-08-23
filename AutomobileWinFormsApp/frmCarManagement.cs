using AutomobileLibrary.Repository;
using AutomobileLibrary.BusinessObjects;
namespace AutomobileWinFormsApp
{
    public partial class frmManagementCar : Form
    {
        private ICarRepository _carRepository;
        private BindingSource _bindingSource;
        public frmManagementCar()
        {
            InitResource();
            InitializeComponent();
        }

        private void InitResource()
        {
            _carRepository = new CarRepository();
            _bindingSource = new BindingSource();
        }

        private void frmManagementCar_Load(object sender, EventArgs e)
        {
            //load data from db to dgv
            LoadCarList();

        }

        private void LoadCarList()
        {
            IEnumerable<Car> cars = _carRepository.GetCars();
            try
            {
                this._bindingSource.DataSource = cars;
                dgvCarList.DataSource = null; //reset dgv
                dgvCarList.DataSource = this._bindingSource;
                if (cars.Count() == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void btnSave_Click(object sender, EventArgs e)
        {
            //Thuc thi viec validation va add to database
            //1. Hien thi form frmDetail de thuc hien them moi
            frmCarDetails carDetail = new frmCarDetails(this._carRepository, false,
              LoadCarList  
              );
            if(carDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                this._bindingSource.Position = this._bindingSource.Count - 1;
            }
            
        }

        private void dgvCarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. Lay 1 dòng trong datagridview
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvCarList.Rows[rowIndex];
            //2. convert a row to object Car
            //Object inialize
            var c = new Car
            {
                CarID = int.Parse(row.Cells[0].Value.ToString()),
                CarName = row.Cells[1].Value.ToString(),
                Manufacturer = row.Cells[2].Value.ToString(),
                Price = decimal.Parse(row.Cells[3].Value.ToString()),
                ReleaseYear = int.Parse(row.Cells[4].Value.ToString())

            };
            //3. khoi tao doi tuong CarDetail thong qua constructor


            frmCarDetails frmCar = new frmCarDetails(_carRepository,true,c);
            frmCar.Show();
        }

        private void dgvCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}