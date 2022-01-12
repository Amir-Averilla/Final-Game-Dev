using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    private int scoreNum;
    private int level;
    

    void Start()
    {
        scoreNum = 0;
        scoreText.text = "Score: " + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Food"){
            scoreNum +=10;
            scoreText.text = "Score: " + scoreNum;
            nextLevel();
        }
    }

    private void nextLevel()
    {
        if(scoreNum == 100){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
