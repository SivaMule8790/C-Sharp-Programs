
using System;

class Program
{
    static void Main()
    {
        Tourist[] tourists = new Tourist[2];

        Console.WriteLine("Welcome to the National Park Guided Hike!");

        for (int i = 0; i < tourists.Length; i++)
        {
            Console.WriteLine("Tourist "+(i+1)+" - Please provide the following information:");
            tourists[i] = GatherTouristInfo(i + 1);
            Console.WriteLine();
        }

        DisplayTouristInformation(tourists);
    }

    static Tourist GatherTouristInfo(int touristNumber)
    {
        Console.Write("Full Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Emergency Contact: ");
        string emergencyContact = Console.ReadLine();

        Console.Write("Any Medical Conditions or Allergies (if any): ");
        string medicalConditions = Console.ReadLine();

        return new Tourist(name, age, emergencyContact, medicalConditions);
    }

    static void DisplayTouristInformation(Tourist[] tourists)
    {
        Console.WriteLine("Tourist Information for the Guided Hike:");
        Console.WriteLine("-----------------------------------------");

        for (int i = 0; i < tourists.Length; i++)
        {
            Console.WriteLine("Tourist " + (i + 1) + " Details:");
            Console.WriteLine("Name: " + tourists[i].Name);
            Console.WriteLine("Age: " + tourists[i].Age);
            Console.WriteLine("Emergency Contact: " + tourists[i].EmergencyContact);
            Console.WriteLine("Medical Conditions: " + tourists[i].MedicalConditions);
            Console.WriteLine("-----------------------------------------");
        }
    }
}

class Tourist
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string EmergencyContact { get; set; }
    public string MedicalConditions { get; set; }

    public Tourist(string name, int age, string emergencyContact, string medicalConditions)
    {
        Name = name;
        Age = age;
        EmergencyContact = emergencyContact;
        MedicalConditions = medicalConditions;
    }
}/*
Imagine you are a tour guide at a national park, and you are leading a group of tourists on a guided nature hike. 
You want to gather some basic information from each tourist to ensure their safety and provide them with an enjoyable experience.
As a tour guide at the national park, you need to collect essential information from each tourist before the hike. 
You decide to use the java.util package and the Scanner class to capture this data. 
Describe how you would use the Scanner class in this real-world scenario to gather the following information from each tourist:
Note : Use for loop to take data of 2 tourists 
Sample Test Case: 
Input :
Welcome to the National Park Guided Hike!
Tourist 1 - Please provide the following information:
Full Name: Ramesh
Age: 35
Emergency Contact: 1112223334
Any Medical Conditions or Allergies (if any): Fine
Tourist 2 - Please provide the following information:
Full Name: Raju
Age: 25
Emergency Contact: 7778889990
Any Medical Conditions or Allergies (if any): Fine
Output :

Tourist Information for the Guided Hike:
-----------------------------------------
Tourist 1 Details:
Name: Ramesh
Age: 35
Emergency Contact: 1112223334
Medical Conditions: Fine
-----------------------------------------
Tourist 2 Details:
Name: Raju
Age: 25
Emergency Contact: 7778889990
Medical Conditions: Fine
*/