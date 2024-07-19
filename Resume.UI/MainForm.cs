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
using Resume.DataAccess.Concrete.EntityFramework;

namespace Resume.UI;
public partial class MainForm : Form
{

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnCity_Click(object sender, EventArgs e)
    {
        //FrmCity frmCity = new(new CityManager(new EfCityDal(new ResumeDbContext())));
        FrmCity frmCity = new();

        frmCity.Show();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void btnTownProcess_Click(object sender, EventArgs e)
    {
        FrmTown frmTown = new();

        /*
		FrmCity frmCity = new(int id,string name, bool isActive );
		new(
		new TownManager(new EfTownDal(new ResumeDbContext())),
		new CityManager(new EfCityDal(new ResumeDbContext())))
		*/
        frmTown.Show();
    }

    private void btnAddress_Click(object sender, EventArgs e)
    {
        FrmAddress frmAddres = new();
        frmAddres.Show();
    }
}
