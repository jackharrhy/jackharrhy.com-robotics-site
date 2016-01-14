' I use the "..." to avoid posting all of the code
' every time I copy it; get used to it or git
'
' These following lines will disconnect the Phidget
' peacefully, as you see by manager.close(), followed
' by manager = Nothing
'
' This is also wrapped in a Try/Catch statement, in
' which if something goes wrong, it will log 'Error'
' to the console; which it hopefully won't have to do

		...

		Console.WriteLine("Press Enter to end anytime")
		Console.Read()
		Console.WriteLine("Closing...")

		Try ' Try/Catch for errors
			RemoveHandler manager.Attach, AddressOf manager_Attach
			RemoveHandler manager.Detach, AddressOf manager_Detach
			manager.close()
			manager = Nothing
			' Remove Handlers, close the manager, and erase the varible
		Catch ex As Phidgets.Phidget Exception
			Console.WriteLine("Error")
		End Try

	End Sub

End Module
