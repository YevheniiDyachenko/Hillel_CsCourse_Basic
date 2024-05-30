namespace _15._2_CatalogOfContacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Dictionary for storing contacts
            Dictionary<string, string> contacts = new Dictionary<string, string>
            {
                // Add Demo contacts to the dictionary
                {"Pavlo", "0987654321"},
                {"Will", "0999999999"},
                {"Mark", "0987654321"},
                {"James", "0999999999"}
            };
            
            // Menu for user selection
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" -- Contact Catalog Menu --");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Remove Contact");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Search Contact");
                Console.WriteLine("5. List All Contacts");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Contact.AddContact(contacts);
                            break;
                        case 2:
                            Contact.RemoveContact(contacts);
                            break;
                        case 3:
                            Contact.UpdatePhone(contacts);
                            break;
                        case 4:
                            Contact.SearchContact(contacts);
                            break;
                        case 5:
                            Contact.ListContacts(contacts);
                            break;
                        case 0:
                            Contact.Exit();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}