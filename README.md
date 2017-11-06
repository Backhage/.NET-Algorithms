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

### Graphs
Contains data structures and algorithms to work with graphs.

#### Data Structures
The most common data structure for Graphs are the Vertex. A number of vertices and edges is what makes a Graph.

##### AbstractVertex
This is a simple base class for vertices. It is abstract and cannot be instantiated on its own. Instead it is intended to be used as a base for more specific vertex classes.

##### BFSVertex
A vertex class that can be used when performing Breadth First Search.

#### Algorithms
There are some well known and really useful algorithms that works on Graphs. Known graph problems are "Shortest path" and "The traveling salesman problem".

##### Breadth First Search
The Breadth first search algorithm (BFS) can be used for finding the shortest path between two vertices in an undirected and unweighted graph. One example of a relationship that can be represented with such a graph is a network of friends, for example on social media.

### Dynamic Programming
Dynamic Programming (DP) is a method for solving complex problems by breaking them down into simpler subproblems, solving them, and storing (memoizing) the solution.
The next time the same subproblem occurs the solution can be quickly looked up instead of re-computed.

#### Large Fibonacci numbers
Calculating a Fibonacci sequence is often used as an introduction to recursion since it is defined as *F(1) = F(2) = 1; F(n) = F(n-2) + F(n-1)*. However, implementing this algorithm recursively without much thought will lead to an exponential function where calulation of larger n will be painfully slow.

Included in this library is a version of the Fibonacci algorithm that runs in *O(n)* and uses minimal extra space.