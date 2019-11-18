public class parentClass1
{
    public virtual int addition(int number1, int number2)
    {
        return number1 + number2;
    }
    // In order for a method to be overriden it must be tagged with the word "virtual" //
    // Methods tagged with "abstract" must always be overidden whenever a child class is defined //
}
public class childClass1: parentClass1
{
    public override int addition(int number1, int number2)
    {
        return number1 * number2;
    }
}

public class parentClass2
{
    public int integer = 0;
    public int addition(int number1, int number2)
    {
        return number1 + number2;
    }

}
public class childClass2 : parentClass2
{
    public new int integer = 1;

}
// Use of the new keyword hides the base class value for integer //
// Seemingly it overrides it but parentclass2.integer will return the original value //
// i.e. object.integer will return 1 //
// but object.parentClass2.integer will return 0 //
// This allows the almost overriding of a certain member but still having access to the original member if required //