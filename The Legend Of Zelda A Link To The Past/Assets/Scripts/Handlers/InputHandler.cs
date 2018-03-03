using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

    [SerializeField] Player player;

	// Use this for initialization
	void Start () {
		
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

        var moveCommand = new MoveCommand(horizontalInput, verticalInput);
        moveCommand.Execute(player);

        if (Input.GetKeyDown("z")) {
            player.Attack();
        }
    }
}
