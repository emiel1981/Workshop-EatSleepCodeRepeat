using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch05.boardpanel.v1
{
    public class BoardPanel
    {
        // tag::render[]
        /// <summary>
        /// Renders a single square on the given graphics context on the specified
        /// rectangle.
        ///
        /// <param name="square">The square to render.</param>
        /// <param name="g">The graphics context to draw on.</param>
        /// <param name="x">The x position to start drawing.</param>
        /// <param name="y">The y position to start drawing.</param>
        /// <param name="w">The width of this square (in pixels.)</param>
        /// <param name="h">The height of this square (in pixels.)</param>
        private void Render(Square square, Graphics g, Rectangle rectangle)
        {
            square.Sprite.Draw(g, rectangle);
            foreach (Unit unit in square.Occupants)
            {
                unit.Sprite.Draw(g, rectangle);
            }
        }
        // end::render[]

        private class Sprite
        {
            public void Draw(Graphics g, Rectangle rectangle)
            {

            }
        }

        private class Unit
        {
            public Sprite Sprite { get; set; }
        }

        private class Square : Unit
        {

            public IList<Unit> Occupants { get; set; }
        }

    }
}
