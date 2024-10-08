using ExtensionMethods.Model;

namespace ExtensionMethods.ExtensionMethods;

public static class PersonExtensionMethods
{
    public static string GetFullName(this Person person)
    {
        return person.FirstName + " " + person.LastName;
    }

    public static string GetContactInfo(this Person person)
    {
        return person.GetFullName() + " " + person.Email;
    }
}