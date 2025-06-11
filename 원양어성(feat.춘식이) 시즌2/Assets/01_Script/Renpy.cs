using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; // 배경
    [SerializeField] Image[] img_Character; // 캐릭터

    [SerializeField] TextMeshProUGUI text_Name; // 캐릭터 이름 : 호시노
    [SerializeField] TextMeshProUGUI text_NameTitle; // 캐릭터 타이틀 : 대책위원회
    [SerializeField] TextMeshProUGUI text_Dialogue; // 대사 : 여기에 대사가 출력됩니다.

    int id = 1;

    void Start()
    {
        RefreshUI();
    }

    public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character;


        text_Name.text = SData.GetCharacterData(characterID).Name;
        text_NameTitle.text = SData.GetCharacterData(characterID).Title;
        text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }



}