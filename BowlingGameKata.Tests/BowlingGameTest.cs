using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BowlingGameKata.Tests
{
    public class BowlingGameTest
    {
        [Fact]
        public void TestGutterGame()
        {
            Game g = new Game();

            for (int i = 0; i < 20; i++)
                g.Roll(0);

            Assert.Equal(0, g.Score());
        }
    }
}
