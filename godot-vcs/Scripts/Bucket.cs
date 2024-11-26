using Godot;
using System;

public partial class Bucket : Area2D
{
	[Export]
	private ScoreUi scoreUI;

    [Export]
    private int PointValue = 1;

    // Called when the node enters the scene tree for the first time.
    private void OnBodyEntered(Node2D body)
	{
        GD.Print("OnBodyEntered");
        scoreUI.IncrementScore(PointValue);
	}

}
