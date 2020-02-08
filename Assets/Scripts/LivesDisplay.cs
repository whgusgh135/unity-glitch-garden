using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 100;
    [SerializeField] int damage = 1;
    Text liveText;

    private void Start()
    {
        liveText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        liveText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();

        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
