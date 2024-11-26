using Godot;
using System;

public partial class HelloWorld : Node2D
{
	[Export] Label timeLabel;
	double time;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		time += delta;
		timeLabel.Text = $"Time elapsed: {time:0.000}";
	}
}
