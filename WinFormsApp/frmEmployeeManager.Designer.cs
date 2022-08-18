namespace WinFormsApp;
using DataAccess.Entities;
partial class frmEmployeeManager
{

    private System.ComponentModel.IContainer components = null;

    private Label label1;
    private TextBox txtEmployeeID;
    private Label label2;
    private TextBox txtEmployeeName;
    private Label label3;
    private Label label4;
    private GroupBox grpGender;
    private RadioButton radioButton2;
    private RadioButton radMale;
    private Label label5;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.grpGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeID.Location = new System.Drawing.Point(288, 67);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(378, 43);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeName.Location = new System.Drawing.Point(288, 155);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(378, 43);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radioButton2);
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Location = new System.Drawing.Point(288, 318);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(378, 73);
            this.grpGender.TabIndex = 7;
            this.grpGender.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(182, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 41);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Fermale";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radMale.Location = new System.Drawing.Point(18, 24);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(107, 41);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(TypeEmployee.Types);
            this.cboType.Location = new System.Drawing.Point(287, 430);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(379, 40);
            this.cboType.TabIndex = 6;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
        this.cboType.SelectedIndex = 0;    
        // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskPhone.Location = new System.Drawing.Point(288, 248);
            this.mskPhone.Mask = "000-0000000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(378, 43);
            this.mskPhone.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(32, 507);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(434, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 54);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(244, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 54);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(738, 67);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 82;
            this.dgvEmployees.RowTemplate.Height = 41;
            this.dgvEmployees.Size = new System.Drawing.Size(1149, 555);
            this.dgvEmployees.TabIndex = 11;
            // 
            // frmEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 677);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskPhone);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees Management";
            this.Load += new System.EventHandler(this.frmEmployeeManager_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }



    #endregion

    private MaskedTextBox mskPhone;
    private GroupBox groupBox1;
    private Button btnClose;
    private Button btnUpdate;
    private Button btnAdd;
    private DataGridView dgvEmployees;
    private ComboBox cboType;
}
