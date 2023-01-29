using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private Mover mover;
    private PlayerInput playerInp;

    private void Awake()
    {
      playerInp = GetComponent<PlayerInput>();
      var movers = FindObjectsOfType<Mover>();
      var index = playerInp.playerIndex;
      mover = movers.FirstOrDefault(m => m.getPlayerIndex() == index);
    }

    public void OnMove(CallbackContext ctx)
    {
      if (mover != null)
        mover.setInputVector(ctx.ReadValue<Vector2>());
    }
}
