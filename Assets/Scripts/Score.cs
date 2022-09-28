using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Keep track of the players position
    public Transform player;
    // Keep track of the text box
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        // Update the text both with the players position (.ToString() makes the float a string, and the "0" turns it into a whole number)
        scoreText.text = player.position.z.ToString("0");
    }
}
