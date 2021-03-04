BFME Particle System Viewer v1
Author: Philip Diffenderfer, aka {IP}Gil-Galad
Contact: freaklotr4@yahoo.com

What's this?
This program was developed by me to aid modders in creating and editting EA's The Battle for Middle Earth's 1 and 2 special effects
This version only supports the 'FXParticleSystem' type and not the 'ParticleSystem' type as of this version

Im having problems Running IT!!!
If you are having problems just starting this up it could be up to 3 things
-Framework
	-The required framework for windows is '.Net Framework v2.0' or better
	-To download the newest Framework heres a link
		@ http://www.microsoft.com/downloads/details.aspx?FamilyID=0856eacb-4362-4b0d-8edd-aab15c5e04f5&displaylang=en
-Managed Directx
	-The required Directx version is 9.0c, however you need Managed Directx to run it.
	-To Download Managed Directx heres a link
		@ http://www.microsoft.com/downloads/details.aspx?FamilyID=c72d9f1e-53f3-4747-8490-6801d8e8b4ef&DisplayLang=en
-Graphics Card
	-You have to have a decent graphics card to run at a good FPS

I get Errors while running the program!!!
If you get errors while running it all errors are deposited into "Errors.xml" in the 'Config' Folder at the executables location (you can view the error in notepad)
If you cant solve the problem yourself please feel free to email me and remember to send along the xml file.

To Do's:
-Particle Color
	-In this version the Coloring of the particle is off, it is being worked on, I promise
-Particle Alpha
	-In this version the Alpha (transparency) of the particle is also off, it is also being worked on.
-Particle System Rotation
	-When you rotate the bone in the center of the Particle System the System will adapt to the rotations and display it at its proper angles
	-Its used for when your attaching a Particle System to a bone, bones have a rotation and change the positions and direction of a particle
-Editting & Viewing Multiple Particle Systems
	-Ill be adding the functionalites of this in the next version
-Wind
	-Setup wind system
-Fix all "Not Supported in this Verson"
	-Where it says that below, it should be out on the next version

How to Use:
How to manipulate it so you get what you want!!!
Author: Me!

System:
Definition = Information thats set and affect the system as a whole, all values here apply to all particles in system
Priority =(ALWAYS_RENDER, CRITICAL, AREA_EFFECT, WEAPON_TRAIL, CONSTANT, SEMI_CONSTANT, 
	  DEATH_EXPLOSION, UNIT_DAMAGE_FX, DEBRIS_TRAIL, BUILDUP, DUST_TRAIL, SCORCH_MARK, WEAPON_EXPLOSION)
	-This is the priority for rendering the particle system in bfme, the most critical 'ALWAYS_RENDER' will however 
	  make it be rendered always
Shader = (ALPHA, ADDITIVE)
	-This is to tell the System how to display the particles, play with it to get different effects.
SystemLifetime = (Value)
	-This is the life of the Particle System in milliseconds, it only dies out at this time if 'IsOneShot' is set to 'Yes'
ParticleName = (TextureName.tga)
	-This is the name of the texture located in Textures.Big
IsOneShot = (Yes or No)
	-If Yes, this System will die in 'SystemLifetime' amount of milliseconds, however if you wish it to render the whole 
	  time you dont need to put this at all
IsGroundAligned = (Yes or No)
	-If Yes, the particles will align with the ground so their horizontal, however if you wish it not to be ground aligned, 
	  and always face the camera then you dont need to put this at all
SortLevel = (0 or 1)
	-This is by default 0, but can be set to 1. This function is unknown.
LifeTime = (Value Value)
	-This is the lifetime of the Particle in milliseconds, random between both values
Size = (Value Value)
	-This is the Size of the Particle, random between both values
InitialDelay =  (Value Value)
	-This is the Delay of rendering for the Particle System, set in milliseconds, random between both values
BurstDelay = (Value Value)
	-This is the delay inbetween the particles creation, set in milliseconds, random between both values
BurstCount = (Value Value)
	-This is the amount of particles to be created at each 'Burst' which happens every 'BurstDelay', set in whole numbers, 
	  random between both values
StartSizerate = (Value Value)
	-Not supported in this version, function Unknown
Color:
Definition = Color of a particle
Color# = (R:Value G:Value B:Value Value)
	-This is the color of the particle at the certain time
	-As the particle progresses in life, it sets the color to R,G,B and then sets the destination color to the color after the 
	  current one
	-Values range from (0-255), Time (last value) is in milliseconds
ColorScale = (Value Value)
	-Not supported in this version, function Unknown
Alpha:
Definition = Transpareny of the Particle
Alpha# = (Value Value Value)
	-This is the alpha (transparency) of the particle at the certain time
	-As the particle progresses in life, it sets the alpha to a random value between the first 2 Values, and then sets the 
	  destination alpha to the alpha after the current one
	-Values range from (0-invisible, 1-visible), Time (last Value) is in milliseconds
