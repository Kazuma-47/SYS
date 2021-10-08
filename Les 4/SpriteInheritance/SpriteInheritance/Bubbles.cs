using System.Drawing;


namespace Eindopdracht 
{
    class Bubbles : Sprite
    {
        public Bubbles(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 279, 16, 16);
        }
    }
}
