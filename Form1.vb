Imports System
Imports System.Management
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")
            For Each queryObj As ManagementObject In searcher.Get()
                Dim temp As Double = CDbl(queryObj("CurrentTemperature"))
                temp = (temp - 2732) / 10.0
                MessageBox.Show("CPU Temperature :" & temp.ToString)
                lblCPUTepm.Text = temp.ToString

            Next
        Catch ex As ManagementException
            MessageBox.Show("Please run as Adminstor to Check CPU" & ex.Message)
        End Try

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDeviceName.Text = New Microsoft.VisualBasic.Devices.Computer().Name
        lblAvailableMemory.Text = New Microsoft.VisualBasic.Devices.ComputerInfo().OSFullName
        lblt.Text = New Microsoft.VisualBasic.Devices.Clock().LocalTime
        lblTotalMemory.Text = Math.Round(New Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1204 / 1024, 2) & " GB"
        lblVirtualMemory.Text = Math.Round(New Microsoft.VisualBasic.Devices.ComputerInfo().TotalVirtualMemory / 1204 / 1024 / 1024, 2) & " GB"
        lblAvailableMemory.Text = Math.Round(New Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory / 1024 / 12024 / 1024, 2) & " GB"
        lblOSPlatFrom.Text = New Microsoft.VisualBasic.Devices.ComputerInfo().OSFullName
        Try
            Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")
            For Each queryObj As ManagementObject In searcher.Get()
                Dim temp As Double = CDbl(queryObj("CurrentTemperature"))
                temp = (temp - 2732) / 10.0
                lblCPUTepm.Text = temp.ToString

            Next
        Catch ex As ManagementException
            lblCPUTepm.Text = "need run as adminstor"

        End Try


    End Sub
End Class
