' 5
'
' Now for the opposite to the last step,
'
' Make sure you place this after you attach,
' but before your Main()

		...

	End Sub

	Private Sub manager_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles manager.Detach
		Console.WriteLine("Goodbye Device {0}, Serial Number: {1}!", e.Device.SerialNumber.ToString, e.Device.name)
	End Sub

	Sub Main()

		...
