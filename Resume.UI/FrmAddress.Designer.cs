namespace Resume.UI;

partial class FrmAddress
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
        gbxCityUpdate = new GroupBox();
        txtUpdateApartmentNumber = new TextBox();
        label9 = new Label();
        txtUpdateFloor = new TextBox();
        label10 = new Label();
        txtUpdateBuildNumber = new TextBox();
        label13 = new Label();
        cmbUpdateTowns = new ComboBox();
        cmbUpdateCities = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        txtUpdatePostalCode = new TextBox();
        label8 = new Label();
        txtUpdateStreet = new TextBox();
        label11 = new Label();
        txtUpdateDistrict = new TextBox();
        label12 = new Label();
        btnUpdate = new Button();
        cbxIsActive = new CheckBox();
        cbxIsDeleted = new CheckBox();
        gbxCityList = new GroupBox();
        dgvAddresses = new DataGridView();
        gbxCityInsert = new GroupBox();
        lblAddTown = new Label();
        lblAddCity = new Label();
        cmbTowns = new ComboBox();
        cmbCities = new ComboBox();
        label7 = new Label();
        label6 = new Label();
        txtPostalCode = new TextBox();
        label5 = new Label();
        txtApartmentNumber = new TextBox();
        label4 = new Label();
        txtFloor = new TextBox();
        label3 = new Label();
        txtBuildNumber = new TextBox();
        lblBuildNumber = new Label();
        txtStreet = new TextBox();
        lblStreet = new Label();
        txtDistrict = new TextBox();
        lblCityName = new Label();
        btnSave = new Button();
        gbxCityUpdate.SuspendLayout();
        gbxCityList.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAddresses).BeginInit();
        gbxCityInsert.SuspendLayout();
        SuspendLayout();
        // 
        // btnRemove
        // 
        btnRemove.Location = new Point(236, 193);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new Size(75, 23);
        btnRemove.TabIndex = 11;
        btnRemove.Text = "Sil";
        btnRemove.UseVisualStyleBackColor = true;
        btnRemove.Click += btnRemove_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(155, 193);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 23);
        btnClear.TabIndex = 10;
        btnClear.Text = "Temizle";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnGetRemove
        // 
        btnGetRemove.Location = new Point(12, 193);
        btnGetRemove.Name = "btnGetRemove";
        btnGetRemove.Size = new Size(137, 23);
        btnGetRemove.TabIndex = 9;
        btnGetRemove.Text = "Silinenleri Getir";
        btnGetRemove.UseVisualStyleBackColor = true;
        // 
        // gbxCityUpdate
        // 
        gbxCityUpdate.Controls.Add(txtUpdateApartmentNumber);
        gbxCityUpdate.Controls.Add(label9);
        gbxCityUpdate.Controls.Add(txtUpdateFloor);
        gbxCityUpdate.Controls.Add(label10);
        gbxCityUpdate.Controls.Add(txtUpdateBuildNumber);
        gbxCityUpdate.Controls.Add(label13);
        gbxCityUpdate.Controls.Add(cmbUpdateTowns);
        gbxCityUpdate.Controls.Add(cmbUpdateCities);
        gbxCityUpdate.Controls.Add(label1);
        gbxCityUpdate.Controls.Add(label2);
        gbxCityUpdate.Controls.Add(txtUpdatePostalCode);
        gbxCityUpdate.Controls.Add(label8);
        gbxCityUpdate.Controls.Add(txtUpdateStreet);
        gbxCityUpdate.Controls.Add(label11);
        gbxCityUpdate.Controls.Add(txtUpdateDistrict);
        gbxCityUpdate.Controls.Add(label12);
        gbxCityUpdate.Controls.Add(btnUpdate);
        gbxCityUpdate.Controls.Add(cbxIsActive);
        gbxCityUpdate.Controls.Add(cbxIsDeleted);
        gbxCityUpdate.Location = new Point(422, 12);
        gbxCityUpdate.Name = "gbxCityUpdate";
        gbxCityUpdate.Size = new Size(575, 175);
        gbxCityUpdate.TabIndex = 8;
        gbxCityUpdate.TabStop = false;
        gbxCityUpdate.Text = "City Update";
        // 
        // txtUpdateApartmentNumber
        // 
        txtUpdateApartmentNumber.Location = new Point(297, 86);
        txtUpdateApartmentNumber.Name = "txtUpdateApartmentNumber";
        txtUpdateApartmentNumber.Size = new Size(100, 23);
        txtUpdateApartmentNumber.TabIndex = 34;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(248, 90);
        label9.Name = "label9";
        label9.Size = new Size(43, 15);
        label9.TabIndex = 33;
        label9.Text = "Daire : ";
        // 
        // txtUpdateFloor
        // 
        txtUpdateFloor.Location = new Point(297, 57);
        txtUpdateFloor.Name = "txtUpdateFloor";
        txtUpdateFloor.Size = new Size(100, 23);
        txtUpdateFloor.TabIndex = 32;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(258, 60);
        label10.Name = "label10";
        label10.Size = new Size(33, 15);
        label10.TabIndex = 31;
        label10.Text = "Kat : ";
        // 
        // txtUpdateBuildNumber
        // 
        txtUpdateBuildNumber.Location = new Point(297, 28);
        txtUpdateBuildNumber.Name = "txtUpdateBuildNumber";
        txtUpdateBuildNumber.Size = new Size(100, 23);
        txtUpdateBuildNumber.TabIndex = 30;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(233, 31);
        label13.Name = "label13";
        label13.Size = new Size(58, 15);
        label13.TabIndex = 29;
        label13.Text = "Bina No : ";
        // 
        // cmbUpdateTowns
        // 
        cmbUpdateTowns.FormattingEnabled = true;
        cmbUpdateTowns.Location = new Point(105, 57);
        cmbUpdateTowns.Name = "cmbUpdateTowns";
        cmbUpdateTowns.Size = new Size(121, 23);
        cmbUpdateTowns.TabIndex = 28;
        // 
        // cmbUpdateCities
        // 
        cmbUpdateCities.FormattingEnabled = true;
        cmbUpdateCities.Location = new Point(105, 28);
        cmbUpdateCities.Name = "cmbUpdateCities";
        cmbUpdateCities.Size = new Size(121, 23);
        cmbUpdateCities.TabIndex = 27;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(65, 61);
        label1.Name = "label1";
        label1.Size = new Size(34, 15);
        label1.TabIndex = 26;
        label1.Text = "İlçe : ";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(57, 31);
        label2.Name = "label2";
        label2.Size = new Size(42, 15);
        label2.TabIndex = 25;
        label2.Text = "Şehir : ";
        // 
        // txtUpdatePostalCode
        // 
        txtUpdatePostalCode.Location = new Point(105, 145);
        txtUpdatePostalCode.Name = "txtUpdatePostalCode";
        txtUpdatePostalCode.Size = new Size(121, 23);
        txtUpdatePostalCode.TabIndex = 24;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(23, 148);
        label8.Name = "label8";
        label8.Size = new Size(76, 15);
        label8.TabIndex = 23;
        label8.Text = "Posta Kodu : ";
        // 
        // txtUpdateStreet
        // 
        txtUpdateStreet.Location = new Point(105, 116);
        txtUpdateStreet.Name = "txtUpdateStreet";
        txtUpdateStreet.Size = new Size(121, 23);
        txtUpdateStreet.TabIndex = 20;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(7, 119);
        label11.Name = "label11";
        label11.Size = new Size(92, 15);
        label11.TabIndex = 19;
        label11.Text = "Cadde / Sokak : ";
        // 
        // txtUpdateDistrict
        // 
        txtUpdateDistrict.Location = new Point(105, 87);
        txtUpdateDistrict.Name = "txtUpdateDistrict";
        txtUpdateDistrict.Size = new Size(121, 23);
        txtUpdateDistrict.TabIndex = 18;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(41, 90);
        label12.Name = "label12";
        label12.Size = new Size(58, 15);
        label12.TabIndex = 17;
        label12.Text = "Mahalle : ";
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(322, 137);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Güncelle";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // cbxIsActive
        // 
        cbxIsActive.AutoSize = true;
        cbxIsActive.Location = new Point(330, 113);
        cbxIsActive.Name = "cbxIsActive";
        cbxIsActive.Size = new Size(70, 19);
        cbxIsActive.TabIndex = 5;
        cbxIsActive.Text = "Is Active";
        cbxIsActive.UseVisualStyleBackColor = true;
        // 
        // cbxIsDeleted
        // 
        cbxIsDeleted.AutoSize = true;
        cbxIsDeleted.Location = new Point(247, 113);
        cbxIsDeleted.Name = "cbxIsDeleted";
        cbxIsDeleted.Size = new Size(77, 19);
        cbxIsDeleted.TabIndex = 4;
        cbxIsDeleted.Text = "Is Deleted";
        cbxIsDeleted.UseVisualStyleBackColor = true;
        // 
        // gbxCityList
        // 
        gbxCityList.Controls.Add(dgvAddresses);
        gbxCityList.Location = new Point(9, 223);
        gbxCityList.Name = "gbxCityList";
        gbxCityList.Size = new Size(1002, 370);
        gbxCityList.TabIndex = 7;
        gbxCityList.TabStop = false;
        gbxCityList.Text = "City List";
        // 
        // dgvAddresses
        // 
        dgvAddresses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAddresses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAddresses.Dock = DockStyle.Fill;
        dgvAddresses.Location = new Point(3, 19);
        dgvAddresses.Name = "dgvAddresses";
        dgvAddresses.Size = new Size(996, 348);
        dgvAddresses.TabIndex = 0;
        dgvAddresses.CellDoubleClick += dgvAddresses_CellDoubleClick;
        // 
        // gbxCityInsert
        // 
        gbxCityInsert.Controls.Add(lblAddTown);
        gbxCityInsert.Controls.Add(lblAddCity);
        gbxCityInsert.Controls.Add(cmbTowns);
        gbxCityInsert.Controls.Add(cmbCities);
        gbxCityInsert.Controls.Add(label7);
        gbxCityInsert.Controls.Add(label6);
        gbxCityInsert.Controls.Add(txtPostalCode);
        gbxCityInsert.Controls.Add(label5);
        gbxCityInsert.Controls.Add(txtApartmentNumber);
        gbxCityInsert.Controls.Add(label4);
        gbxCityInsert.Controls.Add(txtFloor);
        gbxCityInsert.Controls.Add(label3);
        gbxCityInsert.Controls.Add(txtBuildNumber);
        gbxCityInsert.Controls.Add(lblBuildNumber);
        gbxCityInsert.Controls.Add(txtStreet);
        gbxCityInsert.Controls.Add(lblStreet);
        gbxCityInsert.Controls.Add(txtDistrict);
        gbxCityInsert.Controls.Add(lblCityName);
        gbxCityInsert.Controls.Add(btnSave);
        gbxCityInsert.Location = new Point(12, 12);
        gbxCityInsert.Name = "gbxCityInsert";
        gbxCityInsert.Size = new Size(404, 175);
        gbxCityInsert.TabIndex = 6;
        gbxCityInsert.TabStop = false;
        gbxCityInsert.Text = "City Insert";
        // 
        // lblAddTown
        // 
        lblAddTown.AutoSize = true;
        lblAddTown.BackColor = Color.DarkGreen;
        lblAddTown.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblAddTown.Location = new Point(10, 58);
        lblAddTown.Name = "lblAddTown";
        lblAddTown.Size = new Size(29, 15);
        lblAddTown.TabIndex = 18;
        lblAddTown.Text = "[ + ]";
        lblAddTown.Click += lblAddTown_Click;
        // 
        // lblAddCity
        // 
        lblAddCity.AutoSize = true;
        lblAddCity.BackColor = Color.DarkGreen;
        lblAddCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblAddCity.Location = new Point(10, 28);
        lblAddCity.Name = "lblAddCity";
        lblAddCity.Size = new Size(29, 15);
        lblAddCity.TabIndex = 17;
        lblAddCity.Text = "[ + ]";
        lblAddCity.Click += label8_Click;
        // 
        // cmbTowns
        // 
        cmbTowns.FormattingEnabled = true;
        cmbTowns.Location = new Point(102, 54);
        cmbTowns.Name = "cmbTowns";
        cmbTowns.Size = new Size(121, 23);
        cmbTowns.TabIndex = 16;
        // 
        // cmbCities
        // 
        cmbCities.FormattingEnabled = true;
        cmbCities.Location = new Point(102, 25);
        cmbCities.Name = "cmbCities";
        cmbCities.Size = new Size(121, 23);
        cmbCities.TabIndex = 15;
        cmbCities.SelectedIndexChanged += cmbCities_SelectedIndexChanged;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(62, 58);
        label7.Name = "label7";
        label7.Size = new Size(34, 15);
        label7.TabIndex = 14;
        label7.Text = "İlçe : ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(54, 28);
        label6.Name = "label6";
        label6.Size = new Size(42, 15);
        label6.TabIndex = 13;
        label6.Text = "Şehir : ";
        // 
        // txtPostalCode
        // 
        txtPostalCode.Location = new Point(102, 142);
        txtPostalCode.Name = "txtPostalCode";
        txtPostalCode.Size = new Size(121, 23);
        txtPostalCode.TabIndex = 12;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 145);
        label5.Name = "label5";
        label5.Size = new Size(76, 15);
        label5.TabIndex = 11;
        label5.Text = "Posta Kodu : ";
        // 
        // txtApartmentNumber
        // 
        txtApartmentNumber.Location = new Point(297, 83);
        txtApartmentNumber.Name = "txtApartmentNumber";
        txtApartmentNumber.Size = new Size(100, 23);
        txtApartmentNumber.TabIndex = 10;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(248, 87);
        label4.Name = "label4";
        label4.Size = new Size(43, 15);
        label4.TabIndex = 9;
        label4.Text = "Daire : ";
        // 
        // txtFloor
        // 
        txtFloor.Location = new Point(297, 54);
        txtFloor.Name = "txtFloor";
        txtFloor.Size = new Size(100, 23);
        txtFloor.TabIndex = 8;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(258, 57);
        label3.Name = "label3";
        label3.Size = new Size(33, 15);
        label3.TabIndex = 7;
        label3.Text = "Kat : ";
        // 
        // txtBuildNumber
        // 
        txtBuildNumber.Location = new Point(297, 25);
        txtBuildNumber.Name = "txtBuildNumber";
        txtBuildNumber.Size = new Size(100, 23);
        txtBuildNumber.TabIndex = 6;
        // 
        // lblBuildNumber
        // 
        lblBuildNumber.AutoSize = true;
        lblBuildNumber.Location = new Point(233, 28);
        lblBuildNumber.Name = "lblBuildNumber";
        lblBuildNumber.Size = new Size(58, 15);
        lblBuildNumber.TabIndex = 5;
        lblBuildNumber.Text = "Bina No : ";
        // 
        // txtStreet
        // 
        txtStreet.Location = new Point(102, 113);
        txtStreet.Name = "txtStreet";
        txtStreet.Size = new Size(121, 23);
        txtStreet.TabIndex = 4;
        // 
        // lblStreet
        // 
        lblStreet.AutoSize = true;
        lblStreet.Location = new Point(4, 116);
        lblStreet.Name = "lblStreet";
        lblStreet.Size = new Size(92, 15);
        lblStreet.TabIndex = 3;
        lblStreet.Text = "Cadde / Sokak : ";
        // 
        // txtDistrict
        // 
        txtDistrict.Location = new Point(102, 84);
        txtDistrict.Name = "txtDistrict";
        txtDistrict.Size = new Size(121, 23);
        txtDistrict.TabIndex = 2;
        // 
        // lblCityName
        // 
        lblCityName.AutoSize = true;
        lblCityName.Location = new Point(38, 87);
        lblCityName.Name = "lblCityName";
        lblCityName.Size = new Size(58, 15);
        lblCityName.TabIndex = 1;
        lblCityName.Text = "Mahalle : ";
        // 
        // btnSave
        // 
        btnSave.Location = new Point(297, 112);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(100, 23);
        btnSave.TabIndex = 0;
        btnSave.Text = "Kaydet";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // FrmAddress
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.ForestGreen;
        ClientSize = new Size(1023, 605);
        Controls.Add(btnRemove);
        Controls.Add(btnClear);
        Controls.Add(btnGetRemove);
        Controls.Add(gbxCityUpdate);
        Controls.Add(gbxCityList);
        Controls.Add(gbxCityInsert);
        Name = "FrmAddress";
        Text = "Address Process";
        Load += FrmAddress_Load;
        gbxCityUpdate.ResumeLayout(false);
        gbxCityUpdate.PerformLayout();
        gbxCityList.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvAddresses).EndInit();
        gbxCityInsert.ResumeLayout(false);
        gbxCityInsert.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnRemove;
    private Button btnClear;
    private Button btnGetRemove;
    private GroupBox gbxCityUpdate;
    private Button btnUpdate;
    private CheckBox cbxIsActive;
    private CheckBox cbxIsDeleted;
    private GroupBox gbxCityList;
    private DataGridView dgvAddresses;
    private GroupBox gbxCityInsert;
    private TextBox txtDistrict;
    private Label lblCityName;
    private Button btnSave;
    private TextBox txtStreet;
    private Label lblStreet;
    private TextBox txtApartmentNumber;
    private Label label4;
    private TextBox txtFloor;
    private Label label3;
    private TextBox txtBuildNumber;
    private Label lblBuildNumber;
    private Label label7;
    private Label label6;
    private TextBox txtPostalCode;
    private Label label5;
    private ComboBox cmbTowns;
    private ComboBox cmbCities;
    private Label lblAddTown;
    private Label lblAddCity;
    private ComboBox cmbUpdateTowns;
    private ComboBox cmbUpdateCities;
    private Label label1;
    private Label label2;
    private TextBox txtUpdatePostalCode;
    private Label label8;
    private TextBox txtUpdateStreet;
    private Label label11;
    private TextBox txtUpdateDistrict;
    private Label label12;
    private TextBox txtUpdateApartmentNumber;
    private Label label9;
    private TextBox txtUpdateFloor;
    private Label label10;
    private TextBox txtUpdateBuildNumber;
    private Label label13;
}