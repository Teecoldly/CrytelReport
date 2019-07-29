Imports CrystalDecisions.CrystalReports.Engine
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt = read("select cm.id, cm.FirstName,cm.LastName,(op.id) as orderid,op.orderDate,ot.ProductId,pt.ProductName,pt.UnitPrice,ot.Quantity  from Customer cm inner join Orderpro op on  cm.Id = op.CustomerId inner join OrderItem ot on op.Id = ot.OrderId  inner join Product pt on ot.ProductId = pt.Id order by cm.id")
        Dim rpt As New ReportDocument
        Dim directory As String = My.Application.Info.DirectoryPath
        rpt.Load(Application.StartupPath & "\reportfile\reportbill.rpt")
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.Refresh()



    End Sub
End Class
