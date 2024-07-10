// int[] numArray = new int[9];

// int[] numArray2 = {1,2,3,4,5,6,7,8,9};


List<string> names = new List<string>();

names.Add("Tim");
names.Add("Martin");
names.Add("Nikki");
names.Add("Sara");


    // bool[] booleanArray = new bool[10];

    //     for (int i = 0; i < booleanArray.Length; i++)
    //     {
    //         booleanArray[i] = i % 2 == 0;
    //     }
    //     foreach (bool value in booleanArray)
    //     {
    //         Console.WriteLine(value);
    //     }


List<string> iceCreams = new List<string>();

iceCreams.Add("vanilla");
iceCreams.Add("Green Tea");
iceCreams.Add("Banana Foster");
iceCreams.Add("Cookies Cream");
iceCreams.Add("Cotton Candy");
iceCreams.Add("Passion Fruit");
iceCreams.Add("Pistachio");
iceCreams.Add("Spumonio");
iceCreams.Add("Grape Nuts");
iceCreams.Add("Passion Fruit");

//  Console.WriteLine(iceCreams.Count);


// Console.WriteLine(iceCreams[2]);

// Console.WriteLine(iceCreams.Count);
// iceCreams.RemoveAt(2);

// Console.WriteLine(iceCreams[2]);

// Console.WriteLine(iceCreams.Count);

// for(int i = 0; i < icecreams.Count; i++){
//     Console.WriteLine(icecreams[2]);
// }



        // string[] names = { "Tim", "Martin", "Nikki", "Sara",};


        // string[] flavors = { "Vanilla", "Cotton Candy", "Spumonio", "Banana Foster" };

        Dictionary<string, string> userDictionary = new Dictionary<string, string>();
        
        Random rand = new Random();

for(int i = 0; i < names.Count; i++){
    userDictionary.Add(names[i], iceCreams[rand.Next(iceCreams.Count)]);
}

foreach (var i in userDictionary){
    Console.WriteLine($"{i.Key} likes {i.Value} ice creams.");
}

