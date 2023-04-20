## Quick Sort Algorithm

Quick Sort is an in place sort of an array that has a best case performance of `O(nlogn)` to what is possible a worst case performance of `O(n^2)`. Picking a bad pivot with the array could cause the worst case, though the average is that you should get the best case upper bound. Quick Sort is an recursive algorithm as well.

The first step is to "partition the array".

### Partioning

* First choose your pivot. Lets say value at highest index
* Start at -1 (really one below the low index)
* Loop from the lowest index to the highest index, don't include highest
* If the value we are on is `<=` the pivot, then we need to increase the index, and swap the value
* this partions the array the array so everything less than the pivot is to the left, and everything greater than the pivot is to the right
* Set the high value to the index
* set the index value to the pivot, and return the index. This is your pivot index


Now that we have our pivot index we can now divide this into two different arrays and quick sort over both of those arrays. Creating a recursive algorithm.

### Recursion

* First run QuickSort recursion on the left side of the array
* This is from the low index to the pivot index - 1
* Since this is recursion, we first need to check our base case
* If the low >= high then we know are good and can exit out
* If not, then we will re-partiion that smaller array and do the same thing. 
* keep recursing until you can no longer.
* Repeat for the right side of the array, pivot index + 1 to the high index
