<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpCustomers = New System.Windows.Forms.GroupBox()
        Me.lblCustForm = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblYes = New System.Windows.Forms.Label()
        Me.txtDateLastEmp = New System.Windows.Forms.TextBox()
        Me.lblDateLastEmp = New System.Windows.Forms.Label()
        Me.txtField = New System.Windows.Forms.TextBox()
        Me.lblField = New System.Windows.Forms.Label()
        Me.txtExpSal = New System.Windows.Forms.TextBox()
        Me.lblExpSal = New System.Windows.Forms.Label()
        Me.txtEmpSect = New System.Windows.Forms.TextBox()
        Me.lblEmpSect = New System.Windows.Forms.Label()
        Me.txtYes = New System.Windows.Forms.TextBox()
        Me.lblEngFluency = New System.Windows.Forms.Label()
        Me.txtCustContNo = New System.Windows.Forms.TextBox()
        Me.lblCustContNo = New System.Windows.Forms.Label()
        Me.txtCustAdd = New System.Windows.Forms.TextBox()
        Me.lblCustAdd = New System.Windows.Forms.Label()
        Me.txtCustPPSN = New System.Windows.Forms.TextBox()
        Me.lblCustPPSN = New System.Windows.Forms.Label()
        Me.txtCustDOB = New System.Windows.Forms.TextBox()
        Me.lblCustDOB = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.grdCustomers = New System.Windows.Forms.DataGridView()
        Me.grpCustomers.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustomers
        '
        Me.grpCustomers.BackColor = System.Drawing.SystemColors.Window
        Me.grpCustomers.Controls.Add(Me.lblCustForm)
        Me.grpCustomers.Controls.Add(Me.pbxLogo)
        Me.grpCustomers.Controls.Add(Me.txtNo)
        Me.grpCustomers.Controls.Add(Me.lblNo)
        Me.grpCustomers.Controls.Add(Me.lblYes)
        Me.grpCustomers.Controls.Add(Me.txtDateLastEmp)
        Me.grpCustomers.Controls.Add(Me.lblDateLastEmp)
        Me.grpCustomers.Controls.Add(Me.txtField)
        Me.grpCustomers.Controls.Add(Me.lblField)
        Me.grpCustomers.Controls.Add(Me.txtExpSal)
        Me.grpCustomers.Controls.Add(Me.lblExpSal)
        Me.grpCustomers.Controls.Add(Me.txtEmpSect)
        Me.grpCustomers.Controls.Add(Me.lblEmpSect)
        Me.grpCustomers.Controls.Add(Me.txtYes)
        Me.grpCustomers.Controls.Add(Me.lblEngFluency)
        Me.grpCustomers.Controls.Add(Me.txtCustContNo)
        Me.grpCustomers.Controls.Add(Me.lblCustContNo)
        Me.grpCustomers.Controls.Add(Me.txtCustAdd)
        Me.grpCustomers.Controls.Add(Me.lblCustAdd)
        Me.grpCustomers.Controls.Add(Me.txtCustPPSN)
        Me.grpCustomers.Controls.Add(Me.lblCustPPSN)
        Me.grpCustomers.Controls.Add(Me.txtCustDOB)
        Me.grpCustomers.Controls.Add(Me.lblCustDOB)
        Me.grpCustomers.Controls.Add(Me.txtCustName)
        Me.grpCustomers.Controls.Add(Me.lblCustName)
        Me.grpCustomers.Controls.Add(Me.txtCustID)
        Me.grpCustomers.Controls.Add(Me.lblCustID)
        Me.grpCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCustomers.Location = New System.Drawing.Point(2, -4)
        Me.grpCustomers.Name = "grpCustomers"
        Me.grpCustomers.Size = New System.Drawing.Size(495, 678)
        Me.grpCustomers.TabIndex = 0
        Me.grpCustomers.TabStop = False
        '
        'lblCustForm
        '
        Me.lblCustForm.AutoSize = True
        Me.lblCustForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCustForm.Location = New System.Drawing.Point(172, 82)
        Me.lblCustForm.Name = "lblCustForm"
        Me.lblCustForm.Size = New System.Drawing.Size(146, 20)
        Me.lblCustForm.TabIndex = 38
        Me.lblCustForm.Text = "Customers Form:"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(109, 7)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(264, 56)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 31
        Me.pbxLogo.TabStop = False
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(425, 433)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(26, 20)
        Me.txtNo.TabIndex = 25
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.Location = New System.Drawing.Point(396, 434)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(23, 15)
        Me.lblNo.TabIndex = 24
        Me.lblNo.Text = "No"
        '
        'lblYes
        '
        Me.lblYes.AutoSize = True
        Me.lblYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYes.Location = New System.Drawing.Point(314, 433)
        Me.lblYes.Name = "lblYes"
        Me.lblYes.Size = New System.Drawing.Size(27, 15)
        Me.lblYes.TabIndex = 23
        Me.lblYes.Text = "Yes"
        '
        'txtDateLastEmp
        '
        Me.txtDateLastEmp.Location = New System.Drawing.Point(317, 621)
        Me.txtDateLastEmp.Name = "txtDateLastEmp"
        Me.txtDateLastEmp.Size = New System.Drawing.Size(135, 20)
        Me.txtDateLastEmp.TabIndex = 21
        '
        'lblDateLastEmp
        '
        Me.lblDateLastEmp.AutoSize = True
        Me.lblDateLastEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateLastEmp.Location = New System.Drawing.Point(27, 622)
        Me.lblDateLastEmp.Name = "lblDateLastEmp"
        Me.lblDateLastEmp.Size = New System.Drawing.Size(171, 15)
        Me.lblDateLastEmp.TabIndex = 20
        Me.lblDateLastEmp.Text = "Date of Last Employment:"
        '
        'txtField
        '
        Me.txtField.Location = New System.Drawing.Point(318, 571)
        Me.txtField.Name = "txtField"
        Me.txtField.Size = New System.Drawing.Size(135, 20)
        Me.txtField.TabIndex = 19
        '
        'lblField
        '
        Me.lblField.AutoSize = True
        Me.lblField.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblField.Location = New System.Drawing.Point(28, 576)
        Me.lblField.Name = "lblField"
        Me.lblField.Size = New System.Drawing.Size(123, 15)
        Me.lblField.TabIndex = 18
        Me.lblField.Text = "Field of Expertise:"
        '
        'txtExpSal
        '
        Me.txtExpSal.Location = New System.Drawing.Point(317, 525)
        Me.txtExpSal.Name = "txtExpSal"
        Me.txtExpSal.Size = New System.Drawing.Size(135, 20)
        Me.txtExpSal.TabIndex = 17
        Me.txtExpSal.Text = "€"
        '
        'lblExpSal
        '
        Me.lblExpSal.AutoSize = True
        Me.lblExpSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpSal.Location = New System.Drawing.Point(28, 530)
        Me.lblExpSal.Name = "lblExpSal"
        Me.lblExpSal.Size = New System.Drawing.Size(114, 15)
        Me.lblExpSal.TabIndex = 16
        Me.lblExpSal.Text = "Expected Salary:"
        '
        'txtEmpSect
        '
        Me.txtEmpSect.Location = New System.Drawing.Point(317, 479)
        Me.txtEmpSect.Name = "txtEmpSect"
        Me.txtEmpSect.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpSect.TabIndex = 15
        '
        'lblEmpSect
        '
        Me.lblEmpSect.AutoSize = True
        Me.lblEmpSect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpSect.Location = New System.Drawing.Point(28, 484)
        Me.lblEmpSect.Name = "lblEmpSect"
        Me.lblEmpSect.Size = New System.Drawing.Size(135, 15)
        Me.lblEmpSect.TabIndex = 14
        Me.lblEmpSect.Text = "Employment Sector:"
        '
        'txtYes
        '
        Me.txtYes.Location = New System.Drawing.Point(347, 432)
        Me.txtYes.Name = "txtYes"
        Me.txtYes.Size = New System.Drawing.Size(26, 20)
        Me.txtYes.TabIndex = 13
        '
        'lblEngFluency
        '
        Me.lblEngFluency.AutoSize = True
        Me.lblEngFluency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEngFluency.Location = New System.Drawing.Point(27, 434)
        Me.lblEngFluency.Name = "lblEngFluency"
        Me.lblEngFluency.Size = New System.Drawing.Size(112, 15)
        Me.lblEngFluency.TabIndex = 12
        Me.lblEngFluency.Text = "English Fluency:"
        '
        'txtCustContNo
        '
        Me.txtCustContNo.Location = New System.Drawing.Point(316, 383)
        Me.txtCustContNo.Name = "txtCustContNo"
        Me.txtCustContNo.Size = New System.Drawing.Size(135, 20)
        Me.txtCustContNo.TabIndex = 11
        '
        'lblCustContNo
        '
        Me.lblCustContNo.AutoSize = True
        Me.lblCustContNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustContNo.Location = New System.Drawing.Point(27, 388)
        Me.lblCustContNo.Name = "lblCustContNo"
        Me.lblCustContNo.Size = New System.Drawing.Size(179, 15)
        Me.lblCustContNo.TabIndex = 10
        Me.lblCustContNo.Text = "Customer Contact Number:"
        '
        'txtCustAdd
        '
        Me.txtCustAdd.Location = New System.Drawing.Point(316, 333)
        Me.txtCustAdd.Name = "txtCustAdd"
        Me.txtCustAdd.Size = New System.Drawing.Size(135, 20)
        Me.txtCustAdd.TabIndex = 9
        '
        'lblCustAdd
        '
        Me.lblCustAdd.AutoSize = True
        Me.lblCustAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustAdd.Location = New System.Drawing.Point(27, 338)
        Me.lblCustAdd.Name = "lblCustAdd"
        Me.lblCustAdd.Size = New System.Drawing.Size(127, 15)
        Me.lblCustAdd.TabIndex = 8
        Me.lblCustAdd.Text = "Customer Address:"
        '
        'txtCustPPSN
        '
        Me.txtCustPPSN.Location = New System.Drawing.Point(317, 281)
        Me.txtCustPPSN.Name = "txtCustPPSN"
        Me.txtCustPPSN.Size = New System.Drawing.Size(135, 20)
        Me.txtCustPPSN.TabIndex = 7
        '
        'lblCustPPSN
        '
        Me.lblCustPPSN.AutoSize = True
        Me.lblCustPPSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustPPSN.Location = New System.Drawing.Point(28, 286)
        Me.lblCustPPSN.Name = "lblCustPPSN"
        Me.lblCustPPSN.Size = New System.Drawing.Size(113, 15)
        Me.lblCustPPSN.TabIndex = 6
        Me.lblCustPPSN.Text = "Customer PPSN:"
        '
        'txtCustDOB
        '
        Me.txtCustDOB.Location = New System.Drawing.Point(317, 229)
        Me.txtCustDOB.Name = "txtCustDOB"
        Me.txtCustDOB.Size = New System.Drawing.Size(135, 20)
        Me.txtCustDOB.TabIndex = 5
        '
        'lblCustDOB
        '
        Me.lblCustDOB.AutoSize = True
        Me.lblCustDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustDOB.Location = New System.Drawing.Point(28, 234)
        Me.lblCustDOB.Name = "lblCustDOB"
        Me.lblCustDOB.Size = New System.Drawing.Size(156, 15)
        Me.lblCustDOB.TabIndex = 4
        Me.lblCustDOB.Text = "Customer Date of Birth:"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(317, 181)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(135, 20)
        Me.txtCustName.TabIndex = 3
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(27, 186)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(114, 15)
        Me.lblCustName.TabIndex = 2
        Me.lblCustName.Text = "Customer Name:"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(317, 133)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(135, 20)
        Me.txtCustID.TabIndex = 1
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(28, 138)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(90, 15)
        Me.lblCustID.TabIndex = 0
        Me.lblCustID.Text = "Customer ID:"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(521, 384)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 30)
        Me.btnNext.TabIndex = 39
        Me.btnNext.Text = "Next Form"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(927, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 40
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(922, 29)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 29)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(789, 29)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 29)
        Me.btnUpdate.TabIndex = 43
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnView.Location = New System.Drawing.Point(655, 29)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(106, 29)
        Me.btnView.TabIndex = 42
        Me.btnView.Text = "View Record"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(521, 29)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(106, 29)
        Me.btnCreate.TabIndex = 41
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'grdCustomers
        '
        Me.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomers.Location = New System.Drawing.Point(521, 78)
        Me.grdCustomers.Name = "grdCustomers"
        Me.grdCustomers.Size = New System.Drawing.Size(507, 286)
        Me.grdCustomers.TabIndex = 45
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 675)
        Me.Controls.Add(Me.grdCustomers)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpCustomers)
        Me.Name = "frmCustomers"
        Me.Text = "Customers Form"
        Me.grpCustomers.ResumeLayout(False)
        Me.grpCustomers.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustomers As GroupBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents lblNo As Label
    Friend WithEvents lblYes As Label
    Friend WithEvents lblDateLastEmp As Label
    Friend WithEvents txtField As TextBox
    Friend WithEvents lblField As Label
    Friend WithEvents txtExpSal As TextBox
    Friend WithEvents lblExpSal As Label
    Friend WithEvents txtEmpSect As TextBox
    Friend WithEvents lblEmpSect As Label
    Friend WithEvents txtYes As TextBox
    Friend WithEvents lblEngFluency As Label
    Friend WithEvents txtCustContNo As TextBox
    Friend WithEvents lblCustContNo As Label
    Friend WithEvents txtCustAdd As TextBox
    Friend WithEvents lblCustAdd As Label
    Friend WithEvents txtCustPPSN As TextBox
    Friend WithEvents lblCustPPSN As Label
    Friend WithEvents txtCustDOB As TextBox
    Friend WithEvents lblCustDOB As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents lblCustID As Label
    Friend WithEvents txtDateLastEmp As TextBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents lblCustForm As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents grdCustomers As DataGridView
End Class
