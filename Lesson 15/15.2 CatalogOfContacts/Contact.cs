namespace _15._2_CatalogOfContacts
{
    static class Contact
    {
        public static void AddContact(Dictionary<string, string> contacts)
        {
            if (GetName(contacts, out var name, expectExists: false)) return;
            if (GetPhone(contacts, out var phone, expectExists: false)) return;

            contacts.Add(name, phone);
            Console.WriteLine($"Contact {name} added successfully.");
        }

        public static void RemoveContact(Dictionary<string, string> contacts)
        {
            if (GetName(contacts, out var name, expectExists: true)) return;

            contacts.Remove(name);
            Console.WriteLine($"Contact {name} removed successfully.");
        }

        public static void UpdatePhone(Dictionary<string, string> contacts)
        {
            if (GetName(contacts, out var name, expectExists: true)) return;
            if (GetPhone(contacts, out var phone, expectExists: false)) return;

            contacts[name] = phone;
            Console.WriteLine($"Contact {name} updated successfully.");
        }

        public static void SearchContact(Dictionary<string, string> contacts)
        {
            if (GetName(contacts, out var name, expectExists: true)) return;

            if (contacts.TryGetValue(name, out var phone))
            {
                Console.WriteLine($"Contact {name}: {phone}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        public static void ListContacts(Dictionary<string, string> contacts)
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("The contact list is empty.");
                return;
            }

            Console.WriteLine("A list of contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
        }

        public static void Exit()
        {
            Console.WriteLine("Exiting...");
        }

        private static bool GetName(Dictionary<string, string> contacts, out string name, bool expectExists)
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            if (expectExists && !contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact with name {name} does not exist.");
                return true;
            }

            if (!expectExists && contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact with name {name} already exists.");
                return true;
            }

            return false;
        }

        private static bool GetPhone(Dictionary<string, string> contacts, out string phone, bool expectExists)
        {
            Console.Write("Enter phone: ");
            phone = Console.ReadLine();

            if (expectExists && !contacts.ContainsValue(phone))
            {
                Console.WriteLine($"Contact with phone {phone} does not exist.");
                return true;
            }

            if (!expectExists && contacts.ContainsValue(phone))
            {
                Console.WriteLine($"Contact with phone {phone} already exists.");
                return true;
            }

            return false;
        }
    }
}