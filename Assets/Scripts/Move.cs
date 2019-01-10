using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public Transform target;
    //float left = 1.5f;
    float startSize;

    void Start()
    {
        startSize = this.GetComponent<Camera>().orthographicSize;
    }
    void Update () {

        var targetScript = target.GetComponent<PlayerCl>();
        if (targetScript.isMove)
            this.GetComponent<Camera>().orthographicSize = Mathf.Lerp(this.GetComponent<Camera>().orthographicSize, startSize, Time.time * 0.003f);
        else
            this.GetComponent<Camera>().orthographicSize = Mathf.Lerp(this.GetComponent<Camera>().orthographicSize, 5.0f, Time.time * 0.001f);

        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -100f);
        transform.LookAt(target);
    }
}
