using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject[] ArraysPanels;
    public ButtonManager buttonManager;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text LevelCount; 
    int count =0;    
    void Start()
    {
        SetListner();
       LevelCount.text = "LEVEL: "+(count+1);
    }

    void OnCorrectSelected()
    {
        if(count<ArraysPanels.Length-1)
        {
            foreach(GameObject panelRef in ArraysPanels)
            {
                panelRef.SetActive(false);
            }
            count++;
            LevelCount.text = "LEVEL: "+(count+1);
            ArraysPanels[count].SetActive(true);

            buttonManager = ArraysPanels[count].GetComponent<ButtonManager>();
            SetListner();
        }
        Debug.Log("Correct selection made!");
       
    }

    void SetListner()
    {
        buttonManager.onCorrectSelection.AddListener(OnCorrectSelected);

    }
}
