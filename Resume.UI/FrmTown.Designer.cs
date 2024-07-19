namespace Resume.UI;

partial class FrmTown
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		btnRemove = new Button();
		btnClear = new Button();
		btnGetRemove = new Button();
		gbxTownUpdate = new GroupBox();
		btnUpdate = new Button();
		cbxIsActive = new CheckBox();
		cbxIsDeleted = new CheckBox();
		txtName = new TextBox();
		label2 = new Label();
		txtId = new TextBox();
		label1 = new Label();
		gbxTownList = new GroupBox();
		dgvTowns = new DataGridView();
		gbxTownInsert = new GroupBox();
		cmbCities = new ComboBox();
		lblTownName = new Label();
		txtTownName = new TextBox();
		lblCityName = new Label();
		btnSave = new Button();
		gbxTownUpdate.SuspendLayout();
		gbxTownList.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvTowns).BeginInit();
		gbxTownInsert.SuspendLayout();
		SuspendLayout();
		// 
		// btnRemove
		// 
		btnRemove.Location = new Point(238, 125);
		btnRemove.Name = "btnRemove";
		btnRemove.Size = new Size(75, 23);
		btnRemove.TabIndex = 11;
		btnRemove.Text = "Sil";
		btnRemove.UseVisualStyleBackColor = true;
		// 
		// btnClear
		// 
		btnClear.Location = new Point(157, 125);
		btnClear.Name = "btnClear";
		btnClear.Size = new Size(75, 23);
		btnClear.TabIndex = 10;
		btnClear.Text = "Temizle";
		btnClear.UseVisualStyleBackColor = true;
		// 
		// btnGetRemove
		// 
		btnGetRemove.Location = new Point(14, 125);
		btnGetRemove.Name = "btnGetRemove";
		btnGetRemove.Size = new Size(137, 23);
		btnGetRemove.TabIndex = 9;
		btnGetRemove.Text = "Silinenleri Getir";
		btnGetRemove.UseVisualStyleBackColor = true;
		// 
		// gbxTownUpdate
		// 
		gbxTownUpdate.Controls.Add(btnUpdate);
		gbxTownUpdate.Controls.Add(cbxIsActive);
		gbxTownUpdate.Controls.Add(cbxIsDeleted);
		gbxTownUpdate.Controls.Add(txtName);
		gbxTownUpdate.Controls.Add(label2);
		gbxTownUpdate.Controls.Add(txtId);
		gbxTownUpdate.Controls.Add(label1);
		gbxTownUpdate.Location = new Point(251, 12);
		gbxTownUpdate.Name = "gbxTownUpdate";
		gbxTownUpdate.Size = new Size(323, 107);
		gbxTownUpdate.TabIndex = 8;
		gbxTownUpdate.TabStop = false;
		gbxTownUpdate.Text = "Town Update";
		// 
		// btnUpdate
		// 
		btnUpdate.Location = new Point(236, 54);
		btnUpdate.Name = "btnUpdate";
		btnUpdate.Size = new Size(75, 23);
		btnUpdate.TabIndex = 6;
		btnUpdate.Text = "Güncelle";
		btnUpdate.UseVisualStyleBackColor = true;
		// 
		// cbxIsActive
		// 
		cbxIsActive.AutoSize = true;
		cbxIsActive.Location = new Point(165, 56);
		cbxIsActive.Name = "cbxIsActive";
		cbxIsActive.Size = new Size(70, 19);
		cbxIsActive.TabIndex = 5;
		cbxIsActive.Text = "Is Active";
		cbxIsActive.UseVisualStyleBackColor = true;
		// 
		// cbxIsDeleted
		// 
		cbxIsDeleted.AutoSize = true;
		cbxIsDeleted.Location = new Point(165, 27);
		cbxIsDeleted.Name = "cbxIsDeleted";
		cbxIsDeleted.Size = new Size(77, 19);
		cbxIsDeleted.TabIndex = 4;
		cbxIsDeleted.Text = "Is Deleted";
		cbxIsDeleted.UseVisualStyleBackColor = true;
		// 
		// txtName
		// 
		txtName.Location = new Point(53, 54);
		txtName.Name = "txtName";
		txtName.Size = new Size(100, 23);
		txtName.TabIndex = 3;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Location = new Point(3, 57);
		label2.Name = "label2";
		label2.Size = new Size(48, 15);
		label2.TabIndex = 2;
		label2.Text = "Name : ";
		// 
		// txtId
		// 
		txtId.Enabled = false;
		txtId.Location = new Point(53, 25);
		txtId.Name = "txtId";
		txtId.Size = new Size(100, 23);
		txtId.TabIndex = 1;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Location = new Point(24, 28);
		label1.Name = "label1";
		label1.Size = new Size(27, 15);
		label1.TabIndex = 0;
		label1.Text = "ID : ";
		// 
		// gbxTownList
		// 
		gbxTownList.Controls.Add(dgvTowns);
		gbxTownList.Location = new Point(11, 155);
		gbxTownList.Name = "gbxTownList";
		gbxTownList.Size = new Size(563, 194);
		gbxTownList.TabIndex = 7;
		gbxTownList.TabStop = false;
		gbxTownList.Text = "Town List";
		// 
		// dgvTowns
		// 
		dgvTowns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvTowns.Dock = DockStyle.Fill;
		dgvTowns.Location = new Point(3, 19);
		dgvTowns.Name = "dgvTowns";
		dgvTowns.Size = new Size(557, 172);
		dgvTowns.TabIndex = 0;
		// 
		// gbxTownInsert
		// 
		gbxTownInsert.Controls.Add(cmbCities);
		gbxTownInsert.Controls.Add(lblTownName);
		gbxTownInsert.Controls.Add(txtTownName);
		gbxTownInsert.Controls.Add(lblCityName);
		gbxTownInsert.Controls.Add(btnSave);
		gbxTownInsert.Location = new Point(14, 12);
		gbxTownInsert.Name = "gbxTownInsert";
		gbxTownInsert.Size = new Size(231, 107);
		gbxTownInsert.TabIndex = 6;
		gbxTownInsert.TabStop = false;
		gbxTownInsert.Text = "Town Insert";
		// 
		// cmbCities
		// 
		cmbCities.FormattingEnabled = true;
		cmbCities.Location = new Point(94, 18);
		cmbCities.Name = "cmbCities";
		cmbCities.Size = new Size(131, 23);
		cmbCities.TabIndex = 4;
		cmbCities.SelectedIndexChanged += cmbCities_SelectedIndexChanged;
		// 
		// lblTownName
		// 
		lblTownName.AutoSize = true;
		lblTownName.Location = new Point(6, 50);
		lblTownName.Name = "lblTownName";
		lblTownName.Size = new Size(70, 15);
		lblTownName.TabIndex = 3;
		lblTownName.Text = "Town Name";
		// 
		// txtTownName
		// 
		txtTownName.Location = new Point(94, 47);
		txtTownName.Name = "txtTownName";
		txtTownName.Size = new Size(131, 23);
		txtTownName.TabIndex = 2;
		// 
		// lblCityName
		// 
		lblCityName.AutoSize = true;
		lblCityName.Location = new Point(6, 27);
		lblCityName.Name = "lblCityName";
		lblCityName.Size = new Size(63, 15);
		lblCityName.TabIndex = 1;
		lblCityName.Text = "City Name";
		// 
		// btnSave
		// 
		btnSave.Location = new Point(150, 76);
		btnSave.Name = "btnSave";
		btnSave.Size = new Size(75, 23);
		btnSave.TabIndex = 0;
		btnSave.Text = "Kaydet";
		btnSave.UseVisualStyleBackColor = true;
		btnSave.Click += btnSave_Click;
		// 
		// FrmTown
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.LightSeaGreen;
		ClientSize = new Size(584, 361);
		Controls.Add(btnRemove);
		Controls.Add(btnClear);
		Controls.Add(btnGetRemove);
		Controls.Add(gbxTownUpdate);
		Controls.Add(gbxTownList);
		Controls.Add(gbxTownInsert);
		Name = "FrmTown";
		Text = "FrmTown";
		Load += FrmTown_Load;
		gbxTownUpdate.ResumeLayout(false);
		gbxTownUpdate.PerformLayout();
		gbxTownList.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvTowns).EndInit();
		gbxTownInsert.ResumeLayout(false);
		gbxTownInsert.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private Button btnRemove;
	private Button btnClear;
	private Button btnGetRemove;
	private GroupBox gbxTownUpdate;
	private Button btnUpdate;
	private CheckBox cbxIsActive;
	private CheckBox cbxIsDeleted;
	private TextBox txtName;
	private Label label2;
	private TextBox txtId;
	private Label label1;
	private GroupBox gbxTownList;
	private DataGridView dgvTowns;
	private GroupBox gbxTownInsert;
	private TextBox txtTownName;
	private Label lblCityName;
	private Button btnSave;
	private Label lblTownName;
	private ComboBox cmbCities;
}