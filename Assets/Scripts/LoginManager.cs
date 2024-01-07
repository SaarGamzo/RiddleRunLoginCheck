using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField uNameInput;
    public TMP_InputField passInput;

    public void OnLoginButtonClick()
    {
        // Get the text from input fields
        string username = uNameInput.text;
        string password = passInput.text;

        // Log the information to the console
        Debug.Log("Login button clicked!");

        if (username.Equals("Maayan") && password.Equals("123456"))
        {
            Debug.Log("Teacher login!");
            Debug.Log("Username: " + username);
            Debug.Log("Password: " + password);
            // Save the username to PlayerPrefs
            PlayerPrefs.SetString("teacherUserName", username);

            // Load the TeacherScene
            SceneManager.LoadScene("TeacherScene");
        }
        else if (username.Equals("Saar") && password.Equals("123456"))
        {
            Debug.Log("Student login!");
            Debug.Log("Username: " + username);
            Debug.Log("Password: " + password);

            // Save the username to PlayerPrefs
            PlayerPrefs.SetString("studentUsername", username);

            // Load the StudentScene
            SceneManager.LoadScene("StudentScene");
        }
        else
        {
            // Handle incorrect login credentials
            Debug.Log("Invalid login credentials!");
        }
    }
}
