<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetsVisit
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
        Me.txtBusiness = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtAssociate = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Business:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Associate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Location:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Client:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Description:"
        '
        'txtBusiness
        '
        Me.txtBusiness.Location = New System.Drawing.Point(84, 10)
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.ReadOnly = True
        Me.txtBusiness.Size = New System.Drawing.Size(225, 20)
        Me.txtBusiness.TabIndex = 6
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(84, 37)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(225, 20)
        Me.txtDate.TabIndex = 7
        '
        'txtAssociate
        '
        Me.txtAssociate.Location = New System.Drawing.Point(84, 64)
        Me.txtAssociate.Name = "txtAssociate"
        Me.txtAssociate.ReadOnly = True
        Me.txtAssociate.Size = New System.Drawing.Size(225, 20)
        Me.txtAssociate.TabIndex = 8
        Me.txtAssociate.Text = "X"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(84, 91)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(225, 20)
        Me.txtLocation.TabIndex = 9
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(84, 118)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.ReadOnly = True
        Me.txtClient.Size = New System.Drawing.Size(225, 20)
        Me.txtClient.TabIndex = 10
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(16, 167)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(293, 219)
        Me.txtDescription.TabIndex = 11
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(227, 407)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(50, 23)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmDetsVisit
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(321, 450)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtClient)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtAssociate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtBusiness)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDetsVisit"
        Me.Text = "Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBusiness As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtAssociate As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtClient As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnOK As Button
End Class
