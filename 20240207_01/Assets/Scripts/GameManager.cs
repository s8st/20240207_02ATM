using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // 입금 누르면 입금 씬으로
    //출금 누르면 출금씬으로
    // 뒤로가기 누르면 메인화면으로

    //1.버튼을 달고 누르면 씬 이동하기
    ////////////////////////
    // 씬 이동이 아니라 SetActive로 숨기고 보이게 하는게 낫다

    public Button deposit;
    public Button withdrawal;

    // 유니티가 캔버스는 setactive가 없다고 한다...GameObject로 만들어야 하나보다
    //public Canvas canvasMain;
    //public Canvas canvasWithdrawal;
    //public Canvas canvasDeposit;

    public GameObject canvasMain;
    public GameObject canvasWithdrawal;
    public GameObject canvasDeposit;


    void Start()
    {
        ShowMain();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMain()
    {
        //클릭하면 버튼을 실행하라? 
        canvasMain.SetActive(true);
        canvasDeposit.SetActive(false);
        canvasWithdrawal.SetActive(false);
    }

    public void ShowDeposit()
    {
        //클릭하면 버튼을 실행하라? 
        canvasMain.SetActive(false);
        canvasDeposit.SetActive(true);
        canvasWithdrawal.SetActive(false);
    }

    public void ShowWithdrawal()
    {
        //클릭하면 버튼을 실행하라? 
        canvasMain.SetActive(false);
        canvasDeposit.SetActive(false);
        canvasWithdrawal.SetActive(true);
    }

}
