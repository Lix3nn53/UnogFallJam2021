using System;

[Serializable]
public class BoolReference
{
    public bool useConstant = true;
    public bool constantValue;
    public BoolVariable variable;

    public BoolReference() { }

    public BoolReference(bool v)
    {
        this.useConstant = true;
        this.constantValue = v;
    }

    public bool value
    {
        get
        {
            return this.useConstant ? this.constantValue : this.variable.value;
        }
    }

    public static implicit operator bool(BoolReference reference)
    {
        return reference.value;
    }
}
