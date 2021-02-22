using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelDisplay : MonoBehaviour
{
    public Text levelText;

    private void Start()
    {
        levelText.text = (SceneManager.GetActiveScene().name); 
    }
}
