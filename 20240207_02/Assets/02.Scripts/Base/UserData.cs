using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public string Name;
    public int Balance;
    public int Cash;

    public UserData(string name, int balance, int cash) 
    {
        Name = name;
        Balance = balance;  
        Cash = cash;


    }

}
