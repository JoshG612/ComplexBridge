Public Class Form1

    'Code for Input Boxes
    Private Sub btnapproach_Click(sender As Object, e As EventArgs) Handles btnapproach.Click
        Dim strName As String = InputBox("what is your name?", "Name")
        Dim strQuest As String = InputBox("what is your quest?", "Quest")
        Dim strRandomQAnwer As String
        Dim intRandomQuestionNumber As Integer



        'Random Questions
        Dim strRandomQ1 As String = "What is your favorite color?"
        Dim strRandomQ2 As String = "What is the flight speed of an unladen swallow?"
        Dim strRandomQ3 As String = "What is the capital of Assyria?"
        Dim strRandomQ4 As String = "What is the depth of the polar ice cap?"


        'Responses
        Dim strRespnse As String

        'Random Question Answers
        Dim strRandomQA As String
        Dim strRandomQA1 As String = "Blue"
        Dim strRandomQA2 As String = "10 mph"
        Dim strRandomQA3 As String = "Assur"
        Dim strRandomQA4 As String = "500 ft"

        'typical random number sequence
        Randomize()
        intRandomQuestionNumber = Int((4 - 1 + 1) * Rnd() + 1)

        If intRandomQuestionNumber = 1 Then
            strRandomQAnwer = InputBox(strRandomQ1, "Random")
            strRandomQA = strRandomQA1
        ElseIf intRandomQuestionNumber = 2 Then
            strRandomQAnwer = InputBox(strRandomQ2, "Random")
            strRandomQA = strRandomQA2
        ElseIf intRandomQuestionNumber = 3 Then
            strRandomQAnwer = InputBox(strRandomQ3, "Random")
            strRandomQA = strRandomQA3
        ElseIf intRandomQuestionNumber = 4 Then
            strRandomQAnwer = InputBox(strRandomQ4, "Random")
            strRandomQA = strRandomQA4
        End If


        If strName = "Josh" Then
            Me.lblName.Text = "True"
        Else
            Me.lblName.Text = "False"
        End If

        If strQuest = "Seek the grail" Then
            Me.lblQuest.Text = "True"
        Else
            Me.lblQuest.Text = "False"
        End If
        If strRandomQAnwer = strRandomQA Then
            Me.lblRandom.Text = "True"
        Else
            Me.lblRandom.Text = "False"
            If strRandomQAnwer = "Nineveh" And intRandomQuestionNumber = 3 Then
                Me.lblRandom.Text = "True"
            End If
        End If

        If Me.lblQuest.Text = "True" And Me.lblName.Text = "True" And Me.lblRandom.Text = "True" Then
            Me.lblfate.Text = "You may pass"
        Else
            Me.lblfate.Text = "You will die"
        End If

    End Sub
End Class
