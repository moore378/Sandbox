using static System.Console;


var y = 0b0011;
var x = 0b1101;

var a = y << 2;

WriteLine("Left Binary Shift Operator");
WriteLine($"y = {y}"); //0011
Write(y); //3
WriteLine("Shift 2");
WriteLine($"Answer: {a}");
Write(a); // 1100

a = x >> 2;

WriteLine("Right Binary Shift Operator");
WriteLine($"x = {x}"); //1101
Write(x); //3
WriteLine("Shift 2");
WriteLine($"Answer: {a}");
Write(a); // 0011

void Write(int value)
{
    WriteLine($"{Convert.ToString(value, 2)} / {value} ");
}