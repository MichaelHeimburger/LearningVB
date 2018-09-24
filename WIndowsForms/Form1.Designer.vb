<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.SuperMarketTestDataSet = New WIndowsForms.SuperMarketTestDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New WIndowsForms.SuperMarketTestDataSetTableAdapters.ProductTableAdapter()
        Me.ProductData = New System.Windows.Forms.DataGridView()
        Me.LblBrand = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtBrand = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Programs = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProgramsProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramsStoreInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.test = New System.Windows.Forms.Button()
        CType(Me.SuperMarketTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCreate.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCreate.Location = New System.Drawing.Point(12, 275)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(129, 34)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 1
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(18, 125)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(45, 17)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Name"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(18, 181)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(40, 17)
        Me.LblPrice.TabIndex = 3
        Me.LblPrice.Text = "Price"
        '
        'SuperMarketTestDataSet
        '
        Me.SuperMarketTestDataSet.DataSetName = "SuperMarketTestDataSet"
        Me.SuperMarketTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.SuperMarketTestDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ProductData
        '
        Me.ProductData.AllowUserToAddRows = False
        Me.ProductData.AllowUserToDeleteRows = False
        Me.ProductData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ProductData.Location = New System.Drawing.Point(404, 28)
        Me.ProductData.Name = "ProductData"
        Me.ProductData.RowTemplate.Height = 24
        Me.ProductData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductData.Size = New System.Drawing.Size(616, 429)
        Me.ProductData.TabIndex = 4
        '
        'LblBrand
        '
        Me.LblBrand.AutoSize = True
        Me.LblBrand.Location = New System.Drawing.Point(18, 153)
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.Size = New System.Drawing.Size(46, 17)
        Me.LblBrand.TabIndex = 5
        Me.LblBrand.Text = "Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(73, 213)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(12, 17)
        Me.LblID.TabIndex = 7
        Me.LblID.Text = "/"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(76, 122)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(181, 22)
        Me.TxtName.TabIndex = 8
        '
        'TxtBrand
        '
        Me.TxtBrand.Location = New System.Drawing.Point(76, 150)
        Me.TxtBrand.Name = "TxtBrand"
        Me.TxtBrand.Size = New System.Drawing.Size(181, 22)
        Me.TxtBrand.TabIndex = 9
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(76, 178)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(181, 22)
        Me.TxtPrice.TabIndex = 10
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnClear.Location = New System.Drawing.Point(160, 275)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(129, 34)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Location = New System.Drawing.Point(160, 324)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(129, 34)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Programs})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1032, 27)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Programs
        '
        Me.Programs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Programs.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramsProducts, Me.ProgramsStoreInventory})
        Me.Programs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Programs.Name = "Programs"
        Me.Programs.Size = New System.Drawing.Size(86, 24)
        Me.Programs.Text = "Programs"
        '
        'ProgramsProducts
        '
        Me.ProgramsProducts.Name = "ProgramsProducts"
        Me.ProgramsProducts.Size = New System.Drawing.Size(216, 26)
        Me.ProgramsProducts.Text = "Products"
        '
        'ProgramsStoreInventory
        '
        Me.ProgramsStoreInventory.Name = "ProgramsStoreInventory"
        Me.ProgramsStoreInventory.Size = New System.Drawing.Size(216, 26)
        Me.ProgramsStoreInventory.Text = "StoreInventory"
        '
        'test
        '
        Me.test.Location = New System.Drawing.Point(9, 401)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(75, 23)
        Me.test.TabIndex = 14
        Me.test.Text = "test"
        Me.test.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1032, 465)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.TxtBrand)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblBrand)
        Me.Controls.Add(Me.ProductData)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCreate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SuperMarketTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents SuperMarketTestDataSet As SuperMarketTestDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SuperMarketTestDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductData As DataGridView
    Friend WithEvents LblBrand As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtBrand As TextBox
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Programs As ToolStripDropDownButton
    Friend WithEvents ProgramsProducts As ToolStripMenuItem
    Friend WithEvents ProgramsStoreInventory As ToolStripMenuItem
    Friend WithEvents test As Button
End Class
