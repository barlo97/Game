# Creating a Cube & Adding Movement & Camera Follow 

The first thing that I need to do is to create a cube and a platform. A Cube should have a letter designed on it in the future. 

Auto complete in VS 2019 with Unity -\
1.Ensure Game Development with Unity is installed with VS. \
2.Go to Edit -- Preferences -- External Tools -- Script Editor (set to VS 2019)


## Update Vs Fixed Update Methods vs Late Update 

**Update**
Update is called once per frame
A computer draws an image multiple times a second 
If this method is called once per frame this means that it will run slower
on the slower computer and faster on the faster computer. A frame is a single, still image 
displayed by a computer that is generated a certain amount of time per second 
depending on how good our computer is. One computer may generate more frames per second
than the other - that is why this Update method if called once per frame will depend 
on how good our computer is. Better PC means more FPS - meaning less time between frames. 
For example If a computer runs at 100 FPS this Update is called 100 times. 


**FixedUpdate**
I am using FixedUpdate (for the rigid body component), which is better when using
physics. FixedUpdate Update runs once per frame. FixedUpdate can run once, zero, or several times 
per frame, depending on how many physics frames per second are set in the time settings, 
and how fast/slow the framerate is.FixedUpdate is used for being in-step with the physics engine, 
so anything that needs to be applied to a rigidbody should happen in FixedUpdate.

FixedUpdate can run once, zero, or several times 
per frame, depending on how many physics frames per second are set in the time settings, 
and how fast/slow the framerate is.FixedUpdate is used for being in-step with the physics engine, 
so anything that needs to be applied to a rigidbody should happen in FixedUpdate. iT is called
before the Update method. It is different to Update because it is called a guaranteed set number 
of times per second. So it's not dependent on the framerate like Update. We can
set how many times we want the FixedUpdate method to be called. Open Unity and go to project settings
then --> time --> and fixed timestep. Timestep is simply a time that Unity will wait in between 
the FixedUpdated calls. By changing fixed timestep value we can shorten or extend this time. 
Since we know that this value is the duration between the FixedUpdate calls we can do a simpley calculation
to see how many times our FixedUpdate will be called: For example if we set the timestep to be 0.02, we will simply
divide 1000ms/0.02 = 50. It will be called 50 times per second.

**LateUpdate**
LateUpdate is called after all Update functions have been called. This is useful to 
order script execution. For example a follow camera should always be implemeneted in here
because it tracks objects that might have moved inside Update. All of the code inside the Update method 
will be executed before the LateUpdate is called. By the time LateUpdate is called
our cube has already moved. 




## Time.deltaTime 

**Time.delta time** is the completion of seconds since the last frame.\
It is used to even out the performance of the game. The code inside \
the Update method will be excecuted depending on how many times\
the Update method was called. For example if our computer is running at\
60 FPS it will be excecuted 60 times. So it will be: \
60 * (0,0,200) = 12000 units per second. \
If a computer runs at 100 FPS this would be: \
100 * (0,0,200) = 20000 units per second. 

**Units per second** in unity refers to the velocity of an object. 
For example if I have an object with coordinates (0, 0, 0), 
set its velocity to (1.0f, 0, 0) and wait 10 seconds, 
it will be at (10.0f, 0, 0).
Regarding what's a "grid unit" in meters: That depends on what you want it to be in your game. In a game where you build a space empire, it could be 1 light-year. In a game where you control a bacteria, it could be 1 µm. But the default assumption seems to be 1 meter. 1m = 1 unit is the scale of most assets you will find on the asset store. Also, the default value for gravity is 9.81f, which would be the value you would expect if your game uses a 1m scale and takes place on the surface of planet Earth.



**Delta Time formula is: 1 / Framerate**
So If my computer runs at 100 FPS this would be: 1 / 100 = 0.01\
Or if my computer runst at 60 FPS this would be: 1 /60 = 0.016666666666667\
So for the computer that runs at 100 FPS the new result would be:\
100 * (0,0,200) * 0.01  = 200 units per second\
60* (0,0,200) * 0.016666666666667 = 200 units per second

So now we can see how time.delta is used to even out the performance and 
get the precise representation of how the objects are moving. We use it to make sure
that the game functions the same when it comes to a speed of certain elements of the game an all computers. 

         
**Movement**

To get a better feel for the movement we can use ForceMode.VelocityChange with the AddForce method. 
VelocityChange directly changes the velocity of the object and ignores the mass. So it means that I can directly change the speed at which my cube will be moving left and right when I press arrow keys. 

We can also use change the value of Drag inside the Rigidbody component. Drag is the air resistance - meaning the higher the value of Drag the higher the air resistance will be. 

<div align="right"> 

[Next Page -->](./Piano.md) 

</div>
