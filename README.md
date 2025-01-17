[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects:
- UI (amount of seeds planted and amount you can plant)
    - When “seeds remaining” equals 0, the player can no longer create plant prefabs with the spacebar
    - Attributes: Text
    - Actions: Lower/increase count when player plants a seed
- Player
    - Movement 
        - Movement speed
        - WASD Keys
    - Can plant seeds with the spacebar 
        - Checks to see if seeds remaining is greater than or equal to 1 
        - Creates plant prefabs at player’s location
        - Lowers the # of available seeds in the UI
        - Increases the # of seeds planted in the UI
- The plants
    - Performs no actions
    - If the player code doesn’t affect the UI, the number of prefabs present can increase the planted seeds score using a list
    - Has a sprite and transform position
- The camera
    - Doesn’t move, just exists


## Devlog
I started by creating the plant prefab because it was the easiest to implement since according to the plan, it had no actions besides containing a sprite with a SpriteRenderer. Going into the code, I assigned the Player script to the Player GameObject, and the first thing I did was go into the Start method to define the values of _numSeedsLeft and _numSeedsPlanted. The plan mentioned that when the player creates a plant, the amount of seeds to plant would be lower while the number planted would increase, so I then went to the Player script's PlantSeed method. For the UI to change, I needed to lower and raise _numSeedsLeft and _numSeedsPlanted respectively, then send the UI information through the PlantCountUI's public UpdateSeeds method with the modified variables. I attatched the PlantCountUI to the Canvas, then added it to the Player's Plant Count UI while setting the Canvas' number children to be the script's Planted Text and Remaining Text.

When it came to the player's movement, I followed the plan to have movement speed be involved in translating _playerTransform, and I added in Time.deltatime just in case since I remember that being used last quarter. To respond to the player's input, the Vector involved in the translation used Input.GetAxis("horizontal") and Input.GetAxis("vertical") for horizontal and vertical movement respectively.

Something that wasn't detailed in the plan was how I'd create the plants at the player's position. I was able to instantiate the plants, but in order for them to stay at the location the player pressed the space button at, I had to make use of a Quaternion for the plant's rotation, which I've never done before. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Good job working from the least complicated to the most complicated thing- that's a good strategy for these projects in general.

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
