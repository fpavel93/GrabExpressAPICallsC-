
public class DeliveryTracker {

	string status;
	Courier courier;
	Timeline timeline;
	string trackingURL;
	AdvanceInfo advanceInfo;

    public string Status { get => status; set => status = value; }
    public Courier Courier { get => courier; set => courier = value; }
    public Timeline Timeline { get => timeline; set => timeline = value; }
    public string TrackingURL { get => trackingURL; set => trackingURL = value; }
    public AdvanceInfo AdvanceInfo { get => advanceInfo; set => advanceInfo = value; }
}
