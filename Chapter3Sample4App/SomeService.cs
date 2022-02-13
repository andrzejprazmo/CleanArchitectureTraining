using Chapter3Sample4App.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3Sample4App
{
	public interface ISomeService
	{
		void Foo();
	}
	public class SomeService : ISomeService
	{
		private readonly ILogger _logger;
		private readonly ISomeRepository _someRepository;
		public SomeService(ILogger logger, ISomeRepository someRepository)
		{
			_logger = logger;
			_someRepository = someRepository;
		}
		public void Foo()
		{
			Console.WriteLine($"SomeService->Logger->SomeText = {_logger.SomeText}");

			_someRepository.Bar();
		}
	}
}
