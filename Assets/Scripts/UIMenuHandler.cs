using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMenuHandler : MonoBehaviour
{
    public InputField usernameField;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        // load the main scene
        MenuManager.Instance.username = usernameField.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR // exit playmode when in editor
        EditorApplication.ExitPlaymode();
#else // else close application (build)
        Application.Quit();
#endif
    }
}
