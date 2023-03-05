using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    private Transform _selection;
    void Update()
    {
        if (_selection != null)
        {
            var outline = _selection.GetComponent<Outline>();
            outline.enabled = false;
            _selection = null;
        }

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;

            if (selection.CompareTag(selectableTag))
            {
                var outline = selection.GetComponent<Outline>();

                if (outline != null)
                {
                    outline.OutlineWidth = 10;
                    outline.enabled = true;
                }

                _selection = selection;
            }
        }
    }
}
