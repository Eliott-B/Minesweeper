using System;
namespace Minesweeper.App
{
	public class Engine
    {
        private int[] iGridHeight;
        private int[] iGridWidth;

        private int iMines;

        public Engine(int iInHeight, int iInWidth, int iInMines)
		{
            if (iInMines > (iInHeight*iInWidth*0.15))
            {
                throw new EngineException(0);
            }
            else if (iInMines < 1)
            {
                throw new EngineException(1);
            }
            else if (iInHeight < 5 ||
                iInWidth < 5)
            {
                throw new EngineException(2);
            }
            iGridHeight = new int[iInHeight];
            iGridWidth = new int[iInWidth];
            iMines = iInMines;
        }
	}
}

