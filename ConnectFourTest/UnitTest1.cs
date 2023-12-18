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
        Player expected = Player.PlayerTwo;
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

public class WhenGivenA2DArrayAndPlayerOneHasFourDiagonalDown
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
//write a diagonal test going the other way with player two winning.
public class WhenGivenA2DArrayAndPlayerOneHasFourDiagonalUp
{
    Player [,] connectFourGame3 = new Player [6, 7]
    {
        { 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, (Player) 1, (Player)2, 0, 0 },
        { 0, 0, 0,(Player) 2, 0, 0, 0 },
        { 0, 0,(Player) 2, 0, 0, 0, 0 },
        { 0,(Player) 2, 0, 0, 0, 0, 0 },
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
        Player expected = Player.PlayerTwo;
        Assert.AreEqual(expected, actual);
    }

    public class WhenGivenAnEmpty2DArrayAPlayerAndAColumn
    {
        Player [,] connectFourGame4 = new Player [6, 7]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
        };

        int column = 3;
        private Player player = Player.PlayerOne;

        [SetUp]
        public void Setup()
        {
 
            BoardStateManager boardStateManager = new BoardStateManager();
            boardStateManager.PlaceToken(connectFourGame4, column, player);
        }
        [Test]
        public void ThenItCanFindTheNextOpenSpace()
        {
            Player expected = Player.PlayerOne;
            Player actual = connectFourGame4[5, 3];
            Assert.AreEqual(expected, actual);
        }
    }

    public class WhenGivenAPartialyPopulated2DArrayAPlayerAndAColumn
    {
        Player [,] connectFourGame5 = new Player [6, 7]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, (Player) 1, 0, 0, 0 },
            { 0, 0, 0, (Player) 1, 0, 0, 0 },
        };

        int column = 3;
       Player player = Player.PlayerOne;
       
       [SetUp]
       public void Setup()
       {
 
           BoardStateManager boardStateManager = new BoardStateManager();
           boardStateManager.PlaceToken(connectFourGame5, column, player);
       }
       
       [Test]
       public void ThenItCanFindTheNextOpenSpace()
       {
           Player expected = Player.PlayerOne;
           Player actual = connectFourGame5[3, 3];
           Assert.AreEqual(expected, actual);
       }

    }

    public class WhenGivenAPartiallyPopulated2DArrayAPlayerAndAColumn
    {
        Player[,] connectFourGame6 = new Player [6, 7]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, (Player) 1, 0, 0, 0, 0 },
            { 0, 0, (Player) 1, 0, 0, 0, 0 },
        };

        int column = 2;
        private Player player = Player.PlayerTwo;
        
        [SetUp]
        public void Setup()
        {
 
            BoardStateManager boardStateManager = new BoardStateManager();
            boardStateManager.PlaceToken(connectFourGame6, column, player);
        }
        
        [Test]
        public void ThenItCanFindTheNextOpenSpace()
        {
            Player expected = Player.PlayerTwo;
            Player actual = connectFourGame6[3, 2];
            Assert.AreEqual(expected, actual);
        }
    }
}