' 2
'
' We now setup the Phidget manager
'
' We start the manager by making a new Manager,
' and then 'open()' it
'
' Later on we will allow for network connections,
' but for now simply a USB connection from the local machine
'
' We also Console.Read() to stop the program from quitting

Module Module1

	Sub Main()

		manager = New Phidgets.Manager() ' Create new manager for our Phidgets

		manager.open() ' Start/open this manager

		Console.WriteLine("Press Enter to end anytime")
		Console.Read() ' Read to prevent insta-quitting
		Console.WriteLine("Closing...")

	End Sub

End Module
