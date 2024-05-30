# Description
This is an emulator for turn taking similar to Classic RPG games. Build in .Net8.

Units with a faster speed stat may lap slower units. 

It is designed to be magnitude agnostic. Speed must be in positive intigers but can be any number up to int.MaxValue. 

### Example:
Speed 100 and 120 will function the same as Speed 1 million and 1.2 million. 
As would 10 and 12. 
The faster unit lapping every 5th turn.

***The Engine.cs file is 50 lines of code. Has add, destroy and modify functionality. You can take that file and add it to any project you can think of just modifying what object it takes instead of my Unit.cs class.***

# Console
Build and run TakingTurns to have things visualized with a console application. The core code is in here also for reference or copying.

![alt text](https://github.com/DerekGooding/TakingTurns/blob/master/Console.png)

# WPF
Build and run TakingTurns.WPF to have a window with general visuals and a application style menu. It uses the logic directly from the console application. 

![alt text](https://github.com/DerekGooding/TakingTurns/blob/master/WPF.png)

# Math Explained
*There are several ways of creating a turn order in games. I in no way claim to have things perfected. This is just how I've decided to do it.*

Each character or Unit has a name and a speed stat. That speed can be any number from 1 to int.MaxValue (about 2 billion). 
When you create a new Engine object, it creates a tacker which is a list of Unit, int tuples. **List<(Unit unit, int time)>** 

Any new unit added to the Engine is added to the tracker with an initialized time value of zero. 

The turn order prediction is created by simulated a number of turns in advance. It copies the current Engine tracker and steps through it a number of times. 

When you actually take a turn (step), the tracker itself steps forward. Any future simulations are run using that new tracker info. 

### Tick Value
Some systems use a hard line value (100 or 1000) or divide 1 / speed value. Both run into problems as speed values approach excessive numbers. Might not matter for most games. Here, we're using the largest speed stat in the list as the tick value.  

### Step
When you take a step if no unit has a time at or over the tick value, we add each one's speed to the respective time value. Since our tick value is the fastest units speed, there will ALWAYS be one unit passing the tick line after a single calculation. (no while loop)

Then we order decending by time, grab the highest time Unit, lower it's time by the tick value and return that Unit. If there is a tie, it'll use the order they were added to the list (index) as with any list ordering. 

It's that simple. If more than one unit crosses the finish line (tick), the Step won't calculate the next time it's called, just grab the highest and process it. 

# Roadmap

- ~~Unit testing~~
- ~~WPF visualization~~
- Unity package with UI support
- Any suggestions are welcome
