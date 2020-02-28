#include "StoryIntro.h"

void intro(string name, string BF)
{
	cout << "\n\t\t\t\t\tThis is where your story begins!\n" << endl;
	cout << "*******************************************************************" << endl;
	//Setting the intro
	cout << "\n\nYou were out having fun with your friends, when out of nowhere you notice somebody running towards your group." << endl;
	cout << "Once the person was closer to you, you see that the guy is holding a knife and is still running towards your best friend." << endl;
	cout << "You protect " << BF << " from the random slasher in time, but the slasher hits you and stabs you on your side." << endl;
	cout << "You are in immense pain while, " << BF << " comes to your side to help you, but by that point you have lost a lot of blood and are dying." << endl;
	cout << "You know you will die so you tell " << BF << " your last message. \n\n" << endl;
	cout << "*******************************************************************" << endl;
	//Pauses the system
	system("pause");

	//Message choice
	Message(name);
	cout << "*******************************************************************" << endl;

	//Last of the intro
	cout << "\nWith your last breath, you finish telling " << BF << " your message and die. " << endl;
	cout << "As you feel yourself drift away from reality, you can hear a voice explaining things to you." << endl;
	cout << "You can't here the voice very well, but you still respond to it." << endl;
	cout << "The last thing you here and make out is:\n\n\t\tWelcome " << name << " to The Timeless Planet!!\n" << endl;
	cout << "This is where your new life will begin.\n\n" << endl;
	cout << "*******************************************************************" << endl;
	system("pause");
}
void Message(std::string& name)
{
	cout << "\n\n" << name << ", What do you want you dying message to be? " << endl;
	//Catches any wrong answer
	bool message = false;
	//Loop while the answer is not the one I want
	while (message == false)
	{
		//Ask the user to enter their choice
		cout << "Funny or Serious? ";
		//Makes a string varaible for their choice
		string usersChoice;
		//Sets the chioce to the varaible
		cin >> usersChoice;
		//If your chice is Fuuny
		if (usersChoice == "Funny" || usersChoice == "funny")
		{
			cout << "\nI need you to go to my computer and delete my brower's history. ";
			cout << "Then get rid of the evidence.\n" << "\n\t\tThank you.\n\n" << endl;
			message = true;
		}
		//If your choice is Serious
		else if (usersChoice == "Serious" || usersChoice == "serious")
		{
			cout << "\nTell my love ones, I love them. " << endl;
			cout << "\t\tThank you.\n\n" << endl;
			message = true;
		}
		//A catch all
		else
		{
			cout << "\nNot one of the choices. Try again\n" << endl;
			message = false;
		}
	}
	//Pauses the system
	system("pause");
}