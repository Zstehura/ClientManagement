<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisitation))
        Me.ClientDBDataSet = New Clients.ClientDBDataSet()
        Me.Business_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Business_tableTableAdapter = New Clients.ClientDBDataSetTableAdapters.Business_tableTableAdapter()
        Me.TableAdapterManager = New Clients.ClientDBDataSetTableAdapters.TableAdapterManager()
        Me.Business_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Business_tableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBusiness = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblAssociate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtBusiness = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtAssociate = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.chkGeneral = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.BusinesstableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.Client_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Client_tableTableAdapter = New Clients.ClientDBDataSetTableAdapters.Client_tableTableAdapter()
        Me.datDateOf = New System.Windows.Forms.DateTimePicker()
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Business_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Business_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Business_tableBindingNavigator.SuspendLayout()
        CType(Me.BusinesstableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientDBDataSet
        '
        Me.ClientDBDataSet.DataSetName = "ClientDBDataSet"
        Me.ClientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Business_tableBindingSource
        '
        Me.Business_tableBindingSource.DataMember = "Business_table"
        Me.Business_tableBindingSource.DataSource = Me.ClientDBDataSet
        '
        'Business_tableTableAdapter
        '
        Me.Business_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Business_tableTableAdapter = Me.Business_tableTableAdapter
        Me.TableAdapterManager.Client_tableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Clients.ClientDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Business_tableBindingNavigator
        '
        Me.Business_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Business_tableBindingNavigator.BindingSource = Me.Business_tableBindingSource
        Me.Business_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Business_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Business_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Business_tableBindingNavigatorSaveItem})
        Me.Business_tableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Business_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Business_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Business_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Business_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Business_tableBindingNavigator.Name = "Business_tableBindingNavigator"
        Me.Business_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Business_tableBindingNavigator.Size = New System.Drawing.Size(512, 25)
        Me.Business_tableBindingNavigator.TabIndex = 0
        Me.Business_tableBindingNavigator.Text = "BindingNavigator1"
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
        'Business_tableBindingNavigatorSaveItem
        '
        Me.Business_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Business_tableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Business_tableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Business_tableBindingNavigatorSaveItem.Name = "Business_tableBindingNavigatorSaveItem"
        Me.Business_tableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Business_tableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(181, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(204, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "How did the visit go?"
        '
        'lblBusiness
        '
        Me.lblBusiness.AutoSize = True
        Me.lblBusiness.Location = New System.Drawing.Point(12, 66)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(83, 13)
        Me.lblBusiness.TabIndex = 4
        Me.lblBusiness.Text = "Business Name:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(12, 97)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(48, 13)
        Me.lblLocation.TabIndex = 5
        Me.lblLocation.Text = "Location"
        '
        'lblAssociate
        '
        Me.lblAssociate.AutoSize = True
        Me.lblAssociate.Location = New System.Drawing.Point(12, 159)
        Me.lblAssociate.Name = "lblAssociate"
        Me.lblAssociate.Size = New System.Drawing.Size(104, 13)
        Me.lblAssociate.TabIndex = 6
        Me.lblAssociate.Text = "Associate Talked to:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(16, 194)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(311, 159)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(67, 13)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date of Visit:"
        '
        'txtBusiness
        '
        Me.txtBusiness.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Business_tableBindingSource, "Business", True))
        Me.txtBusiness.Location = New System.Drawing.Point(125, 62)
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.Size = New System.Drawing.Size(365, 20)
        Me.txtBusiness.TabIndex = 1
        '
        'txtLocation
        '
        Me.txtLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Business_tableBindingSource, "Location", True))
        Me.txtLocation.Location = New System.Drawing.Point(125, 93)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(260, 20)
        Me.txtLocation.TabIndex = 2
        '
        'txtAssociate
        '
        Me.txtAssociate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Business_tableBindingSource, "Associate", True))
        Me.txtAssociate.Location = New System.Drawing.Point(125, 155)
        Me.txtAssociate.Name = "txtAssociate"
        Me.txtAssociate.Size = New System.Drawing.Size(161, 20)
        Me.txtAssociate.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Business_tableBindingSource, "Description", True))
        Me.txtDescription.Location = New System.Drawing.Point(12, 210)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(485, 164)
        Me.txtDescription.TabIndex = 7
        '
        'chkGeneral
        '
        Me.chkGeneral.AutoSize = True
        Me.chkGeneral.Location = New System.Drawing.Point(311, 127)
        Me.chkGeneral.Name = "chkGeneral"
        Me.chkGeneral.Size = New System.Drawing.Size(113, 17)
        Me.chkGeneral.TabIndex = 16
        Me.chkGeneral.Text = "General Questions"
        Me.chkGeneral.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.Location = New System.Drawing.Point(428, 380)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(12, 128)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(67, 13)
        Me.lblClientName.TabIndex = 19
        Me.lblClientName.Text = "Client Name:"
        '
        'BusinesstableBindingSource
        '
        Me.BusinesstableBindingSource.DataMember = "Business_table"
        Me.BusinesstableBindingSource.DataSource = Me.ClientDBDataSet
        '
        'txtClientName
        '
        Me.txtClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtClientName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Business_tableBindingSource, "ClientName", True))
        Me.txtClientName.Location = New System.Drawing.Point(125, 125)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(161, 20)
        Me.txtClientName.TabIndex = 3
        '
        'Client_tableBindingSource
        '
        Me.Client_tableBindingSource.DataMember = "Client_table"
        Me.Client_tableBindingSource.DataSource = Me.ClientDBDataSet
        '
        'Client_tableTableAdapter
        '
        Me.Client_tableTableAdapter.ClearBeforeFill = True
        '
        'datDateOf
        '
        Me.datDateOf.CustomFormat = "dd/mm/yyyy"
        Me.datDateOf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Business_tableBindingSource, "DateVisited", True))
        Me.datDateOf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datDateOf.Location = New System.Drawing.Point(384, 155)
        Me.datDateOf.Name = "datDateOf"
        Me.datDateOf.Size = New System.Drawing.Size(106, 20)
        Me.datDateOf.TabIndex = 6
        '
        'frmVisitation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 407)
        Me.Controls.Add(Me.datDateOf)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.chkGeneral)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtAssociate)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtBusiness)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblAssociate)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblBusiness)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Business_tableBindingNavigator)
        Me.Name = "frmVisitation"
        Me.Text = "Visitation"
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Business_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Business_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Business_tableBindingNavigator.ResumeLayout(False)
        Me.Business_tableBindingNavigator.PerformLayout()
        CType(Me.BusinesstableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientDBDataSet As ClientDBDataSet
    Friend WithEvents Business_tableBindingSource As BindingSource
    Friend WithEvents Business_tableTableAdapter As ClientDBDataSetTableAdapters.Business_tableTableAdapter
    Friend WithEvents TableAdapterManager As ClientDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Business_tableBindingNavigator As BindingNavigator
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
    Friend WithEvents Business_tableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblBusiness As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblAssociate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtBusiness As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtAssociate As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents chkGeneral As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblClientName As Label
    Friend WithEvents BusinesstableBindingSource As BindingSource
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents Client_tableBindingSource As BindingSource
    Friend WithEvents Client_tableTableAdapter As ClientDBDataSetTableAdapters.Client_tableTableAdapter
    Friend WithEvents datDateOf As DateTimePicker
End Class
