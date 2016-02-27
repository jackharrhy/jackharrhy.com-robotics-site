' 8
'
' Now how hard can it be to hook it up
' to a network?
'
' Ez

	...

	Sub Main()

		manager = New Phidgets.Manager()

		manager.open(IP ADDRESS HERE, 5001)

		Console.WriteLine("Press Enter to end anytime")
		Console.Read()
		Console.WriteLine("Closing...")

		...

' For example
		manager.open("192.168.0.59", 5001)

' To find your Phidget's IP & port, view the network diagarm
