' Last step; we create a sub-module that will
' be called once an error occurs on the
' managers side of things
'
' We also add a line just before the Main module
' to make Phidgets.Manager the same as manager,
' since its must easier to type

		...

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

		...
