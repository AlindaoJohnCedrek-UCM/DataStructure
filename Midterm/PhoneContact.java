package DATASTRUCT;

public class PhoneContact {
	String firstName, lastName, company, alias, phone, email;

    // Constructor to initialize a contact
    public PhoneContact(String fn, String ln, String comp, String al, String ph, String em) {
        this.firstName = fn;
        this.lastName = ln;
        this.company = comp;
        this.alias = al;
        this.phone = ph;
        this.email = em;
    }

    // A helper method to display contact info neatly
    public void display() {
        System.out.printf("%-12s | %-12s | %-10s | %-15s | %s%n", 
                          firstName, lastName, alias, phone, email);
}
}
