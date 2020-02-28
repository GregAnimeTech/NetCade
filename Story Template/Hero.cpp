#include "Hero.h"

Hero::Hero()
{
}

void Hero::Talk()
{
	cout << "\n\n\tYour character says: This is where my adventure begins!" << endl;
	system("pause");
}

void Hero::RollDice()
{
	cout << "\n\nDo you want to roll some dice that could affect your adventure?\n";
	//Ask the user to enter their choice
	cout << "Yes or No?";
	//Makes a string varaible for their choice
	string choice;
	//Sets the chioce to the varaible
	cin >> choice;
	//If your chice is m
	if (choice == "Yes" || choice == "yes")
	{
		/* initialize random seed: */
		srand(time(NULL));
		int dice1 = (rand() % 6) + 1;
		int dice2 = (rand() % 6) + 1;
		cout << "\n\n\t You made the right choice!" << endl;
		cout << "\tThe first dice is: " << dice1 << " and the second dice is: " << dice2 << endl;
	}
	//If your choice is no
	else
	{
		cout << "\nOh, that's ok." << endl;
		cout << "Have a good adventure." << endl;
	}
	//Pauses the system
	system("pause");
}


Hero::~Hero()
{
}