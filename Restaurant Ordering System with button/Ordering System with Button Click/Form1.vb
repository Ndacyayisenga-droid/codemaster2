Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialization code if needed
    End Sub

    ' Method to compute the total and update the TextBox
    Sub Compute()
        If DataGridView2.Rows.Count > 0 Then
            TextBox1.Text = Total().ToString("0.00")
        End If
    End Sub

    ' Method to calculate the total amount
    Private Function Total() As Double
        Dim tot As Double = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            tot += Convert.ToDouble(row.Cells(2).Value)
        Next
        Return tot
    End Function

    ' Method to handle button clicks and add items
    Private Sub AddItem(itemName As String, price As Integer)
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = itemName Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price
                Compute()
                Exit Sub
            End If
        Next
        DataGridView2.Rows.Add(itemName, "1", price)
        Compute()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddItem("SOLO HAWAIIAN", 150000)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AddItem("SOLO PEPPERONI", 30000)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AddItem("SOLO OVERLOAD", 45000)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddItem("MEDIUM ALL CHEESE", 25000)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AddItem("MEDIUM ALL MEAT", 45000)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AddItem("MEDIUM HAWAIIAN", 55000)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AddItem("LARGE ALL MEAT", 65000)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddItem("LARGE OVERLOAD", 50000)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        AddItem("COKE", 8000)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        AddItem("SPRITE", 9000)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AddItem("PEPSI", 8000)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AddItem("TROPICANA", 12000)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        AddItem("MOUNTAIN DEW", 8000)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AddItem("ICED TEA", 10000)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        AddItem("PINEAPPLE JUICE", 15000)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AddItem("CHOCOLATE SMOOTHIE", 18000)
    End Sub

    Private Sub DataGridView2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        Compute()
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        Dim change As Double
        If Val(TextBox2.Text) >= Val(TextBox1.Text) Then
            change = Val(TextBox2.Text) - Val(TextBox1.Text)
            TextBox3.Text = change.ToString("0.00")
        Else
            MsgBox("INSUFFICIENT FUNDS! PLEASE PAY THE RIGHT AMOUNT!")
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        DataGridView2.Rows.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

End Class
