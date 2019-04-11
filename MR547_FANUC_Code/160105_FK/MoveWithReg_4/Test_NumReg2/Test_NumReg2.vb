Option Explicit On
Public Class Test_NumReg2
    ' Sample VB.NET program to display R[1] and send a new value
    ' to/from any controller
    '
    ' Declarations
    '

    '   Public Class NumRegTest

    Private mobjRobot As FRRobot.FRCRobot
    Private WithEvents mobjRegs As FRRobot.FRCVars
    Dim Test1 As FRRobot.FRCVars



    ' Handle the Connect/Disconnect button click 
    Private Sub cmdConnect_Click(ByVal sender As Object, _
                                                             ByVal e As System.EventArgs) Handles cmdConnect.Click
        Try

            If cmdConnect.Text = "Connect" Then

                txtRegValue.Text = String.Format("Connecting to {0} Please wait.", txtHostName.Text)

                mobjRobot = New FRRobot.FRCRobot
                mobjRobot.Connect(txtHostName.Text)
                mobjRegs = mobjRobot.RegNumerics




                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                'MAIN LOOP'
                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%



                '' move to Ready
                ''If mobjRobot.RegNumerics(2).value.reglong = 1 Then

                ''mobjRobot.RegNumerics(1).value.reglong = 2
                ''mobjRobot.RegNumerics(2).value.reglong = 0

                ''While mobjRobot.RegNumerics(2).value.reglong = 0
                ''System.Threading.Thread.Sleep(200)
                ''End While
                ''End If


                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(0, 65, -73, 73, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -90, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If



                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(-7, 66, -73, 73, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -96, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If



                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(0, 70, -64, 64, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -90, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If



                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(-6, 77, -53, 53, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -95, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If



                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(6, 77, -53, 53, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -85, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If



                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(7, 66, -73, 73, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -83, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If


                '' MOVE TO LINEAR COORDINATES
                If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                    Dim FKxyz(3) As Double
                    FKxyz = forwKin(0, 65, -73, 73, -90)
                    Console.WriteLine(FKxyz)
                    '' x, y, z, W, P, R, speed (mm/sec)
                    moveLin(FKxyz(1), FKxyz(2), FKxyz(3), -90, 0, -90, 100)

                    mobjRobot.RegNumerics(1).Value.RegLong = 3
                    mobjRobot.RegNumerics(2).Value.RegLong = 0
                    While mobjRobot.RegNumerics(2).Value.RegLong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If







                '' MOVE TO JOINT COORDINATES
                ''If mobjRobot.RegNumerics(2).Value.RegLong = 1 Then

                '' theta1, theta2, theta3, theta4, theta5, speed (percent)
                ''moveJnt(5, 10, 0, 0, 0, 20)

                ''mobjRobot.RegNumerics(1).Value.RegLong = 4
                ''mobjRobot.RegNumerics(2).Value.RegLong = 0
                ''While mobjRobot.RegNumerics(2).Value.RegLong = 0
                ''System.Threading.Thread.Sleep(200)
                ''End While
                ''End If


                '' move to Home
                If mobjRobot.RegNumerics(2).value.reglong = 1 Then

                    mobjRobot.RegNumerics(1).value.reglong = 1
                    mobjRobot.RegNumerics(2).value.reglong = 0

                    While mobjRobot.RegNumerics(2).value.reglong = 0
                        System.Threading.Thread.Sleep(200)
                    End While
                End If





                '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                ''End the motion by setting R(1) to 99
                mobjRobot.RegNumerics(1).Value.RegLong = 99
                mobjRobot.RegNumerics(2).Value.RegLong = 0
                System.Threading.Thread.Sleep(2000)

                ''Zero the Register Values before disconnecting!
                zeroRegs()




            Else    ' must be the user wants to disconnect

                txtRegValue.Text = "Releasing the Robot objects"
                ReleaseObjects()
                txtRegValue.Text = "Not Connected"
            End If

        Catch ex As System.Runtime.InteropServices.COMException
            ' The only time an error is expected is during connect
            MsgBox(String.Format("{0} - {1}", ex.ErrorCode, ex.Message))
            ReleaseObjects()
        Catch ex As Exception
            MsgBox(ex.Message)
            ReleaseObjects()
        End Try

        If mobjRobot IsNot Nothing AndAlso mobjRobot.IsConnected Then
            cmdConnect.Text = "Disconnect"
        Else
            cmdConnect.Text = "Connect"
        End If

    End Sub





    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '' FORWARD KINEMATICS
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    Public Function forwKin(ByVal th1 As Double, ByVal th2 As Double, ByVal th3 As Double, ByVal th4 As Double, ByVal th5 As Double)

        '' Define pi:
        Dim pi As Double
        pi = 22 / 7

        '' DH to Fanuc Conversion:
        th1 = th1
        th2 = th2
        th3 = th2 + th3
        th4 = th2 - th3
        th5 = 0

        '' Radians to Degree Conversion:
        th1 = th1 * pi / 180
        th2 = (th2 - 90) * pi / 180
        th3 = (th3 - 86) * pi / 180
        th4 = (th4 + 86) * pi / 180
        th5 = th5 * pi / 180

        '' Define x, y, z:
        Dim x, y, z As Double
        x = (Math.Cos(th3) * (Math.Cos(th1) * Math.Cos(th2)) * (2.9)) + ((2.6) * Math.Cos(th1) * Math.Cos(th2)) + (Math.Cos(th4) * (Math.Sin(th3) * Math.Cos(th1) * Math.Cos(th2) - Math.Cos(th3) * Math.Cos(th1) * Math.Sin(th2)) * 0.78) + (Math.Sin(th4) * (Math.Cos(th3) * Math.Cos(th1) * Math.Cos(th2) + Math.Sin(th3) * Math.Cos(th1) * Math.Sin(th2)) * 0.78) + (Math.Sin(th3) * Math.Cos(th1) * Math.Sin(th2) * 2.9)
        y = (Math.Cos(th3) * (Math.Cos(th2) * Math.Sin(th1)) * (2.9)) + ((2.6) * Math.Cos(th2) * Math.Sin(th1)) + (Math.Cos(th4) * (Math.Sin(th3) * Math.Cos(th2) * Math.Sin(th1) - Math.Cos(th3) * Math.Sin(th1) * Math.Sin(th2)) * 0.78) + (Math.Sin(th4) * (Math.Cos(th3) * Math.Cos(th2) * Math.Sin(th1) + Math.Sin(th3) * Math.Sin(th1) * Math.Sin(th2)) * 0.78) + (Math.Sin(th3) * Math.Sin(th1) * Math.Sin(th2) * 2.9)
        z = -2.6 * Math.Sin(th2) - 2.9 * Math.Cos(th3) * Math.Sin(th2) - Math.Cos(th4) * (Math.Cos(th2 - th3)) * 0.78 - Math.Sin(th4) * (Math.Sin(th2 - th3) * 0.78) + 2.9 * Math.Sin(th3) * Math.Cos(th2)

        '' Convert from meters to millimeters:
        x = 100 * x
        y = 100 * y
        z = 100 * z

        Dim outFK(3) As Double
        outFK(1) = x
        outFK(2) = y
        outFK(3) = z

        Return outFK

    End Function





















    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '' MOTION FUNCTIONS
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    '' LINEAR MOTION FUNCTION
    Private Sub moveLin(xLin As Double, yLin As Double, zLin As Double, wLin As Double, pLin As Double, rLin As Double, speedLin As Double)
        '' POINT1
        mobjRobot.RegNumerics(11).Value.RegLong = xLin     '' Point1 x-axis
        mobjRobot.RegNumerics(12).Value.RegLong = yLin     '' Point1 y-axis
        mobjRobot.RegNumerics(13).Value.RegLong = zLin     '' Point1 z-axis
        mobjRobot.RegNumerics(14).Value.RegLong = wLin     '' Point1 w-aangle
        mobjRobot.RegNumerics(15).Value.RegLong = pLin     '' Point1 p-angle
        mobjRobot.RegNumerics(16).Value.RegLong = rLin     '' Point1 r-angle
        '%%%%%%%%
        mobjRobot.RegNumerics(10).Value.RegLong = speedLin

    End Sub


    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '' JOINT MOTION FUNCTION
    Private Sub moveJnt(theta1 As Double, theta2 As Double, theta3 As Double, theta4 As Double, theta5 As Double, speedJnt As Double)
        '' POINT1
        mobjRobot.RegNumerics(21).Value.RegLong = theta1     '' Point1 x-axis
        mobjRobot.RegNumerics(22).Value.RegLong = theta2     '' Point1 y-axis
        mobjRobot.RegNumerics(23).Value.RegLong = theta3     '' Point1 z-axis
        mobjRobot.RegNumerics(24).Value.RegLong = theta4     '' Point1 w-aangle
        mobjRobot.RegNumerics(25).Value.RegLong = theta5     '' Point1 p-angle
        '%%%%%%%%
        mobjRobot.RegNumerics(20).Value.RegLong = speedJnt

    End Sub




    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '' Grip Open FUNCTION
    Private Sub gripOpen()

        mobjRobot.RegNumerics(51).Value.RegLong = 1
        mobjRobot.RegNumerics(52).Value.RegLong = 0

    End Sub


    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '' Grip Close FUNCTION
    Private Sub gripClose()

        mobjRobot.RegNumerics(51).Value.RegLong = 0
        mobjRobot.RegNumerics(52).Value.RegLong = 1

    End Sub


    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '' Zero the Register Values
    Private Sub zeroRegs()
        Dim counterZR As Integer = 1
        For counterZR = 1 To 200
            mobjRobot.RegNumerics(counterZR).Value.RegLong = 0
        Next counterZR
    End Sub



    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


    ' Fully releasing COM objects requires waiting for garbage collection
    Private Sub ReleaseObjects()
        mobjRegs = ReleaseObject("mobjRegs", mobjRegs)
        mobjRobot = ReleaseObject("mobjRobot", mobjRobot)
        System.GC.Collect()
    End Sub

    ' Wrap object release in Try-Catch for enhanced diagnostics
    Private Function ReleaseObject(ByVal identifier As String, ByRef item As Object) As Object
        Try
            item = Nothing
        Catch ex As Exception
            System.Diagnostics.Trace.WriteLine(String.Format("Error releasing {0}.{1}Error: {2}", identifier, Environment.NewLine, ex.Message))
        End Try

        Return Nothing
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '
        mobjRobot.RegNumerics(1).Value.RegLong = txtRegValue.Text
    End Sub
End Class

