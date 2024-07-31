using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Puck puck;
    public TextMesh playerScoreUI;
    public TextMesh computerScoreUI;

    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreUI.text = playerScore.ToString();
        this.puck.ResetPuck();
    }

    public void ComputerScore()
    {
        computerScore++;
        computerScoreUI.text = computerScore.ToString();
        this.puck.ResetPuck();
    }


}
