# Unity enemy AI (simple path trajectory interception)
This Unity project demonstrates enemy AI for enemy movement using NavMesh and a path trajectory interception algorithm.

## Description
In this demo, enemies operate based on a baked mesh generated on the map and a familiar shortest path algorithm using ray casting on the 2D mesh. The navigation mesh is generated on a simple map in Unity.

In the path interception algorithm, each character has a velocity reporter that tracks the velocity with respect to real-world time. Using the velocity and direction of a player, an enemy character can predict the future position of that player and move to intercept instead of just following linearly.

## Features

- Enemy AI powered by NavMesh for intelligent movement.
- Path trajectory interception algorithm for predicting player movement and intercepting.
- Simple map showcasing the navigation mesh generation.

## Requirements
- Unity 3D

## Getting Started

To get started with the Unity Enemy AI Demo, follow these steps:

1. Clone the repository.
2. Open the Unity project in Unity 3D.
3. Open the main scene "EnemyAIDemo".
4. Place enemy prefabs and run the scene

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please feel free to submit a pull request or open an issue.

