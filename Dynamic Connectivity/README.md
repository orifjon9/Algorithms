## Dynamic Connectivity

## Union-Find

### QuickFind

#### Given a set of N elements
- Union: connect two elements
- Connected: is there a path connecting the two elements?

Components: { { 0 } { 1 } { 2 } { 3 } { 4 } { 5 } { 6 } { 7 } { 8 } { 9 } }

- Union(4, 9)
- Union(3, 4)
- Union(1, 2)
- Union(2, 7)
- Union(0, 1)

Components: { { 0, 1, 2, 7 } { 5 } { 6 } { 3, 4, 9 } { 8 } }

- Connected(1, 2) is true
- Connected(0, 7) is true
- Connected(0, 9) is false
- Connected(3, 4) is true
- Connected(5, 6) is false


|Algorithms	       |   Initialize	|   Union    |   Find      |
|:-----------------|:---------------|:-----------|:------------|
|Quick-Find        |  N             |   N	     |   1         |
|Quick-Union       |  N             |   N t	     |   N         | 



t - includescost of finding root
