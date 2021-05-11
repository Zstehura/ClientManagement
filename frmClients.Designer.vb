<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClients))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblBateofBirth = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblCircumstances = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Client_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDBDataSet = New Clients.ClientDBDataSet()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCircum = New System.Windows.Forms.TextBox()
        Me.Client_tableTableAdapter = New Clients.ClientDBDataSetTableAdapters.Client_tableTableAdapter()
        Me.TableAdapterManager = New Clients.ClientDBDataSetTableAdapters.TableAdapterManager()
        Me.Client_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Client_tableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.Client_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Client_tableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(147, 36)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(342, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Please enter the client's Information"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(37, 81)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(37, 109)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'lblBateofBirth
        '
        Me.lblBateofBirth.AutoSize = True
        Me.lblBateofBirth.Location = New System.Drawing.Point(37, 137)
        Me.lblBateofBirth.Name = "lblBateofBirth"
        Me.lblBateofBirth.Size = New System.Drawing.Size(69, 13)
        Me.lblBateofBirth.TabIndex = 3
        Me.lblBateofBirth.Text = "Date of Birth:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(250, 81)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(250, 109)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(474, 109)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State:"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(250, 137)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(55, 13)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "ZIP Code:"
        '
        'lblCircumstances
        '
        Me.lblCircumstances.AutoSize = True
        Me.lblCircumstances.Location = New System.Drawing.Point(37, 165)
        Me.lblCircumstances.Name = "lblCircumstances"
        Me.lblCircumstances.Size = New System.Drawing.Size(79, 13)
        Me.lblCircumstances.TabIndex = 8
        Me.lblCircumstances.Text = "Circumstances:"
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(115, 77)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(117, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'Client_tableBindingSource
        '
        Me.Client_tableBindingSource.DataMember = "Client_table"
        Me.Client_tableBindingSource.DataSource = Me.ClientDBDataSet
        '
        'ClientDBDataSet
        '
        Me.ClientDBDataSet.DataSetName = "ClientDBDataSet"
        Me.ClientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(115, 105)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(117, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtDoB
        '
        Me.txtDoB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "DoB", True))
        Me.txtDoB.Location = New System.Drawing.Point(115, 133)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.Size = New System.Drawing.Size(117, 20)
        Me.txtDoB.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(312, 77)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(268, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(312, 105)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ShortcutsEnabled = False
        Me.txtCity.Size = New System.Drawing.Size(129, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "State", True))
        Me.txtState.Location = New System.Drawing.Point(531, 105)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(21, 20)
        Me.txtState.TabIndex = 6
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "ZIP", True))
        Me.txtZip.Location = New System.Drawing.Point(312, 133)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(43, 20)
        Me.txtZip.TabIndex = 7
        '
        'txtCircum
        '
        Me.txtCircum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCircum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tableBindingSource, "Circumstance", True))
        Me.txtCircum.Location = New System.Drawing.Point(40, 194)
        Me.txtCircum.Multiline = True
        Me.txtCircum.Name = "txtCircum"
        Me.txtCircum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCircum.Size = New System.Drawing.Size(560, 213)
        Me.txtCircum.TabIndex = 8
        '
        'Client_tableTableAdapter
        '
        Me.Client_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Business_tableTableAdapter = Nothing
        Me.TableAdapterManager.Client_tableTableAdapter = Me.Client_tableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clients.ClientDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Client_tableBindingNavigator
        '
        Me.Client_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Client_tableBindingNavigator.BindingSource = Me.Client_tableBindingSource
        Me.Client_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Client_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Client_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Client_tableBindingNavigatorSaveItem})
        Me.Client_tableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Client_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Client_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Client_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Client_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Client_tableBindingNavigator.Name = "Client_tableBindingNavigator"
        Me.Client_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Client_tableBindingNavigator.Size = New System.Drawing.Size(646, 25)
        Me.Client_tableBindingNavigator.TabIndex = 18
        Me.Client_tableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Client_tableBindingNavigatorSaveItem
        '
        Me.Client_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Client_tableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Client_tableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Client_tableBindingNavigatorSaveItem.Name = "Client_tableBindingNavigatorSaveItem"
        Me.Client_tableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Client_tableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(436, 427)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmClients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 462)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Client_tableBindingNavigator)
        Me.Controls.Add(Me.txtCircum)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblCircumstances)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblBateofBirth)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmClients"
        Me.Text = "Client Information"
        CType(Me.Client_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Client_tableBindingNavigator.ResumeLayout(False)
        Me.Client_tableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblBateofBirth As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblCircumstances As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCircum As TextBox
    Friend WithEvents ClientDBDataSet As ClientDBDataSet
    Friend WithEvents Client_tableBindingSource As BindingSource
    Friend WithEvents Client_tableTableAdapter As ClientDBDataSetTableAdapters.Client_tableTableAdapter
    Friend WithEvents TableAdapterManager As ClientDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_tableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Client_tableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnClear As Button
End Class
