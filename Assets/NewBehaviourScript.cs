    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject A, B, C, D, E, F, Object, Origin;

    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = A.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = target - Object.transform.position;
        Vector3 cross = Vector3.Cross(Object.transform.forward, v.normalized);
        Quaternion q = Quaternion.AngleAxis(0.5f, cross);

        Object.transform.rotation = q * Object.transform.rotation;

        Object.transform.position = Object.transform.position +
                Object.transform.forward * 4f * Time.deltaTime;

        if (Vector3.Distance(Object.transform.position, A.transform.position) <= 0.5f)
            target = B.transform.position;

        else if (Vector3.Distance(Object.transform.position, B.transform.position) <= 0.5f)
            target = C.transform.position;

        else if (Vector3.Distance(Object.transform.position, C.transform.position) <= 0.5f)
            target = D.transform.position;

        else if (Vector3.Distance(Object.transform.position, D.transform.position) <= 0.5f)
            target = E.transform.position;

        else if (Vector3.Distance(Object.transform.position, E.transform.position) <= 0.5f)
            target = F.transform.position;

        else if (Vector3.Distance(Object.transform.position, F.transform.position) <= 0.5f)
            target = Origin.transform.position;
    }
}
