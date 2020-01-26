using Godot;
using System;

public class CombatPlayer : KinematicBody2D
{
    [Signal]
    public delegate void UpdateHealth();
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    Global global;
    AnimatedSprite sprite;
    Vector2 velocity;
    Area2D hitbox;
    public override void _Ready()
    {
        AddUserSignal("UpdateHealth");
        global = (Global)GetNode("/root/Global");
        sprite = (AnimatedSprite) GetNode("AnimatedSprite");
        hitbox = (Area2D) GetNode("hitbox");
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
        var overlappingAreas = hitbox.GetOverlappingAreas();
        for(int i = 0; i < overlappingAreas.Count;i++){
            var area = (Area2D) overlappingAreas[i];
            if(area.IsInGroup("lethal")){
                GD.Print("lethal area");
                GD.Print(global.health);
                GD.Print(area.Get("DAMAGE"));
                global.health -= (float) area.Get("DAMAGE");
                if(area.IsInGroup("despawn")){
                    area.QueueFree();
                }
                EmitSignal("UpdateHealth");
            }
        }
        velocity.x = 0;
        velocity.y = 0;
    }
}
