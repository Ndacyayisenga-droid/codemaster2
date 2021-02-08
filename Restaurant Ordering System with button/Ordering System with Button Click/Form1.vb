Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub compute()
        If DataGridView2.Rows.Count > 0 Then
            TextBox1.Text = Total().ToString("0.00")
        End If
    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0
        For i = 0 To DataGridView2.Rows.Count - 1
            tot = tot + Convert.ToDouble(DataGridView2.Rows(i).Cells(2).Value)
        Next i
        Return tot
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim price1 As Integer = 150000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "SOLO HAWAIIAN" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("SOLO HAWAIIAN", "1", price1)
        compute()
    End Sub

    Private Sub DataGridView2_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        compute()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim price1 As Integer = 30000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "SOLO PEPPERONI" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("SOLO PEPPERONI", "1", price1)
        compute()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim price1 As Integer = 45000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "SOLO OVERLOAD" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("SOLO OVERLOAD", "1", price1)
        compute()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim price1 As Integer = 25000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "MEDIUM ALL CHEESE" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("MEDIUM ALL CHEESE", "1", price1)
        compute()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim price1 As Integer = 45000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "MEDIUM ALL MEAT" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("MEDIUM ALL MEAT", "1", price1)
        compute()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim price1 As Integer = 55000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "MEDIUM HAWAIIAN" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("MEDIUM HAWAIIAN", "1", price1)
        compute()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim price1 As Integer = 65000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "LARGE ALL MEAT" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("LARGE ALL MEAT", "1", price1)
        compute()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim price1 As Integer = 50000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "LARGE OVERLOAD" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("LARGE OVERLOAD", "1", price1)
        compute()
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

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim price1 As Integer = 8000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "COKE" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("COKE", "1", price1)
        compute()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim price1 As Integer = 9000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "SPRITE" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("SPRITE", "1", price1)
        compute()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim price1 As Integer = 8000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "PEPSI" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("PEPSI", "1", price1)
        compute()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim price1 As Integer =12000 

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "TROPICANA" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("TROPICANA", "1", price1)
        compute()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim price1 As Integer = 8000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "MOUNTAIN DEW" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("MOUNTAIN DEW", "1", price1)
        compute()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim price1 As Integer = 10000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "ICED TEA" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("ICED TEA", "1", price1)
        compute()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim price1 As Integer = 15000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "PINEAPPLE JUICE" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("PINEAPPLE JUICE", "1", price1)
        compute()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim price1 As Integer = 18000

        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(0).Value = "CHOCOLATE SMOOTHIE" Then
                row.Cells(1).Value = Integer.Parse(row.Cells(1).Value) + 1
                row.Cells(2).Value = Integer.Parse(row.Cells(1).Value) * price1

                Exit Sub
            End If

        Next
        DataGridView2.Rows.Add("CHOCOLATE FRAPPE", "1", price1)
        compute()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        DataGridView2.Rows.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
