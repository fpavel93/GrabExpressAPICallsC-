
public class Package {

	string name;
	string description;
	int quantity;
	int price;
	Dimensions dimensions;

    public string Name { get => name; set => name = value; }
    public string Description { get => description; set => description = value; }
    public int Quantity { get => quantity; set => quantity = value; }
    public int Price { get => price; set => price = value; }
    public Dimensions Dimensions { get => dimensions; set => dimensions = value; }
}
