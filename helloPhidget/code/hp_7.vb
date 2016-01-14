' Here is all of the code, in all its glory!
'
' Feel free to copy and paste this into your
' DLL'ed Visual Basic project; but please
' understand to an extent what it does!
'
' This of course is designed only for USB; it
' will NOT work over network!

Module Module1

	Private Sub manager_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles manager.Attach

		Dim serialNumber As Integer
		Dim name As String

		Try
			serialNumber = e.Device.SerialNumber
			name = e.Device.Name
			Console.WriteLine("Hello Device {0}, Serial Number: {1}!", serialNumber.ToString, name)
		Catch ex As Phidgets.PhidgetException
			Console.WriteLine("Error")
			Console.WriteLine(ex.Code)
			Console.WriteLine(ex.Description)
		End Try

	End Sub

	Private Sub manager_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles manager.Detach

		Dim serialNumber As Integer
		Dim name As String

		Try
			serialNumber = e.Device.SerialNumber
			name = e.Device.Name
			Console.WriteLine("Goodbye Device {0}, Serial Number: {1}!", serialNumber.ToString, name)
		Catch ex As Phidgets.PhidgetException
			Console.WriteLine("Error")
			Console.WriteLine(ex.Code)
			Console.WriteLine(ex.Description)
		End Try

	End Sub

	Private Sub manager_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles manager.Error
		
		Dim number As Integer
		Dim description As String

		number = e.Code
		description = e.Description

		Console.WriteLine("Error Event: {0} - {1}!", number.ToString, description)

	End Sub

	Dim WithEvents manager As Phidgets.Manager

	Sub Main()

		manager = New Phidgets.Manager()

		manager.open()

		Console.WriteLine("Press Enter to end anytime")
		Console.Read()
		Console.WriteLine("Closing...")

		Try
			RemoveHandler manager.Attach, AddressOf manager_Attach
			RemoveHandler manager.Detach, AddressOf manager_Detach
			manager.close()
			manager = Nothing
		Catch ex As Phidgets.Phidget Exception
			Console.WriteLine("Error")
			Console.WriteLine(ex.Code)
			Console.WriteLine(ex.Description)
		End Try

	End Sub

End Module
