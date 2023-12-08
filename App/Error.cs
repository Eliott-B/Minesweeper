using System;
namespace Minesweeper.App
{
	public static class Error
	{
		public static readonly string[] ENGINE_ERROR =
        {
            "Mines can't be upper than 15% of cases.",
            "You need to add minimum 5 mines.",
            "You need to have minimum 5 columns and lines.",
            "You don't have anymore flags.",
            "You need to enter a valid Height or Width.",
            "This case is already discovered or have already a flag.",
            "This is not flag here.",
            "This is a flag here.",
            "Start coords can't be negative or out of range of the grid."
        };
	}
}

