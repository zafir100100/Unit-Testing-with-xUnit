## Unit-Testing-with-xUnit

This project is a simple C# calculator application containing basic arithmetic operations such as addition, subtraction, multiplication, and division. The calculator is implemented in the `CalculatorApp` console application, and the functionality is validated using unit tests written in the xUnit testing framework. The repository ensures that each operation is correctly implemented, and it also handles edge cases like division by zero. The unit tests validate each method of the `Calculator` class to guarantee correct behavior and improve maintainability.

## Video

https://github.com/user-attachments/assets/e32153a2-b616-425c-ad06-732d8f69d421

## Test Scenario - Step by Step

**Test Scenario: Validate Calculator Operations**

**Test 1: Addition**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Add` method with two numbers, `3` and `2`.
  3. Assert that the result equals `5`.

**Test 2: Subtraction**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Subtract` method with two numbers, `5` and `3`.
  3. Assert that the result equals `2`.

**Test 3: Multiplication**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Multiply` method with two numbers, `3` and `4`.
  3. Assert that the result equals `12`.

**Test 4: Division**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Divide` method with two numbers, `10` and `2`.
  3. Assert that the result equals `5.0`.

**Test 5: Division by Zero**
- **Test Steps:**
  1. Initialize the `Calculator` class.
  2. Call the `Divide` method with two numbers, `10` and `0`.
  3. Assert that a `DivideByZeroException` is thrown.

## Screenshot (Report)

![image](https://github.com/user-attachments/assets/b4c457a9-06e5-4529-92e7-348182296ada)
