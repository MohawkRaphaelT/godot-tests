using Godot;
using System;

public partial class Disk : RigidBody2D
{
	bool isDropped = false;
	float speed = 400;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!isDropped)
		{
			float moveX = Input.GetAxis("left", "right") * speed * (float)delta;
			Translate(new Vector2(moveX, 0));

			if (Input.IsActionJustPressed("drop"))
			{
				isDropped = true;
				Freeze = false;
			}
		}
	}

}
