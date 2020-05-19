using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderSelBtn : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private DefenderSelBtn[] defenderSelBtn;

    private PlayGrid playGrid;

    [SerializeField] public Image btnImage;

    private bool isSelected = false;


    private void Start() {
        defenderSelBtn = FindObjectsOfType<DefenderSelBtn>();
        playGrid = FindObjectOfType<PlayGrid>();
    }

    public void OnSelected() 
    {
        if(isSelected)
        {
            OnDeselected(); return;
        }


        // 나머지 DefenderSelBtn들을 OnDeselected() 호출
        for(int i = 0; i < defenderSelBtn.Length; i++)
        {
            defenderSelBtn[i].OnDeselected();
        }

        // PlayGrid에 defender 보내줘서 PlayGrid의 defender를 Set해줘야합니다.
        // FindObjectOfType<PlayGrid>().defender = defender;
        playGrid.SetDefender(defender);

        isSelected = true;

        // 자식 게임오브젝트 (image)를 white로 만듭니다.
        btnImage.color = Color.white;
    }

    public void OnDeselected()
    {
        // PlayGrid에 null 보내줘서 PlayGrid의 defender를 비워줘야합니다.
        playGrid.SetDefender(null);

        // 자식 게임오브젝트 (image)를 black으로 만듭니다.
        btnImage.color = Color.black;

        isSelected = false;
    }

}
