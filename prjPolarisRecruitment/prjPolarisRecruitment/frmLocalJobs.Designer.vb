<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalJobs
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
        Me.grpLocalJobs = New System.Windows.Forms.GroupBox()
        Me.lblLocalJobsForm = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtConLength = New System.Windows.Forms.TextBox()
        Me.lblConLength = New System.Windows.Forms.Label()
        Me.txtConType = New System.Windows.Forms.TextBox()
        Me.lblConType = New System.Windows.Forms.Label()
        Me.txtDateAd = New System.Windows.Forms.TextBox()
        Me.lblDateAd = New System.Windows.Forms.Label()
        Me.txtMinEx = New System.Windows.Forms.TextBox()
        Me.lblMinEx = New System.Windows.Forms.Label()
        Me.txtMinQ = New System.Windows.Forms.TextBox()
        Me.lblMinQ = New System.Windows.Forms.Label()
        Me.txtJobSalary = New System.Windows.Forms.TextBox()
        Me.lblJobSalary = New System.Windows.Forms.Label()
        Me.txtJobTitle = New System.Windows.Forms.TextBox()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.txtJobSect = New System.Windows.Forms.TextBox()
        Me.lblJobSect = New System.Windows.Forms.Label()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.lblJobID = New System.Windows.Forms.Label()
        Me.grdLocalJobs = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpLocalJobs.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLocalJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpLocalJobs
        '
        Me.grpLocalJobs.BackColor = System.Drawing.SystemColors.Window
        Me.grpLocalJobs.Controls.Add(Me.lblLocalJobsForm)
        Me.grpLocalJobs.Controls.Add(Me.txtEmpID)
        Me.grpLocalJobs.Controls.Add(Me.lblEmpID)
        Me.grpLocalJobs.Controls.Add(Me.pbxLogo)
        Me.grpLocalJobs.Controls.Add(Me.txtConLength)
        Me.grpLocalJobs.Controls.Add(Me.lblConLength)
        Me.grpLocalJobs.Controls.Add(Me.txtConType)
        Me.grpLocalJobs.Controls.Add(Me.lblConType)
        Me.grpLocalJobs.Controls.Add(Me.txtDateAd)
        Me.grpLocalJobs.Controls.Add(Me.lblDateAd)
        Me.grpLocalJobs.Controls.Add(Me.txtMinEx)
        Me.grpLocalJobs.Controls.Add(Me.lblMinEx)
        Me.grpLocalJobs.Controls.Add(Me.txtMinQ)
        Me.grpLocalJobs.Controls.Add(Me.lblMinQ)
        Me.grpLocalJobs.Controls.Add(Me.txtJobSalary)
        Me.grpLocalJobs.Controls.Add(Me.lblJobSalary)
        Me.grpLocalJobs.Controls.Add(Me.txtJobTitle)
        Me.grpLocalJobs.Controls.Add(Me.lblJobTitle)
        Me.grpLocalJobs.Controls.Add(Me.txtJobSect)
        Me.grpLocalJobs.Controls.Add(Me.lblJobSect)
        Me.grpLocalJobs.Controls.Add(Me.txtJobID)
        Me.grpLocalJobs.Controls.Add(Me.lblJobID)
        Me.grpLocalJobs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpLocalJobs.Location = New System.Drawing.Point(2, 2)
        Me.grpLocalJobs.Name = "grpLocalJobs"
        Me.grpLocalJobs.Size = New System.Drawing.Size(472, 628)
        Me.grpLocalJobs.TabIndex = 2
        Me.grpLocalJobs.TabStop = False
        '
        'lblLocalJobsForm
        '
        Me.lblLocalJobsForm.AutoSize = True
        Me.lblLocalJobsForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalJobsForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLocalJobsForm.Location = New System.Drawing.Point(158, 82)
        Me.lblLocalJobsForm.Name = "lblLocalJobsForm"
        Me.lblLocalJobsForm.Size = New System.Drawing.Size(146, 20)
        Me.lblLocalJobsForm.TabIndex = 36
        Me.lblLocalJobsForm.Text = "Local Jobs Form:"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(311, 582)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpID.TabIndex = 32
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpID.Location = New System.Drawing.Point(21, 583)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(96, 15)
        Me.lblEmpID.TabIndex = 31
        Me.lblEmpID.Text = "Employers ID:"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(97, 10)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(264, 56)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 30
        Me.pbxLogo.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(901, 39)
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
        Me.btnUpdate.Location = New System.Drawing.Point(771, 39)
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
        Me.btnView.Location = New System.Drawing.Point(640, 39)
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
        Me.btnCreate.Location = New System.Drawing.Point(509, 39)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(106, 29)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'txtConLength
        '
        Me.txtConLength.Location = New System.Drawing.Point(310, 530)
        Me.txtConLength.Name = "txtConLength"
        Me.txtConLength.Size = New System.Drawing.Size(135, 20)
        Me.txtConLength.TabIndex = 21
        '
        'lblConLength
        '
        Me.lblConLength.AutoSize = True
        Me.lblConLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConLength.Location = New System.Drawing.Point(20, 531)
        Me.lblConLength.Name = "lblConLength"
        Me.lblConLength.Size = New System.Drawing.Size(112, 15)
        Me.lblConLength.TabIndex = 20
        Me.lblConLength.Text = "Contract Length:"
        '
        'txtConType
        '
        Me.txtConType.Location = New System.Drawing.Point(311, 480)
        Me.txtConType.Name = "txtConType"
        Me.txtConType.Size = New System.Drawing.Size(135, 20)
        Me.txtConType.TabIndex = 19
        '
        'lblConType
        '
        Me.lblConType.AutoSize = True
        Me.lblConType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConType.Location = New System.Drawing.Point(21, 485)
        Me.lblConType.Name = "lblConType"
        Me.lblConType.Size = New System.Drawing.Size(98, 15)
        Me.lblConType.TabIndex = 18
        Me.lblConType.Text = "Contract Type:"
        '
        'txtDateAd
        '
        Me.txtDateAd.Location = New System.Drawing.Point(310, 433)
        Me.txtDateAd.Name = "txtDateAd"
        Me.txtDateAd.Size = New System.Drawing.Size(135, 20)
        Me.txtDateAd.TabIndex = 17
        '
        'lblDateAd
        '
        Me.lblDateAd.AutoSize = True
        Me.lblDateAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAd.Location = New System.Drawing.Point(21, 438)
        Me.lblDateAd.Name = "lblDateAd"
        Me.lblDateAd.Size = New System.Drawing.Size(170, 15)
        Me.lblDateAd.TabIndex = 16
        Me.lblDateAd.Text = "Date Job First Advertised:"
        '
        'txtMinEx
        '
        Me.txtMinEx.Location = New System.Drawing.Point(310, 386)
        Me.txtMinEx.Name = "txtMinEx"
        Me.txtMinEx.Size = New System.Drawing.Size(135, 20)
        Me.txtMinEx.TabIndex = 11
        '
        'lblMinEx
        '
        Me.lblMinEx.AutoSize = True
        Me.lblMinEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinEx.Location = New System.Drawing.Point(21, 391)
        Me.lblMinEx.Name = "lblMinEx"
        Me.lblMinEx.Size = New System.Drawing.Size(147, 15)
        Me.lblMinEx.TabIndex = 10
        Me.lblMinEx.Text = "Minimum Experience:"
        '
        'txtMinQ
        '
        Me.txtMinQ.Location = New System.Drawing.Point(310, 336)
        Me.txtMinQ.Name = "txtMinQ"
        Me.txtMinQ.Size = New System.Drawing.Size(135, 20)
        Me.txtMinQ.TabIndex = 9
        '
        'lblMinQ
        '
        Me.lblMinQ.AutoSize = True
        Me.lblMinQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinQ.Location = New System.Drawing.Point(21, 341)
        Me.lblMinQ.Name = "lblMinQ"
        Me.lblMinQ.Size = New System.Drawing.Size(156, 15)
        Me.lblMinQ.TabIndex = 8
        Me.lblMinQ.Text = "Minimum Qualification:"
        '
        'txtJobSalary
        '
        Me.txtJobSalary.Location = New System.Drawing.Point(310, 287)
        Me.txtJobSalary.Name = "txtJobSalary"
        Me.txtJobSalary.Size = New System.Drawing.Size(135, 20)
        Me.txtJobSalary.TabIndex = 7
        Me.txtJobSalary.Text = "€"
        '
        'lblJobSalary
        '
        Me.lblJobSalary.AutoSize = True
        Me.lblJobSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobSalary.Location = New System.Drawing.Point(21, 292)
        Me.lblJobSalary.Name = "lblJobSalary"
        Me.lblJobSalary.Size = New System.Drawing.Size(78, 15)
        Me.lblJobSalary.TabIndex = 6
        Me.lblJobSalary.Text = "Job Salary:"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Location = New System.Drawing.Point(310, 232)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(135, 20)
        Me.txtJobTitle.TabIndex = 5
        '
        'lblJobTitle
        '
        Me.lblJobTitle.AutoSize = True
        Me.lblJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobTitle.Location = New System.Drawing.Point(21, 237)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(66, 15)
        Me.lblJobTitle.TabIndex = 4
        Me.lblJobTitle.Text = "Job Title:"
        '
        'txtJobSect
        '
        Me.txtJobSect.Location = New System.Drawing.Point(310, 184)
        Me.txtJobSect.Name = "txtJobSect"
        Me.txtJobSect.Size = New System.Drawing.Size(135, 20)
        Me.txtJobSect.TabIndex = 3
        '
        'lblJobSect
        '
        Me.lblJobSect.AutoSize = True
        Me.lblJobSect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobSect.Location = New System.Drawing.Point(20, 189)
        Me.lblJobSect.Name = "lblJobSect"
        Me.lblJobSect.Size = New System.Drawing.Size(79, 15)
        Me.lblJobSect.TabIndex = 2
        Me.lblJobSect.Text = "Job Sector:"
        '
        'txtJobID
        '
        Me.txtJobID.Location = New System.Drawing.Point(310, 136)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.Size = New System.Drawing.Size(135, 20)
        Me.txtJobID.TabIndex = 1
        '
        'lblJobID
        '
        Me.lblJobID.AutoSize = True
        Me.lblJobID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobID.Location = New System.Drawing.Point(21, 141)
        Me.lblJobID.Name = "lblJobID"
        Me.lblJobID.Size = New System.Drawing.Size(52, 15)
        Me.lblJobID.TabIndex = 0
        Me.lblJobID.Text = "Job ID:"
        '
        'grdLocalJobs
        '
        Me.grdLocalJobs.Location = New System.Drawing.Point(509, 84)
        Me.grdLocalJobs.Name = "grdLocalJobs"
        Me.grdLocalJobs.Size = New System.Drawing.Size(507, 288)
        Me.grdLocalJobs.TabIndex = 44
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(915, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(509, 390)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 30)
        Me.btnNext.TabIndex = 45
        Me.btnNext.Text = "Next Form"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmLocalJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 633)
        Me.Controls.Add(Me.grdLocalJobs)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpLocalJobs)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmLocalJobs"
        Me.Text = "Local Jobs Form"
        Me.grpLocalJobs.ResumeLayout(False)
        Me.grpLocalJobs.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLocalJobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLocalJobs As GroupBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtConLength As TextBox
    Friend WithEvents lblConLength As Label
    Friend WithEvents txtConType As TextBox
    Friend WithEvents lblConType As Label
    Friend WithEvents txtDateAd As TextBox
    Friend WithEvents lblDateAd As Label
    Friend WithEvents txtMinEx As TextBox
    Friend WithEvents lblMinEx As Label
    Friend WithEvents txtMinQ As TextBox
    Friend WithEvents lblMinQ As Label
    Friend WithEvents txtJobSalary As TextBox
    Friend WithEvents lblJobSalary As Label
    Friend WithEvents txtJobTitle As TextBox
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents txtJobSect As TextBox
    Friend WithEvents lblJobSect As Label
    Friend WithEvents txtJobID As TextBox
    Friend WithEvents lblJobID As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents lblEmpID As Label
    Friend WithEvents lblLocalJobsForm As Label
    Friend WithEvents grdLocalJobs As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
End Class
