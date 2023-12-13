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
                if (connectFourGame1[rowIndex, columnIndex] != 0)
                {
                    //right
                    if (columnIndex + 1 < connectFourGame1.GetLength(1))
                    {
                        if (connectFourGame1[rowIndex, columnIndex + 1] == connectFourGame1[rowIndex, columnIndex])
                        {
                            int variableIndex = columnIndex + 1;
                            int inARow = 1;
                            while (variableIndex < connectFourGame1.GetLength(1) &&
                                   connectFourGame1[rowIndex, variableIndex] == connectFourGame1[rowIndex, columnIndex])
                            {
                                inARow++;
                                variableIndex++;
                            }

                            if (inARow >= 4)
                            {
                                return connectFourGame1[rowIndex, columnIndex];
                            }
                        }
                    }

                    //left
                    if (columnIndex - 1 >= 0)
                    {
                        if (connectFourGame1[rowIndex, columnIndex - 1] != 0)
                        {
                            int variableIndex = columnIndex - 1;
                            int inARow = 1;
                            while (variableIndex >= 0 && connectFourGame1[rowIndex, variableIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
                            {
                                inARow++;
                                variableIndex--;
                            }

                            if (inARow >= 4)
                            {
                                return connectFourGame1[rowIndex, columnIndex];
                            }
                        }
                    }

                    //up
                    if (rowIndex + 1 < connectFourGame1.GetLength(0))
                    {
                        if (connectFourGame1[rowIndex + 1, columnIndex] != 0)
                        {
                            int variableIndex = rowIndex + 1;
                            int inARow = 1;
                            while (variableIndex < connectFourGame1.GetLength(0) &&
                                   connectFourGame1[variableIndex, columnIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
                            {
                                inARow++;
                                variableIndex++;
                            }

                            if (inARow >= 4)
                            {
                                return connectFourGame1[rowIndex, columnIndex];
                            }
                        }
                    }

                    //down
                    if (rowIndex - 1 >= 0)
                    {
                        if (connectFourGame1[rowIndex - 1, columnIndex] != 0)
                        {
                            int variableIndex = rowIndex - 1;
                            int inARow = 1;
                            while (variableIndex >= 0 && connectFourGame1[variableIndex, columnIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
                            {
                                inARow++;
                                variableIndex--;
                            }

                            if (inARow >= 4)
                            {
                                return connectFourGame1[rowIndex, columnIndex];
                            }
                        }
                    }

                    //top right diagonal
                    if (columnIndex + 1 < connectFourGame1.GetLength(1) && rowIndex + 1 < connectFourGame1.GetLength(0))
                    {
                        if (connectFourGame1[rowIndex + 1, columnIndex + 1] != 0)
                        {
                            int variableRowIndex = rowIndex + 1;
                            int variableColumnIndex = columnIndex + 1;
                            int inARow = 1;
                            while (variableColumnIndex < connectFourGame1.GetLength(1) &&
                                   variableRowIndex < connectFourGame1.GetLength(0) &&
                                   connectFourGame1[variableRowIndex, variableColumnIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
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
                    }

                    //botom left diagonal
                    if (columnIndex - 1 >= 0 && rowIndex - 1 >= 0)
                    {
                        if (connectFourGame1[rowIndex - 1, columnIndex - 1] != 0)
                        {
                            int variableRowIndex = rowIndex - 1;
                            int variableColumnIndex = columnIndex - 1;
                            int inARow = 1;
                            while (variableRowIndex >= 0 && variableColumnIndex >= 0 &&
                                   connectFourGame1[variableRowIndex, variableColumnIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
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

                    //top left diagonal
                    if (columnIndex + 1 < connectFourGame1.GetLength(1) && rowIndex - 1 >= 0)
                    {
                        if (connectFourGame1[rowIndex - 1, columnIndex + 1] != 0)
                        {
                            int variableRowIndex = rowIndex - 1;
                            int variableColumnIndex = columnIndex + 1;
                            int inARow = 1;
                            while (variableColumnIndex < connectFourGame1.GetLength(1) && variableRowIndex >= 0 &&
                                   connectFourGame1[variableRowIndex, variableColumnIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
                            {
                                inARow++;
                                variableRowIndex--;
                                variableColumnIndex++;
                            }

                            if (inARow >= 4)
                            {
                                return connectFourGame1[rowIndex, columnIndex];
                            }
                        }
                    }

                    //bottom right diagonal
                    if (columnIndex - 1 >= 0 && rowIndex + 1 < connectFourGame1.GetLength(0))
                    {
                        if (connectFourGame1[rowIndex + 1, columnIndex - 1] != 0)
                        {
                            int variableRowIndex = rowIndex + 1;
                            int variableColumnIndex = columnIndex - 1;
                            int inARow = 1;
                            while (variableColumnIndex >= 0 && variableRowIndex < connectFourGame1.GetLength(0) &&
                                   connectFourGame1[variableRowIndex, variableColumnIndex] ==
                                   connectFourGame1[rowIndex, columnIndex])
                            {
                                inARow++;
                                variableRowIndex++;
                                variableColumnIndex--;
                            }

                            if (inARow >= 4)
                            {
                                return connectFourGame1[rowIndex, columnIndex];
                            }
                        }
                    }
                }

                columnIndex++;
            }

            rowIndex++;
        }

        return Player.NoOne;
    }
}