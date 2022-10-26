## About
This project is a demonstration of a robot program that can navigate an arbitrary 2 dimensional grid by following a simple move set command.

Sample command string: LFLRFLFF

L: Turn the robot left\
R: Turn the robot right\
F: Move forward on it's facing direction


## Sample input

```
5x5
FFRFLFLF
```

When the robot initial position is set to 1,1 and North\
The robot final position and direction will be 
```
1,4,West
```

## Constraints
The robot will always start at X: 1, Y: 1 facing NORTH.\
If the robot reaches the limits of the plateau the command must be ignored.

There is no limit for the Plateau size\
Inputs will always be valid, so there is no need to validate them\
There is no 0,0 position

## Tests
Supplied test cases well covered all the robot functionalities and edge cases.
