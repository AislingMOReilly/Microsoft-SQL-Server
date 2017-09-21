<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpStaff = New System.Windows.Forms.GroupBox()
        Me.lblStaffForm = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtOfficeID = New System.Windows.Forms.TextBox()
        Me.lblOfficeID = New System.Windows.Forms.Label()
        Me.txtYearsEmp = New System.Windows.Forms.TextBox()
        Me.lblYearsEmp = New System.Windows.Forms.Label()
        Me.txtStaffSal = New System.Windows.Forms.TextBox()
        Me.lbStaffSal = New System.Windows.Forms.Label()
        Me.txtStaffContNo = New System.Windows.Forms.TextBox()
        Me.lblStaffContNo = New System.Windows.Forms.Label()
        Me.txtStaffAdd = New System.Windows.Forms.TextBox()
        Me.lblStaffAdd = New System.Windows.Forms.Label()
        Me.txtStaffPPSN = New System.Windows.Forms.TextBox()
        Me.lblStaffPPSN = New System.Windows.Forms.Label()
        Me.txtStaffDOB = New System.Windows.Forms.TextBox()
        Me.lblStaffDOB = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.grdStaff = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpStaff.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpStaff
        '
        Me.grpStaff.BackColor = System.Drawing.SystemColors.Window
        Me.grpStaff.Controls.Add(Me.lblStaffForm)
        Me.grpStaff.Controls.Add(Me.pbxLogo)
        Me.grpStaff.Controls.Add(Me.txtOfficeID)
        Me.grpStaff.Controls.Add(Me.lblOfficeID)
        Me.grpStaff.Controls.Add(Me.txtYearsEmp)
        Me.grpStaff.Controls.Add(Me.lblYearsEmp)
        Me.grpStaff.Controls.Add(Me.txtStaffSal)
        Me.grpStaff.Controls.Add(Me.lbStaffSal)
        Me.grpStaff.Controls.Add(Me.txtStaffContNo)
        Me.grpStaff.Controls.Add(Me.lblStaffContNo)
        Me.grpStaff.Controls.Add(Me.txtStaffAdd)
        Me.grpStaff.Controls.Add(Me.lblStaffAdd)
        Me.grpStaff.Controls.Add(Me.txtStaffPPSN)
        Me.grpStaff.Controls.Add(Me.lblStaffPPSN)
        Me.grpStaff.Controls.Add(Me.txtStaffDOB)
        Me.grpStaff.Controls.Add(Me.lblStaffDOB)
        Me.grpStaff.Controls.Add(Me.txtStaffName)
        Me.grpStaff.Controls.Add(Me.lblStaffName)
        Me.grpStaff.Controls.Add(Me.txtStaffID)
        Me.grpStaff.Controls.Add(Me.lblStaffID)
        Me.grpStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpStaff.Location = New System.Drawing.Point(3, 2)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(466, 583)
        Me.grpStaff.TabIndex = 1
        Me.grpStaff.TabStop = False
        '
        'lblStaffForm
        '
        Me.lblStaffForm.AutoSize = True
        Me.lblStaffForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStaffForm.Location = New System.Drawing.Point(175, 85)
        Me.lblStaffForm.Name = "lblStaffForm"
        Me.lblStaffForm.Size = New System.Drawing.Size(100, 20)
        Me.lblStaffForm.TabIndex = 38
        Me.lblStaffForm.Text = "Staff Form:"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(100, 10)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(264, 56)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 30
        Me.pbxLogo.TabStop = False
        '
        'txtOfficeID
        '
        Me.txtOfficeID.Location = New System.Drawing.Point(306, 529)
        Me.txtOfficeID.Name = "txtOfficeID"
        Me.txtOfficeID.Size = New System.Drawing.Size(135, 20)
        Me.txtOfficeID.TabIndex = 21
        '
        'lblOfficeID
        '
        Me.lblOfficeID.AutoSize = True
        Me.lblOfficeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficeID.Location = New System.Drawing.Point(16, 530)
        Me.lblOfficeID.Name = "lblOfficeID"
        Me.lblOfficeID.Size = New System.Drawing.Size(66, 15)
        Me.lblOfficeID.TabIndex = 20
        Me.lblOfficeID.Text = "Office ID:"
        '
        'txtYearsEmp
        '
        Me.txtYearsEmp.Location = New System.Drawing.Point(307, 479)
        Me.txtYearsEmp.Name = "txtYearsEmp"
        Me.txtYearsEmp.Size = New System.Drawing.Size(135, 20)
        Me.txtYearsEmp.TabIndex = 19
        '
        'lblYearsEmp
        '
        Me.lblYearsEmp.AutoSize = True
        Me.lblYearsEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsEmp.Location = New System.Drawing.Point(17, 484)
        Me.lblYearsEmp.Name = "lblYearsEmp"
        Me.lblYearsEmp.Size = New System.Drawing.Size(193, 15)
        Me.lblYearsEmp.TabIndex = 18
        Me.lblYearsEmp.Text = "Years Employed with Polaris:"
        '
        'txtStaffSal
        '
        Me.txtStaffSal.Location = New System.Drawing.Point(307, 430)
        Me.txtStaffSal.Name = "txtStaffSal"
        Me.txtStaffSal.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffSal.TabIndex = 17
        Me.txtStaffSal.Text = "€"
        '
        'lbStaffSal
        '
        Me.lbStaffSal.AutoSize = True
        Me.lbStaffSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStaffSal.Location = New System.Drawing.Point(18, 435)
        Me.lbStaffSal.Name = "lbStaffSal"
        Me.lbStaffSal.Size = New System.Drawing.Size(84, 15)
        Me.lbStaffSal.TabIndex = 16
        Me.lbStaffSal.Text = "Staff Salary:"
        '
        'txtStaffContNo
        '
        Me.txtStaffContNo.Location = New System.Drawing.Point(307, 383)
        Me.txtStaffContNo.Name = "txtStaffContNo"
        Me.txtStaffContNo.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffContNo.TabIndex = 11
        '
        'lblStaffContNo
        '
        Me.lblStaffContNo.AutoSize = True
        Me.lblStaffContNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffContNo.Location = New System.Drawing.Point(18, 388)
        Me.lblStaffContNo.Name = "lblStaffContNo"
        Me.lblStaffContNo.Size = New System.Drawing.Size(147, 15)
        Me.lblStaffContNo.TabIndex = 10
        Me.lblStaffContNo.Text = "Staff Contact Number:"
        '
        'txtStaffAdd
        '
        Me.txtStaffAdd.Location = New System.Drawing.Point(307, 333)
        Me.txtStaffAdd.Name = "txtStaffAdd"
        Me.txtStaffAdd.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffAdd.TabIndex = 9
        '
        'lblStaffAdd
        '
        Me.lblStaffAdd.AutoSize = True
        Me.lblStaffAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffAdd.Location = New System.Drawing.Point(18, 338)
        Me.lblStaffAdd.Name = "lblStaffAdd"
        Me.lblStaffAdd.Size = New System.Drawing.Size(95, 15)
        Me.lblStaffAdd.TabIndex = 8
        Me.lblStaffAdd.Text = "Staff Address:"
        '
        'txtStaffPPSN
        '
        Me.txtStaffPPSN.Location = New System.Drawing.Point(307, 284)
        Me.txtStaffPPSN.Name = "txtStaffPPSN"
        Me.txtStaffPPSN.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffPPSN.TabIndex = 7
        '
        'lblStaffPPSN
        '
        Me.lblStaffPPSN.AutoSize = True
        Me.lblStaffPPSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffPPSN.Location = New System.Drawing.Point(18, 289)
        Me.lblStaffPPSN.Name = "lblStaffPPSN"
        Me.lblStaffPPSN.Size = New System.Drawing.Size(81, 15)
        Me.lblStaffPPSN.TabIndex = 6
        Me.lblStaffPPSN.Text = "Staff PPSN:"
        '
        'txtStaffDOB
        '
        Me.txtStaffDOB.Location = New System.Drawing.Point(307, 232)
        Me.txtStaffDOB.Name = "txtStaffDOB"
        Me.txtStaffDOB.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffDOB.TabIndex = 5
        '
        'lblStaffDOB
        '
        Me.lblStaffDOB.AutoSize = True
        Me.lblStaffDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffDOB.Location = New System.Drawing.Point(18, 237)
        Me.lblStaffDOB.Name = "lblStaffDOB"
        Me.lblStaffDOB.Size = New System.Drawing.Size(124, 15)
        Me.lblStaffDOB.TabIndex = 4
        Me.lblStaffDOB.Text = "Staff Date of Birth:"
        '
        'txtStaffName
        '
        Me.txtStaffName.Location = New System.Drawing.Point(307, 180)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffName.TabIndex = 3
        '
        'lblStaffName
        '
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffName.Location = New System.Drawing.Point(17, 185)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(82, 15)
        Me.lblStaffName.TabIndex = 2
        Me.lblStaffName.Text = "Staff Name:"
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(307, 132)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(135, 20)
        Me.txtStaffID.TabIndex = 1
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(18, 137)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(58, 15)
        Me.lblStaffID.TabIndex = 0
        Me.lblStaffID.Text = "Staff ID:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(899, 38)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 29)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(766, 38)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 29)
        Me.btnUpdate.TabIndex = 50
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnView.Location = New System.Drawing.Point(632, 38)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(106, 29)
        Me.btnView.TabIndex = 49
        Me.btnView.Text = "View Record"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(498, 38)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(106, 29)
        Me.btnCreate.TabIndex = 48
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'grdStaff
        '
        Me.grdStaff.Location = New System.Drawing.Point(498, 87)
        Me.grdStaff.Name = "grdStaff"
        Me.grdStaff.Size = New System.Drawing.Size(507, 288)
        Me.grdStaff.TabIndex = 45
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(904, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(498, 393)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 30)
        Me.btnNext.TabIndex = 46
        Me.btnNext.Text = "Next Form"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 589)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.grdStaff)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpStaff)
        Me.Name = "frmStaff"
        Me.Text = "Staff Form"
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpStaff As GroupBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents txtOfficeID As TextBox
    Friend WithEvents lblOfficeID As Label
    Friend WithEvents txtYearsEmp As TextBox
    Friend WithEvents lblYearsEmp As Label
    Friend WithEvents txtStaffSal As TextBox
    Friend WithEvents lbStaffSal As Label
    Friend WithEvents txtStaffContNo As TextBox
    Friend WithEvents lblStaffContNo As Label
    Friend WithEvents txtStaffAdd As TextBox
    Friend WithEvents lblStaffAdd As Label
    Friend WithEvents txtStaffPPSN As TextBox
    Friend WithEvents lblStaffPPSN As Label
    Friend WithEvents txtStaffDOB As TextBox
    Friend WithEvents lblStaffDOB As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents lblStaffName As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents lblStaffForm As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents grdStaff As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
End Class
