#include "Story1.h"

void theStory(string name, int* pNumber)
{
	//Giving the main story to the person
	cout << "\n\nIt's dark.  You can't see anything in this total darkness. ";
	cout << "Where is this? Rather ... what happened? " << endl;
	cout << "If I remember correctly, I think I died ... You recall what had happened to you." << endl;
	cout << "And then remember the conversation you had with the voice." << endl;
	cout << "In the conversation the voice was explaining your situation and how you will be reincarnated in a new world, completely different from your orignal world. " << endl;
	cout << "A world of magic, magical creatures, and dangerous monsters. A world strait out of a fantasy game. " << endl;
	cout << "You got to pick the number of skills and abilities that you get to have in your new life, and you choose: " << *pNumber << ".\n";
	cout << "*******************************************************************" << endl;
	//Using the number the user entered before.
	Skills(pNumber);
	cout << "*******************************************************************" << endl;
	system("pause");
	//Ending the story
	Ending();
	//Pauses the system
	system("pause");
	//Thanks the user for playing
	cout << "*******************************************************************" << endl;
	cout << "\n\n\t\t\tThank you for playing!\n\n" << endl;
}

void Skills(int* pNumber)
{
	if (*pNumber <= 30)
	{
		cout << "\nYou will use all your skills and remember them throughout your adventure. \n" << endl;
	}
	else if (*pNumber > 30)
	{
		cout << "\nYou will use the skills that are you favorite and eventually forget the rest throughout your adventure. \n" << endl;
	}
}

void Ending()
{
	cout << "\n\nIf you don't like the number of skills that you have, then you can change it. " << endl;
	//Catches any wrong answer
	bool change = false;
	//Loop until you give the right answer
	while (change == false)
	{
		cout << "\tYes or No? ";
		string userChoice;
		cin >> userChoice;
		//If your choice is yes
		if (userChoice == "Yes" || userChoice == "yes")
		{
			cout << "\n\nYou chose wrong." << endl;
			cout << "You are dead. Game Over." << endl;
			cout << "You can't go and change the past in life.\n\n" << endl;
			change = true;
		}
		//If your choice is no
		else if (userChoice == "No" || userChoice == "no")
		{
			cout << "\n\nYou choose correct, NEVER second guess yourself in life. " << endl;
			cout << "You meet new people and go on amazing  adventures with your new friends. \n\n" << endl;
			change = true;
		}
		//Catch all
		else
		{
			cout << "Are you even trying? ";
			cout << "There was 2 easy answers (Yes or No) to this.";
			cout << "Do it again.\n" << endl;
			change = false;
		}
	}
}
