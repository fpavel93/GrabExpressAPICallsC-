
using System.Collections.Generic;

public class Quotes {

	List<QuoteParam> QuotesParams;
	List<Package> packages;
	Place origin;
	Place destination;

    public List<QuoteParam> QuotesParams1 { get => QuotesParams; set => QuotesParams = value; }
    public List<Package> Packages { get => packages; set => packages = value; }
    public Place Origin { get => origin; set => origin = value; }
    public Place Destination { get => destination; set => destination = value; }
}
