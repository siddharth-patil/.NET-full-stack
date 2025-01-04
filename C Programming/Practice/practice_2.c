
#include <stdio.h>
int main() {
  int a, b, c, i = 0, n;
  printf("Enter how many pythagorean triples you want to print\n");
  scanf("%d", &n);
  if (n <= 0) {
    printf("You have to enter a number greater than zero\n ");
  } else {
    printf("Your %d pythagorean triples number are\n", n);
    for (c = 1; c <= 100; c++) {
      for (a = 1; a <= 100; a++) {
        for (b = 1; b <= 100; b++) {
          if (c * c == (a * a + b * b) && a < b) {
            printf("%d + %d + %d = %d\n", a, b, c, a + b + c);
            i++;
          }
          if (i == n) break;
        }
      }
    }
  }
  return 0;
}