Update:
Definition = Values that effect attributes about the particle, happens every frame and continues along its life
SizeRate = (Value Value)
	-This is how the size progress in life, if negative the particle will shrink, if positive it will grow.
SizeRateDamping = (Value Value)
	-This is the damping, (acceleration) in which the sizerate increases. If 1, it will maintain a normal rate, If 1.01 or higher it will 
	  increase acceleration rate, if .99 or lower it will decrease acceleration rate.
AngleZ = (Value Value)
	-This is the Initial angle of the Particle (0-360), , random between both values
AngularRateZ = (Value Value)
	-This is the rate at which the angle of the particle changes, if negative it will move right, if positive it will move left, 
	  random between both values
AngularDamping = (Value Value)
	-This is the damping, (acceleration) in which the angularratez  increases. If 1, it will maintain a normal rate, If 1.01 or higher it will 
	  increase acceleration rate, if .99 or lower it will decrease acceleration rate.
Physics:
Definition = Values that effect the speed and direction of the particle along its life
VelocityDamping = (Value Value)
	-This is the damping, (acceleration) in which the velocity (speed) of a particle  increases. If 1, it will maintain a normal rate, If 1.01 or higher it will 
	  increase acceleration rate, if .99 or lower it will decrease acceleration rate.
Gravity = (Value Value)
	-This is the gravity of the particle, if positive the particle will rise, if negative it will fall, random between both values
DriftVelocity = (X:Value Y:Value Z:Value)
	-This is the 'Drift' of each particle, it will increment direction by these values.
EmissionVelocity:
Definition = speed and direction of the Particle
OrthoEmissionVelocity (X, Y, Z)
	X = (Value Value)
		-XVelocity random between both values
	Y = (Value Value)
		-YVelocity random between both values
	Z = (Value Value)
		-ZVelocity random between both values
OutwardEmissionVelocity (Speed, OtherSpeed)
	-Speed = (Value Value)
		-Shoots Particles away from Initial location at a value random from both values
	-OtherSpeed = (Value Value)
		-Not supported in this version, function Unknown
CylindricalEmissionVelocity (Radial, Normal)
	-Radial = (Value Value)
	-Norma = (Value Value)
EmissionVolume:
Definition = Initial Position of a particle
PointEmissionVolume (IsHollow)
	-IsHollow = (Yes or No)
		-Not supported in this version, function Unknown
SphereEmissionVolume (IsHollow, Radius)
	-IsHollow = (Yes or No)
		-If Yes, Particles will be designated on the shell of the sphere, if No, dont bother puting 
		  it the system, by default it makes them appear anywhere in the sphere
	-Radius = (Value)
		-Sets the radius of the sphere, which is half the spheres width (diameter)
CylinderEmissionVolume (IsHollow, Length, Radius, RadiusRate, Offset)
	-IsHollow = (Yes or No)
		-If Yes, Particles will be designated on the shell of the cylinder, if No, dont bother puting 
		  it the system, by default it makes them appear anywhere in the cylinder
	-Length = (Value)
		-Sets the height of the Cylinder
	-Radius = (Value)
		-Sets the radius of the cylinder, which is half the cylinders width (diameter)
	-RadiusRate = (Value Value)
		-Not supported in this version, function Unknown
	-Offset = (X:Value Y:Value Z:Value)
		-Sets the offset of the Cylinder relative to its actual location
LineEmissionVolume (IsHollow, StartPoint, EndPoint)
	-IsHollow = (Yes or No)
		-Not supported in this version, function Unknown
	-StartPoint = (X:Value Y:Value Z:Value)
	-EndPoint = (X:Value Y:Value Z:Value)
		-Particles location is set between these to points, to make a "Line"	
 BoxEmissonVolume (IsHollow, Halfsize)
	-IsHollow = (Yes or No)
		-Yes then Particles are on the outside of a box, If No dont bother including it, by default it will make it in the box anywhere
	-Halfsize = (X:Value Y:Value Z:Value)
		-X is the half the box Width, Y is half the box Depth, Z is half the box Height	


Wind:
Definition = Random values that effect the particles and emulates an actual environment
Not supported in this version, function not evaluated
Draw:
Definition =how to render the particle in the system
Not supported in this version, Only Default Draw is available

FXParticleSystem in a Nutshell
The Particle System is triggered...
It waits 'InitialDelay' amount of seconds...
'BurstCount' amount of particles are released every 'BurstDelay' amount of time...
particles are set to 'Size' and size increases 'SizeRate', 'SizeRate is multiplied by 'SizeDamping'.....
particle rotation is set to 'AngleZ' and it increases 'AngularRateZ', 'AngularRateZ' is multiplied by 'AngularDamping'....
particles position is determined by 'EmissionVolume'....
particles velocity is determined by 'EmissionVelocity', that is multiplied by 'VelocityDamping'...
particles positon adds 'DriftVelocity' to its position, and Adds 'Gravity' to its ZLocation
If 'IsOneShot' and 'SystemLifetime' is up then System Dies, particles stop being produced and existing die.