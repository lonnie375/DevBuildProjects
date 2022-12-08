using Assessment3_ljohnson3;
using System.Linq;

//1. Initialize a list of SiftMembers and is populated with at least one member and a skill 
List<SiftMember> members = new List<SiftMember>();


SiftMember generic = new SiftMember("Lonnie Johnson", "Engineer", new DateTime(1989, 10, 04), "lonnie@gmail.com", new List<string> {"Github"});
members.Add(generic);

//2. Give user the ability to add a new SiftMember object to the list 

bool proceed = true;
while (proceed)
{

    Console.WriteLine("Welcome to Sift, what would you like to do?");

    //Display options 
    Console.WriteLine("1. Add a team member");
    Console.WriteLine("2. Search for a team member and add skills");
    Console.WriteLine("3. Print all members");
    Console.WriteLine("4. Quit");
    Console.Write("Select an option: ");
    string userInput = Console.ReadLine();
    int userChoice;
    bool correction = int.TryParse(userInput, out userChoice);

    if (userChoice == 1)
    {

        Console.Write("Enter the team member's name: ");
        string memberName = Console.ReadLine().ToLower();

        Console.Write("Enter their job title: ");
        string memberTitle = Console.ReadLine().ToLower();

        Console.Write("Enter their email: ");
        string memberEmail = Console.ReadLine().ToLower();

        Console.Write("Enter their anniversiary (MM dd yyyy): ");
        DateTime memberDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter a skill: ");
        string userSkill = Console.ReadLine().ToLower();

        //SiftMember userSkills = new SiftMember();
         //userSkills.skills.Add(userSkill);

  
        SiftMember member = new SiftMember(memberName, memberTitle, memberDate, memberEmail, new List<string> {userSkill});
        members.Add(member);

    }
    else if (userChoice == 2)
    {

        SiftMember skill = new SiftMember();

        Console.Write("Enter the full name of the person you'd like to search for: ");
        string searchPerson = Console.ReadLine().ToLower();

     

        //var membersContains = members.Where(x => x.name == searchPerson.ToLower()).ToList();

        bool correctName = false;
        while (correctName == false)
        {
            bool test = members.Any(x => x.name.ToLower() == searchPerson);

            if (test)
            {
                Console.WriteLine("he is here");
                correctName = true;
            }
            else
            {
                Console.WriteLine("Please try again");
                searchPerson = Console.ReadLine().ToLower();
            }

            //foreach (SiftMember skills in members)
            //{
            //    if (skills.name.ToLower() == searchPerson)
            //    {
            //        Console.WriteLine("He is here");
            //        correctName = true;
            //    }
            //    else
            //    {
            //        Console.Write("This member is not found. Please enter a member that is on the list: ");
            //        searchPerson = Console.ReadLine().ToLower();
            //    }

            
        }


        bool addSkill = true;
        while (addSkill)
        {
          

            Console.Write("Enter a skill, enter 'q' to stop adding skills: ");
            string skillSearch = Console.ReadLine().ToLower();



            if (skillSearch != "q" ) 
            {
                SiftMember addingSkills = new SiftMember();
                addingSkills.skills.Add(skillSearch);
                Console.WriteLine($"Added {skillSearch} to {searchPerson} "); 
            }
            else
            {
                addSkill = false;
            }
        }
    }
    else if (userChoice == 3)
    {
        foreach (SiftMember member in members)
        {
            Console.WriteLine(member.ToString());
        }
    }
    else
    {
        proceed = false;
        Console.WriteLine("GoodBye!");
    }
}






