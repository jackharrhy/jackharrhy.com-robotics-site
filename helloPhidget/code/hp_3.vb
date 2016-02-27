' 3
'
' I use the "..." to avoid posting all of the code
' every time I copy it
'
' These following lines will disconnect the Phidget
' peacefully, as you see by manager.close(), followed
' by manager = Nothing

		...

		Console.WriteLine("Press Enter to end anytime")
		Console.Read()
		Console.WriteLine("Closing...")

		RemoveHandler manager.Attach, AddressOf manager_Attach
		RemoveHandler manager.Detach, AddressOf manager_Detach
		manager.close()
		manager = Nothing

	End Sub

End Module
