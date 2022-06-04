# What have I done so far? 

I have learned about different ways of working with objects. 

I learned about **Vectors, public variables, fix update, update and late update, ways of adding force to my objects and moving objects left and right, smooth camera follow, inputs from the keyboard and the actions that take after those inputs, delta time, the order of update methods calls, more about frames per second, units per second in Unity, setup of different settings, adding scripts, adding objects to scripts, manipulating the shape of the objects, adding drag - so air resistance to our object, controlling the camera, adding physics material to my object and changing the frictions of the object - e.g platform as well as adding color to objects and found out information about different modelling softwares such as blender or gimp**

The Next steps I need to take: I need to model the piano and add it to the game. 


## New things added OR learned:

**Unity**
1.Added new layer "Platform" to the Platform and locked it so that it won't select for me the platform in the scence. This way I can just select all of the objects in the scene without worrying about the platform. 
2.Snap setting - located directly above the scene - set to 2 so that they move every two units - ctrl + move the the object. 



**Cs**
1.ForceMode - 4th parameter of the AddForce method. It allows to specify how to apply force to our object. I used ForceMode.VelocityChange To get a better feel for the movement we can use ForceMode.VelocityChange with the AddForce method. VelocityChange directly changes the velocity of the object and ignores the mass. So it means that I can directly change the speed at which my cube will be moving left and right when I press arrow keys. 



