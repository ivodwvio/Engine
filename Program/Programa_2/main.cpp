#include <cstdlib>
#include <ctime>
#include <iostream>
using namespace std;

int main()
{
	srand((unsigned)time(0));
	int random_integer;

	for (int index = 0; index < 20; index++)
	{
		random_integer = (rand() % 256);
		cout << random_integer << endl;
	}

	return 0;
}
