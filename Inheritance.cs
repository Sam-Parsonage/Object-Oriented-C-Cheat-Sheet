public class baseClass
{
    private int privateValue = 0;
    protected int protectedValue = 1;
    public int publicValue = 2;
    public class nestedChildClass : baseClass
    // NOTATION: child class name : base class name //
    {
        public int getFunction()
        {
            return this.privateValue;
        }
        // Private attributes only accessible by nested child classes //
    }
}
public class unnestedChildClass : baseClass
{
    public int getFunction()
    {
        //return this.privateValue;//
        return this.protectedValue;
        return this.publicValue;
    }
    // unnested child classes will not be able to see private attributes //
    // but it will see public and protected attributes (although the second return statement would never be executed)//
}