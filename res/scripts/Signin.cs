using Godot;
using PocketBaseCore;
using System;
using System.Linq;
using System.Threading.Tasks;

public partial class Signin : Control
{

	private Main main = new Main();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Button signIn = GetNode<Button>("MarginContainer/HBoxContainer/SignIn/Button");
		signIn.Pressed += () => _OnSIButtonPressed();

		Button signUp = GetNode<Button>("MarginContainer/HBoxContainer/SignUp/Button");
		signUp.Pressed += () => _OnSUButtonPressed();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	/*
	* Loads signin data
	* 1. Get username and password input
	* 2. Cross reference with PocketBase data
	*/
	public async void _OnSIButtonPressed()
	{
		GD.Print("Got request!");

		LineEdit usernameIn = GetNode<LineEdit>("MarginContainer/HBoxContainer/SignIn/Username");
		LineEdit passwordIn = GetNode<LineEdit>("MarginContainer/HBoxContainer/SignIn/Password");

		string user = usernameIn.Text;
		string pass = passwordIn.Text;
		GD.Print("Got data ready!");
		try {
			var authResponse = main.client.AuthenticateAsync(user, pass);
			if (authResponse.IsCompletedSuccessfully)
    			{
        			GD.Print("Login successful!");
    		}
    		else
    		{
        		GD.Print("Login failed!");
    		}
		} catch (Exception e) {
			GD.PrintErr($"Error:\n{e}");
		}
	}

	public async void _OnSUButtonPressed()
	{
		GD.Print("Creation ready!");
	}
}
