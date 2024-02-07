using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // �Ա� ������ �Ա� ������
    //��� ������ ��ݾ�����
    // �ڷΰ��� ������ ����ȭ������

    //1.��ư�� �ް� ������ �� �̵��ϱ�
    ////////////////////////
    // �� �̵��� �ƴ϶� SetActive�� ����� ���̰� �ϴ°� ����

    public Button deposit;
    public Button withdrawal;

    // ����Ƽ�� ĵ������ setactive�� ���ٰ� �Ѵ�...GameObject�� ������ �ϳ�����
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
        //Ŭ���ϸ� ��ư�� �����϶�? 
        canvasMain.SetActive(true);
        canvasDeposit.SetActive(false);
        canvasWithdrawal.SetActive(false);
    }

    public void ShowDeposit()
    {
        //Ŭ���ϸ� ��ư�� �����϶�? 
        canvasMain.SetActive(false);
        canvasDeposit.SetActive(true);
        canvasWithdrawal.SetActive(false);
    }

    public void ShowWithdrawal()
    {
        //Ŭ���ϸ� ��ư�� �����϶�? 
        canvasMain.SetActive(false);
        canvasDeposit.SetActive(false);
        canvasWithdrawal.SetActive(true);
    }

}
