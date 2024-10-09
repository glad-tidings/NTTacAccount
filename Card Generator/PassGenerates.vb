Module PassGenerates

    Private AccessNum As String = "01234567890123456789012345"
    Private AccessUpCase As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private AccessLowCase As String = "abcdefghijklmnopqrstuvwxyz"
    Private AccessSymCase As String = "!@#$%^*-_=+\/<>[]{}?:.()@#"
    Dim RNDTMP As New Random(System.DateTime.Now.Millisecond)

    Public Function GetChar(Optional ANum As Boolean = True, Optional AUC As Boolean = False, Optional ALC As Boolean = False, Optional ASC As Boolean = False) As String
        Dim TMP As String = ""
        Dim TMP1 As Integer
        For I As Integer = 1 To 26
            If ANum Then
                TMP += Microsoft.VisualBasic.Mid(AccessNum, I, 1)
            End If
            If AUC Then
                TMP += Microsoft.VisualBasic.Mid(AccessUpCase, I, 1)
            End If
            If ALC Then
                TMP += Microsoft.VisualBasic.Mid(AccessLowCase, I, 1)
            End If
            If ASC Then
                TMP += Microsoft.VisualBasic.Mid(AccessSymCase, I, 1)
            End If
        Next
        TMP1 = RNDTMP.Next(1, Len(TMP))
        Return Microsoft.VisualBasic.Mid(TMP, TMP1, 1)
    End Function

End Module
