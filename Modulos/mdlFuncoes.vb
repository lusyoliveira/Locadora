Imports System.IO

Module mdlFuncoes
    'Public meuServidor As String = "SJFPA008\DEV"
    Dim ClasseCombo As New clsCombo
    Public Function mcripto(ByVal wvTEXTO As String)
        Dim wvTEXTO1, wvTEXTO2, wvRETORNA As String
        Dim X, Y, INDICE As Integer
        Dim CARACTER As String
        wvTEXTO = UCase(wvTEXTO)
        wvRETORNA = ""
        wvTEXTO1 = "ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890 WÇÃÕ"
        wvTEXTO2 = "!@#$%^&*()_+|=\-][{}?/><,.~`®¬½¼¡«»¨©ÇÕÃ"
        For X = 1 To Len(wvTEXTO)
            CARACTER = Right(Left(wvTEXTO, X), 1)
            For Y = 1 To Len(wvTEXTO1)

                If CARACTER = Right(Left(wvTEXTO1, Y), 1) Then
                    INDICE = Y

                End If
            Next
            wvRETORNA = wvRETORNA + Right(Left(wvTEXTO2, INDICE), 1)

        Next

        mcripto = wvRETORNA

    End Function
    Public Function muncripto(ByVal wvTEXTO As String)
        Dim X, Y, INDICE As Integer
        Dim CARACTER As String
        Dim wvTEXTO1, wvTEXTO2, wvRETORNA As String
        wvRETORNA = ""
        wvTEXTO = UCase(wvTEXTO)
        wvTEXTO2 = "ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890 WÇÃÕ"
        wvTEXTO1 = "!@#$%^&*()_+|=\-][{}?/><,.~`®¬½¼¡«»¨©ÇÕÃ"
        For X = 1 To Len(wvTEXTO)
            CARACTER = Right(Left(wvTEXTO, X), 1)
            For Y = 1 To Len(wvTEXTO1)

                If CARACTER = Right(Left(wvTEXTO1, Y), 1) Then
                    INDICE = Y

                End If
            Next
            wvRETORNA = wvRETORNA + Right(Left(wvTEXTO2, INDICE), 1)

        Next

        muncripto = wvRETORNA

    End Function

    Public Function ProcessFile(ByVal cxTexto As ListBox, ByVal strFile As String)
        'DECLARA UM OBJETO PARA A CLASSE STREAMREADER

        cxTexto.Items.AddRange(File.ReadAllLines(strFile))
        'Dim linhas() As String
        ''ABRE O ARQUIVO
        'linhas = File.ReadAllLines(strFile)
        'cxTexto.Items.AddRange(linhas)
        '        cxTexto.Refresh()
        ProcessFile = True
    End Function
    Public Function encontrachr(ByVal texto As String, ByVal caract As String, ByVal posicao As Integer) As String
        Dim y As Integer
        Dim posicoes As Integer
        Dim ultima As Integer
        Dim achou As Boolean
        Dim retorno As String
        posicoes = 1
        ultima = 0
        achou = False
        retorno = ""
        For y = 1 To Len(texto)

            If Mid(texto, y, 1) = caract Then
                If posicoes = posicao Then
                    retorno = Mid(texto, IIf(ultima = 0, 1, ultima), IIf(ultima = 0, y - ultima - 1, y - ultima))
                    achou = True
                    Exit For
                Else
                    achou = False
                End If
                posicoes = posicoes + 1
                ultima = y + 1
            End If
        Next
        If achou = False Then
            retorno = Mid(texto, IIf(ultima = 0, 1, ultima), IIf(ultima = 0, y - ultima - 1, y - ultima))
        End If
        encontrachr = retorno
    End Function
    Public Function montadata(ByVal data As String) As Date
        Dim novadata As String
        novadata = Left(data, 2) & "/" & Mid(data, 3, 2) & "/" & Right(data, 4)
        If IsDate(novadata) = False Then
            montadata = Date.Today
            Exit Function
        End If
        montadata = CDate(novadata)

    End Function

    Public Function centraliza(ByVal frase As String, ByVal valor As Integer)
        Return (valor - frase.Length) / 2
    End Function

    Public Function moeda(ByVal valor As String)
        If valor = "" Then
            moeda = 0
            Exit Function
        End If
        Dim novovalor As String = valor.Replace("R$", "").Replace(".", "")
        Return novovalor.Replace(",", ".").Trim
    End Function
    Public Function definesemestre(ByVal data As Date) As Integer
        If data.Month < 7 Then
            Return 1
        Else
            Return 2
        End If
    End Function
    Public Function diasuteis(ByVal mes As Integer, ByVal ano As Integer, ByVal diautil As Integer) As Date
        Dim data, novadata As Date
        Dim x, dias As Integer
        data = CDate("01/" & mes & "/" & ano)
        x = 0
        dias = 0
        While dias < diautil
            novadata = data.AddDays(x)
            If novadata.DayOfWeek = DayOfWeek.Saturday Or novadata.DayOfWeek = DayOfWeek.Sunday Then
            Else
                dias += 1
            End If
            x += 1
        End While
        Return novadata
    End Function
    Public Function zeros(ByVal expr As String, ByVal qtd As Integer)
        Dim dd As String
        Dim x As Integer
        dd = ""
        If qtd <= Len(expr) Then
            Return expr
            Exit Function
        End If
        For x = 1 To (qtd - Len(expr))
            dd = dd & "0"
        Next
        Return dd & expr

    End Function
    Public Function tratadata(ByVal data As String, Optional ByVal mascara As String = "dd/MM/yyyy") As Date
        If IsDate(data) Then
            Return Format(CDate(data), mascara)
        Else
            data = "01/01/1900"
            Return Format(CDate(data), mascara)
        End If
    End Function
    Public Function VAL_CPF(ByVal CPF As String) As Boolean
        On Error Resume Next
        Dim soma As Integer
        Dim Resto As Integer
        Dim i As Integer
        'Valida argumento
