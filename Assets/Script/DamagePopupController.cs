using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopupController : MonoBehaviour
{
    public TextMeshPro textMesh;

    private void Awake() {
        StartCoroutine("SelfDestroy");
    }

    private void FixedUpdate() {
        transform.Translate(1.0f * Vector3.up * Time.deltaTime, Space.World);
    }

    public void SetValue(float value){
        textMesh.SetText(value.ToString());
    }

    public void SetCrit(){
        textMesh.color = Color.red;
        textMesh.fontSize += 0.1f * textMesh.fontSize;
    }

    IEnumerator SelfDestroy(){
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
}
