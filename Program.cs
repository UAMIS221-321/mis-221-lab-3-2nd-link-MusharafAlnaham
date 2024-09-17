//objective of this program: Recommend game based on preferred level of enjoyment

// Main
string enjoyment = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoyment);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);

// End main

static string GetEnjoymentLevel() {
    System.Console.WriteLine("Hi, what is your preferred level of enjoyment? (Boring, Average, Fun, Epic)");
    return Console.ReadLine().ToLower();
}

static string GetStadiumRecommendation(string enjoymentLevel) {
    if (enjoymentLevel == "boring") {
        return "Neyland Stadium";
    } 
    else if (enjoymentLevel == "average") {
        return "Jordan-Hare Stadium";
    } 
    else if (enjoymentLevel == "fun") {
        return "Tiger Stadium";
    } 
    else if (enjoymentLevel == "epic") {
        return "Bryant-Denny Stadium";
    } 
    else {
        return "Unknown Stadium";
    }
}

static string GetGameRecommendation(string stadium) {
    if (stadium == "Neyland Stadium") {
        return "Kent State";
    } 
    else if (stadium == "Jordan-Hare Stadium") {
        return "Kentucky";
    } 
    else if (stadium == "Tiger Stadium") {
        return "Alabama";
    } 
    else if (stadium == "Bryant-Denny Stadium") {
        return "Auburn";
    } 
    else {
        return "Invalid Game";
    }
}

static void DisplayStadiumDetails(string stadium, string game) {
    Console.Clear();
    System.Console.WriteLine($"You should watch {game} at {stadium}.");
}