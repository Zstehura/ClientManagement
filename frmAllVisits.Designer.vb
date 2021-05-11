<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllVisits
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllVisits))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Business_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Business_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDBDataSet = New Clients.ClientDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Business_tableDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnDets = New System.Windows.Forms.Button()
        Me.Business_tableTableAdapter = New Clients.ClientDBDataSetTableAdapters.Business_tableTableAdapter()
        Me.TableAdapterManager = New Clients.ClientDBDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateVisited = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Business_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Business_tableBindingNavigator.SuspendLayout()
        CType(Me.Business_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Business_tableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Business_tableBindingNavigator
        '
        Me.Business_tableBindingNavigator.AddNewItem = Nothing
        Me.Business_tableBindingNavigator.BindingSource = Me.Business_tableBindingSource
        Me.Business_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Business_tableBindingNavigator.DeleteItem = Nothing
        Me.Business_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Business_tableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Business_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Business_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Business_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Business_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Business_tableBindingNavigator.Name = "Business_tableBindingNavigator"
        Me.Business_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Business_tableBindingNavigator.Size = New System.Drawing.Size(600, 25)
        Me.Business_tableBindingNavigator.TabIndex = 0
        Me.Business_tableBindingNavigator.Text = "BindingNavigator1"
        '
        'Business_tableBindingSource
        '
        Me.Business_tableBindingSource.DataMember = "Business_table"
        Me.Business_tableBindingSource.DataSource = Me.ClientDBDataSet
        '
        'ClientDBDataSet
        '
        Me.ClientDBDataSet.DataSetName = "ClientDBDataSet"
        Me.ClientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Business_tableDataGridView
        '
        Me.Business_tableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Business_tableDataGridView.AutoGenerateColumns = False
        Me.Business_tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Business_tableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DateIndex, Me.Column1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.colDateVisited})
        Me.Business_tableDataGridView.DataSource = Me.Business_tableBindingSource
        Me.Business_tableDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.Business_tableDataGridView.MultiSelect = False
        Me.Business_tableDataGridView.Name = "Business_tableDataGridView"
        Me.Business_tableDataGridView.ReadOnly = True
        Me.Business_tableDataGridView.Size = New System.Drawing.Size(576, 377)
        Me.Business_tableDataGridView.TabIndex = 1
        '
        'btnDets
        '
        Me.btnDets.Location = New System.Drawing.Point(453, 415)
        Me.btnDets.Name = "btnDets"
        Me.btnDets.Size = New System.Drawing.Size(75, 23)
        Me.btnDets.TabIndex = 2
        Me.btnDets.Text = "Details..."
        Me.btnDets.UseVisualStyleBackColor = True
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Business"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Business"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DateIndex
        '
        Me.DateIndex.DataPropertyName = "DaysSince2000"
        Me.DateIndex.HeaderText = "DateIndex"
        Me.DateIndex.Name = "DateIndex"
        Me.DateIndex.ReadOnly = True
        Me.DateIndex.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'colDateVisited
        '
        Me.colDateVisited.DataPropertyName = "DateVisited"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colDateVisited.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDateVisited.HeaderText = "DateVisited"
        Me.colDateVisited.MaxInputLength = 10
        Me.colDateVisited.Name = "colDateVisited"
        Me.colDateVisited.ReadOnly = True
        Me.colDateVisited.Width = 80
        '
        'frmAllVisits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.btnDets)
        Me.Controls.Add(Me.Business_tableDataGridView)
        Me.Controls.Add(Me.Business_tableBindingNavigator)
        Me.Name = "frmAllVisits"
        Me.Text = "All Business Visits"
        CType(Me.Business_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Business_tableBindingNavigator.ResumeLayout(False)
        Me.Business_tableBindingNavigator.PerformLayout()
        CType(Me.Business_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Business_tableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientDBDataSet As ClientDBDataSet
    Friend WithEvents Business_tableBindingSource As BindingSource
    Friend WithEvents Business_tableTableAdapter As ClientDBDataSetTableAdapters.Business_tableTableAdapter
    Friend WithEvents TableAdapterManager As ClientDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Business_tableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Business_tableDataGridView As DataGridView
    Friend WithEvents btnDets As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DateIndex As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents colDateVisited As DataGridViewTextBoxColumn
End Class
