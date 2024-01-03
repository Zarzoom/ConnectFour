using ConnectFour.DataType;
using System;
namespace ConnectFour.Services;

public class BoardStateManager
{
    public Player FourInARow(Player[][] connectFourGame1)
    {
        int rowIndex = connectFourGame1.GetLength(0) - 1;
        while (rowIndex >= 0)
        {
            int columnIndex = 0;
            while (columnIndex < connectFourGame1[0].GetLength(0))
            {
                if (connectFourGame1[rowIndex][columnIndex] != 0)
                {
                    //right
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, 0, +1))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }


                    //left
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, 0, -1))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }

                    //up
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, +1, 0))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }

                    //down
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, -1, 0))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }

                    //top right diagonal
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, +1, +1))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }


                    //botom left diagonal
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, -1, -1))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }

                    //top left diagonal
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, -1, +1))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }

                    //bottom right diagonal
                    if (CheckDirection(connectFourGame1, columnIndex, rowIndex, +1, -1))
                    {
                        return connectFourGame1[rowIndex][columnIndex];
                    }
                }

                columnIndex++;
            }

            rowIndex--;
        }

        return Player.NoOne;
    }

    private bool CheckDirection(Player[][] connectFourGame1, int columnIndex, int rowIndex, int rowDelta,
        int columnDelta)
    {
        int variableRowIndex = rowIndex + rowDelta;
        int variableColumnIndex = columnIndex + columnDelta;
        if (InBounds(variableColumnIndex, variableRowIndex, connectFourGame1) &&
            connectFourGame1[variableRowIndex][variableColumnIndex] != 0)
        {

            int inARow = 1;
            while (InBounds(variableColumnIndex, variableRowIndex, connectFourGame1) &&
                   connectFourGame1[variableRowIndex][variableColumnIndex] ==
                   connectFourGame1[rowIndex][columnIndex])
            {
                inARow++;
                variableRowIndex += rowDelta;
                variableColumnIndex += columnDelta;
            }

            if (inARow >= 4)
            {
                return true;

            }
        }

        return false;
    }

    public bool InBounds(int variableColumnIndex, int variableRowIndex, Player[][] connectFourGame1)
    {
        if (variableColumnIndex < 0 || variableRowIndex >= connectFourGame1.GetLength(0) ||
            variableColumnIndex >= connectFourGame1[0].GetLength(0) || variableRowIndex < 0)
        {
            return false;
        }

        return true;
    }

    public Player[][] PlaceToken(Player[][] connectFourGame, int whichColumn, Player whichPlayer)
    {
        int row = 0;
        while (row < connectFourGame.GetLength(0) && connectFourGame[row][whichColumn] == Player.NoOne)
        {
            row++;

        }

        connectFourGame[row - 1][whichColumn] = whichPlayer;
        FourInARow(connectFourGame);
        return connectFourGame;

    }


    // public Player[][] TranslationStringToPlayer(string[][] connectFourGameString)
    // {
    //
    //     Player[][] connectFourGame = connectFourGameString
    //         .Select(x => x.Select(c => (Player)Enum.Parse(typeof(Player), c)).ToArray())
    //         .ToArray();
    //     return connectFourGame;
    // }


}