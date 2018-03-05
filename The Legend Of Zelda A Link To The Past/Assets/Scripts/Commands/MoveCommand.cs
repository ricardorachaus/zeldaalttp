using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Implementation of the Move Command usign abstract Command.
/// </summary>
public class MoveCommand : Command {

    /// <summary>
    /// The velocity of the player.
    /// </summary>
    Vector2 velocity;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:MoveCommand"/> class.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    public MoveCommand(float x, float y) {
        velocity = new Vector2(x, y);
    }

    /// <summary>
    /// Sets the velocity.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    public void SetVelocity(float x, float y) {
        velocity.x = x;
        velocity.y = y;
    }

    /// <summary>
    /// Execute movement for the specified player.
    /// </summary>
    /// <returns>Void.</returns>
    /// <param name="player">Player.</param>
    public override void Execute(Player player) {
        player.Walk(velocity);
    }
}
