# Zelda-base

A learning project about the base of a action-adventue like zelda made in Unity. This project is based on the video tutorials [Make a game like the Legend of zelda using Unity](https://www.youtube.com/playlist?list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu) although it has many differences on script level and organization. For this project I am trying to [separate things by domain concepts](https://medium.com/@larribas/5-ways-to-make-your-codebase-withstand-the-test-of-time-9f9192ff1763) as a test to see if its more efficient, for now its a bit messy but I will try to organize things better as the project goes.

## Topics in the project
This project objective is to be a learning tool and a full base for development of a game similar to zelda a link to the past, that being said I don't like overusing comments in the code, i prefer to leave it  readable. I will be using the github wiki for the full documentation. In this project will be used:

- Animator state machine and StateMachine behaviours (no enums as state machines)
- Cinemachine
- [Super Tiled2Unity](https://github.com/Seanba/SuperTiled2Unity) as I like the workflow better than the unity tilemap system
- Scriptable objects as signals based on [NeoDragonCP implementation](https://github.com/NeoDragonCP/Unity-ScriptableObjects-Game-Events-)
- iTween

## Controls
I plan to implement a way to change inputs at some point but for now these are the controls:

| Action   | Input                    |
|----------|--------------------------|
| Movement | directional keys or WASD |
| interact | z                        |
| attack   | x                        |
| dash     | left shift               |