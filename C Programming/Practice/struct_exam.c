void display(struct student stud);

struct student{

	int roll;

	float marks;

};

void display(struct student stud){

	stud.marks = 76;

	stud.roll = 101;

}

int main()

{

	struct student s;

	s.roll = 201;

	s.marks = 68;

	display(s);

	printf("\n roll number = %d \n", s.roll);

	printf("\n marks %f \n", s.marks);

	return 0;

}
