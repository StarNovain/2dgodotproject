using Godot;
using System;

public class Conversation : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    JSONParseResult obj;
    public override void _Ready()
    {
        GD.Print(System.Environment.CurrentDirectory + "\\scripts\\base.json");
        string text = System.IO.File.ReadAllText(System.Environment.CurrentDirectory + "\\scripts\\base.json");
        obj = JSON.Parse(text);
        object dialogue = obj.Result;

        //Directory.GetCurrentDirectory
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
