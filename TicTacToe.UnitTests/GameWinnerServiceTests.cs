using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        IGameWinnerService _gameWinnerService;
            
        [SetUp]
        public void SetupUnitTests()
        {
            _gameWinnerService = new GameWinnerService();
        }

        [Test]
        public void NeitherPlayerHasThreeInARow()
        {
            

            const char expected = ' ';

            var gameBoard = new char[3, 3] {{' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '}};
            var actual = _gameWinnerService.Validate(gameBoard);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()
        {
            
            const char expected = 'X';
            var gameBoard = new char[3, 3] { { expected, expected, expected }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            var actual = _gameWinnerService.Validate(gameBoard);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        
        }
    }
}
