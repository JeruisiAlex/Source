using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class OpenPhone : MonoBehaviour
{
    public GameObject m_Mobile, Navigation, AddressBook, Log, Setting, Guide, Memorandum;
    public int number=-1;
    //-1��UIδ�� 0�����ֻ� 1���򿪵��� 2����ͨѶ¼ 3������־ 4�������� 5����ͼ�� 6���򿪱���¼

    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if(number == -1)
            {
                m_Mobile.SetActive(true);
                number = 0;
            }
            else if(number ==0)
            {
                m_Mobile.SetActive(false);
                number = -1;
            }
            else if(number == 1)
            {
                Navigation.SetActive(false);
                number = -1;
            }
            else if(number == 2)
            {
                AddressBook.SetActive(false);
                number = -1;
            }
            else if(number == 3)
            {
                Log.GetComponent<Animator>().SetTrigger("RotateEnd");
                Log.SetActive(false);
                number = -1;

            }
            else if(number == 4)
            {
                Setting.SetActive(false);
                number = -1;
            }
            else if(number == 5)
            {
                Guide.SetActive(false);
                number = -1;
            }
            else
            {
                Memorandum.SetActive(false);
                number = -1;
            }
        }
    }

}
