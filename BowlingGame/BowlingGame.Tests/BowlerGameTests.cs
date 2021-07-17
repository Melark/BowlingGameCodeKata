using System;
using FluentAssertions;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlerGameTests
    {
        [Fact]
        public void ScoreIsZeroWhenGameIsGreated()
        {
            var game = new BowlerGame();
            var score = game.Score();
            score.Should().Be(0);
        }

        [Fact]
        public void RollMethodCanGetMax10Pins()
        {
            var game = new BowlerGame();
            Action act = () => game.Roll(11);
            act.Should().Throw<ArgumentException>();
        }
        
        [Fact]
        public void RollMethodCanGetMin0Pins()
        {
            var game = new BowlerGame();
            Action act = () => game.Roll(-1);
            act.Should().Throw<ArgumentException>();
        }
    }
}