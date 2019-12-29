
public class QuoteParam {

	Service service;
	int amount;
	Timeline estimatedTimeline;
	int distance;

    public Service Service { get => service; set => service = value; }
    public int Amount { get => amount; set => amount = value; }
    public Timeline EstimatedTimeline { get => estimatedTimeline; set => estimatedTimeline = value; }
    public int Distance { get => distance; set => distance = value; }
}
