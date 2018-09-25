<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblMarketName = New System.Windows.Forms.Label()
        Me.BtnMarketName = New System.Windows.Forms.Button()
        Me.GrdMarketInventory = New System.Windows.Forms.DataGridView()
        Me.GrdAllProducts = New System.Windows.Forms.DataGridView()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.LblProductsList = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRemoveProduct = New System.Windows.Forms.Button()
        Me.TxtMarketAmt = New System.Windows.Forms.TextBox()
        Me.UserControl11 = New WIndowsForms.UserControl1()
        CType(Me.GrdMarketInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMarketName
        '
        Me.lblMarketName.AutoSize = True
        Me.lblMarketName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblMarketName.Location = New System.Drawing.Point(12, 39)
        Me.lblMarketName.Name = "lblMarketName"
        Me.lblMarketName.Size = New System.Drawing.Size(168, 29)
        Me.lblMarketName.TabIndex = 1
        Me.lblMarketName.Text = "Select Market"
        '
        'BtnMarketName
        '
        Me.BtnMarketName.Location = New System.Drawing.Point(17, 71)
        Me.BtnMarketName.Name = "BtnMarketName"
        Me.BtnMarketName.Size = New System.Drawing.Size(150, 23)
        Me.BtnMarketName.TabIndex = 2
        Me.BtnMarketName.Text = "Select A Market"
        Me.BtnMarketName.UseVisualStyleBackColor = True
        '
        'GrdMarketInventory
        '
        Me.GrdMarketInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdMarketInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrdMarketInventory.Location = New System.Drawing.Point(804, 230)
        Me.GrdMarketInventory.Name = "GrdMarketInventory"
        Me.GrdMarketInventory.RowTemplate.Height = 24
        Me.GrdMarketInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdMarketInventory.Size = New System.Drawing.Size(586, 268)
        Me.GrdMarketInventory.TabIndex = 3
        '
        'GrdAllProducts
        '
        Me.GrdAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAllProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrdAllProducts.Location = New System.Drawing.Point(12, 230)
        Me.GrdAllProducts.MultiSelect = False
        Me.GrdAllProducts.Name = "GrdAllProducts"
        Me.GrdAllProducts.RowTemplate.Height = 24
        Me.GrdAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdAllProducts.Size = New System.Drawing.Size(532, 268)
        Me.GrdAllProducts.TabIndex = 4
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Location = New System.Drawing.Point(550, 230)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(121, 46)
        Me.BtnAddProduct.TabIndex = 5
        Me.BtnAddProduct.Text = "Add Product To Store"
        Me.BtnAddProduct.UseVisualStyleBackColor = True
        '
        'LblProductsList
        '
        Me.LblProductsList.AutoSize = True
        Me.LblProductsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblProductsList.Location = New System.Drawing.Point(12, 202)
        Me.LblProductsList.Name = "LblProductsList"
        Me.LblProductsList.Size = New System.Drawing.Size(194, 25)
        Me.LblProductsList.TabIndex = 6
        Me.LblProductsList.Text = "All Products Availible"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(617, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Products in Store"
        '
        'BtnRemoveProduct
        '
        Me.BtnRemoveProduct.Location = New System.Drawing.Point(677, 230)
        Me.BtnRemoveProduct.Name = "BtnRemoveProduct"
        Me.BtnRemoveProduct.Size = New System.Drawing.Size(121, 46)
        Me.BtnRemoveProduct.TabIndex = 8
        Me.BtnRemoveProduct.Text = "Remove Product From Store"
        Me.BtnRemoveProduct.UseVisualStyleBackColor = True
        '
        'TxtMarketAmt
        '
        Me.TxtMarketAmt.Location = New System.Drawing.Point(677, 305)
        Me.TxtMarketAmt.Name = "TxtMarketAmt"
        Me.TxtMarketAmt.Size = New System.Drawing.Size(121, 22)
        Me.TxtMarketAmt.TabIndex = 10
        '
        'UserControl11
        '
        Me.UserControl11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl11.Location = New System.Drawing.Point(-3, -2)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(1446, 29)
        Me.UserControl11.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1437, 737)
        Me.Controls.Add(Me.TxtMarketAmt)
        Me.Controls.Add(Me.BtnRemoveProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblProductsList)
        Me.Controls.Add(Me.BtnAddProduct)
        Me.Controls.Add(Me.GrdAllProducts)
        Me.Controls.Add(Me.GrdMarketInventory)
        Me.Controls.Add(Me.BtnMarketName)
        Me.Controls.Add(Me.lblMarketName)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.GrdMarketInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents lblMarketName As Label
    Friend WithEvents BtnMarketName As Button
    Friend WithEvents GrdMarketInventory As DataGridView
    Friend WithEvents GrdAllProducts As DataGridView
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents LblProductsList As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRemoveProduct As Button
    Friend WithEvents TxtMarketAmt As TextBox
End Class
