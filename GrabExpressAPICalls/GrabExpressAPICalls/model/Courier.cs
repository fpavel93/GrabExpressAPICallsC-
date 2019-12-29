
public class Courier {

	Coordinates coordinates;
	string name;
	string phone;
	string pictureURL;
	Vehicle vehicle;

    public Coordinates Coordinates { get => coordinates; set => coordinates = value; }
    public string Name { get => name; set => name = value; }
    public string Phone { get => phone; set => phone = value; }
    public string PictureURL { get => pictureURL; set => pictureURL = value; }
    public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
}
