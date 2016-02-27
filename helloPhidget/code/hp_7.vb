' 7
'
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
		Console.WriteLine("Hello Device {0}, Serial Number: {1}!", e.Device.SerialNumber.ToString, e.Device.Name)
	End Sub

	Private Sub manager_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles manager.Detach
		Console.WriteLine("Goodbye Device {0}, Serial Number: {1}!", e.Device.SerialNumber.ToString, e.Device.Name)
	End Sub

	Private Sub manager_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles manager.Error
		Console.WriteLine("Error Event: {0} - {1}!", e.Code.ToString, e.Description)
	End Sub

	Dim WithEvents manager As Phidgets.Manager

	Sub Main()

		manager = New Phidgets.Manager()

		manager.open()

		Console.WriteLine("Press Enter to end anytime")
		Console.Read()
		Console.WriteLine("Closing...")

		RemoveHandler manager.Attach, AddressOf manager_Attach
		RemoveHandler manager.Detach, AddressOf manager_Detach
		manager.close()
		manager = Nothing

	End Sub

End Module
