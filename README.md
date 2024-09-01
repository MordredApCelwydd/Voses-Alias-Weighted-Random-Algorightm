# Voses-Alias-Weighted-Random-Algorithm

This is a C# implementation of the Vose's Allias weighted random algorithm, a lightweight algo with the complexity of O(n) in Big O notation.

Usage:
1. In order for the algo to yield accurate resuts, the sum of all passed values must be equal to 1.
2. Passing a reference to the initial list of values will result in the list being modified, be sure to create a copy of the list before passing it. 

Theory:
For more information, check out this awesome article about sampling from a discrete distribution by Keith Schwarz: https://www.keithschwarz.com/darts-dice-coins/
As well as own code of the algo in Java: https://www.keithschwarz.com/interesting/code/?dir=alias-method
