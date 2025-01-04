#include<stdio.h>

void main() {

	static m;

	int x;

        int call(int);

	x = call(m);

	printf(" % d ", x);

	getch();

}

int call(int address) {

	address++;

	return address;

}
