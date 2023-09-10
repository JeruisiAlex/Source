using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class UpdateCharacterImage : MonoBehaviour
{
    public GameObject LeiQieEr1, LeiQieEr2,WuWenZhong1,WuWenZhong2,LiuSanQiang1,LiuSanQiang2,LiJianGuo1,LiJianGuo2,AZheng1,AZheng2,BookstoreBoss1,BookstoreBoss2,Librarian1,Librarian2,Bartender1,Bartender2,Knight1,Knight2,Princess1,Princess2,Dragon1,Dragon2,TeacherLiu1,TeacherLiu2;
    public GameObject LeiQieEr3, LeiQieEr4, WuWenZhong3, WuWenZhong4, LiuSanQiang3, LiuSanQiang4, LiJianGuo3, LiJianGuo4, AZheng3, AZheng4, BookstoreBoss3, BookstoreBoss4, Librarian3, Librarian4, Bartender3, Bartender4, Knight3, Knight4, Princess3, Princess4, Dragon3, Dragon4, TeacherLiu3, TeacherLiu4;
    public void UpdateImage(string name)
    {
        if(name == "LeiQieEr")
        {
            LeiQieEr1.SetActive(false);
            LeiQieEr2.SetActive(true);
            LeiQieEr3.SetActive(false);
            LeiQieEr4 .SetActive(true);
        }
        else if(name == "WuWenZhong")
        {
            WuWenZhong1.SetActive(false);
            WuWenZhong2.SetActive(true);
            WuWenZhong3.SetActive(false);
            WuWenZhong4 .SetActive(true);
        }
        else if(name == "LiuSanQiang")
        {
            LiuSanQiang1.SetActive(false);
            LiuSanQiang2 .SetActive(true);
            LiuSanQiang3 .SetActive(false);
            LiuSanQiang4 .SetActive(true);
        }
        else if(name == "LiJianGuo")
        {
            LiJianGuo1.SetActive(false);
            LiJianGuo2 .SetActive(true);
            LiJianGuo3 .SetActive(false);
            LiJianGuo4 .SetActive(true);
        }
        else if(name == "AZheng")
        {
            AZheng1 .SetActive(false);
            AZheng2 .SetActive(true);
            AZheng3 .SetActive(false);
            AZheng4 .SetActive(true);
        }
        else if(name == "BookstoreBoss")
        {
            BookstoreBoss1 .SetActive(false);
            BookstoreBoss2 .SetActive(true);
            BookstoreBoss3 .SetActive(false);
            BookstoreBoss4 .SetActive(true);
        }
        else if(name == "Librarian")
        {
            Librarian1 .SetActive(false);
            Librarian2 .SetActive(true);
            Librarian3.SetActive(false);
            Librarian4.SetActive(true);
        }
        else if(name == "Bartender")
        {
            Bartender1 .SetActive(false);
            Bartender2 .SetActive(true);
            Bartender3 .SetActive(false);
            Bartender4 .SetActive(true);
        }
        else if (name == "Knight")
        {
            Knight1 .SetActive(false);
            Knight2 .SetActive(true);
            Knight3 .SetActive(false);
            Knight4 .SetActive(true);
        }
        else if (name == "Princess")
        {
            Princess1 .SetActive(false);
            Princess2 .SetActive(true);
            Princess3 .SetActive(false);
            Princess4 .SetActive(true);
        }
        else if(name == "Dragon")
        {
            Dragon1 .SetActive(false);
            Dragon2 .SetActive(true);
            Dragon3 .SetActive(false);
            Dragon4 .SetActive(true);
        }
        else if(name == "Teacher Liu")
        {
            TeacherLiu1 .SetActive(false);
            TeacherLiu2 .SetActive(true);
            TeacherLiu3 .SetActive(false);
            TeacherLiu4 .SetActive(true);
        }
    }
}
