using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resume.Business.Abstract;
using Resume.Business.DependencyInjection.AutoFac;
using Resume.Entity.Concrete;

namespace Resume.UI;
public partial class FrmAddress : Form
{
    private readonly IAddressService _addressService;
    private readonly ICityService _cityService;
    private readonly ITownService _townService;
    private Address _address;
    public FrmAddress()
    {
        _addressService = InstanceFactory.GetInstance<IAddressService>();
        _cityService = InstanceFactory.GetInstance<ICityService>();
        _townService = InstanceFactory.GetInstance<ITownService>();
        InitializeComponent();
    }


    private void FrmAddress_Load(object sender, EventArgs e)
    {
        ComboBoxFill();
        DataGridFill();
    }

    void CityComboFill()
    {
        cmbCities.DataSource = null;
        cmbCities.DataSource = _cityService.GetAll();
        cmbCities.DisplayMember = "Name";
        cmbCities.ValueMember = "Id";
    }
    void TownComboFill()
    {
        cmbTowns.DataSource = null;
        cmbTowns.DataSource = _townService.GetAllByCity(cmbCities.SelectedValue.ToString());
        cmbTowns.DisplayMember = "Name";
        cmbTowns.ValueMember = "Id";
    }

    void ComboBoxFill()
    {
        CityComboFill();
        TownComboFill();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Address address = new Address();
        address.Street = txtStreet.Text;
        address.District = txtDistrict.Text;
        address.TownId = (Guid)cmbTowns.SelectedValue;
        address.CityId = (Guid)cmbCities.SelectedValue;
        address.PostalCode = txtPostalCode.Text;
        address.BuildNumber = Convert.ToByte(txtBuildNumber.Text);
        if (txtFloor.Text != "")
        {
            address.FloorNumber = Convert.ToByte(txtFloor.Text);
        }

        if (txtApartmentNumber.Text != "")
        {
            address.ApartmentNumber = Convert.ToByte(txtApartmentNumber.Text);
        }

        _addressService.Add(address);
        DataGridFill();
        ComboBoxFill();
        ClearControls();
    }

    void DataGridFill()
    {
        var addresses = _addressService.GetAllQueryable();
        var list = addresses.Select(x => new
        {
            Id = x.Id,
            Mahalle = x.District,
            Sokak = x.Street,
            BinaNo = x.BuildNumber,
            Kat = x.FloorNumber,
            Daire = x.ApartmentNumber,
            İlce = x.Town.Name,
            Sehir = x.City.Name,
            PostaKodu = x.PostalCode
        });
        dgvAddresses.DataSource = list.ToList();
    }

    private void label8_Click(object sender, EventArgs e)
    {
        FrmCity frmCity = new FrmCity();
        frmCity.Show();
    }

    private void lblAddTown_Click(object sender, EventArgs e)
    {
        FrmTown frmTown = new FrmTown();
        frmTown.Show();
    }

    private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
    {
        TownComboFill();
    }

    private void dgvAddresses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        _address = _addressService.GetById(dgvAddresses.CurrentRow.Cells["Id"].Value.ToString());
        UpdateComboBoxFill();
        txtUpdateDistrict.Text = _address.District.ToString();
        txtUpdateStreet.Text = _address.Street.ToString();
        txtUpdateBuildNumber.Text = _address.BuildNumber.ToString();
        txtUpdateFloor.Text = _address.FloorNumber.ToString();
        txtUpdateApartmentNumber.Text = _address.ApartmentNumber.ToString();
        txtUpdatePostalCode.Text = _address.PostalCode.ToString();
        cbxIsActive.Checked = _address.IsActive;
        cbxIsDeleted.Checked = _address.IsDeleted;
    }

    void UpdateComboBoxFill()
    {
        cmbUpdateCities.DataSource = null;
        cmbUpdateTowns.DataSource = null;
        cmbUpdateCities.DataSource = _cityService.GetAll();
        cmbUpdateCities.DisplayMember = "Name";
        cmbUpdateCities.ValueMember = "Id";
        cmbUpdateCities.SelectedValue = _address.CityId;
        cmbUpdateTowns.DataSource = _townService.GetAllByCity(_address.CityId.ToString());
        cmbUpdateTowns.DisplayMember = "Name";
        cmbUpdateTowns.ValueMember = "Id";
        cmbUpdateTowns.SelectedValue = _address.TownId;
    }

    void ClearControls()
    {
        DataGridFill();
        txtDistrict.Clear();
        txtStreet.Clear();
        txtBuildNumber.Clear();
        txtFloor.Clear();
        txtApartmentNumber.Clear();
        txtPostalCode.Clear();
        txtUpdateApartmentNumber.Clear();
        txtUpdateBuildNumber.Clear();
        txtUpdateDistrict.Clear();
        txtUpdateFloor.Clear();
        txtUpdatePostalCode.Clear();
        txtUpdateStreet.Clear();
        cbxIsActive.Checked = true;
        cbxIsDeleted.Checked = false;
        _address = null;
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearControls();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {

    }
}
