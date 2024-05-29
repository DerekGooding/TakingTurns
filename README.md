# Description
This is an emulator for turn taking similar to Classic RPG games. Build in .Net8.

Units with a faster speed stat may lap slower units. 

It is designed to be magnitude agnostic. Speed must be in positive intigers but can be any number up to int.MaxValue. 

### Example:
Speed 100 and 120 will function the same as Speed 1 million and 1.2 million. 
As would 10 and 12. 
The faster unit lapping every 5th turn.

# Console
Build and run TakingTurns to have things visualized with a console application. The core code is in here also for reference or copying.

![alt text](https://github.com/DerekGooding/TakingTurns/blob/master/Console.png)

# WPF
Build and run TakingTurns.WPF to have a window with general visuals and a application style menu. It uses the logic directly from the console application. 

![alt text](https://github.com/DerekGooding/TakingTurns/blob/master/WPF.png)

# Roadmap

- ~~Unit testing~~
- ~~WPF visualization~~
- Any suggestions are welcome
- Possible Unity package
