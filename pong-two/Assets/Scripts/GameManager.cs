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

    private void Update()
    {
        CheckForWinner();
    }

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

    void CheckForWinner()
    {
        if (playerScore == 11)
        {
            Debug.Log("Player Wins");
        }
        else if (computerScore == 11)
        {
            Debug.Log("AI Wins");
        }
    }
}
