using System;

public class Vector2
{

    public float x;
    public float y;

    public Vector2()
    {

        x = 0;
        y = 0;

    }

    public Vector2(float _x, float _y)
    {

        x = _x;
        y = _y;

    }

    public float magnitude
    {

        get
        {

            return (float)Math.Sqrt(x * x + y * y);

        }

    }

}