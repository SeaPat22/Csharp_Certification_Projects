string permission = "Manager";
int level = 65;

if (permission.Contains("Admin")) {
    Console.WriteLine((level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Manager")) {
    Console.WriteLine((level >= 20) ? "Contact an admin for access." : "You do not have sufficient privileges.");
}
else if (!permission.Contains("Admin") && !permission.Contains("Manager")) {
    Console.WriteLine("You do not have sufficient privileges.");
}

