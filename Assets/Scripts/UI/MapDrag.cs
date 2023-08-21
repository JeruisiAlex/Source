 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MapDrag : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDragHandler, IEndDragHandler
{
    bool allowDrag = false;   //允许拖动

    public RectTransform parents;
    public RectTransform map;
    public float DragSpeed = 0.2f;

    Vector2 offctV = Vector2.zero;
    public void OnDrag(PointerEventData eventData)
    {

        if (parents.GetComponent<Transform>().localScale.x > 1)
        {
            offctV = eventData.delta * DragSpeed;
            float X = map.anchoredPosition.x + offctV.x;
            X = Mathf.Clamp(X, -((parents.sizeDelta.x * parents.localScale.x - parents.sizeDelta.x) / 2) / parents.localScale.x, ((parents.sizeDelta.x * parents.localScale.x - parents.sizeDelta.x) / 2) / parents.localScale.x);
            float Y = map.anchoredPosition.y + offctV.y;
            Y = Mathf.Clamp(Y, -((parents.sizeDelta.y * parents.localScale.y - parents.sizeDelta.y) / 2) / parents.localScale.x, ((parents.sizeDelta.y * parents.localScale.y - parents.sizeDelta.y) / 2) / parents.localScale.x);
            map.anchoredPosition = new Vector2(X, Y);
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        allowDrag = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        allowDrag = false;
    }

    private void Update()
    {
        BorderClamp();
        if (allowDrag)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //放大
                float f = parents.transform.localScale.x + 0.2f;
                f = Mathf.Clamp(f, 1, 10);
                parents.transform.localScale = new Vector3(f, f, f);
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //map.anchoredPosition = new Vector2(0,0);


                float f = parents.transform.localScale.x - 0.2f;
                f = Mathf.Clamp(f, 1, 10);
                parents.transform.localScale = new Vector3(f, f, f);
                BorderClamp();
            }

        }
    }


    void BorderClamp()
    {
        float X1 = map.anchoredPosition.x;
        X1 = Mathf.Clamp(X1, -((parents.sizeDelta.x * parents.localScale.x - parents.sizeDelta.x) / 2) / parents.localScale.x, ((parents.sizeDelta.x * parents.localScale.x - parents.sizeDelta.x) / 2) / parents.localScale.x);
        float Y1 = map.anchoredPosition.y;
        Y1 = Mathf.Clamp(Y1, -((parents.sizeDelta.y * parents.localScale.y - parents.sizeDelta.y) / 2) / parents.localScale.x, ((parents.sizeDelta.y * parents.localScale.y - parents.sizeDelta.y) / 2) / parents.localScale.x);
        map.anchoredPosition = new Vector2(X1, Y1);
    }
}