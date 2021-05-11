<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetsClient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCircum = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(176, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ZIP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Circumstance:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(98, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(270, 20)
        Me.txtName.TabIndex = 7
        '
        'txtDoB
        '
        Me.txtDoB.Location = New System.Drawing.Point(98, 41)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.ReadOnly = True
        Me.txtDoB.Size = New System.Drawing.Size(270, 20)
        Me.txtDoB.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(98, 69)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(270, 20)
        Me.txtAddress.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(98, 97)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(270, 20)
        Me.txtCity.TabIndex = 10
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(98, 125)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(36, 20)
        Me.txtState.TabIndex = 11
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(209, 125)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(66, 20)
        Me.txtZip.TabIndex = 12
        '
        'txtCircum
        '
        Me.txtCircum.Location = New System.Drawing.Point(19, 183)
        Me.txtCircum.Multiline = True
        Me.txtCircum.Name = "txtCircum"
        Me.txtCircum.ReadOnly = True
        Me.txtCircum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCircum.Size = New System.Drawing.Size(349, 218)
        Me.txtCircum.TabIndex = 13
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(291, 415)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(48, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmClientDets
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtCircum)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientDets"
        Me.Text = "Client Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCircum As TextBox
    Friend WithEvents btnOK As Button
End Class
