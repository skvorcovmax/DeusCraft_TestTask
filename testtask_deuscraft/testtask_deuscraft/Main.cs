using System;
using System.IO;
using System.Collections.Generic;

namespace testtask_deuscraft
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ConsoleInterpreter interpreter = new ConsoleInterpreter (args);
			TaskPerformer.PerformTask (interpreter);
		}
	}
}
