using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddressBookManager : MonoBehaviour
{
    public GameObject addressBookUI;

    public void JumpToDetailPage(GameObject Page)
    {
        addressBookUI.SetActive(false);
        Page.SetActive(true);
    }

    public void ReturnToUI(GameObject Page)
    {
        Page.SetActive(false);
        addressBookUI.SetActive(true);
        
    }

}
