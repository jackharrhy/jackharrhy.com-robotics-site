' We now setup the Manager, which you guessed it;
' manages our Phidgets connection to us
'
' We start the manager by making a new Manager, and
' then we open it up to connections
'
' Later on we will allow for network connections, but
' now its simply a USB connection from the local
' computer
'
' We also Console.Read() to stop the program from
' prematurely giving up its meager existence

Module Module1

	Sub Main()

		manager = New Phidgets.Manager() ' Create new manager for our Phidgets

		manager.open() ' Start/open this manager

		Console.WriteLine("Press Enter to end anytime")
		Console.Read() ' Read to prevent insta-quitting
		Console.WriteLine("Closing...")

	End Sub

End Module
