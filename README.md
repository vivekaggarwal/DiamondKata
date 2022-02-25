# Diamond Kata

## Problem Description

Given a letter, print a diamond starting with ‘A’ with the supplied letter at the widest point.

For example: Passing in 'C' will result with

```
  A
 B B
C   C
 B B
  A
```
  
## Analysis
THere are two main things that need to be understood: 

1. the outer padding (ie. padding needed before a letter is placed in the correct position)
1. the inner padding (ie. the padding required between two letters which are the same and not the first letter)

For example

```
				Outer	Inner
A				0		0


-A-				1		0				
B-B				0		1

--A--			2		0
-B-B-			1		1
C---C			0		3

---A---			3		0
--B-B--			2		1
-C---C-			1		3
D-----D			0		5

----A----		4		0
---B-B---		3		1
--C---C--		2		3
-D-----D-		1		5
E-------E		0		7

-----A-----		5		0
----B-B----		4		1
---C---C---		3		3
--D-----D--		2		5
-E-------E-		1		7
F---------F		0		9

```
We observe the the outer padding is 1 minus the index of the alphabet letter (ie. E is in the 5th index, so the outer padding starts at 4). We also observe the inner values are odd numbers that start with 0, and proceed accordingly. The general formula for an odd number is 2X-1 where x is the index number.

This completes the first half of the diamond. To complete the diamond, taking all the rows minus the middle row, reversing it and adding to the existing diamond will complete the diamond.
