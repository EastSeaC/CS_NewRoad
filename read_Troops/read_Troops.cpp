#include<iostream>

using namespace std;

typedef struct troop_Unit {
	string id;
	string name;
	string plural_name;
	int dopant;//用来存储结尾符号0
	int Troop_flags;
	int Scene;
	int Faction;
	int Inventory[64];
	int strength, agility, intelligence, charisma, starting_level;
	int wp_one_handed;
	int wp_two_handed;
	int wp_polearm;
	int wp_archery;
	int wp_crossbow;
	int wp_throwing;
	int Skills;
	
}longa;

typedef long long dl;
int main(void) {
	int a = 0xffffffff;
	cout << a;
	return 0;
}
