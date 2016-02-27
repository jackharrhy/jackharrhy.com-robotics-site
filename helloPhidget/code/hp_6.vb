' 6
'
' Last step; we create a sub that will
' be called once an manager error occurs
'
' We also add a line just before the Main module
' to hook our events to a new Phidget Manager

		...

	End Sub

	Private Sub manager_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles manager.Error
		Console.WriteLine("Error Event: {0} - {1}!", e.Code.ToString, e.Description)
	End Sub

	Dim WithEvents manager As Phidgets.Manager

	Sub Main()

		...
