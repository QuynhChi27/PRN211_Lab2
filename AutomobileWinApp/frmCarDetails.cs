using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp
{

    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdaters { get; set; }

        public Car CarInfo { get; set; }





        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdaters;
            if (InsertOrUpdaters == true)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtCarName.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleasedYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtCarName.Text),
                    ReleasedYear = int.Parse(txtReleaseYear.Text),
                };
                if (InsertOrUpdaters == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdaters == false ? "Add a new car" : "Update a car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
