<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOffice
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
        Me.grpOffice = New System.Windows.Forms.GroupBox()
        Me.grdOffice = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOffForm = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtNoEmps = New System.Windows.Forms.TextBox()
        Me.lblNoEmps = New System.Windows.Forms.Label()
        Me.txtOffEmail = New System.Windows.Forms.TextBox()
        Me.lblOffEmail = New System.Windows.Forms.Label()
        Me.txtOffConNo = New System.Windows.Forms.TextBox()
        Me.lblOffConNo = New System.Windows.Forms.Label()
        Me.txtOffAdd = New System.Windows.Forms.TextBox()
        Me.lblOffAdd = New System.Windows.Forms.Label()
        Me.txtOffID = New System.Windows.Forms.TextBox()
        Me.lblOffID = New System.Windows.Forms.Label()
        Me.grpOffice.SuspendLayout()
        CType(Me.grdOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOffice
        '
        Me.grpOffice.BackColor = System.Drawing.SystemColors.Window
        Me.grpOffice.Controls.Add(Me.grdOffice)
        Me.grpOffice.Controls.Add(Me.btnExit)
        Me.grpOffice.Controls.Add(Me.lblOffForm)
        Me.grpOffice.Controls.Add(Me.btnDelete)
        Me.grpOffice.Controls.Add(Me.btnUpdate)
        Me.grpOffice.Controls.Add(Me.btnView)
        Me.grpOffice.Controls.Add(Me.btnCreate)
        Me.grpOffice.Controls.Add(Me.pbxLogo)
        Me.grpOffice.Controls.Add(Me.txtNoEmps)
        Me.grpOffice.Controls.Add(Me.lblNoEmps)
        Me.grpOffice.Controls.Add(Me.txtOffEmail)
        Me.grpOffice.Controls.Add(Me.lblOffEmail)
        Me.grpOffice.Controls.Add(Me.txtOffConNo)
        Me.grpOffice.Controls.Add(Me.lblOffConNo)
        Me.grpOffice.Controls.Add(Me.txtOffAdd)
        Me.grpOffice.Controls.Add(Me.lblOffAdd)
        Me.grpOffice.Controls.Add(Me.txtOffID)
        Me.grpOffice.Controls.Add(Me.lblOffID)
        Me.grpOffice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpOffice.Location = New System.Drawing.Point(3, 2)
        Me.grpOffice.Name = "grpOffice"
        Me.grpOffice.Size = New System.Drawing.Size(568, 710)
        Me.grpOffice.TabIndex = 4
        Me.grpOffice.TabStop = False
        '
        'grdOffice
        '
        Me.grdOffice.Location = New System.Drawing.Point(27, 402)
        Me.grdOffice.Name = "grdOffice"
        Me.grdOffice.Size = New System.Drawing.Size(507, 240)
        Me.grdOffice.TabIndex = 50
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(433, 658)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 52
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblOffForm
        '
        Me.lblOffForm.AutoSize = True
        Me.lblOffForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblOffForm.Location = New System.Drawing.Point(214, 70)
        Me.lblOffForm.Name = "lblOffForm"
        Me.lblOffForm.Size = New System.Drawing.Size(108, 20)
        Me.lblOffForm.TabIndex = 35
        Me.lblOffForm.Text = "Office Form:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(425, 358)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 29)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(295, 358)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 29)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnView.Location = New System.Drawing.Point(160, 358)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(109, 29)
        Me.btnView.TabIndex = 32
        Me.btnView.Text = "View Record"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Location = New System.Drawing.Point(27, 358)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(109, 29)
        Me.btnCreate.TabIndex = 31
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(140, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(264, 56)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 30
        Me.pbxLogo.TabStop = False
        '
        'txtNoEmps
        '
        Me.txtNoEmps.Location = New System.Drawing.Point(347, 298)
        Me.txtNoEmps.Name = "txtNoEmps"
        Me.txtNoEmps.Size = New System.Drawing.Size(135, 20)
        Me.txtNoEmps.TabIndex = 9
        '
        'lblNoEmps
        '
        Me.lblNoEmps.AutoSize = True
        Me.lblNoEmps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoEmps.Location = New System.Drawing.Point(58, 303)
        Me.lblNoEmps.Name = "lblNoEmps"
        Me.lblNoEmps.Size = New System.Drawing.Size(152, 15)
        Me.lblNoEmps.TabIndex = 8
        Me.lblNoEmps.Text = "Number of Employees:"
        '
        'txtOffEmail
        '
        Me.txtOffEmail.Location = New System.Drawing.Point(347, 249)
        Me.txtOffEmail.Name = "txtOffEmail"
        Me.txtOffEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtOffEmail.TabIndex = 7
        '
        'lblOffEmail
        '
        Me.lblOffEmail.AutoSize = True
        Me.lblOffEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffEmail.Location = New System.Drawing.Point(58, 254)
        Me.lblOffEmail.Name = "lblOffEmail"
        Me.lblOffEmail.Size = New System.Drawing.Size(144, 15)
        Me.lblOffEmail.TabIndex = 6
        Me.lblOffEmail.Text = "Office Email Address:"
        '
        'txtOffConNo
        '
        Me.txtOffConNo.Location = New System.Drawing.Point(347, 197)
        Me.txtOffConNo.Name = "txtOffConNo"
        Me.txtOffConNo.Size = New System.Drawing.Size(135, 20)
        Me.txtOffConNo.TabIndex = 5
        '
        'lblOffConNo
        '
        Me.lblOffConNo.AutoSize = True
        Me.lblOffConNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffConNo.Location = New System.Drawing.Point(58, 202)
        Me.lblOffConNo.Name = "lblOffConNo"
        Me.lblOffConNo.Size = New System.Drawing.Size(155, 15)
        Me.lblOffConNo.TabIndex = 4
        Me.lblOffConNo.Text = "Office Contact Number:"
        '
        'txtOffAdd
        '
        Me.txtOffAdd.Location = New System.Drawing.Point(347, 149)
        Me.txtOffAdd.Name = "txtOffAdd"
        Me.txtOffAdd.Size = New System.Drawing.Size(135, 20)
        Me.txtOffAdd.TabIndex = 3
        '
        'lblOffAdd
        '
        Me.lblOffAdd.AutoSize = True
        Me.lblOffAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffAdd.Location = New System.Drawing.Point(57, 154)
        Me.lblOffAdd.Name = "lblOffAdd"
        Me.lblOffAdd.Size = New System.Drawing.Size(103, 15)
        Me.lblOffAdd.TabIndex = 2
        Me.lblOffAdd.Text = "Office Address:"
        '
        'txtOffID
        '
        Me.txtOffID.Location = New System.Drawing.Point(347, 101)
        Me.txtOffID.Name = "txtOffID"
        Me.txtOffID.Size = New System.Drawing.Size(135, 20)
        Me.txtOffID.TabIndex = 1
        '
        'lblOffID
        '
        Me.lblOffID.AutoSize = True
        Me.lblOffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffID.Location = New System.Drawing.Point(58, 106)
        Me.lblOffID.Name = "lblOffID"
        Me.lblOffID.Size = New System.Drawing.Size(66, 15)
        Me.lblOffID.TabIndex = 0
        Me.lblOffID.Text = "Office ID:"
        '
        'frmOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 712)
        Me.Controls.Add(Me.grpOffice)
        Me.Name = "frmOffice"
        Me.Text = "Office Form"
        Me.grpOffice.ResumeLayout(False)
        Me.grpOffice.PerformLayout()
        CType(Me.grdOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOffice As GroupBox
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents txtNoEmps As TextBox
    Friend WithEvents lblNoEmps As Label
    Friend WithEvents txtOffEmail As TextBox
    Friend WithEvents lblOffEmail As Label
    Friend WithEvents txtOffConNo As TextBox
    Friend WithEvents lblOffConNo As Label
    Friend WithEvents txtOffAdd As TextBox
    Friend WithEvents lblOffAdd As Label
    Friend WithEvents txtOffID As TextBox
    Friend WithEvents lblOffID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblOffForm As Label
    Friend WithEvents grdOffice As DataGridView
    Friend WithEvents btnExit As Button
End Class
