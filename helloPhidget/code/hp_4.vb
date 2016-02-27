' 4
'
' Jumping back to the top of the file, we create
' "manager_Attach", a sub that once we
' attach a Phidget, it will be called
' 
' We grab the 'Serial Number' and 'Name' from the varible 'e',
' and then write them to the Console

Module Module1

	' A new sub for when USB Phidgets are connected to our device
	Private Sub manager_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles manager.Attach
		Console.WriteLine("Hello Device {0}, Serial Number: {1}!", e.Device.SerialNumber.ToString, e.Device.Name)
	End Sub

	Sub Main()

		manager = New Phidgets.Manager()

		...
