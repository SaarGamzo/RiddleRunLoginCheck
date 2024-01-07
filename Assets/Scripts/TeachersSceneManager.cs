using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TeachersSceneManager : MonoBehaviour
{
    public TMP_Text teacherNameTxt;

    void Start()
    {
        // Retrieve the username from PlayerPrefs
        string username = PlayerPrefs.GetString("teacherUserName", "DefaultUsername");

        // Display a welcome message with the username
        teacherNameTxt.text = "Hello " + username;
    }

    public void onLogOutClick()
    {
        Debug.Log("Logout button clicked!");
        SceneManager.LoadScene("LoginScene");
    }
}
