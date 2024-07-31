using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Puck puck;
    public TextMeshProUGUI playerScoreUI;
    public TextMeshProUGUI computerScoreUI;

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
