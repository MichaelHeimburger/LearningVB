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

Partial Public Class Market
    Public Property MarketID As Integer
    Public Property MarketName As String
    Public Property Location As String
    Public Property MarketSize As String

    Public Overridable Property CustomerOrders As ICollection(Of CustomerOrder) = New HashSet(Of CustomerOrder)
    Public Overridable Property Stocks As ICollection(Of Stock) = New HashSet(Of Stock)

End Class