# Train to Nowhere

Name: Eoin McMahon

Student Number: C19382426

Class Group: TU857/ DT211C

# Description of the project
A projection of a futuristic, holographic train set. Intended to be an emitter to be placed in the real world by passthrough to then project a train floating in a circlular pattern. The train would have an appropriate shader and sound effect, leaving a trail to enhance the aesthetic. The train could also be interacted with, moving it around with the quest controllers, with a diagetic controller in game for adjusting speed/ turning of the train.

Inspired by train sets, both for childrens toys and hobbyist simulator sets, while incorporating the aesthetics from the 6 million dollar man.

# How it turned out
Due to personal reasons, project ended up not incorporating all the intended features. The project is now a trian travelling a set path around the player, though the passthrough works, despite making it harder to see the train in game. The train still has the holographic shader while also simulating a hover movement and a free hover sound effect, though volume was adjusted to headphones and thus ended up being dronwed out in a crowded lab room.

# Instructions for use
Deployed to an oculus quest(1 or 2) headset, the project is ismply seeing a holographic train hover around the player, playing sound effects as it circles. The user was supposed to be able to interact with the train and choose whhere to place it in the real world, but the feature was cut due to self imposed time constraints.

# How it works
An empty game object generates a list of waypoints, instantiating the train model which has a movement script to follow these waypoints with a reasonable turning speed, a low magnitude sin function being added to the moveToward() function to simulate a classic hover effect.

Passthrough effect is achieved through oculus integration packages, with a passthrough layer on the OVR camerarig. It was initially configured to paint useable surfaces blue, but was forgotten and was left on when rendering a blue train model, making it harder to see the train in passthrough.

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| MyClass.cs | Self written |
| MyClass1.cs | Modified from [reference]() |
| MyClass2.cs | From [reference]() |

# References

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |

