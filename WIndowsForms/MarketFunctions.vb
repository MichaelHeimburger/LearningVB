Public Class MarketFunctions
    Public Function MarketInventoryRefresh()

        Form2.GrdMarketInventory.DataSource = GetMarketInventory()

    End Function
    Public Function GetMarketInventory()
        Dim db As New SuperMarketTestEntities
        Dim listOfStocks = (From a In db.Stocks Where a.MarketID = Form2.MarketID Select a).ToList
        Dim listOfProducts = New List(Of ProductView)
        For Each stockItem As Stock In listOfStocks
            Dim dbProduct = (From a In db.Products Where a.ProductID = stockItem.ProductID).FirstOrDefault
            Dim viewProduct As New ProductView
            viewProduct.Brand = dbProduct.Brand
            viewProduct.ID = dbProduct.ProductID
            viewProduct.Name = dbProduct.Name
            viewProduct.Price = dbProduct.Price
            viewProduct.Amount = stockItem.Amount
            listOfProducts.Add(viewProduct)
        Next
        Return listOfProducts
    End Function





End Class
