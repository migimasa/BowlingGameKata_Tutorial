using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BowlingGameKata.Tests
{
    public class BowlingGameTest : IDisposable
    {
        private Game g;
        public BowlingGameTest()
        {
            g = new Game();
        }

        public void Dispose()
        {
            g = null;
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        [Fact]
        public void TestGutterGame()
        {
            RollMany(n: 20, pins: 0);

            Assert.Equal(0, g.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            RollMany(n: 20, pins: 1);

            Assert.Equal(20, g.Score());
        }

        [Fact]
        public void TestOneSpare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(n: 17, pins: 0);

            Assert.Equal(16, g.Score());
        }

        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }

        [Fact]
        public void TestOneStrike()
        {
            g.Roll(10); //strike
            g.Roll(3);
            g.Roll(4);
            RollMany(n: 16, pins: 0);

            Assert.Equal(24, g.Score());
        }
    }
}
