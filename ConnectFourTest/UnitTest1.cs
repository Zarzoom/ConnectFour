using ConnectFour.DataType;
using ConnectFour.Services;

namespace ConnectFourTest;

public class whenGivenA2DArrayWithPlayerOneHavingFourAcross
{
    Player[,] connectFourGame1 = new Player [6, 7]
    {
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { (Player)2, (Player)1, (Player)1, (Player)1, (Player)1, 0, 0 },
    };
    [SetUp]
    public void Setup()
    {

        
    }

    [Test]
    public void ThenItCanFindFourAcross()
    {
        BoardStateManager boardStateManager = new BoardStateManager();
        Player actual = boardStateManager.FourInARow(connectFourGame1);
        Player expected = Player.PlayerOne;
        Assert.AreEqual(expected, actual);
    }  
}

public class whenGivenA2DArrayWithPlayerTwoHavingFourAcross
{
    Player[,] connectFourGame1 = new Player [6, 7]
    {
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
        { (Player)2, (Player)2, (Player)2, (Player)2, (Player)1, 0, 0 },
    };
    [SetUp]
    public void Setup()
    {

        
    }

    [Test]
    public void ThenItCanFindFourAcross()
    {
        BoardStateManager boardStateManager = new BoardStateManager();
        Player actual = boardStateManager.FourInARow(connectFourGame1);
        Player expected = Player.PlayerOne;
        Assert.AreEqual(expected, actual);
    }  
}

public class WhenGivenA2DArrayWithPlayerOneHavingFourDown
{
    Player[,] connectFourGame2 = new Player [6, 7]
    {
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, (Player)1, 0, 0, 0 },
        { 0, 0, 0, (Player)1, 0, 0, 0 },
        { 0, 0, 0, (Player)1, 0, 0, 0 },
        { 0, 0, 0, (Player)1, (Player)2, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
    };
    [SetUp]
    public void Setup()
    {

        


    }

    [Test]
    public void ThenItCanFindFourDown()
    {
        BoardStateManager boardStateManager = new BoardStateManager();
        Player actual = boardStateManager.FourInARow(connectFourGame2);
        Player expected = Player.PlayerOne;
        Assert.AreEqual(expected, actual);
      
    }
}

public class WhenGivenA2DArrayAndPlayerOneHasFourDiagonal
{
    Player [,] connectFourGame3 = new Player [6, 7]
    {
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, (Player)1, 0, 0, 0, 0 },
        { 0, (Player)2, 0, (Player)1, 0, 0, 0 },
        { 0, 0, 0, 0, (Player)1, 0, 0 },
        { 0, 0, 0, 0, 0, (Player)1, 0 },
        { 0, 0, 0, 0, 0, 0, 0 },
    };
    [SetUp]
    public void Setup()
    {
 
        

    }

    [Test]
    public void ThenItCanFindFourDiagonal()
    {
        BoardStateManager boardStateManager = new BoardStateManager();
        Player actual = boardStateManager.FourInARow(connectFourGame3);
        Player expected = Player.PlayerOne;
        Assert.AreEqual(expected, actual);
    }
}