using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport.Models;

namespace Airport
{
    public partial class Form1 : Form
    {
        AirportEntities db = new AirportEntities();
        private Fligt selectedFlight;

        public Form1()
        {
            InitializeComponent();

            loadData();
            fillCompanyToCombobox();
            fillCountryToCombobox();
            fillGateToCombobox();
            fillRunwayToCombobox();


        }
        private void AddFlightbtn_Click(object sender, EventArgs e)
        {
            Fligt flg = new Fligt();
            string name = Companycb.Text;
            string Company = Companycb.Text;
            string City = Citycb.Text;
            int Runway = getRunwayIdByName(Runwaycb.Text);
            int Gate = getGateIdByName(Gatecb.Text);
            DateTime date = FlightDate.Value;
            DateTime GateFullTimeBefore = date.AddMinutes(-30);
            DateTime GateFullTimeAfter = date.AddMinutes(30);
            List<Fligt> checkGate = db.Fligts.Where(c => c.FlightDate >= GateFullTimeBefore && c.FlightDate <= GateFullTimeAfter && c.GateID == Gate).ToList();
            DateTime runwayFullTimeBefore = date.AddMinutes(-45);
            DateTime runwayFullTimeAfter = date.AddMinutes(45);
            List<Fligt> checkRunway = db.Fligts.Where(c => c.FlightDate >= runwayFullTimeBefore && c.FlightDate <= runwayFullTimeAfter && c.RunwayID == Runway).ToList();

            if (!(City == string.Empty || Company == string.Empty || Runwaycb.Text == string.Empty || Gatecb.Text == string.Empty))
            {
                if (!(checkGate.Count > 0 || checkRunway.Count > 0))
                {
                    flg.FlightDate = FlightDate.Value;
                    flg.CompanyID = getCompanyIdByName(Company);
                    flg.CityID = getCityIdByName(City);
                    flg.RunwayID = Runway;
                    flg.GateID = Gate;
                    flg.FlightDate = FlightDate.Value;
                    if (arivalbtn.Checked == true)
                    {
                        flg.Type = 1;


                    }
                    if (departurebtn.Checked == true)
                    {
                        flg.Type = 0;
                    }
                    db.Fligts.Add(flg);
                    db.SaveChanges();
                    loadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("bu zamana gediw yoxdu ");
                }

            }
            else
            {
                MessageBox.Show("boxlari doldurun");
            }


        }
        private void loadData()
        {
            Flightdgv.DataSource = db.Fligts.Select(p => new
            {
                p.id,
                Company = p.Company.Name,
                City = p.City.Name,
                Type = p.Type,
                Gate = p.Gate.Name,
                Runway = p.Runway.Name,
                Date = p.FlightDate

            }).ToList();
        }
        private void fillCompanyToCombobox()
        {
            List<Company> list = db.Companies.ToList();

            foreach (Company item in list)
            {
                Companycb.Items.Add(item.Name);
            }
        }
        private void fillCountryToCombobox()
        {
            List<Country> list = db.Countries.ToList();

            foreach (Country item in list)
            {
                Countrycb.Items.Add(item.Name);
            }
        }
        private void fillCityToCombobox()
        {

        }
        private void fillGateToCombobox()
        {
            List<Gate> list = db.Gates.ToList();

            foreach (Gate item in list)
            {
                Gatecb.Items.Add(item.Name);
            }
        }
        private void fillRunwayToCombobox()
        {
            List<Runway> list = db.Runways.ToList();

            foreach (Runway item in list)
            {
                Runwaycb.Items.Add(item.Name);
            }
        }
        private void Countrycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Citycb.Items.Clear();
            int id = getCountryIdByName(Countrycb.Text);
            List<City> city = db.Cities.Where(c => c.CountryID == id).ToList();
            foreach (City item in city)
            {
                Citycb.Items.Add(item.Name);
            }

        }
        private int getCountryIdByName(string name)
        {
            int id = db.Countries.FirstOrDefault(c => c.Name == name).id;
            return id;
        }
        private int getCityIdByName(string name)
        {
            return db.Cities.FirstOrDefault(c => c.Name == name).id;
        }
        private int getCompanyIdByName(string name)
        {
            return db.Companies.FirstOrDefault(c => c.Name == name).id;
        }
        private int getRunwayIdByName(string name)
        {
            return db.Runways.FirstOrDefault(c => c.Name == name).id;
        }
        private int getGateIdByName(string name)
        {
            return db.Gates.FirstOrDefault(c => c.Name == name).id;
        }
        private void Clear()
        {
            Citycb.Text = "";
            Countrycb.Text = "";
            Companycb.Text = "";
            Gatecb.Text = "";
            Runwaycb.Text = "";
            AddFlightbtn.Visible = true;
            Updatebtn.Visible = false;
            Deletebtn.Visible = false;
        }

        private void Flightdgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(Flightdgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.selectedFlight = db.Fligts.Find(id);
            Companycb.Text = this.selectedFlight.Company.Name;
            Countrycb.Text = this.selectedFlight.City.Country.Name;
            Gatecb.Text = this.selectedFlight.Gate.Name;
            Runwaycb.Text = this.selectedFlight.Runway.Name;
            Citycb.Text = this.selectedFlight.City.Name;
            AddFlightbtn.Visible = false;
            Updatebtn.Visible = true;
            Deletebtn.Visible = true;

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("silmek isteyirsiz?", "Sil", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.Fligts.Remove(this.selectedFlight);
                db.SaveChanges();
                loadData();
                Clear();
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string name = Companycb.Text;
            string Company = Companycb.Text;
            string City = Citycb.Text;
            int Runway = getRunwayIdByName(Runwaycb.Text);
            int Gate = getGateIdByName(Gatecb.Text);
            DateTime date = FlightDate.Value;
            DateTime GateFullTimeBefore = date.AddMinutes(-30);
            DateTime GateFullTimeAfter = date.AddMinutes(30);
            List<Fligt> checkGate = db.Fligts.Where(c => c.FlightDate >= GateFullTimeBefore && c.FlightDate <= GateFullTimeAfter && c.GateID == Gate).ToList();
            DateTime runwayFullTimeBefore = date.AddMinutes(-45);
            DateTime runwayFullTimeAfter = date.AddMinutes(45);
            List<Fligt> checkRunway = db.Fligts.Where(c => c.FlightDate >= runwayFullTimeBefore && c.FlightDate <= runwayFullTimeAfter && c.RunwayID == Runway).ToList();
            if (!(City == string.Empty || Company == string.Empty || Runwaycb.Text == string.Empty || Gatecb.Text == string.Empty))
            {
                if (!(checkGate.Count > 0 || checkRunway.Count > 0))
                {
                    this.selectedFlight.FlightDate = FlightDate.Value;
                    this.selectedFlight.CompanyID = getCompanyIdByName(Company);
                    this.selectedFlight.CityID = getCityIdByName(City);
                    this.selectedFlight.RunwayID = Runway;
                    this.selectedFlight.GateID = Gate;
                    this.selectedFlight.FlightDate = FlightDate.Value;
                    if (arivalbtn.Checked == true)
                    {
                        this.selectedFlight.Type = 1;


                    }
                    if (departurebtn.Checked == true)
                    {
                        this.selectedFlight.Type = 0;
                    }
                    db.SaveChanges();
                    loadData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("bu zamana gediw yoxdu");
                }
            }
            else
            {
                MessageBox.Show("boxlari doldurun");
                return;
            }

            
           
        }
    }
}
    