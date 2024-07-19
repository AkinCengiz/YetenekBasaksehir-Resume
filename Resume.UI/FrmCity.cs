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
public partial class FrmCity : Form
{
	//ICityService ile bağlanılacak
	//private readonly ICityService _cityService;


	private readonly ICityService _cityService;
	private City _city;
	public FrmCity()
	{

		_cityService = InstanceFactory.GetInstance<ICityService>();
		InitializeComponent();
	}

	private void FrmCity_Load(object sender, EventArgs e)
	{
		ClearControls();
	}

	private void DataGridFill()
	{
		var cities = _cityService.GetAll();
		dgvCities.DataSource = cities;
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		var city = new City
		{
			Name = txtCityName.Text
		};
		_cityService.Add(city);
		ClearControls();
	}

	private void dgvCities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		string id = dgvCities.CurrentRow.Cells["Id"].Value.ToString();

		//1 YÖNTEM
		//_city = _cityService.GetById(id);
		//txtName.Text = _city.Name;
		//txtId.Text = _city.Id.ToString();
		//cbxIsActive.Checked = _city.IsActive;
		//cbxIsDeleted.Checked = _city.IsDeleted;

		//2 YÖNTEM
		txtId.Text = dgvCities.CurrentRow.Cells["Id"].Value.ToString();
		txtName.Text = dgvCities.CurrentRow.Cells["Name"].Value.ToString();
		cbxIsActive.Checked = Convert.ToBoolean(dgvCities.CurrentRow.Cells["IsActive"].Value);
		cbxIsDeleted.Checked = Convert.ToBoolean(dgvCities.CurrentRow.Cells["IsDeleted"].Value);
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		_city = _cityService.GetById(txtId.Text);
		if (_city != null)
		{
			_city.Name = txtName.Text;
			_city.IsActive = cbxIsActive.Checked;
			_city.IsDeleted = cbxIsDeleted.Checked;
		}
		_cityService.Update(_city);
		ClearControls();
	}

	private void btnGetRemove_Click(object sender, EventArgs e)
	{
		dgvCities.DataSource = _cityService.GetByIsDeleted();
	}

	private void btnClear_Click(object sender, EventArgs e)
	{
		ClearControls();
	}

	private void ClearControls()
	{
		txtId.Clear();
		txtName.Clear();
		txtCityName.Clear();
		cbxIsActive.Checked = true;
		cbxIsDeleted.Checked = false;
		DataGridFill();
	}

	private void btnRemove_Click(object sender, EventArgs e)
	{
		_city = _cityService.GetById(txtId.Text);
		if (_city != null)
		{
			_cityService.Delete(_city);
		}
		ClearControls();
	}
}
