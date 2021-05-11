<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllClients))
        Me.ClientDBDataSet = New Clients.ClientDBDataSet()
        Me.Client_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Client_tableTableAdapter = New Clients.ClientDBDataSetTableAdapters.Client_tableTableAdapter()
        Me.TableAdapterManager = New Clients.ClientDBDataSetTableAdapters.TableAdapterManager()
        Me.Client_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Client_tableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDets = New System.Windows.Forms.Button()
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Client_tableBindingNavigator.SuspendLayout()
        CType(Me.Client_tableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientDBDataSet
        '
        Me.ClientDBDataSet.DataSetName = "ClientDBDataSet"
        Me.ClientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Business_tableTableAdapter = Nothing
        Me.TableAdapterManager.Client_tableTableAdapter = Me.Client_tableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clients.ClientDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Client_tableBindingNavigator
        '
        Me.Client_tableBindingNavigator.AddNewItem = Nothing
        Me.Client_tableBindingNavigator.BindingSource = Me.Client_tableBindingSource
        Me.Client_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Client_tableBindingNavigator.DeleteItem = Nothing
        Me.Client_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Client_tableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Client_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Client_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Client_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Client_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Client_tableBindingNavigator.Name = "Client_tableBindingNavigator"
        Me.Client_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Client_tableBindingNavigator.Size = New System.Drawing.Size(571, 25)
        Me.Client_tableBindingNavigator.TabIndex = 0
        Me.Client_tableBindingNavigator.Text = "BindingNavigator1"
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
        'Client_tableDataGridView
        '
        Me.Client_tableDataGridView.AutoGenerateColumns = False
        Me.Client_tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Client_tableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Column1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.Client_tableDataGridView.DataSource = Me.Client_tableBindingSource
        Me.Client_tableDataGridView.Location = New System.Drawing.Point(12, 46)
        Me.Client_tableDataGridView.Name = "Client_tableDataGridView"
        Me.Client_tableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Client_tableDataGridView.Size = New System.Drawing.Size(547, 361)
        Me.Client_tableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DoB"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DoB"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ZIP"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ZIP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnDets
        '
        Me.btnDets.Location = New System.Drawing.Point(465, 415)
        Me.btnDets.Name = "btnDets"
        Me.btnDets.Size = New System.Drawing.Size(75, 23)
        Me.btnDets.TabIndex = 2
        Me.btnDets.Text = "Details..."
        Me.btnDets.UseVisualStyleBackColor = True
        '
        'frmClientsAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 450)
        Me.Controls.Add(Me.btnDets)
        Me.Controls.Add(Me.Client_tableDataGridView)
        Me.Controls.Add(Me.Client_tableBindingNavigator)
        Me.Name = "frmClientsAll"
        Me.Text = "All Clients"
        CType(Me.ClientDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Client_tableBindingNavigator.ResumeLayout(False)
        Me.Client_tableBindingNavigator.PerformLayout()
        CType(Me.Client_tableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientDBDataSet As ClientDBDataSet
    Friend WithEvents Client_tableBindingSource As BindingSource
    Friend WithEvents Client_tableTableAdapter As ClientDBDataSetTableAdapters.Client_tableTableAdapter
    Friend WithEvents TableAdapterManager As ClientDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_tableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Client_tableDataGridView As DataGridView
    Friend WithEvents btnDets As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
