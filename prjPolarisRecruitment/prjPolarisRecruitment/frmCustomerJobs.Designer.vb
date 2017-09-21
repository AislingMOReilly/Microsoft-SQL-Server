<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerJobs
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
        Me.grpCustJobs = New System.Windows.Forms.GroupBox()
        Me.grdCustJobs = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblCustJobsForm = New System.Windows.Forms.Label()
        Me.txtJobID = New System.Windows.Forms.TextBox()
        Me.lblJobID = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.grpCustJobs.SuspendLayout()
        CType(Me.grdCustJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustJobs
        '
        Me.grpCustJobs.BackColor = System.Drawing.SystemColors.Window
        Me.grpCustJobs.Controls.Add(Me.grdCustJobs)
        Me.grpCustJobs.Controls.Add(Me.btnExit)
        Me.grpCustJobs.Controls.Add(Me.btnNext)
        Me.grpCustJobs.Controls.Add(Me.lblCustJobsForm)
        Me.grpCustJobs.Controls.Add(Me.txtJobID)
        Me.grpCustJobs.Controls.Add(Me.lblJobID)
        Me.grpCustJobs.Controls.Add(Me.pbxLogo)
        Me.grpCustJobs.Controls.Add(Me.btnDelete)
        Me.grpCustJobs.Controls.Add(Me.btnUpdate)
        Me.grpCustJobs.Controls.Add(Me.btnView)
        Me.grpCustJobs.Controls.Add(Me.btnCreate)
        Me.grpCustJobs.Controls.Add(Me.txtCustID)
        Me.grpCustJobs.Controls.Add(Me.lblCustID)
        Me.grpCustJobs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCustJobs.Location = New System.Drawing.Point(3, 3)
        Me.grpCustJobs.Name = "grpCustJobs"
        Me.grpCustJobs.Size = New System.Drawing.Size(537, 643)
        Me.grpCustJobs.TabIndex = 3
        Me.grpCustJobs.TabStop = False
        '
        'grdCustJobs
        '
        Me.grdCustJobs.Location = New System.Drawing.Point(12, 295)
        Me.grdCustJobs.Name = "grdCustJobs"
        Me.grdCustJobs.Size = New System.Drawing.Size(507, 288)
        Me.grdCustJobs.TabIndex = 47
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(418, 596)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 49
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(12, 601)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 30)
        Me.btnNext.TabIndex = 48
        Me.btnNext.Text = "Next Form"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblCustJobsForm
        '
        Me.lblCustJobsForm.AutoSize = True
        Me.lblCustJobsForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustJobsForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCustJobsForm.Location = New System.Drawing.Point(168, 87)
        Me.lblCustJobsForm.Name = "lblCustJobsForm"
        Me.lblCustJobsForm.Size = New System.Drawing.Size(180, 20)
        Me.lblCustJobsForm.TabIndex = 40
        Me.lblCustJobsForm.Text = "Customer Jobs Form:"
        '
        'txtJobID
        '
        Me.txtJobID.Location = New System.Drawing.Point(287, 182)
        Me.txtJobID.Name = "txtJobID"
        Me.txtJobID.Size = New System.Drawing.Size(168, 20)
        Me.txtJobID.TabIndex = 32
        '
        'lblJobID
        '
        Me.lblJobID.AutoSize = True
        Me.lblJobID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobID.Location = New System.Drawing.Point(68, 183)
        Me.lblJobID.Name = "lblJobID"
        Me.lblJobID.Size = New System.Drawing.Size(52, 15)
        Me.lblJobID.TabIndex = 31
        Me.lblJobID.Text = "Job ID:"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(125, 9)
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
        Me.btnDelete.Location = New System.Drawing.Point(407, 251)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 29)
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
        Me.btnUpdate.Location = New System.Drawing.Point(277, 251)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 29)
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
        Me.btnView.Location = New System.Drawing.Point(143, 251)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(112, 29)
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
        Me.btnCreate.Location = New System.Drawing.Point(12, 251)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(111, 29)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(287, 130)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(168, 20)
        Me.txtCustID.TabIndex = 1
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustID.Location = New System.Drawing.Point(69, 135)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(90, 15)
        Me.lblCustID.TabIndex = 0
        Me.lblCustID.Text = "Customer ID:"
        '
        'frmCustomerJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 647)
        Me.Controls.Add(Me.grpCustJobs)
        Me.Name = "frmCustomerJobs"
        Me.Text = "Customer Jobs Form"
        Me.grpCustJobs.ResumeLayout(False)
        Me.grpCustJobs.PerformLayout()
        CType(Me.grdCustJobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustJobs As GroupBox
    Friend WithEvents txtJobID As TextBox
    Friend WithEvents lblJobID As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents lblCustID As Label
    Friend WithEvents lblCustJobsForm As Label
    Friend WithEvents grdCustJobs As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
End Class
