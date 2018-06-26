using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PingPongGameTest
{
  [TestMethod]
  public void ReturnPingWhenInputtingThree()
  {
    PingPongGame game = new PingPongGame();
    string expectedResult = "ping";
    int testValue = 3;
    Assert.AreEqual(expectedResult, game.ReturnMessage(testValue));
  }
  [TestMethod]
  public void ReturnPongWhenInputtingFive()
  {
    PingPongGame game = new PingPongGame();
    string expectedResult = "pong";
    int testValue = 5;
    Assert.AreEqual(expectedResult, game.ReturnMessage(testValue));
  }
  [TestMethod]
  public void ReturnPongWhenInputtingFifteen()
  {
    PingPongGame game = new PingPongGame();
    string expectedResult = "pingpong";
    int testValue = 15;
    Assert.AreEqual(expectedResult, game.ReturnMessage(testValue));
}
}
