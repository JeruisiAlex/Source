using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XCharts.Runtime;

public class JumpToAPP : MonoBehaviour
{
    public GameObject Navigation, AddressBook, Log, Setting, Guide, Memorandum,Mobile;
    public Animator logAnimator;
    private OpenPhone open;

    private void Start()
    {
        open = GameObject.FindWithTag("Player").GetComponent<OpenPhone>();
    }
    public void BtnNavigation()
    {
        Mobile.SetActive(false);
        Navigation.SetActive(true);
        open.number = 1;
    }

    public void BtnAddressBook()
    {
        Mobile.SetActive(false );
        AddressBook.SetActive(true );
        open.number = 2;
    }

    public void BtnLog()
    {
        Mobile.SetActive(false);
        Log.SetActive(true);
        logAnimator.SetTrigger("RotateStart");
        open.number = 3;
    }

    public void BtnSetting()
    {
        Mobile.SetActive(false) ;
        Setting.SetActive(true);
        open.number = 4;
    }

    public void BtnGuide()
    {
        Mobile.SetActive(false ) ;
        Guide.SetActive(true);
        open.number = 5;
    }

    public void BtnMemorandum()
    {
        Mobile.SetActive(false);
        Memorandum.SetActive(true);
        open.number = 6;
    }

    public void ReturnToMobile(GameObject UI)
    {
        if(UI.name != "Log")
        {
            Mobile.SetActive(true);
            UI.SetActive(false);
        }
        else
        {
            Log.GetComponent<Animator>().SetTrigger("RotateEnd");
            StartCoroutine(CloseLog(UI));
        }
        open.number = 0;
    }

    IEnumerator CloseLog(GameObject Log)
    {
        yield return new WaitForSeconds(1);
        Mobile.SetActive(true);
        Log.SetActive(false);
    }

}
