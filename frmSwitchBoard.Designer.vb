<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSwitchBoard
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
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.btnNewBusiness = New System.Windows.Forms.Button()
        Me.btnClientLookup = New System.Windows.Forms.Button()
        Me.btnVisitLookup = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewClient
        '
        Me.btnNewClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewClient.Location = New System.Drawing.Point(7, 53)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(147, 68)
        Me.btnNewClient.TabIndex = 0
        Me.btnNewClient.Text = "Clients"
        Me.btnNewClient.UseVisualStyleBackColor = True
        '
        'btnNewBusiness
        '
        Me.btnNewBusiness.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBusiness.Location = New System.Drawing.Point(160, 53)
        Me.btnNewBusiness.Name = "btnNewBusiness"
        Me.btnNewBusiness.Size = New System.Drawing.Size(147, 68)
        Me.btnNewBusiness.TabIndex = 1
        Me.btnNewBusiness.Text = "Business Visits"
        Me.btnNewBusiness.UseVisualStyleBackColor = True
        '
        'btnClientLookup
        '
        Me.btnClientLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientLookup.Location = New System.Drawing.Point(6, 128)
        Me.btnClientLookup.Name = "btnClientLookup"
        Me.btnClientLookup.Size = New System.Drawing.Size(147, 68)
        Me.btnClientLookup.TabIndex = 2
        Me.btnClientLookup.Text = "Client Lookup"
        Me.btnClientLookup.UseVisualStyleBackColor = True
        '
        'btnVisitLookup
        '
        Me.btnVisitLookup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitLookup.Location = New System.Drawing.Point(159, 128)
        Me.btnVisitLookup.Name = "btnVisitLookup"
        Me.btnVisitLookup.Size = New System.Drawing.Size(147, 68)
        Me.btnVisitLookup.TabIndex = 3
        Me.btnVisitLookup.Text = "Visit lookup"
        Me.btnVisitLookup.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(83, 202)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(147, 68)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSwitchBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 315)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnVisitLookup)
        Me.Controls.Add(Me.btnClientLookup)
        Me.Controls.Add(Me.btnNewBusiness)
        Me.Controls.Add(Me.btnNewClient)
        Me.Name = "frmSwitchBoard"
        Me.Text = "Client Database Manager"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewClient As Button
    Friend WithEvents btnNewBusiness As Button
    Friend WithEvents btnClientLookup As Button
    Friend WithEvents btnVisitLookup As Button
    Friend WithEvents btnExit As Button
End Class
