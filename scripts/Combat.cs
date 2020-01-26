using Godot;
using System;
public class Combat : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    PackedScene bullet, claw;
    int phase;
    float time;
    float diff;
    public override void _Ready()
    {

            bullet = (PackedScene)ResourceLoader.Load("res://scenes/Bullet.tscn");
            KinematicBody2D newbullet = (KinematicBody2D)bullet.Instance();
            //AddChild(newbullet);

            claw = (PackedScene)ResourceLoader.Load("res://scenes/Claw.tscn");
            KinematicBody2D newclaw = (KinematicBody2D)claw.Instance();
            //AddChild(newclaw);

            phase = 1;
            time = 0;
            diff = 0;
            
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        time = time + delta;
        diff += delta;
        if (phase == 1) {

            if (diff > 0.25){
                diff -= 0.25f;
                AddChild((KinematicBody2D)bullet.Instance());
            }
        }
        else if (phase == 2) {
            AddChild((KinematicBody2D)bullet.Instance());
            AddChild((KinematicBody2D)bullet.Instance());
            AddChild((KinematicBody2D)bullet.Instance());
            AddChild((KinematicBody2D)bullet.Instance());
        }
        if (time == 15) {
            
        }
    }
}
