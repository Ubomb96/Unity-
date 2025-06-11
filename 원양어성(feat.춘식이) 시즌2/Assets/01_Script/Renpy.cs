using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class Renpy : MonoBehaviour
{
    [SerializeField] Image img_BG; // ���
    [SerializeField] Image[] img_Character; // ĳ����

    [SerializeField] TextMeshProUGUI text_Name; // ĳ���� �̸� : ȣ�ó�
    [SerializeField] TextMeshProUGUI text_NameTitle; // ĳ���� Ÿ��Ʋ : ��å����ȸ
    [SerializeField] TextMeshProUGUI text_Dialogue; // ��� : ���⿡ ��簡 ��µ˴ϴ�.

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