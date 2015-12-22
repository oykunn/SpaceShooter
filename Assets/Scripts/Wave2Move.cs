using UnityEngine;
using System.Collections;

public class Wave2Move : MonoBehaviour {

	public Vector3 point1;
	public Vector3 point2;
	public Vector3 point3;
	public Vector3 point4;
	public Vector3 point5;
	public Vector3 point6;
	public Vector3 point7;
	public Vector3 point8;
	public Vector3 point9;
	public Vector3 point10;
	public Vector3 pointEnd;

	IEnumerator Start () {
		var pointStart = transform.position;
		while (true){
			yield return StartCoroutine (MoveObject (transform, pointStart, point1, 12.0f));
			yield return StartCoroutine (MoveObject (transform, point1, point2, 2.0f));
			yield return StartCoroutine (MoveObject (transform, point2, point3, 3.0f));
			yield return StartCoroutine (MoveObject (transform, point3, point4, 3.0f));
			yield return StartCoroutine (MoveObject (transform, point4, point5, 3.0f));
			yield return StartCoroutine (MoveObject (transform, point5, point6, 2.0f));
			yield return StartCoroutine (MoveObject (transform, point6, point7, 3.0f));
			yield return StartCoroutine (MoveObject (transform, point7, point8, 2.0f));
			yield return StartCoroutine (MoveObject (transform, point8, point9, 2.0f));
			yield return StartCoroutine (MoveObject (transform, point9, point10, 3.0f));
			yield return StartCoroutine (MoveObject (transform, point10, pointEnd, 3.0f));
		}
	}

	IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		var i = 0.0f;
		var rate = 1.0f / time;
		while (i<1.0f ){
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp (startPos, endPos, i);
			yield return null;
		}
	}
}
