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
using Resume.Business.Concrete;
using Resume.Business.DependencyInjection.AutoFac;
using Resume.Entity.Concrete;

namespace Resume.UI;
public partial class FrmTown : Form
{
	private readonly ITownService _townService;
	private readonly ICityService _cityService;
	private Town _town;
	public FrmTown()
	{
		_townService = InstanceFactory.GetInstance<ITownService>();
		_cityService = InstanceFactory.GetInstance<ICityService>();
		InitializeComponent();
	}

	private void FrmTown_Load(object sender, EventArgs e)
	{
		ComboBoxFill();
		DataGridFill();
	}

	void DataGridFill()
	{
		var towns = _townService.GetAllQueryable();
		var list = towns.Select(x => new { Id= x.Id,Name = x.Name,City = x.City.Name, UpdateAt = x.UpdateAt }).OrderBy(x => x.City).ThenBy(x => x.Name);
		dgvTowns.DataSource = list.ToList();
		//dgvTowns.Columns.Add("CityName", "CityName");

	}

	void ComboBoxFill()
	{
		cmbCities.DataSource = _cityService.GetAll();
		cmbCities.DisplayMember = "Name";
		cmbCities.ValueMember = "Id";
	}

	private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		Town town = new();
		town.Name = txtTownName.Text;
		town.CityId = (Guid)cmbCities.SelectedValue;
		_townService.Add(town);
		ClearControls();
	}

	void ClearControls()
	{
		txtTownName.Clear();
		ComboBoxFill();
		DataGridFill();
	}
}
