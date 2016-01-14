' Now for the opposite to the last step,
' with virtually the same code except for
' Goodbye instead of Hello
'
' Make sure you place this after you attach,
' but before your Main()

		...

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

	Sub Main()

		...
