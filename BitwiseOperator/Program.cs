using static System.Console;


var v = 0b0011;
var x = 0b0101;

WriteLine($"v = {v}\r\nx = {x}");
Write(v & x);
Write(v | x);
Write(v ^ x);
Write(v >> 2);
Write(v << 1);

// Use Logical Or for assignment of rights or elements in the enum
var features = Features.AirConditioning | Features.Brakes;
WriteLine(features);

// Test for Brakes
// How this works :) 
// first feature.Brakes is 1 is 0001 (in binary)
// second, the features assignment above is 5 or 0101
// third, the logical and of 0001 and 0101 is 0001 or 1 which equal Feature.Brakes which is 1 (0001)
// this is done on the bit level
if ((features & Features.Brakes) == Features.Brakes)
{
    WriteLine("has Brakes");
}

// Test for Air Conditioning
// How this works :) 
// first feature.AirConditioning is 4 is 0100 (in binary)
// second, the features assignment above is 5 or 0101
// third, the logical and of 0100 and 0101 is 0100 or 1 which equal Feature.AirConditioning which is 4 (0100)
// this is done on the bit level
if ((features & Features.AirConditioning) == Features.AirConditioning)
{
    WriteLine("has Air Conditioning");
}

void Write(int value)
{
    WriteLine($"{Convert.ToString(value, 2)} / {value} ");
}

// assign values based on binary values ie. 1011 -> going right to left, the first digit is 1, second digit is 2, third digit is 4, fourth is 8, ett.
enum Features
{
    None,
    Brakes=1,
    Radio=2,
    AirConditioning=4 // next element will be 8
}