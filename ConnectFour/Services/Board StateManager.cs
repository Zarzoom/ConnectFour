using ConnectFour.DataType;
using System;
namespace ConnectFour.Services;

public class BoardStateManager
{
    public Player FourInARow(Player[,] connectFourGame1)
    {
        int rowIndex = 0;
        while (rowIndex < connectFourGame1.GetLength(0))
        {
            int columnIndex = 0;
            while (columnIndex < connectFourGame1.GetLength(1))
            {
                if (connectFourGame1[rowIndex, columnIndex + 1] == connectFourGame1[rowIndex, columnIndex])
                {
                    int variableIndex = columnIndex + 1;
                    int inARow = 0;
                    while (connectFourGame1 [rowIndex, variableIndex] == connectFourGame1[rowIndex, columnIndex])
                    {
                        inARow++;
                        variableIndex++;
                    }

                    if (inARow >= 4)
                    {
                        return connectFourGame1[rowIndex, columnIndex];
                    }
                }
                if (connectFourGame1[rowIndex, columnIndex - 1] != 0)
                {
                    int variableIndex = columnIndex - 1;
                    int inARow = 0;
                    while (connectFourGame1 [rowIndex, variableIndex] == connectFourGame1[rowIndex, columnIndex])
                    {
                        inARow++;
                        variableIndex--;
                    }

                    if (inARow >= 4)
                    {
                        return connectFourGame1[rowIndex, columnIndex];
                    }
                }
                if (connectFourGame1[rowIndex + 1, columnIndex] != 0)
                {
                    int variableIndex = rowIndex + 1;
                    int inARow = 0;
                    while (connectFourGame1 [variableIndex, columnIndex] == connectFourGame1[rowIndex, columnIndex])
                    {
                        inARow++;
                        variableIndex++;
                    }

                    if (inARow >= 4)
                    {
                        return connectFourGame1[rowIndex, columnIndex];
                    }
                }
                if (connectFourGame1[rowIndex - 1, columnIndex] != 0)
                {
                    int variableIndex = rowIndex - 1;
                    int inARow = 0;
                    while (connectFourGame1 [variableIndex, columnIndex] == connectFourGame1[rowIndex, columnIndex])
                    {
                        inARow++;
                        variableIndex--;
                    }

                    if (inARow >= 4)
                    {
                        return connectFourGame1[rowIndex, columnIndex];
                    }
                }

                if (connectFourGame1[rowIndex + 1, columnIndex + 1] != 0)
                {
                    int variableRowIndex = rowIndex + 1;
                    int variableColumnIndex = columnIndex + 1;
                    int inARow = 0;
                    while (connectFourGame1 [variableRowIndex, variableColumnIndex] == connectFourGame1[rowIndex, columnIndex])
                    {
                        inARow++;
                        variableRowIndex++;
                        variableColumnIndex++;
                    }

                    if (inARow >= 4)
                    {
                        return connectFourGame1[rowIndex, columnIndex];
                    }
                }

                if (connectFourGame1[rowIndex - 1, columnIndex - 1] != 0)
                {
                    int variableRowIndex = rowIndex - 1;
                    int variableColumnIndex = columnIndex - 1;
                    int inARow = 0;
                    while (connectFourGame1 [variableRowIndex, variableColumnIndex] == connectFourGame1[rowIndex, columnIndex])
                    {
                        inARow++;
                        variableRowIndex--;
                        variableColumnIndex--;
                    }

                    if (inARow >= 4)
                    {
                        return connectFourGame1[rowIndex, columnIndex];
                    } 
                }
            }
        }
        throw new NotImplementedException();
    }
}