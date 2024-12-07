Public Class Form1
    Dim nombreCliente As String
    Dim sexoCliente As String
    Dim fechaNacimiento As Date
    Dim signoZodiacal As String
    Dim prediccion As String
    Dim edad As Integer
    Dim numerosSuerte(2) As String

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorProvider1.Clear()

        If Not ValidarEntradas() Then
            Return
        End If

        Try
            nombreCliente = TextNombre.Text
            sexoCliente = If(rbtnHombre.Checked, "Masculino", "Femenino")
            fechaNacimiento = MonthCalendar1.SelectionStart

            edad = DateTime.Now.Year - fechaNacimiento.Year
            If DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear Then
                edad -= 1
            End If

            signoZodiacal = DeterminarSignoZodiacal(fechaNacimiento)
            prediccion = ObtenerPrediccion(signoZodiacal)

            GenerarNumerosDeLaSuerte()

            lblResultado.Text = $"Nombre: {nombreCliente}" & vbCrLf &
                                $"Edad: {edad}" & vbCrLf &
                                $"Sexo: {sexoCliente}" & vbCrLf &
                                $"Signo Zodiacal: {signoZodiacal}" & vbCrLf &
                                $"Predicción: {prediccion}" & vbCrLf &
                                $"Números de la Suerte: {String.Join(", ", numerosSuerte)}"
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error: " & ex.Message)
        End Try
    End Sub

    Private Function ValidarEntradas() As Boolean
        Dim esValido As Boolean = True

        If String.IsNullOrEmpty(TextNombre.Text) Then
            ErrorProvider1.SetError(TextNombre, "Por favor, ingrese su nombre.")
            esValido = False
        End If

        If Not (rbtnHombre.Checked OrElse rbtnMujer.Checked) Then
            ErrorProvider1.SetError(rbtnHombre, "Por favor, seleccione su sexo.")
            esValido = False
        End If

        fechaNacimiento = MonthCalendar1.SelectionStart
        If fechaNacimiento.Year < 1900 OrElse fechaNacimiento.Year > 2024 Then
            ErrorProvider1.SetError(MonthCalendar1, "El año debe estar entre 1900 y 2024.")
            esValido = False
        End If

        Return esValido
    End Function

    Private Function DeterminarSignoZodiacal(fecha As Date) As String
        Select Case fecha.Month
            Case 1
                If fecha.Day <= 19 Then
                    Return "Capricornio"
                Else
                    Return "Acuario"
                End If
            Case 2
                If fecha.Day <= 19 Then
                    Return "Acuario"
                Else
                    Return "Piscis"
                End If
            Case 3
                If fecha.Day <= 20 Then
                    Return "Piscis"
                Else
                    Return "Aries"
                End If
            Case 4
                If fecha.Day <= 20 Then
                    Return "Aries"
                Else
                    Return "Tauro"
                End If
            Case 5
                If fecha.Day <= 20 Then
                    Return "Tauro"
                Else
                    Return "Géminis"
                End If
            Case 6
                If fecha.Day <= 21 Then
                    Return "Géminis"
                Else
                    Return "Cáncer"
                End If
            Case 7
                If fecha.Day <= 22 Then
                    Return "Cáncer"
                Else
                    Return "Leo"
                End If
            Case 8
                If fecha.Day <= 23 Then
                    Return "Leo"
                Else
                    Return "Virgo"
                End If
            Case 9
                If fecha.Day <= 23 Then
                    Return "Virgo"
                Else
                    Return "Libra"
                End If
            Case 10
                If fecha.Day <= 22 Then
                    Return "Libra"
                Else
                    Return "Escorpio"
                End If
            Case 11
                If fecha.Day <= 22 Then
                    Return "Escorpio"
                Else
                    Return "Sagitario"
                End If
            Case 12
                If fecha.Day <= 21 Then
                    Return "Sagitario"
                Else
                    Return "Capricornio"
                End If
        End Select
        Return ""
    End Function

    Private Function ObtenerPrediccion(signo As String) As String
        Select Case signo
            Case "Aries"
                Return "Buenas notas"
            Case "Tauro"
                Return "Trabajo"
            Case "Géminis"
                Return "Rumbas"
            Case "Cáncer"
                Return "Dinero"
            Case "Leo"
                Return "Deudas"
            Case "Virgo"
                Return "Estabilidad laboral"
            Case "Libra"
                Return "Felicidad"
            Case "Escorpio"
                Return "Amor"
            Case "Sagitario"
                Return "Auto nuevo"
            Case "Capricornio"
                Return "Paz espiritual"
            Case "Acuario"
                Return "Salud"
            Case "Piscis"
                Return "Buena suerte en la lotería"
        End Select
        Return ""
    End Function

    Private Sub GenerarNumerosDeLaSuerte()
        Dim rand As New Random()
        For i As Integer = 0 To 2
            numerosSuerte(i) = rand.Next(0, 100).ToString("D2")
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
