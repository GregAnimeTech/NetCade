#include "Character.h"
Character::Character()
{
	cout << "\n\tYou made a charater for your story!\n\n";
	system("pause");
}

void Character::SetGender()
{
	cout << "\n\nWhat is your character's gender? " << endl;
	//Catches any wrong answer
	bool cha = false;
	while (cha == false)
	{
		//Ask the user to enter their choice
		cout << "m or f?";
		//Makes a string varaible for their choice
		string choice;
		//Sets the chioce to the varaible
		cin >> choice;
		//If your chice is m
		if (choice == "m")
		{
			cout << "\n\tYour gender is Male." << endl;
			cha = true;
		}
		//If your choice is f
		else if
			(choice == "f")
		{
			cout << "\n\tYour gender is Female." << endl;
			cha = true;
		}
		else
		{
			cout << "\nI did not chatch that." << endl;
			cout << "There is only TWO genders." << endl;
			cout << "Try again." << endl;
		}
		//Pauses the system
		system("pause");
	}
}


Character::~Character()
{
}