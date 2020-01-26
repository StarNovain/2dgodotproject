using Godot;
using System;

public class Claw : Damager
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    public float DAMAGE = 10;

    // Called when the node enters the scene tree for the first time.
    AnimatedSprite AnimatedSprite;
    public override void _Ready()
    {
        AnimatedSprite = (AnimatedSprite) GetNode("AnimatedSprite");
        var CombatP = (Node2D) GetParent().GetNode("CombatPlayer");
        Vector2 pPos = CombatP.GetPosition();
        GD.Print(pPos.x,pPos.y); 
        this.SetPosition(pPos);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        AnimatedSprite.Play("default");
        if (AnimatedSprite.Frame >= 24) {
            this.QueueFree();
        }
    }
}
