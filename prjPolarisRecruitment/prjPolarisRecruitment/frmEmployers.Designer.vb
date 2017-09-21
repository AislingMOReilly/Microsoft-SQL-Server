<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployers
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
        Me.grpEmployers = New System.Windows.Forms.GroupBox()
        Me.lblEmpForm = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtOfficeID = New System.Windows.Forms.TextBox()
        Me.lblOfficeID = New System.Windows.Forms.Label()
        Me.txtNoEmps = New System.Windows.Forms.TextBox()
        Me.lblNoEmps = New System.Windows.Forms.Label()
        Me.txtEmpContName = New System.Windows.Forms.TextBox()
        Me.lblEmpConName = New System.Windows.Forms.Label()
        Me.txtEmpConNo = New System.Windows.Forms.TextBox()
        Me.lblEmpConNo = New System.Windows.Forms.Label()
        Me.txtEmpLoc = New System.Windows.Forms.TextBox()
        Me.lblEmpLoc = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.txtEmpSect = New System.Windows.Forms.TextBox()
        Me.lblEmpSect = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.grdEmployers = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpEmployers.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmployers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpEmployers
        '
        Me.grpEmployers.BackColor = System.Drawing.SystemColors.Window
        Me.grpEmployers.Controls.Add(Me.lblEmpForm)
        Me.grpEmployers.Controls.Add(Me.pbxLogo)
        Me.grpEmployers.Controls.Add(Me.txtOfficeID)
        Me.grpEmployers.Controls.Add(Me.lblOfficeID)
        Me.grpEmployers.Controls.Add(Me.txtNoEmps)
        Me.grpEmployers.Controls.Add(Me.lblNoEmps)
        Me.grpEmployers.Controls.Add(Me.txtEmpContName)
        Me.grpEmployers.Controls.Add(Me.lblEmpConName)
        Me.grpEmployers.Controls.Add(Me.txtEmpConNo)
        Me.grpEmployers.Controls.Add(Me.lblEmpConNo)
        Me.grpEmployers.Controls.Add(Me.txtEmpLoc)
        Me.grpEmployers.Controls.Add(Me.lblEmpLoc)
        Me.grpEmployers.Controls.Add(Me.txtEmpName)
        Me.grpEmployers.Controls.Add(Me.lblEmpName)
        Me.grpEmployers.Controls.Add(Me.txtEmpSect)
        Me.grpEmployers.Controls.Add(Me.lblEmpSect)
        Me.grpEmployers.Controls.Add(Me.txtEmpID)
        Me.grpEmployers.Controls.Add(Me.lblEmpID)
        Me.grpEmployers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpEmployers.Location = New System.Drawing.Point(3, 2)
        Me.grpEmployers.Name = "grpEmployers"
        Me.grpEmployers.Size = New System.Drawing.Size(474, 538)
        Me.grpEmployers.TabIndex = 2
        Me.grpEmployers.TabStop = False
        '
        'lblEmpForm
        '
        Me.lblEmpForm.AutoSize = True
        Me.lblEmpForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblEmpForm.Location = New System.Drawing.Point(152, 85)
        Me.lblEmpForm.Name = "lblEmpForm"
        Me.lblEmpForm.Size = New System.Drawing.Size(143, 20)
        Me.lblEmpForm.TabIndex = 37
        Me.lblEmpForm.Text = "Employers Form:"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(87, 10)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(264, 56)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 30
        Me.pbxLogo.TabStop = False
        '
        'txtOfficeID
        '
        Me.txtOfficeID.Location = New System.Drawing.Point(312, 486)
        Me.txtOfficeID.Name = "txtOfficeID"
        Me.txtOfficeID.Size = New System.Drawing.Size(135, 20)
        Me.txtOfficeID.TabIndex = 21
        '
        'lblOfficeID
        '
        Me.lblOfficeID.AutoSize = True
        Me.lblOfficeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficeID.Location = New System.Drawing.Point(22, 487)
        Me.lblOfficeID.Name = "lblOfficeID"
        Me.lblOfficeID.Size = New System.Drawing.Size(66, 15)
        Me.lblOfficeID.TabIndex = 20
        Me.lblOfficeID.Text = "Office ID:"
        '
        'txtNoEmps
        '
        Me.txtNoEmps.Location = New System.Drawing.Point(313, 436)
        Me.txtNoEmps.Name = "txtNoEmps"
        Me.txtNoEmps.Size = New System.Drawing.Size(135, 20)
        Me.txtNoEmps.TabIndex = 19
        '
        'lblNoEmps
        '
        Me.lblNoEmps.AutoSize = True
        Me.lblNoEmps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoEmps.Location = New System.Drawing.Point(23, 441)
        Me.lblNoEmps.Name = "lblNoEmps"
        Me.lblNoEmps.Size = New System.Drawing.Size(152, 15)
        Me.lblNoEmps.TabIndex = 18
        Me.lblNoEmps.Text = "Number of Employees:"
        '
        'txtEmpContName
        '
        Me.txtEmpContName.Location = New System.Drawing.Point(312, 385)
        Me.txtEmpContName.Name = "txtEmpContName"
        Me.txtEmpContName.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpContName.TabIndex = 11
        '
        'lblEmpConName
        '
        Me.lblEmpConName.AutoSize = True
        Me.lblEmpConName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpConName.Location = New System.Drawing.Point(23, 390)
        Me.lblEmpConName.Name = "lblEmpConName"
        Me.lblEmpConName.Size = New System.Drawing.Size(165, 15)
        Me.lblEmpConName.TabIndex = 10
        Me.lblEmpConName.Text = "Employer Contact Name:"
        '
        'txtEmpConNo
        '
        Me.txtEmpConNo.Location = New System.Drawing.Point(312, 335)
        Me.txtEmpConNo.Name = "txtEmpConNo"
        Me.txtEmpConNo.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpConNo.TabIndex = 9
        '
        'lblEmpConNo
        '
        Me.lblEmpConNo.AutoSize = True
        Me.lblEmpConNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpConNo.Location = New System.Drawing.Point(23, 340)
        Me.lblEmpConNo.Name = "lblEmpConNo"
        Me.lblEmpConNo.Size = New System.Drawing.Size(178, 15)
        Me.lblEmpConNo.TabIndex = 8
        Me.lblEmpConNo.Text = "Employer Contact Number:"
        '
        'txtEmpLoc
        '
        Me.txtEmpLoc.Location = New System.Drawing.Point(312, 286)
        Me.txtEmpLoc.Name = "txtEmpLoc"
        Me.txtEmpLoc.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpLoc.TabIndex = 7
        '
        'lblEmpLoc
        '
        Me.lblEmpLoc.AutoSize = True
        Me.lblEmpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpLoc.Location = New System.Drawing.Point(23, 291)
        Me.lblEmpLoc.Name = "lblEmpLoc"
        Me.lblEmpLoc.Size = New System.Drawing.Size(130, 15)
        Me.lblEmpLoc.TabIndex = 6
        Me.lblEmpLoc.Text = "Employer Location:"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(312, 234)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpName.TabIndex = 5
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpName.Location = New System.Drawing.Point(23, 239)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(113, 15)
        Me.lblEmpName.TabIndex = 4
        Me.lblEmpName.Text = "Employer Name:"
        '
        'txtEmpSect
        '
        Me.txtEmpSect.Location = New System.Drawing.Point(312, 186)
        Me.txtEmpSect.Name = "txtEmpSect"
        Me.txtEmpSect.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpSect.TabIndex = 3
        '
        'lblEmpSect
        '
        Me.lblEmpSect.AutoSize = True
        Me.lblEmpSect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpSect.Location = New System.Drawing.Point(22, 191)
        Me.lblEmpSect.Name = "lblEmpSect"
        Me.lblEmpSect.Size = New System.Drawing.Size(135, 15)
        Me.lblEmpSect.TabIndex = 2
        Me.lblEmpSect.Text = "Employment Sector:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(312, 134)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpID.TabIndex = 1
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpID.Location = New System.Drawing.Point(23, 139)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(89, 15)
        Me.lblEmpID.TabIndex = 0
        Me.lblEmpID.Text = "Employer ID:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(907, 38)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 29)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(773, 38)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 29)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnView.Location = New System.Drawing.Point(641, 38)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(106, 29)
        Me.btnView.TabIndex = 27
        Me.btnView.Text = "View Record"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(506, 39)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(106, 29)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'grdEmployers
        '
        Me.grdEmployers.Location = New System.Drawing.Point(506, 87)
        Me.grdEmployers.Name = "grdEmployers"
        Me.grdEmployers.Size = New System.Drawing.Size(507, 288)
        Me.grdEmployers.TabIndex = 41
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(912, 388)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(506, 393)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 30)
        Me.btnNext.TabIndex = 42
        Me.btnNext.Text = "Next Form"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmEmployers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 545)
        Me.Controls.Add(Me.grdEmployers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpEmployers)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnView)
        Me.Name = "frmEmployers"
        Me.Text = "Employers Form"
        Me.grpEmployers.ResumeLayout(False)
        Me.grpEmployers.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmployers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpEmployers As GroupBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtOfficeID As TextBox
    Friend WithEvents lblOfficeID As Label
    Friend WithEvents txtNoEmps As TextBox
    Friend WithEvents lblNoEmps As Label
    Friend WithEvents txtEmpContName As TextBox
    Friend WithEvents lblEmpConName As Label
    Friend WithEvents txtEmpConNo As TextBox
    Friend WithEvents lblEmpConNo As Label
    Friend WithEvents txtEmpLoc As TextBox
    Friend WithEvents lblEmpLoc As Label
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents lblEmpName As Label
    Friend WithEvents txtEmpSect As TextBox
    Friend WithEvents lblEmpSect As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents lblEmpID As Label
    Friend WithEvents lblEmpForm As Label
    Friend WithEvents grdEmployers As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
End Class
