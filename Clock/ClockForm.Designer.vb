<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAdjust = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblCounter1 = New System.Windows.Forms.Label()
        Me.lblCounter2 = New System.Windows.Forms.Label()
        Me.txtbxSec = New System.Windows.Forms.TextBox()
        Me.txtbxMin = New System.Windows.Forms.TextBox()
        Me.txtbxHour = New System.Windows.Forms.TextBox()
        Me.rdbtn24 = New System.Windows.Forms.RadioButton()
        Me.rdbtn12 = New System.Windows.Forms.RadioButton()
        Me.lblSunlight = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.lblSetSec = New System.Windows.Forms.Label()
        Me.lblSetMin = New System.Windows.Forms.Label()
        Me.lblSetHour = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(109, 165)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(41, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAdjust
        '
        Me.btnAdjust.Location = New System.Drawing.Point(13, 165)
        Me.btnAdjust.Name = "btnAdjust"
        Me.btnAdjust.Size = New System.Drawing.Size(62, 23)
        Me.btnAdjust.TabIndex = 3
        Me.btnAdjust.Text = "Adjust"
        Me.btnAdjust.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(5, 19)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(60, 45)
        Me.lblSec.TabIndex = 0
        Me.lblSec.Text = "00"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(94, 19)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(60, 45)
        Me.lblMin.TabIndex = 3
        Me.lblMin.Text = "00"
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(169, 19)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(60, 45)
        Me.lblHour.TabIndex = 2
        Me.lblHour.Text = "00"
        '
        'lblCounter1
        '
        Me.lblCounter1.AutoSize = True
        Me.lblCounter1.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter1.Location = New System.Drawing.Point(62, 19)
        Me.lblCounter1.Name = "lblCounter1"
        Me.lblCounter1.Size = New System.Drawing.Size(33, 45)
        Me.lblCounter1.TabIndex = 3
        Me.lblCounter1.Text = ":"
        '
        'lblCounter2
        '
        Me.lblCounter2.AutoSize = True
        Me.lblCounter2.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter2.Location = New System.Drawing.Point(145, 19)
        Me.lblCounter2.Name = "lblCounter2"
        Me.lblCounter2.Size = New System.Drawing.Size(33, 45)
        Me.lblCounter2.TabIndex = 2
        Me.lblCounter2.Text = ":"
        '
        'txtbxSec
        '
        Me.txtbxSec.Location = New System.Drawing.Point(12, 119)
        Me.txtbxSec.MaxLength = 2
        Me.txtbxSec.Name = "txtbxSec"
        Me.txtbxSec.ReadOnly = True
        Me.txtbxSec.Size = New System.Drawing.Size(25, 20)
        Me.txtbxSec.TabIndex = 4
        '
        'txtbxMin
        '
        Me.txtbxMin.Location = New System.Drawing.Point(44, 119)
        Me.txtbxMin.MaxLength = 2
        Me.txtbxMin.Name = "txtbxMin"
        Me.txtbxMin.ReadOnly = True
        Me.txtbxMin.Size = New System.Drawing.Size(25, 20)
        Me.txtbxMin.TabIndex = 5
        '
        'txtbxHour
        '
        Me.txtbxHour.Location = New System.Drawing.Point(75, 119)
        Me.txtbxHour.MaxLength = 2
        Me.txtbxHour.Name = "txtbxHour"
        Me.txtbxHour.ReadOnly = True
        Me.txtbxHour.Size = New System.Drawing.Size(25, 20)
        Me.txtbxHour.TabIndex = 6
        '
        'rdbtn24
        '
        Me.rdbtn24.AutoSize = True
        Me.rdbtn24.Location = New System.Drawing.Point(90, 67)
        Me.rdbtn24.Name = "rdbtn24"
        Me.rdbtn24.Size = New System.Drawing.Size(68, 17)
        Me.rdbtn24.TabIndex = 7
        Me.rdbtn24.TabStop = True
        Me.rdbtn24.Text = "24 Hours"
        Me.rdbtn24.UseVisualStyleBackColor = True
        '
        'rdbtn12
        '
        Me.rdbtn12.AutoSize = True
        Me.rdbtn12.Location = New System.Drawing.Point(13, 67)
        Me.rdbtn12.Name = "rdbtn12"
        Me.rdbtn12.Size = New System.Drawing.Size(68, 17)
        Me.rdbtn12.TabIndex = 8
        Me.rdbtn12.TabStop = True
        Me.rdbtn12.Text = "12 Hours"
        Me.rdbtn12.UseVisualStyleBackColor = True
        '
        'lblSunlight
        '
        Me.lblSunlight.AutoSize = True
        Me.lblSunlight.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSunlight.Location = New System.Drawing.Point(219, 19)
        Me.lblSunlight.Name = "lblSunlight"
        Me.lblSunlight.Size = New System.Drawing.Size(74, 45)
        Me.lblSunlight.TabIndex = 9
        Me.lblSunlight.Text = "am"
        '
        'cmbSection
        '
        Me.cmbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSection.Enabled = False
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Items.AddRange(New Object() {"am", "pm"})
        Me.cmbSection.Location = New System.Drawing.Point(108, 119)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(39, 21)
        Me.cmbSection.Sorted = True
        Me.cmbSection.TabIndex = 10
        '
        'lblSetSec
        '
        Me.lblSetSec.AutoSize = True
        Me.lblSetSec.Location = New System.Drawing.Point(9, 103)
        Me.lblSetSec.Name = "lblSetSec"
        Me.lblSetSec.Size = New System.Drawing.Size(26, 13)
        Me.lblSetSec.TabIndex = 11
        Me.lblSetSec.Text = "Sec"
        '
        'lblSetMin
        '
        Me.lblSetMin.AutoSize = True
        Me.lblSetMin.Location = New System.Drawing.Point(45, 103)
        Me.lblSetMin.Name = "lblSetMin"
        Me.lblSetMin.Size = New System.Drawing.Size(24, 13)
        Me.lblSetMin.TabIndex = 12
        Me.lblSetMin.Text = "Min"
        '
        'lblSetHour
        '
        Me.lblSetHour.AutoSize = True
        Me.lblSetHour.Location = New System.Drawing.Point(77, 103)
        Me.lblSetHour.Name = "lblSetHour"
        Me.lblSetHour.Size = New System.Drawing.Size(18, 13)
        Me.lblSetHour.TabIndex = 13
        Me.lblSetHour.Text = "Hr"
        '
        'ClockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 246)
        Me.Controls.Add(Me.lblSetHour)
        Me.Controls.Add(Me.lblSetMin)
        Me.Controls.Add(Me.lblSetSec)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.lblSunlight)
        Me.Controls.Add(Me.rdbtn12)
        Me.Controls.Add(Me.rdbtn24)
        Me.Controls.Add(Me.txtbxHour)
        Me.Controls.Add(Me.txtbxMin)
        Me.Controls.Add(Me.txtbxSec)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.lblCounter2)
        Me.Controls.Add(Me.btnAdjust)
        Me.Controls.Add(Me.lblCounter1)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblSec)
        Me.Name = "ClockForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIGITAL CLOCK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAdjust As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents lblCounter1 As System.Windows.Forms.Label
    Friend WithEvents lblCounter2 As System.Windows.Forms.Label
    Friend WithEvents txtbxSec As System.Windows.Forms.TextBox
    Friend WithEvents txtbxMin As System.Windows.Forms.TextBox
    Friend WithEvents txtbxHour As System.Windows.Forms.TextBox
    Friend WithEvents rdbtn24 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtn12 As System.Windows.Forms.RadioButton
    Friend WithEvents lblSunlight As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents lblSetSec As System.Windows.Forms.Label
    Friend WithEvents lblSetMin As System.Windows.Forms.Label
    Friend WithEvents lblSetHour As System.Windows.Forms.Label

End Class
