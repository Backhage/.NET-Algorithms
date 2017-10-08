# .NET Algorithms Library
Contains various computer algorithms written for personal learning and development purpose. There is no guarantee that they are accurate and effective. Use them at your own risk.

## Categories
The algorithms are grouped into different categories depending on their usage.

### Sorting
Contains various algorithms for sorting data.

#### Insertionsort
Suitable for sorting small arrays where elements are highly likely to be close to sorted to begin with.
* Stable
* In place
* Worst case time complexity *O(N^2)*
* Worst case space complexity *O(1)*

#### Heapsort
Suitable for sorting large arrays where worst case time complexity must not exceed *O(NlogN)* and internal order between equal elements are not important.
In practice somewhat slower than Quicksort.
* Not stable
* In place
* Worst case time complexity *O(NlogN)*
* Worst case space complexity *O(1)*

#### Mergesort
Suitable for sorting large arrays where it is important to keep the internal ordering between elements with equal value.
Requires an additional array to be created to hold the data during sort. Hence, requires more memory than heapsort.
* Stable
* Not in place
* Worst case time complexity *O(NlogN)*
* Worst case space complexity *O(N)*

#### Quicksort
Quicksort is, just like the name implies, a fast sorting algorithm. In most cases it is 2-3 times faster than Mergesort. There are however certain conditions under which Quicksort runs in *N^2*. One example is if the data is already sorted.
* Not stable
* In place
* Worst case time complexity *O(N^2)* (though very rare, *O(NlogN)* on avarage)
* Worst case space complexity *O(1)*