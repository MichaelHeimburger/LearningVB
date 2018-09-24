<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        CType(Me.SuperMarketTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.LblName.Location = New System.Drawing.Point(12, 27)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(45, 17)
        Me.LblName.TabIndex = 2
        Me.LblName.Text = "Name"
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(12, 83)
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
        Me.ProductData.Location = New System.Drawing.Point(313, 24)
        Me.ProductData.Name = "ProductData"
        Me.ProductData.RowTemplate.Height = 24
        Me.ProductData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductData.Size = New System.Drawing.Size(675, 429)
        Me.ProductData.TabIndex = 4
        '
        'LblBrand
        '
        Me.LblBrand.AutoSize = True
        Me.LblBrand.Location = New System.Drawing.Point(12, 55)
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.Size = New System.Drawing.Size(46, 17)
        Me.LblBrand.TabIndex = 5
        Me.LblBrand.Text = "Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(67, 132)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(12, 17)
        Me.LblID.TabIndex = 7
        Me.LblID.Text = "/"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(70, 24)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(181, 22)
        Me.TxtName.TabIndex = 8
        '
        'TxtBrand
        '
        Me.TxtBrand.Location = New System.Drawing.Point(70, 52)
        Me.TxtBrand.Name = "TxtBrand"
        Me.TxtBrand.Size = New System.Drawing.Size(181, 22)
        Me.TxtBrand.TabIndex = 9
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(70, 80)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(181, 22)
        Me.TxtPrice.TabIndex = 10
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(160, 275)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(129, 34)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1032, 465)
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
End Class
