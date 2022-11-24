using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
}
