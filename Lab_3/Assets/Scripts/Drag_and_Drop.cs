using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag_and_Drop : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Image _image;

    public AudioSource _audioSource;
    public AudioClip _clip;
    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _image.transform.localScale = Vector2.one * 1.5f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.transform.localScale = Vector2.one;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Play_Sound();
    }

    public void Play_Sound()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = _clip;
            _audioSource.Play();
        }
    }
}
