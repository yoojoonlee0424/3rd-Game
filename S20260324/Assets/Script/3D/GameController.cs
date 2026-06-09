using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject Clear;

    private int score = 0;

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Á¡¼ö: " + score);

        UpdateUi();
    }

    private void UpdateUi()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void GameClear()
    {
        Clear.SetActive(true);

        Invoke("Disable_Clear", 3f);
    }

    private void Disable_Clear()
    {
        Clear.SetActive(false);
    }

}
