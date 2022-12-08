using DevBuildRPGRolePlayingGame;

Console.WriteLine("Welcome to World of Dev.Buildcraft!");

//List of type GameCharacter  called "gameCharacters" 

List<GameCharacter> gameCharacters = new List<GameCharacter>();

Warrior spartacus = new Warrior("Spartacus", 100, 75, "sword");
gameCharacters.Add(spartacus);
Warrior achilles = new Warrior("Achilles", 80, 95, "diatrekhon");
gameCharacters.Add(achilles);


Wizard merlin = new Wizard(9, "Merlin", 65, 85, 95);
gameCharacters.Add(merlin);

Wizard gandalf = new Wizard(7, "Gandalf", 50, 90, 90);
gameCharacters.Add(gandalf);

Wizard voldemort = new Wizard(10, "Voldemort", 25, 100, 100);
gameCharacters.Add(voldemort);

foreach(GameCharacter character in gameCharacters)
{
    character.Play();
}