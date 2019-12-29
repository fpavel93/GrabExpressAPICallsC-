
using System.Collections.Generic;

public class Quote {

	Service service;
	int amount;
	Timeline estimatedTimeline;
	int distance;
	List<Package> packages;
	Place origin;
	Place destination;

    public Service Service { get => service; set => service = value; }
    public int Amount { get => amount; set => amount = value; }
    public Timeline EstimatedTimeline { get => estimatedTimeline; set => estimatedTimeline = value; }
    public int Distance { get => distance; set => distance = value; }
    public List<Package> Packages { get => packages; set => packages = value; }
    public Place Origin { get => origin; set => origin = value; }
    public Place Destination { get => destination; set => destination = value; }
}