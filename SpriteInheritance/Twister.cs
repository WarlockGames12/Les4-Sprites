using System;
using System.Drawing;

public class Twister : Sprite
{
	public Twister(RectangleF screenPosition)
	{
        this.screenPosition = screenPosition;
        imageFrame = new Rectangle(85, 190, 14, 14);
        
    }
}
