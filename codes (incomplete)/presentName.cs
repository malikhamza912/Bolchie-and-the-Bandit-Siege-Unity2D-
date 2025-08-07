using UnityEngine;
using UnityEngine.UI;

public class presentName : MonoBehaviour
{
    public Text displayText;

    // Start is called before the first frame update
    void Start()
    {
       string playerName = PlayerPrefs.GetString("PN");
       displayText.text = "Player Name: " + playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
