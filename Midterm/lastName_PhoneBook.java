package DATASTRUCT;
import java.util.ArrayList;
import java.util.Scanner;
public class lastName_PhoneBook {
	private static ArrayList<PhoneContact> contacts = new ArrayList<>();
    private static Scanner sc = new Scanner(System.in);
	public static void main(String[] args) {
		
		int choice;
        do {
            System.out.println("\n--- PHONE BOOK MENU ---");
            System.out.println("1. Add Contact\n2. Update Contact\n3. Search Contact");
            System.out.println("4. Remove Contact\n5. Display All\n0. Exit");
            System.out.print("Enter choice: ");
            choice = sc.nextInt();
            sc.nextLine(); // consume newline

            switch (choice) {
                case 1: addContact(); break;
                case 2: updateContact(); break;
                case 3: searchContact(); break;
                case 4: deleteContact(); break;
                case 5: displayAll(); break;
            }
        } while (choice != 0);
    }

    // a) Insert / Add Contact
    public static void addContact() {
        System.out.print("First Name: "); String fn = sc.nextLine();
        System.out.print("Last Name: "); String ln = sc.nextLine();
        System.out.print("Company: "); String comp = sc.nextLine();
        System.out.print("Alias: "); String al = sc.nextLine();
        System.out.print("Phone: "); String ph = sc.nextLine();
        System.out.print("Email: "); String em = sc.nextLine();
        
        contacts.add(new PhoneContact(fn, ln, comp, al, ph, em));
        System.out.println("Contact added successfully!");
    }

    // b) Edit / Update Contact
    public static void updateContact() {
        System.out.print("Enter First Name of contact to update: ");
        String name = sc.nextLine();
        for (PhoneContact c : contacts) {
            if (c.firstName.equalsIgnoreCase(name)) {
                System.out.print("Enter New Phone Number: ");
                c.phone = sc.nextLine();
                System.out.println("Updated!");
                return;
            }
        }
        System.out.println("Contact not found.");
    }

    // c) Search Contact
    public static void searchContact() {
        System.out.print("Search by First Name: ");
        String name = sc.nextLine();
        for (PhoneContact c : contacts) {
            if (c.firstName.equalsIgnoreCase(name)) {
                c.display();
                return;
            }
        }
        System.out.println("No match found.");
    }

    // d) Delete / Remove Contact
    public static void deleteContact() {
        System.out.print("Enter First Name to delete: ");
        String name = sc.nextLine();
        for (int i = 0; i < contacts.size(); i++) {
            if (contacts.get(i).firstName.equalsIgnoreCase(name)) {
                contacts.remove(i);
                System.out.println("Contact removed.");
                return;
            }
        }
    }

    // e) Display All
    public static void displayAll() {
        System.out.printf("%-12s | %-12s | %-10s | %-15s | %s%n", 
                          "FIRST", "LAST", "ALIAS", "PHONE", "EMAIL");
        System.out.println("----------------------------------------------------------------------");
        for (PhoneContact c : contacts) {
            c.display();
        }
	}

}
