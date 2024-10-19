Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class KeyboardRemapper
    Inherits Form

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    Private hookID As IntPtr = IntPtr.Zero
    Private lowLevelKeyboardProc As LowLevelKeyboardProcDelegate
    Private isHookAttivo As Boolean = False

    Private Delegate Function LowLevelKeyboardProcDelegate(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr

    Private isKeyQPressed As Boolean = False
    Private isNumPad5Pressed As Boolean = False
    Private isNumPad4Pressed As Boolean = False
    Private isNumPad6Pressed As Boolean = False
    Private isKeyLPressed As Boolean = False

    Public Sub New()
        InitializeComponent()
        lowLevelKeyboardProc = New LowLevelKeyboardProcDelegate(AddressOf CallbackGancio)
        AddHandler btnAttiva.Click, AddressOf BtnAttiva_Click
        AddHandler btnDisattiva.Click, AddressOf BtnDisattiva_Click
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        UnhookWindowsHookEx(hookID)
        MyBase.OnFormClosing(e)
    End Sub

    Private Function ImpostaGancio(proc As LowLevelKeyboardProcDelegate) As IntPtr
        Dim moduleHandle = Marshal.GetHINSTANCE(GetType(KeyboardRemapper).Module)
        Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, moduleHandle, 0)
    End Function

    Private Function CallbackGancio(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
        If nCode >= 0 Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)

            If isHookAttivo Then
                Select Case vkCode
                    Case Keys.A
                        Return GestisciRimappatura(wParam, isKeyQPressed, txtkey6.Text, Keys.A)
                    Case Keys.S
                        Return GestisciRimappatura(wParam, isNumPad5Pressed, txtKey7.Text, Keys.S)
                    Case Keys.D
                        Return GestisciRimappatura(wParam, isNumPad4Pressed, txtKey8.Text, Keys.D)
                    Case Keys.F
                        Return GestisciRimappatura(wParam, isNumPad6Pressed, txtKey9.Text, Keys.F)
                    Case Keys.G
                        Return GestisciRimappatura(wParam, isNumPad6Pressed, txtKey0.Text, Keys.G)
                End Select
            End If
        End If

        Return CallNextHookEx(hookID, nCode, wParam, lParam)
    End Function

    Private Function GestisciRimappatura(wParam As IntPtr, ByRef isKeyPressed As Boolean, testoInviare As String, vkCode As Keys) As IntPtr
        If wParam = New IntPtr(WM_KEYDOWN) AndAlso Not isKeyPressed Then
            isKeyPressed = True

            If String.IsNullOrEmpty(testoInviare) Then
                SendKeys.Send(vkCode.ToString())
            ElseIf Not testoInviare.Contains(vkCode.ToString()) Then
                SendKeys.Send(testoInviare)
            End If

        ElseIf wParam = New IntPtr(WM_KEYUP) Then
            isKeyPressed = False

            If vkCode = Keys.L Then
                isKeyLPressed = False
            End If
        End If

        Return New IntPtr(1)
    End Function

    Private Sub BtnAttiva_Click(sender As Object, e As EventArgs)
        If Not isHookAttivo Then ToggleGancio()
    End Sub

    Private Sub BtnDisattiva_Click(sender As Object, e As EventArgs)
        If isHookAttivo Then ToggleGancio()
    End Sub

    Private Sub ToggleGancio()
        isHookAttivo = Not isHookAttivo

        MessageBox.Show("Hook " & If(isHookAttivo, "Attivato", "Disattivato"), "Variazione Hook")
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(idHook As Integer, lpfn As LowLevelKeyboardProcDelegate, hMod As IntPtr, dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(hhk As IntPtr, nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hookID = ImpostaGancio(lowLevelKeyboardProc)
        MessageBox.Show("Benvenuti nel Keyboard Remapper !" & vbCrLf & " " & vbCrLf &
                        "Imposta i tasti A,S,D,F in sostituzione a quelli che preferisci," &
                        " puoi modificare i parametri cliccando sui numeri preimpostati." & vbCrLf &
                        " " & vbCrLf &
                        "Utilizza i pulsanti per attivare o disattivare il gancio." &
                        vbCrLf & " " & vbCrLf &
                        "- DavideEDN",
                        "Keyboard Remapper 1.0")
    End Sub

End Class