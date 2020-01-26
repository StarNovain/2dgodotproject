using Godot;
using System;

public class Player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    AnimatedSprite sprite;
    Vector2 velocity;
    public override void _Ready()
    {
        sprite = (AnimatedSprite) GetNode("AnimatedSprite");
        velocity = new Vector2();
    }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
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
        if(velocity.x == 0 && velocity.y == 0){
            sprite.Stop();
            sprite.SetFrame(0);
        } else{
            sprite.Play("walk_x");
        }
    }
    public override void _Process(float delta)
    {
        getInput();
        MoveAndSlide(velocity.Normalized() * 200);
        velocity.x = 0;
        velocity.y = 0;
    }
}
