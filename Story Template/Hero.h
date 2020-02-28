#pragma once
#include "Character.h"
#include <time.h> 

class Hero :
	public Character
{
public:
	Hero();
	void Talk();
	void RollDice();
	~Hero();
};