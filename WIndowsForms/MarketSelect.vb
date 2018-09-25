Public Class MarketSelect
    Private Sub MarketSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New SuperMarketTestEntities
        Dim markets = (From a In db.Markets Select a).ToList()
        Dim marketViewModelList = New List(Of MarketSelectViewModel)
        For Each market As Market In markets
            Dim marketSelectViewModel = New MarketSelectViewModel
            marketSelectViewModel.Name = market.MarketName
            marketSelectViewModel.ID = market.MarketID
            marketViewModelList.Add(marketSelectViewModel)
        Next
        GrdMarketList.DataSource = marketViewModelList
    End Sub

    Private Sub BtnMarketSelectSelect_Click(sender As Object, e As EventArgs) Handles BtnMarketSelectSelect.Click
        If GrdMarketList.SelectedRows(0).Cells(0).Value.ToString <> Nothing Then
            'if there is a selection do the following
            Form2.lblMarketName.Text = "Editing: " + GrdMarketList.SelectedRows(0).Cells(0).Value.ToString()
            Form2.MarketID = GrdMarketList.SelectedRows(0).Cells(1).Value.ToString()
            Dim marketFunctions As New MarketFunctions
            marketFunctions.MarketInventoryRefresh()
            MarketSelect.ActiveForm.Close()
        End If
    End Sub

    Private Sub GrdMarketList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrdMarketList.CellContentClick

    End Sub
End Class