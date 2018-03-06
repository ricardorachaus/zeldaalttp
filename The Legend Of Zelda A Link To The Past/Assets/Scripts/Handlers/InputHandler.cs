using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    [SerializeField] Player player;

    private Command moveCommand;

	// Use this for initialization
	void Start () {
        moveCommand = new MoveCommand(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        HandleInput();
	}

    /// <summary>
    /// Handles the input.
    /// </summary>
    void HandleInput() {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        (moveCommand as MoveCommand).SetVelocity(horizontalInput, verticalInput);
        moveCommand.Execute(player);

        if (Input.GetKeyDown("z")) {
            //player.Attack();
            print("Attacked!");
        }
    }
}
