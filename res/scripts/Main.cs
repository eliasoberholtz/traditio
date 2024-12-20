using Godot;
using PocketBaseCore;
using System;
using System.Threading.Tasks;

public partial class Main : Node
{
	public PocketBaseClient client = new PocketBaseClient("https://traditio.pockethost.io/");

	// // Called when the node enters the scene tree for the first time.
	// public override void _Ready()
	// {
		
	// }

	// // Called every frame. 'delta' is the elapsed time since the previous frame.
	// public override void _Process(double delta)
	// {

		
	// }

	public Task<AuthResponse<PocketBaseUser>> Authenticate(String username, String password){
		var authResponse = client.AuthenticateAsync(username, password);

		return authResponse;
	}
}
