using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonManager : MonoBehaviour
{
    public Button correctButton; // Assign correct answer button in Inspector
    public Button wrongButton;   // Assign wrong answer button in Inspector
    public Button crossButton; 
    
    public UnityEvent onCorrectSelection; // Event for correct choice
    public UnityEvent onWrongSelection;   // Event for wrong choice
    public UnityEvent onClose;
    public GameObject incorrectPanel;

    void Start()
    {
        // Assign click listeners
        correctButton.onClick.AddListener(CorrectChoice);
        wrongButton.onClick.AddListener(WrongChoice);
        crossButton.onClick.AddListener(crossButtonClick);
    
    }

    void CorrectChoice()
    {
        Debug.Log("Correct choice selected!");
        onCorrectSelection.Invoke(); // Trigger correct choice event
    }

    void WrongChoice()
    {
       incorrectPanel.SetActive(true);
        Debug.Log("Wrong choice selected!");
        //onWrongSelection.Invoke(); // Trigger wrong choice event
         
    }
    void crossButtonClick()
    {
       incorrectPanel.SetActive(false); 
        Debug.Log("close!");
        //onClose.Invoke(); // Trigger correct choice event
    }
}

