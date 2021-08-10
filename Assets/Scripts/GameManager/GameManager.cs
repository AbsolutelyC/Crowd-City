using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public Leader player;

    private void Update()
    {
        countText.text = "Followers: " + player.dummies.Count.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
