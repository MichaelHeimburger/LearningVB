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

Partial Public Class CustomerOrder
    Public Property OrderID As Integer
    Public Property MarketID As Integer
    Public Property CustomerID As Integer
    Public Property Total As Nullable(Of Decimal)

    Public Overridable Property Customer As Customer
    Public Overridable Property Market As Market
    Public Overridable Property OrderItems As ICollection(Of OrderItem) = New HashSet(Of OrderItem)

End Class
