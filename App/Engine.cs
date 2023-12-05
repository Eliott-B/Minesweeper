using System;
namespace Minesweeper.App
{
	public class Engine
    {
        // 0 No mine
        // -1 No mine and discovered
        // -2 Mine
        // -3 Flag
        // 1,2,3,... Number of mines around
        private readonly int[,] iGrid;

        private readonly int iMines;

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
            iGrid = new int[iInWidth,iInHeight];
            iMines = iInMines;
        }

        public void InitGame()
        {
            int iMinesInGame = 0;
            Random rnd = new Random();

            while (iMinesInGame < iMines)
            {
                int iHeight = rnd.Next(1, iGrid.GetLength(0) - 1);
                int iWidth = rnd.Next(1, iGrid.GetLength(1) - 1);
                iGrid[iHeight, iWidth] = -2;
                iMinesInGame++;
            }
        }

        public void AddFlag(int iHeight, int iWidth)
        {
            iGrid[iHeight, iWidth] = -3;
        }
	}
}

