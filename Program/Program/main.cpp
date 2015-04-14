#include <iostream>
#include <ctime>
#include <cstdlib>
using namespace std;

const int szr = 44;
const int szc = 52;
const int threshold = 122;

void init_matrix(int matrix[][szc]);
int avercomp_matrix(int matrix[][szc], int threshold);
int trace_matrix(int matrix[][szr]);
void fill_square_matrix(int matrix_to[][szr], int matrix_from[][szc]);

int main()
{
	int matrix[szr][szc];
	int matrix_square[szr][szr];

	init_matrix(matrix);
	int cells = avercomp_matrix(matrix, threshold);
	cout << "There Is/are " << cells << " cells\n";
	fill_square_matrix(matrix_square, matrix);
	int trace = trace_matrix(matrix_square);
	cout << "The trace is " << trace << "\n";

	return 0;
}

void init_matrix(int matrix[][szc])
{
	srand((unsigned)time(0));

	for (int r = 0; r < szr; r++)
	{
		for (int c = 0; c < szc; c++)
		{
			matrix[r][c] = rand() % 256;
		}
	}
}

void show_matrix(int matrix[][szc])
{
	for (int r = 0; r < szr; r++)
	{
		for (int c = 0; c < szc; c++)
		{
			cout << matrix[r][c] << ' ';
		}
		cout << "\n";
	}
}

int avercomp_matrix(int matrix[][szc], int threshold)
{
	int cells = 0;

	for (int r = 0; r < szr - 1; r++)
	{
		for (int c = 0; c < szc - 1; c++)
		{
			int total = 0;
			int average = 0;

			for (int subr = 0; subr < 2; subr++)
			{
				for (int subc = 0; subc < 2; subc++)
				{
					total += matrix[r+subr][c+subc];
				}
			}

			average = int(total / 2);
			if (average > threshold)
			{
				cells++;
			}
		}
	}

	return cells;
}

int trace_matrix(int matrix[][szr])
{
	int result = 0;

	for (int x = 0, y = 0; x < szr; x++, y++)
	{
		result += matrix[x][y];
	}

	return result;
}

void fill_square_matrix(int matrix_to[][szr], int matrix_from[][szc])
{
	for (int x = 0; x < szr; x++)
	{
		for (int y = 0; y < szr; y++)
		{
			matrix_to[x][y] = matrix_from[x][y];
		}
	}
}
