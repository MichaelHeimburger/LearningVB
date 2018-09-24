Public Class ProductFunctions

    Public Function ShowProduct()
        Dim db As SuperMarketTestEntities = New SuperMarketTestEntities()
        Dim products = db.Products.ToList
        Dim ProductViewList = New List(Of ProductView)
        For Each product As Product In products
            Dim cv = New ProductView
            cv.Name = product.Name
            cv.Price = product.Price
            cv.Brand = product.Brand
            cv.ID = product.ProductID
            ProductViewList.Add(cv)
        Next
        Form1.ProductData.DataSource = ProductViewList
        'Instead of returning all products right from data base we are sending in a viewmmodel beucase by default it shows foregin keys also?
    End Function

    Public Function ClearProductForm()
        Form1.TxtBrand.Text = ""
        Form1.TxtName.Text = ""
        Form1.TxtPrice.Text = ""
        Form1.LblID.Text = "/"
        Form1.BtnCreate.Text = "Create"
        Form1.ProductData.ClearSelection()
    End Function


End Class
