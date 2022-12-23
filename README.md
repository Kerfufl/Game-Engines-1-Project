# Train to Nowhere

Name: Eoin McMahon

Student Number: C19382426

Class Group: TU857/ DT211C

# Description of the project
A projection of a futuristic, holographic train set. Intended to be an emitter to be placed in the real world by passthrough to then project a train floating in a circlular pattern. The train would have an appropriate shader and sound effect, leaving a trail to enhance the aesthetic. The train could also be interacted with, moving it around with the quest controllers, with a diagetic controller in game for adjusting speed/ turning of the train.

Inspired by train sets, both for childrens toys and hobbyist simulator sets, while incorporating the aesthetics from the 6 million dollar man.

# How it turned out
Due to personal reasons, project ended up not incorporating all the intended features. The project is now a trian travelling a set path around the player, though the passthrough works, despite making it harder to see the train in game. The train still has the holographic shader while also simulating a hover movement and a free hover sound effect, though volume was adjusted to headphones and thus ended up being dronwed out in a crowded lab room.

Before gaining access to a headset, an augmented reality app for android was developed to better understand passthrough and AR development. This only progressed to placing a cube in the real world on compatible horizontal surfaces, with location anchors allowing for persistent instantiation of said objects.

# Instructions for use
Deployed to an oculus quest(1 or 2) headset, the project is ismply seeing a holographic train hover around the player, playing sound effects as it circles. The user was supposed to be able to interact with the train and choose whhere to place it in the real world, but the feature was cut due to self imposed time constraints.

The AR project builds to android devices using software 8.0 onwards for compatibility purposes. 

# How it works
An empty game object generates a list of waypoints, instantiating the train model which has a movement script to follow these waypoints with a reasonable turning speed, a low magnitude sin function being added to the moveToward() function to simulate a classic hover effect.
```csharp
void Update()
    {
        //Keeps track of next waypoint
        Vector3 curtar = br.waypoints[l];
        Vector3 totar = curtar - transform.position;
        //Prevents awkward rotation when sin wave is added
        totar.y =0;
        
        //Moves towards waypoint while hovering up and down
        gameObject.transform.position= Vector3.MoveTowards(transform.position, curtar, speed* Time.deltaTime) + (transform.up * Mathf.Sin(Time.time * 2)*.001f);
        
        //gameObject.transform.position = startPos + (Vector3.up * Mathf.Sin(Time.time * 2)*.2f);
        if (Vector3.Distance(transform.position,  curtar) < .5f)
        {
            l=(l +1) % br.waypoints.Count;
            
        }
        //Rotates the train towards the next waypoint smooth enough
        Quaternion q = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(totar), 1.5f * Time.deltaTime);
        transform.rotation = q;
    }
```

Passthrough effect is achieved through oculus integration packages, with a passthrough layer on the OVR camerarig. It was initially configured to paint useable surfaces blue, but was forgotten and was left on when rendering a blue train model, making it harder to see the train in passthrough.

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| holo_train.cs | Self written |
| waypoint_setup.cs | Self written |
| scifi_train(model) | From [Sketchfab](https://skfb.ly/6RCz6) |
| Hover_train(sound effect) | Edited from [Pixabay](https://pixabay.com/sound-effects/hovercar-76193/) |

# References

1. Scifi Train from Sketchfab: [https://skfb.ly/6RCz6](https://skfb.ly/6RCz6)
2. Hover_train from Pixabay: [https://pixabay.com/sound-effects/hovercar-76193/](https://pixabay.com/sound-effects/hovercar-76193/)
# What I am most proud of in the assignment

The model I sourced from Sketchfab had its vectors setup incorrectly, likely due to it being a conversion from blender to object file extension to work in unity. It took much tinkering without access to a 3d modeller, but I was able to attach this model to an empty game object to 'fix' the irections so that the forward vector was along the logical front of the object. Along with this, getting a small sin function to simulate a hover effect for the model was harder than expected, going particularly off the rails when using move toward. This was rectified by preventing rotations on the y axis to prevent the model from rotating awkwardly while moving up and down.

For the AR project, I managed to figure out AR anchors to lock objects in place, allowing for persistence even if the user were to leave the room and return. This would have strenghtened the vibe of a futuristic trinket/ toy on a table or cabinet.
# Proposal submitted earlier can go here:

## Game-Engines-1-Project
C19382426 Game Engines 1 2022-2023 repo for final assignment, AR scifi trainset

## Proposal
Scifi trainset, probably aesthetically based on 'world of tomorrow' era trains. Should allow you to place tracks in a given space with the quest pass through/ phone AR and place train with a personalised number of carriages to follow said tracks, or set train down first to make their own path. Some sort of *Train To No Where*

## Implementation
Train and carriages will be either found as existing models or generated through ai. In game, train can be spawned, with options of adding carriages as children which will match its movements. Scripts for following tracks or making their own path, possibly ways to react ot human intervention such as flying away when being picked up off the tracks.

Tracks can be standard tracks that are placed or a special *holo* version when the train is making them itself. Probably has a script for checking direction to help the train to rotate with the track correctly. Tracks can be placed before train is set into motion, no need to complete tracks to have fun *off the rails* moments.

If I have time, I might include a diagetic controller for the train to control the speed and maybe elevation of the train to let it fly off the rails, so to speak.

# Video Demonstration
[Short video demonstration](https://www.youtube.com/watch?v=J2kHSSFA4NU), no access to a headset so editor only.


