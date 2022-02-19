using System;

public class Vector3
{

    public float x;
    public float y;
    public float z;

    public Vector3()
    {

        x = 0;
        y = 0;
        z = 0;

    }

    public Vector3(float _x, float _y)
    {

        x = _x;
        y = _y;
        z = 0;

    }

    public Vector3(float _x, float _y, float _z)
    {

        x = _x;
        y = _y;
        z = _z;

    }

    public float magnitude
    {

        get
        {

            return (float)Math.Sqrt(x * x + y * y + z * z);

        }

    }

}