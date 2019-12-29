
public class Contact {

	    string firstName;
	    string lastName;
	    string title;
	    string companyName;
	    string email;
	    string phone;
		bool smsEnabled;
	    string instruction;

    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Title { get => title; set => title = value; }
    public string CompanyName { get => companyName; set => companyName = value; }
    public string Email { get => email; set => email = value; }
    public string Phone { get => phone; set => phone = value; }
    public bool SmsEnabled { get => smsEnabled; set => smsEnabled = value; }
    public string Instruction { get => instruction; set => instruction = value; }
}
