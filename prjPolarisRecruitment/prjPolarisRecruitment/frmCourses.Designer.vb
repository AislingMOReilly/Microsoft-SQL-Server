<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCourses
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
        Me.grpCourses = New System.Windows.Forms.GroupBox()
        Me.lblCoursesForm = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.txtYes = New System.Windows.Forms.TextBox()
        Me.txtOffID = New System.Windows.Forms.TextBox()
        Me.lblOffID = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.txtSponsor = New System.Windows.Forms.TextBox()
        Me.lblSponsor = New System.Windows.Forms.Label()
        Me.lblCert = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.lblCourseID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.grdCourses = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpCourses.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCourses
        '
        Me.grpCourses.BackColor = System.Drawing.SystemColors.Window
        Me.grpCourses.Controls.Add(Me.lblCoursesForm)
        Me.grpCourses.Controls.Add(Me.Label1)
        Me.grpCourses.Controls.Add(Me.TextBox1)
        Me.grpCourses.Controls.Add(Me.txtNo)
        Me.grpCourses.Controls.Add(Me.lblNo)
        Me.grpCourses.Controls.Add(Me.txtYes)
        Me.grpCourses.Controls.Add(Me.txtOffID)
        Me.grpCourses.Controls.Add(Me.lblOffID)
        Me.grpCourses.Controls.Add(Me.pbxLogo)
        Me.grpCourses.Controls.Add(Me.txtFee)
        Me.grpCourses.Controls.Add(Me.lblFee)
        Me.grpCourses.Controls.Add(Me.txtSponsor)
        Me.grpCourses.Controls.Add(Me.lblSponsor)
        Me.grpCourses.Controls.Add(Me.lblCert)
        Me.grpCourses.Controls.Add(Me.txtCapacity)
        Me.grpCourses.Controls.Add(Me.lblCapacity)
        Me.grpCourses.Controls.Add(Me.txtDuration)
        Me.grpCourses.Controls.Add(Me.lblDuration)
        Me.grpCourses.Controls.Add(Me.txtDirector)
        Me.grpCourses.Controls.Add(Me.lblDirector)
        Me.grpCourses.Controls.Add(Me.txtTitle)
        Me.grpCourses.Controls.Add(Me.lblTitle)
        Me.grpCourses.Controls.Add(Me.txtCourseID)
        Me.grpCourses.Controls.Add(Me.lblCourseID)
        Me.grpCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCourses.Location = New System.Drawing.Point(1, 1)
        Me.grpCourses.Name = "grpCourses"
        Me.grpCourses.Size = New System.Drawing.Size(461, 568)
        Me.grpCourses.TabIndex = 3
        Me.grpCourses.TabStop = False
        '
        'lblCoursesForm
        '
        Me.lblCoursesForm.AutoSize = True
        Me.lblCoursesForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoursesForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCoursesForm.Location = New System.Drawing.Point(160, 91)
        Me.lblCoursesForm.Name = "lblCoursesForm"
        Me.lblCoursesForm.Size = New System.Drawing.Size(126, 20)
        Me.lblCoursesForm.TabIndex = 39
        Me.lblCoursesForm.Text = "Courses Form:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Yes"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(330, 382)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(26, 20)
        Me.TextBox1.TabIndex = 37
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(408, 381)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(26, 20)
        Me.txtNo.TabIndex = 36
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.Location = New System.Drawing.Point(379, 383)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(23, 15)
        Me.lblNo.TabIndex = 35
        Me.lblNo.Text = "No"
        '
        'txtYes
        '
        Me.txtYes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtYes.Location = New System.Drawing.Point(380, 386)
        Me.txtYes.Name = "txtYes"
        Me.txtYes.Size = New System.Drawing.Size(26, 13)
        Me.txtYes.TabIndex = 33
        '
        'txtOffID
        '
        Me.txtOffID.Location = New System.Drawing.Point(300, 527)
        Me.txtOffID.Name = "txtOffID"
        Me.txtOffID.Size = New System.Drawing.Size(135, 20)
        Me.txtOffID.TabIndex = 32
        '
        'lblOffID
        '
        Me.lblOffID.AutoSize = True
        Me.lblOffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOffID.Location = New System.Drawing.Point(19, 528)
        Me.lblOffID.Name = "lblOffID"
        Me.lblOffID.Size = New System.Drawing.Size(66, 15)
        Me.lblOffID.TabIndex = 31
        Me.lblOffID.Text = "Office ID:"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = Global.prjPolarisRecruitment.My.Resources.Resources.PRLogo
        Me.pbxLogo.Location = New System.Drawing.Point(92, 11)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(264, 56)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 30
        Me.pbxLogo.TabStop = False
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(300, 474)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(135, 20)
        Me.txtFee.TabIndex = 19
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(19, 479)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(84, 15)
        Me.lblFee.TabIndex = 18
        Me.lblFee.Text = "Course Fee:"
        '
        'txtSponsor
        '
        Me.txtSponsor.Location = New System.Drawing.Point(299, 428)
        Me.txtSponsor.Name = "txtSponsor"
        Me.txtSponsor.Size = New System.Drawing.Size(135, 20)
        Me.txtSponsor.TabIndex = 17
        '
        'lblSponsor
        '
        Me.lblSponsor.AutoSize = True
        Me.lblSponsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSponsor.Location = New System.Drawing.Point(19, 433)
        Me.lblSponsor.Name = "lblSponsor"
        Me.lblSponsor.Size = New System.Drawing.Size(113, 15)
        Me.lblSponsor.TabIndex = 16
        Me.lblSponsor.Text = "Course Sponsor:"
        '
        'lblCert
        '
        Me.lblCert.AutoSize = True
        Me.lblCert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCert.Location = New System.Drawing.Point(19, 386)
        Me.lblCert.Name = "lblCert"
        Me.lblCert.Size = New System.Drawing.Size(114, 15)
        Me.lblCert.TabIndex = 10
        Me.lblCert.Text = "Certified Course:"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(300, 332)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(135, 20)
        Me.txtCapacity.TabIndex = 9
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.Location = New System.Drawing.Point(20, 337)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(114, 15)
        Me.lblCapacity.TabIndex = 8
        Me.lblCapacity.Text = "Course Capacity:"
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(300, 283)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(135, 20)
        Me.txtDuration.TabIndex = 7
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(20, 288)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(115, 15)
        Me.lblDuration.TabIndex = 6
        Me.lblDuration.Text = "Course Duration:"
        '
        'txtDirector
        '
        Me.txtDirector.Location = New System.Drawing.Point(300, 231)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.Size = New System.Drawing.Size(135, 20)
        Me.txtDirector.TabIndex = 5
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(20, 236)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(111, 15)
        Me.lblDirector.TabIndex = 4
        Me.lblDirector.Text = "Course Director:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(300, 183)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(135, 20)
        Me.txtTitle.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(19, 188)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(88, 15)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Course Title:"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(300, 135)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(135, 20)
        Me.txtCourseID.TabIndex = 1
        '
        'lblCourseID
        '
        Me.lblCourseID.AutoSize = True
        Me.lblCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourseID.Location = New System.Drawing.Point(20, 140)
        Me.lblCourseID.Name = "lblCourseID"
        Me.lblCourseID.Size = New System.Drawing.Size(74, 15)
        Me.lblCourseID.TabIndex = 0
        Me.lblCourseID.Text = "Course ID:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(889, 38)
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
        Me.btnUpdate.Location = New System.Drawing.Point(756, 38)
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
        Me.btnView.Location = New System.Drawing.Point(623, 38)
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
        Me.btnCreate.Location = New System.Drawing.Point(488, 38)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(106, 29)
        Me.btnCreate.TabIndex = 26
        Me.btnCreate.Text = "Create Record"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'grdCourses
        '
        Me.grdCourses.Location = New System.Drawing.Point(488, 82)
        Me.grdCourses.Name = "grdCourses"
        Me.grdCourses.Size = New System.Drawing.Size(507, 288)
        Me.grdCourses.TabIndex = 50
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(894, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 27)
        Me.btnExit.TabIndex = 52
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Black
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Location = New System.Drawing.Point(488, 392)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(101, 30)
        Me.btnNext.TabIndex = 51
        Me.btnNext.Text = "Next Form"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 572)
        Me.Controls.Add(Me.grdCourses)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpCourses)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "frmCourses"
        Me.Text = "Courses Form"
        Me.grpCourses.ResumeLayout(False)
        Me.grpCourses.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCourses As GroupBox
    Friend WithEvents txtOffID As TextBox
    Friend WithEvents lblOffID As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtFee As TextBox
    Friend WithEvents lblFee As Label
    Friend WithEvents txtSponsor As TextBox
    Friend WithEvents lblSponsor As Label
    Friend WithEvents lblCert As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents lblCapacity As Label
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents lblDuration As Label
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents lblDirector As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents lblCourseID As Label
    Friend WithEvents txtNo As TextBox
    Friend WithEvents lblNo As Label
    Friend WithEvents txtYes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCoursesForm As Label
    Friend WithEvents grdCourses As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
End Class
