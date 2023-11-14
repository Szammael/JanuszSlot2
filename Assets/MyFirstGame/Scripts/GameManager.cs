using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverObject;

    private void Start()
    {
        gameOverObject.SetActive(false);
    }

    public void OnGameEnded()
    { 
    
        gameOverObject.SetActive(true);

    
    }

    public void Reset()
    {
        SceneManager.LoadScene("MyFirstGame");
        
    }


}
