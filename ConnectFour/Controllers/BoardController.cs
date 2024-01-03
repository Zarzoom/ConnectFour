using ConnectFour.DataType;
using Microsoft.AspNetCore.Mvc;
using ConnectFour.Services;
namespace ConnectFour.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BoardController
{
    private readonly BoardStateManager boardStateManager;

    public BoardController(BoardStateManager boardStateManager)
    {
        this.boardStateManager = boardStateManager;
    }

    [HttpPost]
    public Player GetWinner([FromBody] Player[][] connectFourGame)
    {
        // Player[][] connectFourGame = boardStateManager.TranslationStringToPlayer(connectFourGameString);
        return (boardStateManager.FourInARow(connectFourGame));
    }

    [HttpPost("PlaceToken/{whichColumn}/{whichPlayer}")]
    public Player[][] PlaceToken([FromBody] Player[][] connectFourGame, int whichColumn, Player whichPlayer)
    {
        // Player[][] connectFourGame = boardStateManager.TranslationStringToPlayer(connectFourGameString);
        return boardStateManager.PlaceToken(connectFourGame, whichColumn, whichPlayer);
        
    }
}