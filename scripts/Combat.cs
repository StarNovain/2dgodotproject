using Godot;
using System;
public class Combat : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    PackedScene bullet, claw,fist;
    int phase;
    float time;
    float diff;
    Boolean alternate;
    public override void _Ready()
    {

            bullet = (PackedScene)ResourceLoader.Load("res://scenes/Bullet.tscn");
            Area2D newbullet = (Area2D)bullet.Instance();
            //AddChild(newbullet);

            claw = (PackedScene)ResourceLoader.Load("res://scenes/Claw.tscn");
            Area2D newclaw = (Area2D)claw.Instance();
            fist = (PackedScene)ResourceLoader.Load("res://scenes/Fist.tscn");
            //AddChild(newclaw);

            phase = 1;
            time = 0;
            diff = 0;
            alternate = false;
            
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        time = time + delta;
        diff += delta;
        if (phase == 1) {

            if (diff > 0.25){
                diff -= 0.25f;
                AddChild((Area2D)bullet.Instance());
            }
        }
        else if (phase == 2) {
            if (diff > 0.18){
                diff -= 0.18f;
                AddChild((Area2D)bullet.Instance());
            }
            if (time >= 5){
                time -= 3;
                if(alternate){
                    AddChild((Area2D)fist.Instance());
                } else{
                    AddChild((Area2D)claw.Instance());
                }
                alternate = !alternate;
            }
        }
        if (time >= 5) {
            phase = 2;

        }
    }
}
