using Godot;
using System;

public class Claw : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    AnimatedSprite AnimatedSprite;
    int frpos;
    public override void _Ready()
    {
        AnimatedSprite = (AnimatedSprite) GetNode("AnimatedSprite");
        var CombatP = (Node2D) GetParent().GetNode("CombatPlayer");
        Vector2 pPos = CombatP.GetPosition();
        GD.Print(pPos.x,pPos.y); 
        this.Position.Set(pPos.x,pPos.y);
        frpos = 0;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        AnimatedSprite.Play("default");
        frpos = frpos + 1;
        if (frpos >= 25) {
            AnimatedSprite.Stop();
        }
    }
}
