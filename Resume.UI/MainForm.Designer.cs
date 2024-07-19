namespace Resume.UI;

partial class MainForm
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
        btnCity = new Button();
        btnAddress = new Button();
        btnTownProcess = new Button();
        SuspendLayout();
        // 
        // btnCity
        // 
        btnCity.BackColor = Color.RosyBrown;
        btnCity.Location = new Point(12, 12);
        btnCity.Name = "btnCity";
        btnCity.Size = new Size(75, 54);
        btnCity.TabIndex = 0;
        btnCity.Text = "CITY PROCESS";
        btnCity.UseVisualStyleBackColor = false;
        btnCity.Click += btnCity_Click;
        // 
        // btnAddress
        // 
        btnAddress.BackColor = Color.RosyBrown;
        btnAddress.Location = new Point(93, 12);
        btnAddress.Name = "btnAddress";
        btnAddress.Size = new Size(75, 54);
        btnAddress.TabIndex = 1;
        btnAddress.Text = "ADDRESS PROCESS";
        btnAddress.UseVisualStyleBackColor = false;
        btnAddress.Click += btnAddress_Click;
        // 
        // btnTownProcess
        // 
        btnTownProcess.BackColor = Color.RosyBrown;
        btnTownProcess.Location = new Point(174, 12);
        btnTownProcess.Name = "btnTownProcess";
        btnTownProcess.Size = new Size(75, 54);
        btnTownProcess.TabIndex = 2;
        btnTownProcess.Text = "TOWN PROCESS";
        btnTownProcess.UseVisualStyleBackColor = false;
        btnTownProcess.Click += btnTownProcess_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSeaGreen;
        ClientSize = new Size(800, 450);
        Controls.Add(btnTownProcess);
        Controls.Add(btnAddress);
        Controls.Add(btnCity);
        Name = "MainForm";
        Text = "MainForm";
        Load += MainForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button btnCity;
	private Button btnAddress;
	private Button btnTownProcess;
}