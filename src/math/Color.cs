public class Color
{

    public int r;
    public int g;
    public int b;
    public int a;

    public float _r
    {

        get
        {

            return r / 255.0f;

        }

    }

    public float _g
    {

        get
        {

            return g / 255.0f;

        }

    }

    public float _b
    {

        get
        {

            return b / 255.0f;

        }

    }

    public float _a
    {

        get
        {

            return a / 255.0f;

        }

    }

    public Color()
    {

        r = 255;
        g = 255;
        b = 255;
        a = 255;

    }

    public Color(int value)
    {

        r = value;
        g = value;
        b = value;
        a = 255;

    }

    public Color(int red, int green, int blue)
    {

        r = red;
        g = green;
        b = blue;
        a = 255;

    }

    public Color(int red, int green, int blue, int alpha)
    {

        r = red;
        g = green;
        b = blue;
        a = alpha;

    }

}