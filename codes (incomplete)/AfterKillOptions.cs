using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AfterKillOptions : MonoBehaviour
{
    public bool levelAstatus = BossBanditApna.LevelACompleted;
    public InputField EnterYourName;
    public Text JoTextShowHoga;

    public Button mainmenuclick;
    public AudioSource sidhu;
    public Slider slider;
    public Dropdown levels;

    public void Display()
    {
        JoTextShowHoga.text = EnterYourName.text;
    }

    public void DisplayOtherScreen()
    {
        PlayerPrefs.SetString("PN", EnterYourName.text);
        PlayerPrefs.Save();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    
    public void QuitGame()
    {
        UnityEditor.EditorApplication.ExitPlaymode();
        // OR Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
        sidhu.volume = 0;
        levels.onValueChanged.AddListener(selectlevel);
        mainmenuclick.onClick.AddListener(MainMenu);
        if (levelAstatus == false)
        {
            //levels.options[1].interactable = false;
        }
    }

    public void selectlevel(int index)
    {
        string selectedlevel = levels.options[index].text;
        
        switch (selectedlevel)
        {
            case "A":
                SceneManager.LoadScene(0);
                break;

            case "B":
                SceneManager.LoadScene(0);
                break;
            }
    }

    public void OnVolumeChanged()
    {
        sidhu.volume = slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
