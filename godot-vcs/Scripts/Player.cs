using Godot;
using System;

public partial class Player : Node2D
{
    [Export] PackedScene Prefab;
    [Export] float Speed = 400;


    public override void _Process(double delta)
	{
        float moveX = Input.GetAxis("left", "right") * Speed * (float)delta;
        Translate(new Vector2(moveX, 0));

        if (Input.IsActionJustPressed("drop"))
        {
            Node2D instance = Prefab.Instantiate() as Node2D;
            AddChild(instance);

            GD.Print($"{instance.Name}: {instance.GlobalPosition}");
        }
    }
}
