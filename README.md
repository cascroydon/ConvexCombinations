# Convex Combinations

This program shows:

- a red cube interpolating between a start and end position
- a green cube interpolating between a different start and end position
- a small cube interpolating between those cubes and changing colour

## `InterpolatePosition.cs`

This script uses the `Vector3.Lerp` function to calculate a position vector from the start vector to the end vector as the value t moves from 0 to 1. Typically, a script like will animate platforms and lifts in 2D side-scrolling games.

Note: the `Mathf.PingPong` function takes a constantly increasing value (in this case, the time in seconds) and returns a value that goes from 0 to 1 and then back to 0 repeatedly.

## `InterpolateColour.cs`

This script uses the `Color.Lerp` function to calculate a colour value from a start colour to and end colour as the value t moves from 0 to 1. Typically, a script like this will flash colours to draw the player's attention to something in a game, such as a weak spot on an enemy.
