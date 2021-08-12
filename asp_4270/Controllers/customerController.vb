Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports asp_4270

Namespace Controllers
    Public Class customerController
        Inherits System.Web.Mvc.Controller

        Private db As New Database1Entities

        ' GET: customer
        Function Index() As ActionResult
            Return View(db.Table.ToList())
        End Function

        ' GET: customer/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Table.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' GET: customer/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: customer/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,顧客名,フリガナ,性別,会社名,住所")> ByVal table As Table) As ActionResult
            If ModelState.IsValid Then
                db.Table.Add(table)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(table)
        End Function

        ' GET: customer/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Table.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' POST: customer/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,顧客名,フリガナ,性別,会社名,住所")> ByVal table As Table) As ActionResult
            If ModelState.IsValid Then
                db.Entry(table).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(table)
        End Function

        ' GET: customer/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Table.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' POST: customer/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim table As Table = db.Table.Find(id)
            db.Table.Remove(table)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
