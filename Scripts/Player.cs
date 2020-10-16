using Godot;
using System;
using System.Net;

public class Player : KinematicBody2D
{
    [Export] public float moveSpeed = 2f;

    public override void _Process(float delta)
    {
        

        if(Input.IsActionPressed("MoveLeft"))
        {
            MoveAndCollide(
                new Vector2(-moveSpeed, 0)
            );
        }
        
        if (Input.IsActionPressed("MoveRight"))
        {
            MoveAndCollide(
                new Vector2(moveSpeed, 0)
            );
        }
        
        if (Input.IsActionPressed("MoveUp"))
        {
            MoveAndCollide(
                new Vector2(0, -moveSpeed)
            );
        }
        
        if (Input.IsActionPressed("MoveDown"))
        {
            MoveAndCollide(
                new Vector2(0, moveSpeed)
            );
        }

        if (Input.IsActionPressed("Fire"))
        {
            
        }
        
    }
}
