/*Random random = new Random();
int attack;
int heroHealth = 10;
int monsterHealth = 10;

do {
    attack = random.Next(1, 11);
    monsterHealth = monsterHealth - attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
    attack = random.Next(1, 11);
    heroHealth = heroHealth - attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth <= 0) {
    Console.WriteLine("Monster wins!");
}
else if (monsterHealth <= 0) {
    Console.WriteLine("Hero wins!");
}*/
//////////////////////////////////////////////////
//////////////////////////////////////////////////

/*string? readResult;
int numericValue = 0;
bool validNumber = false;
do {
    Console.WriteLine("Enter a number between 5 and 10:");
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (!validNumber) {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }
    else if (numericValue >= 5 && numericValue <= 10) {
        Console.WriteLine($"Your input value ({readResult}) has been accepted.");
    }
    else {
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
    }
} while (numericValue < 5 || numericValue > 10);*/
/////////////////////////////////////////////////////
/////////////////////////////////////////////////////

/*string? readResult;
string? role;
Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
do {
    readResult = Console.ReadLine();
    role = readResult.Trim().ToLower();
    if (role != "administrator" && role != "manager" && role != "user") {
        Console.WriteLine($"The role name that you entered, {readResult.Trim()} is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (role != "administrator" && role != "manager" && role != "user");

switch (role) {
    case "administrator":
        Console.WriteLine($"Your input value ({readResult.Trim()}) has been accepted.");
        break;
    case "manager":
        Console.WriteLine($"Your input value ({readResult.Trim()}) has been accepted.");
        break;
    case "user":
        Console.WriteLine($"Your input value ({readResult.Trim()}) has been accepted.");
        break;
}*/
/////////////////////////////////////////////////////
/////////////////////////////////////////////////////

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++) {
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1) {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}