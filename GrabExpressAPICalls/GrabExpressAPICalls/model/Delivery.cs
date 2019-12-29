
public class Delivery {

	string deliveryID;
	string merchantOrderID;
	string serviceType;
	Quote quote;
	Contact sender;
	Contact recipient;
	CashOnDelivery cashOnDelivery;
	string status;
	Courier courier;
	Timeline timeline;
	string trackingURL;
	AdvanceInfo advanceInfo;

    public string DeliveryID { get => deliveryID; set => deliveryID = value; }
    public string MerchantOrderID { get => merchantOrderID; set => merchantOrderID = value; }
    public string ServiceType { get => serviceType; set => serviceType = value; }
    public Quote Quote { get => quote; set => quote = value; }
    public Contact Sender { get => sender; set => sender = value; }
    public Contact Recipient { get => recipient; set => recipient = value; }
    public CashOnDelivery CashOnDelivery { get => cashOnDelivery; set => cashOnDelivery = value; }
    public string Status { get => status; set => status = value; }
    public Courier Courier { get => courier; set => courier = value; }
    public Timeline Timeline { get => timeline; set => timeline = value; }
    public string TrackingURL { get => trackingURL; set => trackingURL = value; }
    public AdvanceInfo AdvanceInfo { get => advanceInfo; set => advanceInfo = value; }
}
