<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarketSelect
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
        Me.GrdMarketList = New System.Windows.Forms.DataGridView()
        Me.BtnMarketSelectSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GrdMarketList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdMarketList
        '
        Me.GrdMarketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdMarketList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GrdMarketList.Location = New System.Drawing.Point(12, 69)
        Me.GrdMarketList.MultiSelect = False
        Me.GrdMarketList.Name = "GrdMarketList"
        Me.GrdMarketList.RowTemplate.Height = 24
        Me.GrdMarketList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdMarketList.Size = New System.Drawing.Size(776, 150)
        Me.GrdMarketList.TabIndex = 0
        '
        'BtnMarketSelectSelect
        '
        Me.BtnMarketSelectSelect.Location = New System.Drawing.Point(558, 291)
        Me.BtnMarketSelectSelect.Name = "BtnMarketSelectSelect"
        Me.BtnMarketSelectSelect.Size = New System.Drawing.Size(230, 50)
        Me.BtnMarketSelectSelect.TabIndex = 1
        Me.BtnMarketSelectSelect.Text = "Select"
        Me.BtnMarketSelectSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose a Market"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MarketSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 353)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMarketSelectSelect)
        Me.Controls.Add(Me.GrdMarketList)
        Me.Name = "MarketSelect"
        Me.Text = "MarketSelect"
        CType(Me.GrdMarketList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrdMarketList As DataGridView
    Friend WithEvents BtnMarketSelectSelect As Button
    Friend WithEvents Label1 As Label
End Class
