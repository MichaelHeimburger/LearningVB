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

Partial Public Class Customer
    Public Property CustomerID As Integer
    Public Property Location As String
    Public Property FProduct As Nullable(Of Integer)
    Public Property FStore As Nullable(Of Integer)

    Public Overridable Property CustomerOrders As ICollection(Of CustomerOrder) = New HashSet(Of CustomerOrder)

End Class
