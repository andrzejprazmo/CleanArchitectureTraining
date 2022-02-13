using Chapter3Sample4App.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample4App
{
	public interface ISomeRepository
	{
		void Bar();
	}
	public class SomeRepository : ISomeRepository
	{
		private readonly ILogger _logger;
		public SomeRepository(ILogger logger)
		{
			_logger = logger;
		}
		public void Bar()
		{
			Console.WriteLine($"SomeRepository->Logger->SomeText = {_logger.SomeText}");

		}
	}
}
