Option Explicit On
Public Class Form1

    <Flags>
    Enum oDaysOfTheWeek
        None = 0
        Sunday = 1
        Monday = 2
        Tuesday = 4
        Wednesday = 8
        Thursday = 16
        Friday = 32
        Saturday = 64
    End Enum
    'Enum DaysOfTheWeek
    '        Sunday = 1,
    '    Monday = 1 << 1,
    '    Tuesday = 1 << 2,
    '    Wednesday = 1 << 3,
    '    Thursday = 1 << 4,
    '    Friday = 1 << 5,
    '    Saturday = 1 << 6,
    'End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As oDaysOfTheWeek = oDaysOfTheWeek.Saturday

        MsgBox("Testing OR...")
        testDay(oDaysOfTheWeek.Saturday Or oDaysOfTheWeek.Sunday)

        MsgBox("Testing AND...")
        testDay(oDaysOfTheWeek.Saturday And oDaysOfTheWeek.Sunday)

        MsgBox("Testing +...")
        testDay(oDaysOfTheWeek.Saturday + oDaysOfTheWeek.Sunday)

        'testDay(3)
    End Sub


    Private Sub testDay(ByVal dotw As oDaysOfTheWeek)
        'validate day of th week
        Dim sumDOTW As Integer = 0
        For Each value As Integer In System.Enum.GetValues(GetType(oDaysOfTheWeek))
            sumDOTW += value
        Next value
        If Not (dotw And sumDOTW) = dotw Then
            MsgBox("Invalid Day of the week")
        End If



        If dotw.HasFlag(oDaysOfTheWeek.Saturday) Then
            MsgBox("has Saturday")
        Else
            MsgBox("no Saturday")
        End If

        If dotw.HasFlag(oDaysOfTheWeek.Sunday) Then
            MsgBox("has Sunday")
        Else
            MsgBox("no Sunday")
        End If

    End Sub

End Class
