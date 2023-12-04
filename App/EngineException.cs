using System;
namespace Minesweeper.App
{
	public class EngineException: Exception
	{
		public EngineException(int iInErr) : base(Error.ENGINE_ERROR[iInErr])
		{
		}
	}
}

