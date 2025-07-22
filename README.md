# cpp_HexMap
Console Hex Map Demo (Offset Grid)

A simple C# console application demonstrating a hexagonal map layout using an offset coordinate system.

X1,X2
X3,X4

This is a basic console-based visualization of a 4x4 hexagonal map using offset rows (odd rows are indented).
It simulates map zones (x1, x2, x3, x4) and randomly selects a starting zone for the player character [P].
The map layout adjusts display formatting to mimic a hex-like structure in plain text.


💡 Features
-Simple 2D hex map simulation using offset rows
-Randomly selects a starting zone from predefined groups
-Highlights the starting zone and the player's position with color
-Console output only (no graphics, great for learning or prototyping logic)

🛠 Technologies Used
C# (.NET Console Application)
No external libraries required

✅ Example Output

logs: P spawned in Zone 3 at (x=1, y=2)


[ ] [ ] [ ] [ ] 

  [ ] [ ] [ ] [ ] 
  
[ ] [P] [ ] [ ] 

  [ ] [ ] [ ] [ ] 
  

[ Press Enter to exit ]
