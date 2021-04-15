[System.Serializable]
public struct Float2
{
    public float a;
    public float b;
    public Float2(float _a, float _b)
    {
        a = _a;
        b = _b;
    }
    public Float2(float _ab)
    {
        a = b = _ab;
    }
    public static Float2 operator +(Float2 _a, Float2 _b)
    {
        return new Float2(_a.a + _b.a, _a.b + _b.b);
    }
    public static Float2 operator -(Float2 _a, Float2 _b)
    {
        return new Float2(_a.a - _b.a, _a.b - _b.b);
    }
    public static Float2 operator *(Float2 _a, Float2 _b)
    {
        return new Float2(_a.a * _b.a, _a.b * _b.b);
    }
    public static Float2 operator /(Float2 _a, Float2 _b)
    {
        if (_b.a == 0 || _b.b == 0)
        {
            throw new System.DivideByZeroException();
        }
        return new Float2(_a.a / _b.a, _a.b / _b.b);
    }
    public static bool operator ==(Float2 _a, Float2 _b)
    {
        return (_a.a == _b.a && _a.b == _b.b);
    }
    public static bool operator !=(Float2 _a, Float2 _b)
    {
        return (_a.a != _b.a || _a.b != _b.b);
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return a.ToString() + ", " + b.ToString();
    }
}