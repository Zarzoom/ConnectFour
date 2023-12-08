// using ConnectFour.DataType;
// using System;
// namespace ConnectFour.Services;
//
// public class BoardStateManager
// {
//     public Player FourInARow(Player[,] connectFourGame1)
//     {
//         int rowIndex = 0;
//         while (rowIndex < connectFourGame1.GetLength(0))
//         {
//             int inARowPlayerOne = 0;
//             int inARowPlayerTwo = 0;
//             int columnIndex = 0;
//             while (columnIndex < connectFourGame1.GetLength(1))
//             {
//                 if (connectFourGame1[rowIndex, columnIndex] != 0 && connectFourGame1[rowIndex, columnIndex + 1] != 0)
//                 {
//                     if (connectFourGame1[rowIndex, columnIndex] == Player.PlayerOne)
//                     {
//                         inARowPlayerOne++;
//                     }
//                     else
//                     {
//                         inARowPlayerTwo++;
//                     }
//                 }
//
//                 if (connectFourGame1[rowIndex, columnIndex] != 0 && (inARowPlayerOne == 3 || inARowPlayerTwo == 3))
//                 {
//                     if (connectFourGame1[rowIndex, columnIndex] == Player.PlayerOne)
//                     {
//                         inARowPlayerOne++;
//                         return Player.PlayerOne;
//                     }
//                     else
//                     {
//                         inARowPlayerTwo++;
//                         return Player.PlayerTwo;
//                     }
//                 }
//
//                 if (connectFourGame1[rowIndex, columnIndex] != 0 && connectFourGame1[rowIndex, columnIndex + 1] == 0 &&
//                     inARowPlayerOne != 3 || inARowPlayerTwo != 3)
//                 {
//                     inARowPlayerTwo = 0;
//                     inARowPlayerOne = 0;
//                 }
//             }
//         }
//         throw new NotImplementedException();
//     }
// }