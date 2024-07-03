using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Button _StartBtn;
    [SerializeField] private Button _OptionsBtn;
    private string GameScene = "GameScene";
    // Start is called before the first frame update
    void Start()
    {

        if (_StartBtn != null )
        {
            _StartBtn.onClick.AddListener(LoadGameScene);
        }
    }

    // Update is called once per frame
    void LoadGameScene()
    {
        SceneManager.LoadScene(GameScene);
    }
}
