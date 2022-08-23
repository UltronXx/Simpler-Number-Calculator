Public Class Form1
    Dim num1, num2, result As Double   'declaring num1, num2, result
    Dim operation As String     'declaring opereration name

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Target all checkboxes and add event handler
        For Each cb As Control In Controls
            If TypeOf cb Is CheckBox Then    'if object is a checkbox
                AddHandler cb.Click, AddressOf CheckBox_Enable   'ddd click handler
            End If
        Next
    End Sub

    Private Sub resultButton_Click(sender As Object, e As EventArgs) Handles resultButton.Click
        If firstNumberTextBox.Text.Equals("") Or
            secondNumberTextBox.Text.Equals("") Then    'if textboxes are empty
            MessageBox.Show("No or Missing value", "Calculator App")    'display error message
        Else
            MessageBox.Show(Convert.ToString(calculate(operation)), "Calculator App")   'display result
            reset_checkBox()    'checkboxes enabled = true
        End If
    End Sub

    Private Sub CheckBox_Enable(sender As Object, e As EventArgs)
        Dim check_box As CheckBox = sender
        operation = check_box.Text  'let operation = checkbox text

        If check_box.Checked Then   'if checkbox is checked
            For Each cb As Control In Controls  'captures all controls
                If TypeOf cb Is CheckBox Then   'if control is a checkbox
                    If Not cb.Text.Equals(check_box.Text) Then  'gets checkboxes excluding targeted
                        DirectCast(cb, CheckBox).Enabled = False    'checkboxes enabled = false
                    End If
                End If
            Next
        Else    'if checkbox is not checked
            For Each cb As Control In Controls  'captures all controls
                If TypeOf cb Is CheckBox Then   'if control is a checkbox
                    DirectCast(cb, CheckBox).Enabled = True     'checkboxes enabled = true
                End If
            Next
        End If
    End Sub

    'function to calculate
    Function calculate(operation As String) As Double
        num1 = Convert.ToDouble(firstNumberTextBox.Text)    'initializing num1 as first textbox text
        num2 = Convert.ToDouble(secondNumberTextBox.Text)   'initializing num2 as second textbox text

        Select Case operation   'select case on operation
            Case "Addition"
                result = num1 + num2
            Case "Subtraction"
                result = num1 - num2
            Case "Multiplication"
                result = num1 * num2
            Case "Division"
                If num2 <> 0 Then
                    result = num1 / num2
                End If
        End Select

        Return result   'return result
    End Function

    'function to reset all checkboxes
    Private Sub reset_checkBox()
        For Each cb As Control In Controls
            If TypeOf cb Is CheckBox Then
                DirectCast(cb, CheckBox).Enabled = True     'enable all checkboxes
                DirectCast(cb, CheckBox).Checked = False    'uncheck all checkboxes
            End If
        Next
    End Sub
End Class
