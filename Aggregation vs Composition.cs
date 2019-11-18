// To explain the difference between these 2 methods i'm using the context of an overarching car class //

//Composition//

public class Engine1
{
    public int cylinders;
    public int size;
    public int horsepower;
}

public class Car1
{
    Engine1 engine = new Engine1();
}

// Instantiate new Car1 object: //
// Car1 corsa = new Car1() //

// This is compostion //
// The when the Car1 class is defined a new instance of the Engine1 class is instantiated and then encapsulated inside the Car1 object //
// In the event that the Car1 object is deleted the engine object that was instantiated upon its creation will also be destroyed //

// Aggregation //
public class Engine2
{
    public int cylinders;
    public int size;
    public int horsepower;
}

public class Car2
{
    public Engine2 engine;
}

// Instantiate new Car2 object: //
// Engine2 exampleEngine = new Engine2(); //
// Car2 exampleCar = new Car2(); //
// exampleCar.engine = exampleEngine; //

// This is aggregation //
// In this method rather than creating a new instance of Engine2 inside of Car2 we make a seperate instance outside the Car2 class //
// We then retroactively attach a copy of the Engine2 object to the new Car2 object //
// This way in the event that the Car2 object is deleted the Engine2 object will remain as its own seperate entity //
// While there are more nuanced ways of instantiating the Car2 class this was the best method to explain how aggregation works //

