# SwapWithoutTemp15
A simple C# console application that demonstrates how to swap two integer values without using a temporary variable, using arithmetic operations and the ref keyword.

🚀 Features

Swap two integers without a third variable

Uses arithmetic (addition & subtraction)

Demonstrates call-by-reference (ref)

Beginner-friendly implementation

📌 Code Example
```csharp
void SwapNumbers(ref int a, ref int b)
{
    a = a + b;
    b = a - b;
    a = a - b;
}

// Usage
int x = 5, y = 10;
SwapNumbers(ref x, ref y);

Console.WriteLine($"x:{x}, y:{y}"); 
// Output: x:10, y:5
```
📁 Project Structure
```csharp
SwapWithoutTemp15/
 ├── Program.cs
 └── README.md
```
▶️ How to Run
Clone the repository:
```csharp
git clone https://github.com/BehsaRasouli/SwapWithoutTemp15.git
```
