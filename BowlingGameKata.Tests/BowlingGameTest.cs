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

        [Fact]
        public void TestGutterGame()
        {
            RollMany(n: 20, pins: 0);

            Assert.Equal(0, g.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
                g.Roll(pins);
        }

        [Fact]
        public void TestAllOnes()
        {
            RollMany(n: 20, pins: 1);

            Assert.Equal(20, g.Score());
        }
    }
}
