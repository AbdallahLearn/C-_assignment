class Car
{
    private int model;
    private string type;

    // Public constructor to allow object creation
    public Car(int model, string type)
    {
        this.model = model;
        this.type = type;
    }

    // Method should return a string
    public string Drive()
    {
        return "Model is: " + model + " and its type is " + type;
    }
}