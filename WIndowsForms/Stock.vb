'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Stock
    Public Property StockID As Integer
    Public Property MarketID As Nullable(Of Integer)
    Public Property ProductID As Nullable(Of Integer)
    Public Property Amount As Nullable(Of Integer)

    Public Overridable Property Market As Market
    Public Overridable Property Product As Product

End Class