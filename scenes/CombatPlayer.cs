using Godot;
using System;

public class CombatPlayer : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    Vector2 velocity;
        private void getInput()
    {
        if(Input.IsActionPressed("move_left")){
            velocity.x = -1;
        }
        if(Input.IsActionPressed("move_right")){
            velocity.x = 1;
        }
        if(Input.IsActionPressed("move_down")){
            velocity.y = 1;
        }
        if(Input.IsActionPressed("move_up")){
            velocity.y = -1;
        }
    }
    public override void _Ready()
    {
        velocity = new Vector2();
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        getInput();
        MoveAndSlide(velocity.Normalized() * 300);
        velocity.x = 0;
        velocity.y = 0;
    }
}
