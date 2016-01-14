' Jumping back to the top of the file, we create
' "manager_Attach", a sub-module that once we
' attach a Phidget, it will be called
' 
' We grab the Serial Number and name from the
' arguments to the sub-module, and then neatly
' write them to the Console
'
' Same as last time, this makes use of a Try/Catch
' to stop the program crashing if things go wrong

Module Module1

	' A new sub for when USB Phidgets are connected to our device
	Private Sub manager_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles manager.Attach

		' Pre-define varibles
		Dim serialNumber As Integer
		Dim name As String

		Try
			serialNumber = e.Device.SerialNumber
			name = e.Device.Name
			' Log the device name and serial number to the console
			Console.WriteLine("Hello Device {0}, Serial Number: {1}!", serialNumber.ToString, name)
		Catch ex As Phidgets.PhidgetException
			Console.WriteLine("Error")
			Console.WriteLine(ex.Code)
			Console.WriteLine(ex.Description)
		End Try

	End Sub

	Sub Main()

		manager = New Phidgets.Manager()

		...
