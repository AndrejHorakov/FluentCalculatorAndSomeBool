namespace FluentCalculatorAndSomeBool;

public class SomeBool
{
    public override bool Equals(object? obj)
    {
        if (this == obj)
            return true;
        return base.Equals(obj);
    }

    public static bool operator ==(SomeBool myBool, object? obj)
    {
        var type = obj?.GetType();
        var boolType = typeof(bool); 
        if (type == boolType)
            return true;
        return false;
    }
    public static bool operator !=(SomeBool myBool, object? obj)
    {
        return !(myBool==obj);
    }
}