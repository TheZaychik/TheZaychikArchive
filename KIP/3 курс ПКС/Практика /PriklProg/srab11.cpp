#include <stdio.h>

// вариант 10
int main() {
    unsigned char a, b, c, d;
    a = 36 & 12;
    b = 36 ^ 12;
    c = 36 << 3;
    d = (! -3 ^ 15 & (14 | ! -16));
    printf("36 AND 12 = %i\n", a);
    printf("36 XOR 12 = %i\n", b);
    printf("36 ← 3 = %i\n", c);
    printf("36 ← 3 = %i\n", d);
    return 0;
}