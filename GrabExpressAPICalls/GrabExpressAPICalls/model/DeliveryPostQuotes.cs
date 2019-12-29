
using System.Collections.Generic;

public class DeliveryPostQuotes {
	
		  string serviceType;
		  List<Package> packages;
		  Place origin;
		  Place destination;

    public string ServiceType { get => serviceType; set => serviceType = value; }
    public List<Package> Packages { get => packages; set => packages = value; }
    public Place Origin { get => origin; set => origin = value; }
    public Place Destination { get => destination; set => destination = value; }
}
