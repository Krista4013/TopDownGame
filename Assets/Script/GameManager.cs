using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public partial class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text TimeTxt;
    [SerializeField]
    private GameObject StartUI;
    [SerializeField]
    private GameObject Select;
    [SerializeField]
    private GameObject GreenLizard;
    [SerializeField]
    private GameObject BlueLizard;
    [SerializeField]
    private GameObject CharacterSelect;
    [SerializeField]
    private Text PlayerName;
    [SerializeField]
    private GameObject InJoin;
    [SerializeField]
    private InputField inputField;
    [SerializeField]
    private InputField ChangeinputField;
    [SerializeField]
    private GameObject MainSprite1;
    [SerializeField]
    private GameObject MainSprite2;
    [SerializeField]
    private GameObject ChangeName;
    [SerializeField]
    private GameObject ChangeNameTxt;
    [SerializeField]
    private GameObject ChangeSelectBtn;
    [SerializeField]
    private GameObject ChangeUI;
    [SerializeField]
    private GameObject changeCharacterUI;
    [SerializeField]
    private GameObject LeftUI;
    [SerializeField]
    private GameObject SmallLeftUI;
    [SerializeField]
    private Text NpcName;
    [SerializeField]
    private GameObject NpcList;

    public bool SelectG = false;
    public bool SelectB = false;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        StartUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        TimeTxt.text = DateTime.Now.ToString("HH : mm");

        List<string> List = new List<string>();

        List.Add(NpcName.text);
        List.Add(PlayerName.text);
        string F = "";
        int index = 1;
        foreach (string i in List)
        {
            F += (index++ + ". " + i + "\n"); 
        }
        NpcList.GetComponent<Text>().text = F;
    }

    public void SelectBtn()
    {
        GreenLizard.SetActive(false);
        BlueLizard.SetActive(false);
        CharacterSelect.SetActive(true);
    }

    public void selectGreen()
    {
        SelectB = false;
        SelectG = true;
        CharacterSelect.SetActive(false);
        GreenLizard.SetActive(true);
    }

    public void selectBlue()
    {
        SelectB = true;
        SelectG = false;
        CharacterSelect.SetActive(false);
        BlueLizard.SetActive(true);
    }
    
    public void LoginBtn()
    {
        if (inputField.text.Length > 1 && inputField.text.Length < 11)
        {

            if ((SelectG == true) && (SelectB == false))
            {
                MainSprite1.SetActive(true);
            }

            else if ((SelectG == false) && (SelectB == true))
            {
                MainSprite2.SetActive(true);
            }

            PlayerName.text = inputField.text;
            StartUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ChangeNameUI()
    {
        ChangeUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void ChangeBtn()
    {
        if (inputField.text.Length > 1 && inputField.text.Length < 11)
        {
            PlayerName.text = ChangeinputField.text;
            ChangeUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ChangeCharacterUI()
    {
        changeCharacterUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void ChangeGreen()
    {
        MainSprite2.SetActive(false);
        MainSprite1.SetActive(true);
        changeCharacterUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void ChangeBlue()
    {
        MainSprite1.SetActive(false);
        MainSprite2.SetActive(true);
        changeCharacterUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenLeftUI()
    {
        SmallLeftUI.SetActive(false);
        LeftUI.SetActive(true);
    }
    public void CloseLeftUI()
    {
        LeftUI.SetActive(false);
        SmallLeftUI.SetActive(true);
    }
}
