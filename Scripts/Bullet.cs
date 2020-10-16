using Godot;
using System;


public class Bullet : KinematicBody2D
{
    MouseAngle mouseAngle = new MouseAngle();
    
    [Export] public Vector2 firePoint;
    [Export] private float moveSpeed;

    public override void _Process(float delta)
    {
        GlobalPosition = firePoint;
        MoveAndCollide(new Vector2(1, 1)*mouseAngle.aimAngle);
        
        
        
    }
}
