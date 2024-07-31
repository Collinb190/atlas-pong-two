using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Puck puck;

    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        this.puck.ResetPuck();
    }

    public void ComputerScore()
    {
        computerScore++;
        this.puck.ResetPuck();
    }
}
