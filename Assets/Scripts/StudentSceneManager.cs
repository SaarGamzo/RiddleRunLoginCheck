using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class StudentSceneManager : MonoBehaviour
{
    public TMP_Text studentUsername;

    void Start()
    {
        // Retrieve the username from PlayerPrefs
        string username = PlayerPrefs.GetString("studentUsername", "DefaultUsername");

        // Display a welcome message with the username
        studentUsername.text = "Hello " + username;
    }

    public void onLogOutClick()
    {
        Debug.Log("Logout button clicked!");
        SceneManager.LoadScene("LoginScene");
    }
}
