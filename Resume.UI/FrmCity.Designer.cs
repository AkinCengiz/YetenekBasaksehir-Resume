namespace Resume.UI;

partial class FrmCity
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
		gbxCityInsert = new GroupBox();
		txtCityName = new TextBox();
		lblCityName = new Label();
		btnSave = new Button();
		gbxCityList = new GroupBox();
		dgvCities = new DataGridView();
		gbxCityUpdate = new GroupBox();
		btnUpdate = new Button();
		cbxIsActive = new CheckBox();
		cbxIsDeleted = new CheckBox();
		txtName = new TextBox();
		label2 = new Label();
		txtId = new TextBox();
		label1 = new Label();
		btnGetRemove = new Button();
		btnClear = new Button();
		btnRemove = new Button();
		gbxCityInsert.SuspendLayout();
		gbxCityList.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvCities).BeginInit();
		gbxCityUpdate.SuspendLayout();
		SuspendLayout();
		// 
		// gbxCityInsert
		// 
		gbxCityInsert.Controls.Add(txtCityName);
		gbxCityInsert.Controls.Add(lblCityName);
		gbxCityInsert.Controls.Add(btnSave);
		gbxCityInsert.Location = new Point(12, 12);
		gbxCityInsert.Name = "gbxCityInsert";
		gbxCityInsert.Size = new Size(200, 107);
		gbxCityInsert.TabIndex = 0;
		gbxCityInsert.TabStop = false;
		gbxCityInsert.Text = "City Insert";
		// 
		// txtCityName
		// 
		txtCityName.Location = new Point(94, 25);
		txtCityName.Name = "txtCityName";
		txtCityName.Size = new Size(100, 23);
		txtCityName.TabIndex = 2;
		// 
		// lblCityName
		// 
		lblCityName.AutoSize = true;
		lblCityName.Location = new Point(6, 28);
		lblCityName.Name = "lblCityName";
		lblCityName.Size = new Size(63, 15);
		lblCityName.TabIndex = 1;
		lblCityName.Text = "City Name";
		// 
		// btnSave
		// 
		btnSave.Location = new Point(119, 54);
		btnSave.Name = "btnSave";
		btnSave.Size = new Size(75, 23);
		btnSave.TabIndex = 0;
		btnSave.Text = "Kaydet";
		btnSave.UseVisualStyleBackColor = true;
		btnSave.Click += btnSave_Click;
		// 
		// gbxCityList
		// 
		gbxCityList.Controls.Add(dgvCities);
		gbxCityList.Location = new Point(9, 155);
		gbxCityList.Name = "gbxCityList";
		gbxCityList.Size = new Size(563, 194);
		gbxCityList.TabIndex = 1;
		gbxCityList.TabStop = false;
		gbxCityList.Text = "City List";
		// 
		// dgvCities
		// 
		dgvCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvCities.Dock = DockStyle.Fill;
		dgvCities.Location = new Point(3, 19);
		dgvCities.Name = "dgvCities";
		dgvCities.Size = new Size(557, 172);
		dgvCities.TabIndex = 0;
		dgvCities.CellDoubleClick += dgvCities_CellDoubleClick;
		// 
		// gbxCityUpdate
		// 
		gbxCityUpdate.Controls.Add(btnUpdate);
		gbxCityUpdate.Controls.Add(cbxIsActive);
		gbxCityUpdate.Controls.Add(cbxIsDeleted);
		gbxCityUpdate.Controls.Add(txtName);
		gbxCityUpdate.Controls.Add(label2);
		gbxCityUpdate.Controls.Add(txtId);
		gbxCityUpdate.Controls.Add(label1);
		gbxCityUpdate.Location = new Point(218, 12);
		gbxCityUpdate.Name = "gbxCityUpdate";
		gbxCityUpdate.Size = new Size(354, 107);
		gbxCityUpdate.TabIndex = 2;
		gbxCityUpdate.TabStop = false;
		gbxCityUpdate.Text = "City Update";
		// 
		// btnUpdate
		// 
		btnUpdate.Location = new Point(236, 54);
		btnUpdate.Name = "btnUpdate";
		btnUpdate.Size = new Size(75, 23);
		btnUpdate.TabIndex = 6;
		btnUpdate.Text = "Güncelle";
		btnUpdate.UseVisualStyleBackColor = true;
		btnUpdate.Click += btnUpdate_Click;
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
		// btnGetRemove
		// 
		btnGetRemove.Location = new Point(12, 125);
		btnGetRemove.Name = "btnGetRemove";
		btnGetRemove.Size = new Size(137, 23);
		btnGetRemove.TabIndex = 3;
		btnGetRemove.Text = "Silinenleri Getir";
		btnGetRemove.UseVisualStyleBackColor = true;
		btnGetRemove.Click += btnGetRemove_Click;
		// 
		// btnClear
		// 
		btnClear.Location = new Point(155, 125);
		btnClear.Name = "btnClear";
		btnClear.Size = new Size(75, 23);
		btnClear.TabIndex = 4;
		btnClear.Text = "Temizle";
		btnClear.UseVisualStyleBackColor = true;
		btnClear.Click += btnClear_Click;
		// 
		// btnRemove
		// 
		btnRemove.Location = new Point(236, 125);
		btnRemove.Name = "btnRemove";
		btnRemove.Size = new Size(75, 23);
		btnRemove.TabIndex = 5;
		btnRemove.Text = "Sil";
		btnRemove.UseVisualStyleBackColor = true;
		btnRemove.Click += btnRemove_Click;
		// 
		// FrmCity
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.DarkOliveGreen;
		ClientSize = new Size(584, 361);
		Controls.Add(btnRemove);
		Controls.Add(btnClear);
		Controls.Add(btnGetRemove);
		Controls.Add(gbxCityUpdate);
		Controls.Add(gbxCityList);
		Controls.Add(gbxCityInsert);
		Name = "FrmCity";
		Text = "FrmCity";
		Load += FrmCity_Load;
		gbxCityInsert.ResumeLayout(false);
		gbxCityInsert.PerformLayout();
		gbxCityList.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvCities).EndInit();
		gbxCityUpdate.ResumeLayout(false);
		gbxCityUpdate.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private GroupBox gbxCityInsert;
	private TextBox txtCityName;
	private Label lblCityName;
	private Button btnSave;
	private GroupBox gbxCityList;
	private DataGridView dgvCities;
	private GroupBox gbxCityUpdate;
	private TextBox txtId;
	private Label label1;
	private Button btnUpdate;
	private CheckBox cbxIsActive;
	private CheckBox cbxIsDeleted;
	private TextBox txtName;
	private Label label2;
	private Button btnGetRemove;
	private Button btnClear;
	private Button btnRemove;
}