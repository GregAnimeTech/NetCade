#include "StoryIntro.h"
#include "Story1.h"
#include "Character.h"
#include "Game.h"
#include "Hero.h"

void menu(int& c);
string GetTextFromUser(string prompt);
int GetNumbersFromUser(string prompt);


int  main()
{
	int choice;
	menu(choice);

	if (choice == 1)
	{
		//Information that will be used in the story.
		//Have to catch the input from user coming back from the functions.
		//Assign the inputs to the variables given, for later use.
		cout << "\nEnter some information to make your expierence more enjoyable. " << endl;
		string name = GetTextFromUser("\n\t\tWhat is your name: ");
		//Child class
		Hero UserName;
		//Actions the HERO can do
		UserName.SetGender();
		UserName.Talk();
		UserName.RollDice();
		//Bestfriend in the story
		string bestfriend = GetTextFromUser("\n\t\tName your best friend: ");
		//Using a reference to save the memory
		string& BF = bestfriend;
		//Base class
		Character BFName;
		BFName.SetGender();
		int number = GetNumbersFromUser("\n\t\tEnter a number that you like: ");
		//Pointer for the number's address
		int* pNumber;
		//Setting the pointer to the number
		pNumber = &number;
		//Pauses the system
		system("pause");
		//The intro to the story.
		intro(name, BF);
		//The main story
		theStory(name, pNumber);

		cout << "\n\n\t\tThis is the end of the program." << endl;
		system("pause");
	}
	else if (choice == 2)
	{
		cout << "You will be playing a game againts a computer." << endl;
		cout << "The game is all randomize so you will see the end result." << endl;
		system("pause");
		playTicTacToe(COMPUTER);

		cout << "\n\n\t\tThis is the end of the program." << endl;
		system("pause");
	}
	else
	{
		cout << "\n\tYou did random. " << endl;
		cout << "And you get to do nothing, GOOD JOB!" << endl;

		cout << "\n\n\t\tThis is the end of the program." << endl;
		system("pause");
	}
	return 0;
}

void menu(int& c)
{
	cout << "\n\t\t\t\t\tWelcome user!" << endl;
	cout << "In this program, you will have the option to chose what you want to do." << endl;
	cout << "There is a story that you can play through, a game you can play with the computer, and a random mode." << endl;
	cout << "It is all up to you!" << endl;
	system("pause");
	cout << "\n\tInput your choice (1 for story, 2 for game, 3 for random): ";
	cin >> c;

}

//Getting user's input
string GetTextFromUser(string prompt)
{
	string text;
	cout << prompt;
	cin >> text;
	return text;
}
//Getting the user's input
int GetNumbersFromUser(string prompt)
{
	int num;
	cout << prompt;
	cin >> num;
	return num;
}