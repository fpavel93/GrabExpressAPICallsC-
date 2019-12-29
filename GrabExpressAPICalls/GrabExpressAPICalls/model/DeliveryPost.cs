
using System.Collections.Generic;

public class DeliveryPost {
	
		  string merchantOrderID;
		  string serviceType;
		  string paymentMethod;
		  List<Package> packages;
		  Contact sender;
		  Contact recipient;
		  Place origin;
		  Place destination;
		  CashOnDelivery cashOnDelivery;
		  Schedule schedule;
		  bool highValue;
		  
}
