#pragma once
#include <iostream>
#include <time.h>
#include <algorithm>

using namespace std;

#define COMPUTER 1 
#define HUMAN 2 
#define SIDE 3 // Length of the board 
// Computer will move with 'O' 
// and human with 'X' 
#define COMPUTERMOVE 'O' 
#define HUMANMOVE 'X'

class Game
{
};

void showBoard(char board[][SIDE]);
void showInstructions();
void initialise(char board[][SIDE], int moves[]);
void declareWinner(int whoseTurn);
bool rowCrossed(char board[][SIDE]);
bool columnCrossed(char board[][SIDE]);
bool diagonalCrossed(char board[][SIDE]);
bool gameOver(char board[][SIDE]);
void playTicTacToe(int whoseTurn);