1:      CPF = Replace(CPF, ".", "")
2:      CPF = Replace(CPF, "-", "")
3:      If Len(CPF) <> 11 Then
4:          Return False
            Exit Function
        End If
5:      soma = 0
        For i = 1 To 9
6:          soma = soma + Val(Mid$(CPF, i, 1)) * (11 - i)
7:      Next i
8:      Resto = 11 - (soma - (Int(soma / 11) * 11))
9:      If Resto = 10 Or Resto = 11 Then Resto = 0
10:     If Resto <> Val(Mid$(CPF, 10, 1)) Then
11:         Return False
            Exit Function
        End If
12:     soma = 0
        For i = 1 To 10
13:         soma = soma + Val(Mid$(CPF, i, 1)) * (12 - i)
14:     Next i
15:     Resto = 11 - (soma - (Int(soma / 11) * 11))
16:     If Resto = 10 Or Resto = 11 Then Resto = 0
17:     If Resto <> Val(Mid$(CPF, 11, 1)) Then
18:         Return False
            Exit Function
        End If
19:     Return True
    End Function
    Public Function completa(ByVal mensagem As String, ByVal espacos As Integer, Optional ByVal alinha As String = "e", Optional ByVal formato As String = "")

        mensagem = Trim(mensagem)
        If formato <> "" Then

            If Format(formato, "<") = "n" Then
                mensagem = Format(mensagem, "###,###,##0.00")
            Else
                If Format(formato, "<") = "data" Then
                    mensagem = Format(mensagem, "dd/mm/yyyy")
                    '            If Format(formato, "<") = "currency" Then
                    '                mensagem = "R$" & CStr(Format(mensagem, "###,###,##0.00"))
                Else
                    mensagem = Format(mensagem.Trim, formato)
                    '            End If
                End If
            End If
        End If

        If Len(Trim(mensagem)) > espacos Then
            'espacos = Len(RTrim(mensagem))
            Return Left(mensagem.Trim, espacos)
            Exit Function
        End If

        If Format(alinha, "<") = "d" Then
            Return Space(espacos - Len((mensagem.Trim))) + mensagem.Trim
        Else
            Return mensagem.Trim + Space(espacos - Len((mensagem.Trim)))
        End If

    End Function
    Public Function conectado() As Boolean
        Try
            Return My.Computer.Network.Ping("www.globo.com")
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function validarserial(Optional ByVal operacao As String = "VALIDAR") As Boolean
        Dim arquivo As String
        If operacao.ToUpper = "VALIDAR" Then
            Try

                arquivo = "c:\temp\" & serialhd("c:\") & ".txt"
                If My.Computer.FileSystem.DirectoryExists("c:\temp") = False Then
                    My.Computer.FileSystem.CreateDirectory("c:\temp")
                End If
                If My.Computer.FileSystem.FileExists(arquivo) = True Then
                    My.Computer.FileSystem.DeleteFile(arquivo)
                End If
                My.Computer.Network.DownloadFile("http://br.geocities.com/caafs2/" & serialhd("c:\") & ".txt", arquivo)
                validarserial = True
            Catch ex As Exception
                validarserial = False
            End Try
            Exit Function
        Else
            arquivo = "c:\temp\" & serialhd("c:\") & ".txt"
            If My.Computer.FileSystem.DirectoryExists("c:\temp") = False Then
                My.Computer.FileSystem.CreateDirectory("c:\temp")
            End If
            If My.Computer.FileSystem.FileExists(arquivo) = True Then
                My.Computer.FileSystem.DeleteFile(arquivo)
            End If
            Dim arq As StreamWriter = New StreamWriter(arquivo)
            arq.WriteLine(arquivo)
            arq.Close()
            'My.Computer.Network.UploadFile(arquivo, "http://br.geocities.com/caafs2", "caafs2", "a1b1c1d1")
            My.Computer.Network.UploadFile(arquivo, "https://cp1.runhosting.com/ftp_manager.html", "204774", "208bfcae")
        End If
    End Function
    Public Function serialhd(ByVal driveletter As String)

        Dim fso As Object
        Dim Drv As Object
        Dim DriveSerial As String
        'Cria um objeto FileSystemObject
        fso = CreateObject("Scripting.FileSystemObject")

        'Atribui a letra do drive atual se nada for especificado
        If driveletter <> "" Then
            Drv = fso.GetDrive(driveletter)
        Else
            Drv = fso.GetDrive(fso.GetDriveName("c:\"))
        End If

        With Drv
            If .IsReady Then
                DriveSerial = Int(.SerialNumber)
            Else '"Drive não esta pronto!"
                DriveSerial = -1
            End If
        End With

        'libera objetos
        Drv = Nothing
        fso = Nothing

        serialhd = DriveSerial

    End Function
    Public Function primeiraletra(ByVal palavra As String)
        If palavra.Length = 0 Then
            Return ""
            Exit Function
        End If
        Dim x As Integer
        Dim nova As String
        nova = ""
        nova = palavra.Substring(0, 1).ToUpper

        For x = 1 To palavra.Length - 1
            If palavra.Substring(x - 1, 1).ToUpper = " " Then
                nova = nova & palavra.Substring(x, 1).ToUpper
            Else
                nova = nova & palavra.Substring(x, 1).ToLower
            End If
        Next
        Return nova
    End Function

    Public Function mPASTA(ByVal wcCAMINHO As String)
        Dim wctemp
        Dim xx As Integer
        For xx = 1 To Len(wcCAMINHO)
            If Left(Right(wcCAMINHO, xx + 1), 1) = "\" Then
                wctemp = Len(Right(wcCAMINHO, xx))
                mPASTA = Left(wcCAMINHO, Len(wcCAMINHO) - wctemp)
                xx = Len(wcCAMINHO)
            End If
        Next
        Return ""
    End Function
    Public Function UltimoDia(ByVal wcdata As Date) As Date
        wcdata = wcdata.AddMonths(1)
        wcdata = wcdata.AddDays(-1)
        Return wcdata
    End Function
    Public Function PegaMenus(ByVal listbox1 As CheckedListBox, ByVal menustrip1 As MenuStrip)
        Dim x, y, z As Integer
        Dim v As System.Windows.Forms.ToolStripMenuItem
        Dim submenu As System.Windows.Forms.ToolStripMenuItem

        listbox1.Items.Clear()
        For x = 0 To menustrip1.Items.Count - 1
            v = menustrip1.Items(x)
            If v.Text <> "" Then
                listbox1.Items.Add(v.Text)
                For y = 0 To v.DropDown.Items.Count - 1
                    If v.DropDown.Items(y).Text <> "" Then
                        listbox1.Items.Add(v.DropDown.Items(y).Text)
                        If v.DropDown.Items(y).Text <> "" Then
                            submenu = v.DropDown.Items(y)
                            If submenu.DropDownItems.Count <> 0 Then
                                For z = 0 To submenu.DropDownItems.Count - 1
                                    If submenu.DropDownItems.Item(z).Text <> "" Then
                                        listbox1.Items.Add(submenu.DropDown.Items(z).Text)
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next
            End If
        Next
        PegaMenus = ""
    End Function
End Module
