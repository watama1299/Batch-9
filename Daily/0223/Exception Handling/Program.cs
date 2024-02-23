class Program {
    static void Main(string[] args)
	{
        /**


        Exception handling best done during development
        Try to solve all forms of exceptions before doing try/catch via validation and testing
        In release, use try/catch in case of any unforeseen exceptions
        
        
        */
        

		// FormatException
        // eg. Use TryParse instead of Parse to handle exception from non-numeric string values
		string a = "39r";
		try {
            int status = int.Parse(a);
        } catch (FormatException e) {
            Console.WriteLine(e);
        }

		// IndexOutOfRangeException
        // eg. Check if number < array length, then get value from array
		int[] myArray = {1,2,3};
		try {
            int b = myArray[3];
        } catch (IndexOutOfRangeException e) {
            Console.WriteLine(e);
        }

		//StackOverFlowException
		try {
            Run();
        } catch (StackOverflowException e) {
            Console.WriteLine(e);
        }

		// NullReferenceException
        // eg. Check if string is not null before trying to get length
		string? myString = null;
		try {
            int result = myString.Length;
        } catch (NullReferenceException e) {
            Console.WriteLine(e);
        }
	}
	static void Run()
	{
		Run();
	}
}