# Codility-NumberOfDiscIntersections
We draw N discs on a plane.</br>
The discs are numbered from 0 to N − 1.</br>
An array A of N non-negative integers, specifying the radiuses of the discs, is given.</br> 
The J-th disc is drawn with its center at (J, 0) and radius A[J].</br>
We say that the J-th disc and K-th disc intersect</br> 
if J ≠ K and the J-th and K-th discs have at least one common point (assuming that the discs contain their borders).

The figure below shows discs drawn for N = 6 and A as follows:</br>
A[0] = 1</br>
A[1] = 5</br>
A[2] = 2</br>
A[3] = 1</br>
A[4] = 4</br>
A[5] = 0</br>
There are eleven (unordered) pairs of discs that intersect, namely:</br>
discs 1 and 4 intersect, and both intersect with all the other discs;</br>
disc 2 also intersects with discs 0 and 3.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given an array A describing N discs as explained above,</br> 
returns the number of (unordered) pairs of intersecting discs.</br> 
The function should return −1 if the number of intersecting pairs exceeds 10,000,000.</br>
Given array A shown above, the function should return 11, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..100,000];</br>
each element of array A is an integer within the range [0..2,147,483,647].
