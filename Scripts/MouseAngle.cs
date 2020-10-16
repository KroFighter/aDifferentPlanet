using Godot;
using System;

public class MouseAngle : Node2D
{
    public Vector2 mousePos;
    [Export] public float aimAngle;
    
    public override void _Process(float delta)
    {
        if (!Input.IsMouseButtonPressed(1)) return;
        mousePos = GetLocalMousePosition();
        aimAngle = GetAngleTo(mousePos);
    }
}
