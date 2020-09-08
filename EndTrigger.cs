
using UnityEngine;

public class EndTrigger : GameManager

{

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.completeLevel();
    }
    
}
