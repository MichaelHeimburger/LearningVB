Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productFunctionas As New ProductFunctions
        GrdAllProducts.DataSource = productFunctionas.GetProductViewModels
        Dim marketFunctions As New MarketFunctions
        marketFunctions.MarketInventoryRefresh()

    End Sub

    Private currentMarketID As String
    Public Property MarketID() As String
        Get
            Return currentMarketID
        End Get
        Set(ByVal value As String)
            currentMarketID = value
        End Set
    End Property

    Private Sub BtnMarketName_Click(sender As Object, e As EventArgs) Handles BtnMarketName.Click
        My.Forms.MarketSelect.ShowDialog()
    End Sub
    Private Sub GrdAllProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrdAllProducts.CellContentClick

    End Sub
    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click
        Dim db = New SuperMarketTestEntities

        If (MarketID <> Nothing) Then 'code checks to see if item already exists in inventory

            Dim marketFuncitons As New MarketFunctions
            Dim isMissingItem = True
            For Each item As ProductView In marketFuncitons.GetMarketInventory
                If item.ID = GrdAllProducts.SelectedRows(0).Cells(0).Value.ToString Then
                    isMissingItem = False
                End If
            Next


            If isMissingItem Then


                Dim selectedID = GrdAllProducts.SelectedRows(0).Cells(0).Value.ToString
                Dim stock = New Stock
                stock.ProductID = selectedID
                stock.MarketID = MarketID
                stock.Amount = 0
                db.Stocks.Add(stock)
                db.SaveChanges()

            End If

        End If
        Dim marketFunctions As New MarketFunctions
        marketFunctions.MarketInventoryRefresh()

    End Sub


    Private Sub TxtMarketAmt_TextChanged(sender As Object, e As EventArgs) Handles TxtMarketAmt.TextChanged
        If MarketID <> Nothing Then


            Dim marketFunctions As New MarketFunctions
            Dim db As New SuperMarketTestEntities
            Dim selectedStocks = (From a In db.Stocks Where a.MarketID = MarketID Select a).ToList
            Dim selectedStock = (From a In selectedStocks Where a.ProductID = GrdMarketInventory.SelectedRows(0).Cells(0).Value.ToString Select a).FirstOrDefault
            selectedStock.Amount = TxtMarketAmt.Text.ToString
            db.Entry(selectedStock)
            db.SaveChanges()
            marketFunctions.MarketInventoryRefresh()
        End If
    End Sub
    Private Sub BtnRemoveProduct_Click(sender As Object, e As EventArgs) Handles BtnRemoveProduct.Click
        Dim marketFunctions As New MarketFunctions
        Dim db As New SuperMarketTestEntities
        Dim selectedStocks = (From a In db.Stocks Where a.MarketID = MarketID Select a).ToList
        Dim selectedStock = (From a In selectedStocks Where a.ProductID = GrdMarketInventory.SelectedRows(0).Cells(0).Value.ToString Select a).FirstOrDefault
        db.Stocks.Remove(selectedStock)
        db.SaveChanges()
        marketFunctions.MarketInventoryRefresh()
    End Sub

    Private Sub GrdMarketInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrdMarketInventory.CellContentClick
        TxtMarketAmt.Text = GrdMarketInventory.SelectedRows(0).Cells(4).Value.ToString
    End Sub
End Class